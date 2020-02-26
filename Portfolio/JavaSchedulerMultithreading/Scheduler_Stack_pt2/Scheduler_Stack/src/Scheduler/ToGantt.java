package Scheduler;

import java.io.File;
import java.io.FileWriter;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * Accessory object to write process information to file as a Gantt chart
 * @author Amsta
 */

public class ToGantt {
    public String[][] chart;
    public int index;
    public static String FILEOUT_PATH;
    
    public ToGantt(String FILEPATH) {
        this.FILEOUT_PATH = FILEPATH;
        this.chart = new String[5][2000];
        this.index = 0;
        chart[0][0] = "-";
        chart[1][0] = "|";
        chart[2][0] = "-";
        chart[3][0] = "|";
        chart[4][0] = "0";
    }
    
    public void remove() {
        chart[0][index] = null;
        chart[1][index] = null;
        chart[2][index] = null;
        chart[3][index] = null;
        chart[4][index] = null;
        index--;
    }
    
    public void add() {
        index++;
        chart[0][index] = "-";
        chart[1][index] = " ";
        chart[2][index] = "-";
        chart[3][index] = " ";
        chart[4][index] = " ";
    }
    
    public void add(int t, String p) {
        index++;
        chart[0][index] = "---";
        chart[1][index] = " " + p;
        chart[2][index] = "---";
        chart[3][index] = " | ";
        if(t < 10) chart[4][index] = " " + t + " ";
        else if(t >= 10 && t < 100) chart[4][index] = t + " ";
        else chart[4][index] = Integer.toString(t);
    }
    
    public void print(int op) {
        index++;
        chart[0][index] = "--";
        chart[1][index] = " |";
        chart[2][index] = "--";
        chart[3][index] = "  ";
        chart[4][index] = "  ";
        
        for(String str:chart[0]) {
            if(str!=null) System.out.print(str);
        } System.out.println();
        
        for(String str:chart[1]) {
            if(str!=null) System.out.print(str);
        } System.out.println();
        
        for(String str:chart[2]) {
            if(str!=null) System.out.print(str);
        } System.out.println();
        
        for(String str:chart[3]) {
            if(str!=null) System.out.print(str);
        } System.out.println();
        
        for(String str:chart[4]) {
            if(str!=null) System.out.print(str);
        } System.out.println();
        
        try{
            File file = new File(FILEOUT_PATH);
            if(file.createNewFile()) {System.out.println("Creating new file.");}
            else{System.out.println("File already exists, appending to existing file.");}
            FileWriter fileOut = new FileWriter(FILEOUT_PATH, true);
            Date date = new Date();
            SimpleDateFormat timestamp = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
            
            if(op==1) fileOut.write("Performed FCFS Algorithm at " + timestamp.format(date) + "\n");
            if(op==2) fileOut.write("Performed Priority Algorithm at " + timestamp.format(date) + "\n");
            if(op==3) fileOut.write("Performed SJF Preemptive Algorithm at " + timestamp.format(date) + "\n");
            
            for(int i = 0; i < 5; i++) {
                for(String str:chart[i]) {
                    if(str!=null) fileOut.write(str);
                } fileOut.write("\n");
            }
            fileOut.write("\n\n\n");
            fileOut.close();
            System.out.println("Successfully wrote Gantt Chart to file.\n");
        }catch(Exception e) {
            e.printStackTrace();
        }
    }
}
