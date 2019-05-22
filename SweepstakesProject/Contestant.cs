using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        public Contestant()
        {
            firstName = null;
            lastName = null;
            email = null;
            registrationNumber = null;
        }

        public void GetContestantInfo()
        {
            Console.WriteLine("Enter your first name.");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name.");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your email address.");
            email = Console.ReadLine();
            //add code to generate a registration number for each contestant
        }



    }










}
