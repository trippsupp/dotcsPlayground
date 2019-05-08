using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFG = PairFinderGrounds;

namespace main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the DDI C# Playground -- Created by Data Deck Industries");            
            System.Console.WriteLine("");

            System.Console.WriteLine("Select your grounds:");
            System.Console.WriteLine(" 1) PairFinder");
            System.Console.WriteLine(" 2) TBD");
            System.Console.WriteLine(" 2) TBD");            
            System.Console.WriteLine("");

            switch ( Int32.Parse(System.Console.ReadLine()) )
            {
                case 1:
                    new PFG.PairFinder().Start();
                    break;
                default:
                    System.Console.WriteLine("Invalid grounds selected.");
                    break;                
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Grounds concluded. Press any key to close.");
            System.Console.ReadKey();

        }
        
    }




    
}

