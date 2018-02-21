
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Main(string[] args)
        {
            HumanVsComputer pve = new HumanVsComputer();
            HumanVsHuman pvp = new HumanVsHuman();

            Console.WriteLine("Would you like to play against the computer or another human?");
            string playerGameType = Console.ReadLine();

            if (playerGameType == "computer")
            {
                pve.HvC();
            }
            else
            {
                pvp.HvH();
            }


            //pve.HvC();
            //pvp.HvH();
        }
    }
}
