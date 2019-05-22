using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes : IDictionary<TKey, TValue>
    {
        //use underlying Dictionary data structure
        Contestant contestant = new Contestant();
        public int key;

        public Sweepstakes()
        {
            key = null;
        }
        
        public void SweepstakesInfo(string name)
        {

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
        }

        public string PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }




    }


}
