package Scheduler;

//CURRENTLY NOT BEING USED
//a queue of fixed size 255
public class ProcessQueue {
    public Process[] queue;
    public int size;
    private final int MAXSIZE = 255;
    
    public ProcessQueue() {
        queue = new Process[MAXSIZE];
        size = 0;
    }
    
    public void push(Process p) {
        queue[size] = p;
        size++;
        prioritize();
    }
    
    //rearranges queue based on process priority
    public void prioritize() {
        boolean done;
        
        if(size > 1) {
            for(int i = 0; i < size; i++) {
                done = true;
                for(int j = 0; j < size-1; j++) {
                    if(queue[j].pri > queue[j+1].pri) {swap(j,j+1); done = false;}
                }
                if(done) break;
            }
        }
    }
    
    //swaps two entries in array
    public void swap(int p1, int p2) {
        Process tmp = queue[p1];
        queue[p1] = (queue[p2]);
        queue[p2] = tmp;
    }
    
    public Process pop() {
        Process tmp = queue[0];
        for(int i = 1; i < size; i++) {
            queue[i-1] = queue[i];
        }
        queue[size-1] = null;
        size--;
        return tmp;
    }
}
