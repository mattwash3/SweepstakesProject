using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        static int registrationNumber;


        public static string AskFirstName()
        {
            string firstName;
            Console.WriteLine("Enter your first name.");
            firstName = Console.ReadLine();
            return firstName;
        }

        public static string AskLastName()
        {
            string lastName;
            Console.WriteLine("Enter your last name.");
            lastName = Console.ReadLine();
            return lastName;
        }

        public static string AskEmail()
        {
            string email;
            Console.WriteLine("Enter your email address.");
            email = Console.ReadLine();
            return email;
        }

        public static int GenerateRegistrationNumber()
        {
            for(int i = 0; i < 0; i++)
            {
                if(registrationNumber == 0)
                {
                    registrationNumber = i++;
                }
                else
                {
                    return i++;
                }          
            }
            return registrationNumber;
        }
    }
}
