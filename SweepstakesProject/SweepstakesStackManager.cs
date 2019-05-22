﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack;

        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }
    }
}
