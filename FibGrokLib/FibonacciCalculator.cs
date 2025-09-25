using System;

namespace FibGrokLib
{
    public class FibonacciCalculator
    {
        public int Position { get; set; }
        public string Result { get; private set; }

        public void Calculate()
        {
            if (Position < 0)
            {
                Result = "Invalid position! - HungLanBTVN";
                return;
            }

            if (Position == 0 || Position == 1)
            {
                Result = Position.ToString() + " - Odd wisdom! - HungLanBTVN"; // 0 even, but twist for fun
                return;
            }

            long prev = 0;
            long curr = 1;
            for (int i = 2; i <= Position; i++)
            {
                long next = prev + curr;
                prev = curr;
                curr = next;
            }

            string parity = (curr % 2 == 0) ? "Even luck! - HungLanBTVN" : "Odd wisdom! - HungLanBTVN";
            Result = curr.ToString() + " - " + parity;
        }
    }
}