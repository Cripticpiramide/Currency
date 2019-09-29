using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Currency
{
    class Program
    {
        static void Main(string[] args)
        {

            


            
        }
        static void CurrencyProgram()
        {

            int platToGold = 10;
            int goldToSilver = 100;
            int silverToCopper = 1000;

            int goldToCopper = goldToSilver * silverToCopper;
            int platToCopper = platToGold * goldToCopper;

            Console.Write("Please fill in your amount of coppers: ");
            int originalTotalAmountOfCoppers = int.Parse(Console.ReadLine());

            int platDivision = originalTotalAmountOfCoppers / platToCopper;
            int goldDivision = originalTotalAmountOfCoppers / goldToCopper;
            int silverDivision = originalTotalAmountOfCoppers / silverToCopper;
            int copperDivision = originalTotalAmountOfCoppers % 1000;

            Console.Write("Your currency contains: " + platDivision + "p ");
            Console.Write("Your currency contains: " + goldDivision + "g ");
            Console.Write("Your currency contains: " + silverDivision + "s ");
            Console.Write("Your currency contains: " + copperDivision + "c");


            CurrencyProgram();

            Console.ReadLine();

        }
    }
}
