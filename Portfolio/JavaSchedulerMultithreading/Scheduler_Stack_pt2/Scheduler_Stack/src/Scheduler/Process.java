package Scheduler;

public class Process implements Runnable{
    public final String PID; //process ID
    public final int arT; //arrival time
    public final int brT; //burst time
    public final int pri; //priority
    public boolean finished;
    public int startTime;
    public Thread thr;
    public int runTime;
    
    public Process(String PID, int arT, int brT, int pri) {
        this.PID = PID;
        this.arT = arT;
        this.brT = brT;
        this.pri = pri;
        this.finished = false;
        this.startTime = -1;
        this.runTime = 0;
        this.thr = new Thread();
    }

    //When thread is run, sleeps for alloted burst time
    @Override
    public void run() {
        while(!finished) {
            try{
                thr.sleep(brT);
                this.stop();
            }catch(Exception e) {
                e.printStackTrace();
            }
        }
    }
    
    public void halt(int haltTime) {
        try{
            this.runTime += haltTime - startTime;
            this.finished = false;
        }catch(Exception e) {
            e.printStackTrace();
        }
    }
    
    public void stop() {
        this.finished = true;
    }
}
