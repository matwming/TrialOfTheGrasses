package questions;

import org.junit.Test;

import static org.junit.Assert.*;

public class GuessNumberHigherOrLowerTest {
    @Test
    public void TestMethod1() {
        GuessNumberHigherOrLower outer = new GuessNumberHigherOrLower();
        GuessNumberHigherOrLower.Solution solution = outer.new Solution(6);
        assertEquals(6, solution.guessNumber(10));
    }
}