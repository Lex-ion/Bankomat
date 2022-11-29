using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class CW
    {


        public static void WL(string txt, ConsoleColor barva)
        {

            Console.ForegroundColor = barva;
            Console.WriteLine(txt);
            Console.ForegroundColor=ConsoleColor.White;
        }




    }
}
