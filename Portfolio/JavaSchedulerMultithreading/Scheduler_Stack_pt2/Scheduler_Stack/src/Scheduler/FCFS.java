package Scheduler;

import java.io.*;
import java.util.*;

/**
 * Scheduler and scheduling algorithm implementation
 * Operating Systems: CSC 380 Fall 2019
 * 11/22/2019
 * 
 * Creates a scheduler thread and performs either FCFS or Priority scheduling algorithms,
 *      spinning off child threads for each process
 * 
 * Added SJF Preemptive algorithm
 * 
 * ???Look at spinning child threads (process.run)
 *  is it properly create a new thread for the process?
 * 
 * Added RR algorithm, changed and refactored Process class (error in calculating run time)
 * 
 * !!!PLEASE CHANGE THE FILEPATHS IN MAIN!!!
 * @author Alex Stack
 */

public class FCFS {
    
    public static Process[] pStore; //stores processes
    public static final int MAX_SIZE = 255; //maximum number of processes in file processData
    public static final int CLOCK_DELAY = 10; //sets delay for clock
    public static final int MAX_RUNTIME = 1000; //maximum time for algorithm to run
    public static int pCount, op; //total number of processes/opcode for choosing algorithm
    public static final String FILEIN_PATH = "C:\\Users\\Amsta\\Desktop\\processData.txt";
    public static final String FILEOUT_PATH = "C:\\Users\\Amsta\\Desktop\\processGanttChart.txt";
    
    public static void main(String[] args) {
        Thread thr;
        Scanner sc = new Scanner(System.in);
        boolean stop = true;
        
        while(stop) {
            System.out.print("Enter algorithm to use, (0)Quit,(1)FCFS,(2)Prio,(3)SJF,(4)RR: ");
            int in = sc.nextInt();
            switch(in) {
                    case 1:
                        op = 1;
                        thr = new Thread(new Dispatcher());
                        thr.start();
                        while(thr.isAlive()) {} //loop until thread completes
                        break;
                    case 2:
                        op = 2;
                        thr = new Thread(new Dispatcher());
                        thr.start();
                        while(thr.isAlive()) {} //loop until thread completes
                        break;
                    case 3:
                        op = 3;
                        thr = new Thread(new Dispatcher());
                        thr.start();
                        while(thr.isAlive()) {} //loop until thread completes
                        break;
                    case 4:
                        op = 4;
                        thr = new Thread(new Dispatcher());
                        thr.start();
                        while(thr.isAlive()) {} //loop until thread completes
                        break;
                    case 0:
                        stop=false;
                        break;
                    default:
                        System.out.println("Error: please enter another option...");
            }
        }
    }
    
    //Sorts and starts processes by arrival time
    public static void sortProcesses() {
        boolean mark = false;
        for(int i = 0; i < pCount; i++) {
            mark=false;
            for(int j = 0; j < (pCount-1); j++) {
                if(pStore[j].arT > pStore[j+1].arT) {
                    swap(j,j+1); mark = true;
                }
            }
            if(mark==false) break;
        }
    }
    
    //swaps two entries in array
    public static void swap(int p1, int p2) {
        Process tmp = pStore[p1];
        pStore[p1] = (pStore[p2]);
        pStore[p2] = tmp;
    }
    
    //trims excess off end of array pStore
    public static void trimProcArray() {
        Process[] tmp = new Process[pCount];
        for(int i = 0; i < pCount; i++) {
            tmp[i]=pStore[i];
        }
        pStore=tmp;
    }
    
    //reads process from file
    public static void readFile() {
        File fData = new File(FILEIN_PATH);
                pStore = new Process[MAX_SIZE];
                pCount = 0;

                //read processes from file
                try {
                    System.out.println();
                    Scanner sc = new Scanner(fData);
                    String line = "";
                    while (sc.hasNext()) {
                        line = sc.nextLine();
                        Scanner lineSc = new Scanner(line);
                        lineSc.useDelimiter(",");
                        Process p = new Process(
                                lineSc.next(),
                                lineSc.nextInt(),
                                lineSc.nextInt(),
                                lineSc.nextInt()
                        );
                        System.out.println("Created process " + p.PID + " with vars: arrival-time "
                                + p.arT + ", burst-time " + p.brT + ", and priority " + p.pri + ".");
                        pStore[pCount] = p;
                        pCount++;
                    }
                    System.out.println();
                    trimProcArray();
                }catch(Exception e) {
                    e.printStackTrace();
                }
    }
    
