using System;
using System.Collections.Generic;
namespace ice_cream_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfUsers = InputNumberUsers.inputNumberOfUsers();
            string[] iceCreamSelection = IceCreamInput.iceCreamSelection();
            IceCreamDecider.IceCreamAlgorithm();
        }
    }


    class InputNumberUsers
    {
        public static int inputNumberOfUsers()
        {
            Console.WriteLine("Please enter the number of users:");
            int.TryParse(Console.ReadLine(), out int numberOfUsers);
            return numberOfUsers;
        }
    }
    
    class IceCreamInput
    {
        public static string[] iceCreamSelection()
        {
            List<string> iceCreams = new List<string>{};
            bool enteringIceCreams = true;
            while(enteringIceCreams == true)
            {
                Console.Clear();
                Console.WriteLine("-------------------");
                Console.Write("Current Ice Creams: ");
                foreach (string i in iceCreams) {
                    Console.Write(i.ToString() + ", "); }
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine("Ice Cream Data Entry:");
                Console.WriteLine("Keywords: Exit = Close Program, Done = Finished Entering Data, Reset = Clear Current Ice Creams");
                Console.Write("Please enter a flavour of Ice Cream to compute (type Exit once done): ");
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

    class IceCreamDecider
    {
        public static void IceCreamAlgorithm()
        {
            
        }
    }
}
