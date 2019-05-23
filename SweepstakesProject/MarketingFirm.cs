using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm 
    {
        ISweepstakesManager manager;
        Stack<Sweepstakes> sweepstakesStack;
        Queue<Sweepstakes> sweepstakesQueue;
        public int givenId;

        public MarketingFirm()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
            sweepstakesQueue = new Queue<Sweepstakes>();
        }

        public void PickSwepstakesManagerType()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
            sweepstakesQueue = new Queue<Sweepstakes>();
            Console.Write("Enter the sweepstakes amanager you would like to use: stack or queue.");
            string sweepstakes = Console.ReadLine();

            switch (sweepstakes)
            {
                case "stack":
                    sweepstakes = sweepstakesStack.ToString();
                    break;
                case "queue":
                    sweepstakes = sweepstakesQueue.ToString();
                    break;
            }
            return;
        }











    }
}
