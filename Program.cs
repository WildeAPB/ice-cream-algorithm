using System;
using System.Collections.Generic;
using System.Linq;
namespace ice_cream_algorithm
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] users = IceCreamSetup.userSetup();
            string[] iceCreamSelection = IceCreamSetup.iceCreamSetup();
            IceCreamAlgorithm.runAlgorithm(users, iceCreamSelection);
        }
    }


    class IceCreamSetup
    {
        public static string[] userSetup()
        {
            List<string> users = new List<string>{};
            bool enteringUsers = true;
            while(enteringUsers == true)
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.Write("Current Users: ");
                foreach (string user in users) {
                    Console.Write(user.ToString() + ", "); }
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine("User Data Entry:");
                Console.WriteLine("Keywords: Exit = Close Program, Done = Finished Entering Data, Reset = Clear Current Users");
                Console.Write("Please enter the users: ");
                Console.WriteLine();
                Console.WriteLine("-------------------");
                string lastEntry = Console.ReadLine();
                if(lastEntry == "Clear") {users.Clear();}
                else if(lastEntry == "Exit") {Environment.Exit(0);}
                else if(lastEntry == "Done") {enteringUsers = false;}
                else {users.Add(lastEntry);}
            }
            return users.ToArray();
        }

        public static string[] iceCreamSetup()
        {
            List<string> iceCreams = new List<string>{};
            bool enteringIceCreams = true;
            while(enteringIceCreams == true)
            {
                Console.Clear();
                Console.WriteLine("-------------------");
                Console.Write("Current Ice Creams: ");
                foreach (string iceCream in iceCreams) {
                    Console.Write(iceCream.ToString() + ", "); }
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine("Ice Cream Data Entry:");
                Console.WriteLine("Keywords: Exit = Close Program, Done = Finished Entering Data, Reset = Clear Current Ice Creams");
                Console.Write("Please enter a flavour of Ice Cream to compute (type Exit once done): ");
                Console.WriteLine();
                Console.WriteLine("-------------------");
                string lastEntry = Console.ReadLine();
                if(lastEntry == "Clear") {iceCreams.Clear();}
                else if(lastEntry == "Exit") {Environment.Exit(0);}
                else if(lastEntry == "Done") {enteringIceCreams = false;}
                else {iceCreams.Add(lastEntry);}
                
            }
            return iceCreams.ToArray();
        }
    }

    class IceCreamAlgorithm
    {
        public static void runAlgorithm(string[] users, string[] iceCreams){
            Dictionary<string, string> userChoices = new Dictionary<string, string>();
            Dictionary<string, int> popularIceCreams = new Dictionary<string, int>();
            foreach(var user in users)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("User " + user + ", please choose an ice cream flavour from the list below.");
                Console.WriteLine("Use the number keys to choose your selection.");
                Console.WriteLine("-----------------------------------------------------------------------");
                for(int index = 0; index < iceCreams.Length; index++)
                {
                    Console.WriteLine((index + 1) + ") " + iceCreams[index]);
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                var userInput = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int userIceCreamChoice);
                userChoices.Add(user, iceCreams[(userIceCreamChoice - 1)]);
                
            }
            foreach(var icecream in iceCreams)
            {
                popularIceCreams.Add(icecream, 0);
            }
            foreach(var choice in userChoices)
            {
                
            }
        }
    }
}
