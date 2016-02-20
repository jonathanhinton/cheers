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

            //display prompt for user input
            Console.WriteLine("What's your name?");

            //assign userName to the input typed into console
            userName = Console.ReadLine();

            //print userName to screen after successfull entry
            Console.WriteLine("Hello " + userName);

            //create charArray from userName
            char[] userNameArray = userName.ToCharArray();

            int x = userNameArray.Length;

            for (int i = 0; i < userNameArray.Length; i++)
            {
                Console.WriteLine("Give me a " + userNameArray[i] + "...");
                Console.ReadKey();
            }
            Console.WriteLine(userName + " is GREAT!!!");
            //keep console open until keypress
            Console.ReadKey();
        }
    }
}
