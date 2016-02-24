using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable userName to be a string
            string userName;
            string userBirthDay;

            //display prompt for user input
            Console.WriteLine("What's your name?");
            
            //assign userName to the input typed into console
            userName = Console.ReadLine();

            Console.WriteLine("When is your birthday? (mm/dd)");

            userBirthDay = Console.ReadLine();

            //convert user birthday to DateTime object
            DateTime birthday = DateTime.Parse(userBirthDay);



            //print userName to screen after successfull entry
            Console.WriteLine("Hello " + userName);
            userName = userName.ToLower();

            //create charArray from userName
            char[] userNameArray = userName.ToCharArray();
            
            //for loop to print userNameArray
            for (int i = 0; i < userNameArray.Length; i++)
            {
                //if statement for a/an condition
                string giveMeA = "Give me a ";
                string giveMeAn = "Give me an ";
                //string anLetters = "halfnorsemix";
                if (userNameArray[i] == 'a' || userNameArray[i] == 'e' || userNameArray[i] == 'f' || userNameArray[i] == 'h' || userNameArray[i] == 'i' || userNameArray[i] == 'l' || userNameArray[i] == 'm' || userNameArray[i] == 'n' || userNameArray[i] == 'o' || userNameArray[i] == 'r' || userNameArray[i] == 's' || userNameArray[i] == 'x')
                {
                    Console.WriteLine(giveMeAn + userNameArray[i] + "...");
                } else
                {
                    Console.WriteLine(giveMeA + userNameArray[i] + "...");
                }

            }
            userName = userName.ToUpper();
            Console.WriteLine(userName + " is GREAT!!!");

            //Logic for Birthday Calculation
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);
            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);

            int daysUntil = (nextBirthday - today).Days;

            if ((birthday.Month + "/" + birthday.Day) == (today.Month + "/" + today.Day))
            {
                Console.WriteLine("Happy Birthday!!!");
            } else
            {
                Console.WriteLine("Your birthday is " + daysUntil + " days away!");
            }

            //keep console open until keypress
            Console.ReadKey();
        }
    }
}
