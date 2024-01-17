using System;
using System.Collections.Generic;

class Program {
    static void Main(string [] args) {
        int X = 10;
        int Y = 85;
        int D = 30;
        int jumps = JumpCalculator(X, Y, D);
        Console.WriteLine("The frog needs to jump {0} times to reach the other side.", jumps);
    }

    public static int JumpCalculator(int X, int Y, int D){
        
        int distance = Y - X;   //calculates the distance between the two points

        int jumps = distance/D; //helps find the number of jumps needed to reach the other side

        if (distance % D != 0){  //if the distance is not divisible by the jump distance, add one more jump
            jumps++; //adds one more jump
        }
        return jumps;     //returns the number of jumps needed
    }
}