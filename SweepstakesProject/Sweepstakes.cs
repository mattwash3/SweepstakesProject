using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes : IDictionary<TKey, TValue>
    {
        //use underlying Dictionary data structure
        Contestant contestant = new Contestant();
        Random random = new Random();
        public int key;
        public int winner;
        public string name;

        public Sweepstakes(string name)
        {
            this.name = name;
            key = null;
            winner = null;
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
            key = contestant.registrationNumber;
            Dictionary.append(key, contestant);
        }

        public string PickWinner(winner)
        {
            Console.WriteLine();
            int min = 1;
            int max = 100;
            random = new Random();
            return random.Next(min, max);
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine();
        }




    }


}
