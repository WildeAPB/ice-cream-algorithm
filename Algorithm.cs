using System;
using System.Collections.Generic;

namespace ice_cream_algorithm
{
    class Algorithm
    {
        public static Dictionary<string, string> userChoices = new Dictionary<string, string>();
        public static Dictionary<string, int> popularIceCreams = new Dictionary<string, int>();
        public static string[] iceCreams, users;
        public static void RunAlgorithm(string[] setupUsers, string[] setupIceCreams)
        {
            users = setupUsers;
            iceCreams = setupIceCreams;
            //Get user choices.
            UserInput(users, iceCreams);
            //Sort user choices.
            IceCreamSort();
            //Repeat
            Console.ReadKey();
        }

        private static void UserInput(string[] users, string[] choices)
        {
            foreach(var user in users)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("User " + user + ", please choose an ice cream flavour from the list below.");
                Console.WriteLine("Use the number keys to choose your selection.");
                Console.WriteLine("-----------------------------------------------------------------------");
                for(int index = 0; index < choices.Length; index++)
                {
                    Console.WriteLine((index + 1) + ") " + choices[index]);
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                var userInput = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int userIceCreamChoice);
                userChoices.Add(user, choices[(userIceCreamChoice - 1)]);
                
            }
        }

        private static void IceCreamSort()
        {
            foreach(var icecream in iceCreams)
            {
                popularIceCreams.Add(icecream, 0);
            }
            foreach(var choice in userChoices)
            {
                popularIceCreams[choice.Value]++;
            }
            Console.Clear();
            Console.WriteLine("Voting Results");
            Console.WriteLine("--------------");
            foreach(var iceCream in popularIceCreams)
            {
                Console.WriteLine("{0} : {1}", iceCream.Key, iceCream.Value);
            }
            Console.WriteLine("--------------");
            foreach(var iceCream in popularIceCreams)
            {
                if(iceCream.Value == users.Length)
                {
                    Console.WriteLine("Consensus was reached. Chosen Ice Cream was {0} with {1} votes.", iceCream.Key, iceCream.Value);
                    break;
                }
            }
        }
    }
}
