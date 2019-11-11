package questions;

import java.util.Collections;
import java.util.PriorityQueue;

public class LastStoneWeight {
    public int lastStoneWeight(int[] stones) {
        PriorityQueue<Integer> queue = new PriorityQueue<Integer>(stones.length, Collections.reverseOrder());
        for (int v :
                stones) {
            queue.offer(v);
        }

        while(queue.size() > 1) {
            int large = queue.poll();
            int small = queue.poll();
            if(large > small) {
                queue.offer(large - small);
            }
            if(large == small) {
                continue;
            }
        }
        return queue.size() == 0? 0 : queue.poll();
    }
}
