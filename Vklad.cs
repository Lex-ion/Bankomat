using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Vklad
    {
        public static void Start()
        {
            Console.WriteLine();
            StreamReader sr = new StreamReader(Login.loggedname + "_zus.txt");
           
            StreamWriter sw1 = new StreamWriter(Login.loggedname + "_his.txt", true);
            int tmp = (int)Convert.ToInt64( sr.ReadLine());

            CW.WL("Zadej vklad: ", ConsoleColor.Green);
            string vstupS=Console.ReadLine();
            int vstupI;

            if (!int.TryParse(vstupS, out vstupI))
            {
                CW.WL("NEBEREM", ConsoleColor.Red);
                Start();
            }
            if (vstupI < 1)
            {
                CW.WL("NEBEREM", ConsoleColor.Red);
                Start();
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(Login.loggedname + "_zus.txt");


            tmp += vstupI;
            sw.WriteLine(tmp);
            sw.Flush();
            sw.Close();

           
            sw1.WriteLine(DateTime.Now + " +" + vstupI);
            sw1.Flush();
            sw1.Close();

            Menu.Start();


        }




    }
}
