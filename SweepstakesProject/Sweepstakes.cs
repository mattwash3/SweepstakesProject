using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        Random random = new Random(); 
        public int winner;
        public string name;
        public int registrationNumber;
        public int givenId;

        public Sweepstakes(string name)
        {
            this.name = name;
            winner = 0;
            registrationNumber = 0;
        }

        public void RegisterContestant(Contestant contestant)
        {
            //add code to generate a registration number for each contestant
            // add contestant to dictionary
            contestants.  ;
            contestants.Add(registrationNumber, contestant);
        }

        public string PickWinner()
        {

            Console.WriteLine();
            int min = 1;
            int max = ;
            random = new Random();
            return random.Next(min, max);
        }

        public void PrintContestantInfo(Contestant contestant)
        {         
            Console.WriteLine("The Winner is " + contestant);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
