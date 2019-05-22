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
        public int count;

        public Sweepstakes(string name)
        {
            this.name = name;
            winner = 0;
            registrationNumber = 0;
        }

        public void RegisterContestant(Contestant contestant)
        {
            Console.WriteLine("Enter your first name.");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name.");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Enter your email address.");
            contestant.email = Console.ReadLine();
            //add code to generate a registration number for each contestant
            // add contestant to dictionary
            registrationNumber = contestants.Keys;
            contestants.Add(registrationNumber, contestant);
        }

        public string PickWinner(winner)
        {
            count = contestants.Count();
            Console.WriteLine();
            int min = 1;
            int max = count;
            random = new Random();
            return random.Next(min, max);
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            
            Console.WriteLine();
        }




    }


}
