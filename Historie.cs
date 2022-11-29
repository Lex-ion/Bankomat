using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Bankomat
{
    internal class Historie
    {

        public static void Start()
        {
            Console.Clear();
            string[] tmp = File.ReadAllLines(Login.loggedname + "_his.txt");
            CW.WL("HISTORIE: ",ConsoleColor.DarkYellow);
            for (int i = 0; i < tmp.Length; i++)
            {

                if (tmp[i].Contains("+"))
                {
                    CW.WL(tmp[i],ConsoleColor.Green);
                }
                else
                {
                    CW.WL(tmp[i], ConsoleColor.Red);
                }



               
            }
            Console.ReadKey();

            Menu.Start();

        }
    }
}
