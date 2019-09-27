using System;
using System.Collections.Generic;
namespace ice_cream_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            InputNumberUsers inputNumberUsers = new InputNumberUsers();
            IceCreamInput iceCreamInput = new IceCreamInput();
            IceCreamDecider iceCreamDecider = new IceCreamDecider();

            inputNumberUsers.inputNumberOfUsers();

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
                Console.WriteLine("Current Ice Creams:");
                foreach (string i in iceCreams) {
                    Console.Write("{0}\t", i.ToString()); }
                string lastEntry = Console.ReadLine();
                if(lastEntry == "Exit")
                {
                    enteringIceCreams = false;
                }
                else
                {
                    iceCreams.Add(lastEntry);
                }
            }
            return iceCreams.ToArray();
        }
    }

    class IceCreamDecider
    {

    }
}