    //Dispatcher class, reads file and creates array of Processes
    private static class Dispatcher implements Runnable {

        private volatile boolean exit = false;
        ToGantt chart = new ToGantt(FILEOUT_PATH);
        Thread thr;
        
        public void stop() {
            this.exit = true;
        }

        @Override
        public void run() {
            while (!exit) {
                try{
                    readFile();
                    sortProcesses(); //sorts processes by arrival time
                    int clk = 0; //clock
                    Process curProc = null;
                    
                    //<------------------------------------------------------------------------------------------------------------->
                    //FCFS Algorithm Implementation
                    if (op == 1) {

                        //maintain loop to cycle through threads, stops when all threads have run
                        while (true) {
                            for (Process p : pStore) {
                                //spin new threads if arrival time matches current time
                                if (!p.finished && p.arT <= clk && curProc == null) {
                                    System.out.println("Starting thread " + p.PID + " at time " + clk);
                                    
                                    p.startTime = clk; //sets arrival time of process to current clock time, used to determine when process finished
                                    curProc = p; //set current working process
                                    curProc.run(); //spin child thread
                                    chart.add(clk, curProc.PID); //for logging in Gantt chart
                                }

                                //checks to see if thread is finished
                                if (curProc != null) {
                                    if (clk - curProc.startTime == curProc.brT) { //finished when runtime is equal to burst-time
                                        System.out.println("Thread " + curProc.PID + " completed at time " + clk);
                                        curProc.stop(); //stop thread if finished
                                        chart.add(clk, curProc.PID); //for logging in Gantt chart
                                        curProc = null; //reset current process to open/null
                                    }
                                }
                            }

                            //checks if all threads have been completed
                            boolean isFinished = true;
                            for (Process p : pStore) {
                                if (!p.finished) {
                                    isFinished = false;
                                }
                            }
                            if (isFinished&&curProc == null) {break;}

                            chart.add(); //add whitespace to Gantt chart
                            clk++; //after all ops, increment clock
                            Thread.sleep(CLOCK_DELAY); //adds artificial delay to dispatcher
                            if(clk > MAX_RUNTIME) throw new Exception("MAX TIME REACHED");
                        }

                        System.out.println("\nAll processes completed in time: " + clk + "\n");
                        chart.print(op); //print and write Gantt chart
                        this.stop();
                    }

                    //<------------------------------------------------------------------------------------------------------------->
                    //Priority Algorithm Implementation
                    if (op == 2) {

                        //maintain loop to cycle through threads, stops when all threads have run
                        while (true) {
                            for (Process p : pStore) {
                                //spin new threads if arrival time matches current time
                                if (!p.finished && p.arT <= clk && curProc == null) {
                                    System.out.println("Starting thread " + p.PID + " at time " + clk);
                                    
                                    curProc = p; //set current working process
                                    curProc.run(); //spin child thread
                                    curProc.startTime = clk; //sets arrival time of process to current clock time, used to determine when process finished
                                    
                                    chart.add(clk, curProc.PID); //for logging in Gantt chart
                                }

                                //checks priority and starts if needed
                                if (curProc != null) {
                                    if (!p.finished && p.arT <= clk && p != curProc && p.pri > curProc.pri) {
                                        System.out.println("Stopping process " + curProc.PID + " and starting " + p.PID + " at time " + clk);
                                        curProc.halt(clk); //make current process wait
                                        
                                        chart.remove(); //for logging in Gantt chart
                                        if(curProc.runTime > 0) chart.add(clk, curProc.PID);
                                        chart.add(clk, p.PID); //for logging in Gantt chart
                                        
                                        curProc = p; //swap current process with new higher priority process
                                        curProc.startTime = clk; //sets arrival time of process to current clock time, used to determine when process finished
                                        curProc.run(); //start new process
                                    }
                                }

                                //checks to see if thread is finished
                                if (curProc != null) {
                                    if (clk - curProc.startTime == curProc.brT - curProc.runTime) { //finished when runtime is equal to burst-time
                                        System.out.println("Thread " + curProc.PID + " completed at time " + clk);
                                        curProc.stop(); //stop if thread is finished
                                        chart.add(clk, curProc.PID); //for logging in Gantt chart
                                        curProc = null; //reset current process to open/null
                                    }
                                }
                            }

                            //checks if all threads have been completed
                            boolean isFinished = true;
                            for (Process p : pStore) {
                                if (!p.finished) {
                                    isFinished = false;
                                }
                            }
                            if (isFinished && curProc == null) break;
                            
                            chart.add(); //add whitespace to Gantt chart
                            clk++; //after all ops, increment clock
                            Thread.sleep(CLOCK_DELAY); //adds artificial delay to dispatcher
                            if(clk > MAX_RUNTIME) throw new Exception("MAX TIME REACHED");
                        }

                        System.out.println("\nAll processes completed in time: " + clk + "\n");
                        chart.print(op); //print and write Gantt chart
                        this.stop();
                    }
                    
                    //<------------------------------------------------------------------------------------------------------------->
                    //SJF Preemptive
                    if (op == 3) {

                        //maintain loop to cycle through threads, stops when all threads have run
                        while (true) {
                            for (Process p : pStore) {
                                //spin new threads if arrival time matches current time
                                if (!p.finished && p.arT <= clk && curProc == null) {
                                    System.out.println("Starting thread " + p.PID + " at time " + clk);
                                    
                                    curProc = p; //set current working process
                                    curProc.run(); //spin child thread
                                    curProc.startTime = clk; //sets arrival time of process to current clock time, used to determine when process finished
                                    
                                    chart.add(clk, curProc.PID); //for logging in Gantt chart
                                }

                                //checks burst time and starts if needed
                                if (curProc != null) {
                                    if (!p.finished && p.arT <= clk && p != curProc && (p.brT - p.runTime) < (curProc.brT - curProc.runTime)) {
                                        curProc.halt(clk); //make current process wait
                                        
                                        System.out.println("Stopping process " + curProc.PID + " and starting " + p.PID + " at time " + clk);
                                        if(curProc.runTime > 0) System.out.println("Process " + curProc.PID + " has a remaining time of " + curProc.runTime);
                                        
                                        chart.remove(); //for logging in Gantt chart
                                        if(curProc.runTime > 0) chart.add(clk, curProc.PID);
                                        chart.add(clk, p.PID); //for logging in Gantt chart
                                        
                                        curProc = p; //swap current process with new lower burst time
                                        curProc.startTime = clk; //sets arrival time of process to current clock time, used to determine when process finished
                                        curProc.run(); //start new process
                                    }
                                }

                                //checks to see if thread is finished
                                if (curProc != null) {
                                    if (clk - curProc.startTime == curProc.brT - curProc.runTime) { //finished when runtime is equal to burst-time
                                        System.out.println("Thread " + curProc.PID + " completed at time " + clk);
                                        curProc.stop(); //stop if thread is finished
                                        chart.add(clk, curProc.PID); //for logging in Gantt chart
                                        curProc = null; //reset current process to open/null
                                    }
                                }
                            }

                            //checks if all threads have been completed
                            boolean isFinished = true;
                            for (Process p : pStore) {
                                if (!p.finished) {
                                    isFinished = false;
                                }
                            }
                            if (isFinished && curProc == null) break;
                            
                            chart.add(); //add whitespace to Gantt chart
                            clk++; //after all ops, increment clock
                            Thread.sleep(CLOCK_DELAY); //adds artificial delay to dispatcher
                            if(clk > MAX_RUNTIME) throw new Exception("MAX TIME REACHED");
                        }

                        System.out.println("\nAll processes completed in time: " + clk + "\n");
                        chart.print(op); //print and write Gantt chart
                        this.stop();
                    }
                    
                    //<------------------------------------------------------------------------------------------------------------->
                    //Round robin preemptive
                    
                    if (op == 4) {
                        final int timeQuant = 10; //set the time quantum
                        int quantClk = 0; //used to determine how long a process has run for
                        ProcessQueue prioQueue = new ProcessQueue(); //priority queue
                        
                        //maintain loop to cycle through threads, stops when all threads have run
                        while (true) {
                            for (Process p : pStore) {
                                //pushes new thread into queue
                                if (!p.finished && p.arT <= clk && p.startTime == -1) {
                                    System.out.println("Putting process " + p.PID + " into queue at time " + clk);
                                    
                                    p.startTime = 0; //makes sure process isn't pushed into queue twice
                                    
                                    //check priority and swap if needed
                                    if(curProc != null && p.pri > curProc.pri) {
                                        curProc.halt(clk);
                                        prioQueue.push(curProc);
                                        
                                        System.out.println("Stopping process " + curProc.PID + ", starting higher priority process " + p.PID + " at time " + clk);
                                        if(curProc.runTime > 0) System.out.println("Process " + curProc.PID + " has a remaining time of " + (curProc.brT - curProc.runTime));
                                        chart.remove(); //for logging in Gantt chart
                                        if(curProc.runTime > 0) chart.add(clk, curProc.PID);
                                        chart.add(clk, p.PID);
                                        
                                        curProc = p;
                                        curProc.startTime = clk;
                                        curProc.run();
                                        quantClk = 0;
                                    } else {
                                        prioQueue.push(p); //if not higher prio, push into queue
                                    }
                                }
                            }

                            //checks to see if thread is finished
                                if (curProc != null) {
                                    if (clk - curProc.startTime == curProc.brT - curProc.runTime) { //finished when runtime is equal to burst-time
                                        System.out.println("Thread " + curProc.PID + " completed at time " + clk);
                                        curProc.stop(); //stop if thread is finished
                                        chart.add(clk, curProc.PID); //for logging in Gantt chart
                                        curProc = null; //reset current process to open/null
                                        quantClk = 0;
                                    }
                                }

                                //pop queue if no current process
                                if(curProc == null && prioQueue.size > 0) {
                                    curProc = prioQueue.pop();
                                    curProc.startTime = clk;
                                    System.out.println("Starting process " + curProc.PID + " at time " + clk);
                                    chart.add(clk, curProc.PID);
                                    curProc.run();
                                    quantClk = 0;
                                }                                
                                
                                //checks if time quantum is reached
                                if(curProc != null && quantClk == timeQuant && prioQueue.size > 0) {
                                    Process newProc = prioQueue.pop();
                                    newProc.startTime = clk;
                                    curProc.halt(clk);
                                    
                                    System.out.println("Stopping process " + curProc.PID + " after timeslice expired, starting " + newProc.PID + " at time " + clk);
                                    if(curProc.runTime > 0) System.out.println("Process " + curProc.PID + " has a remaining time of " + (curProc.brT - curProc.runTime));
                                    chart.remove(); //for logging in Gantt chart
                                    if(curProc.runTime > 0) chart.add(clk, curProc.PID);
                                        
                                    prioQueue.push(curProc);
                                    curProc = newProc;
                                    chart.add(clk, curProc.PID);
                                    curProc.run();
                                    quantClk = 0;
                                }
                            
                            //checks if all threads have been completed
                            boolean isFinished = true;
                            for (Process p : pStore) {
                                if (!p.finished) {
                                    isFinished = false;
                                }
                            }
                            if (isFinished && curProc == null) break;
                            
                            chart.add(); //add whitespace to Gantt chart
                            if(curProc != null) quantClk++; //increment the quantum clock if necessary
                            clk++; //after all ops, increment clock
                            Thread.sleep(CLOCK_DELAY); //adds artificial delay to dispatcher
                            if(clk > MAX_RUNTIME) throw new Exception("MAX TIME REACHED");
                        }

                        System.out.println("\nAll processes completed in time: " + clk + "\n");
                        chart.print(op); //print and write Gantt chart
                        this.stop();
                    }

                } catch (Exception e) {
                    System.out.println("Encountered error while performing scheduling, aborting...");
                    e.printStackTrace();
                    this.stop();
                }

            }
        }

    }
}
