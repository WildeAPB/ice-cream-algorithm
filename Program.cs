using System;
using System.Collections.Generic;
using System.Linq;
namespace ice_cream_algorithm
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Setup.UserSetup();
            string[] iceCreamSelection = Setup.IceCreamSetup();
            Algorithm algorithm = new Algorithm();
            algorithm.RunAlgorithm(users, iceCreamSelection);
        }
    }
}
