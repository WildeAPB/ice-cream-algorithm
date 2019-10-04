using System;
using System.Collections.Generic;
using System.Linq;
namespace ice_cream_algorithm
{
    class Setup
    {
        public static string[] UserSetup()
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
                else 
                {
                    //Catch duplicates
                    users.Add(lastEntry);
                }
            }
            return users.ToArray();
        }

        public static string[] IceCreamSetup()
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
                else 
                {
                    //Catch duplicates.
                    iceCreams.Add(lastEntry);
                }
                
            }
            return iceCreams.ToArray();
        }
    }
}
