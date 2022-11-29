using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Vyber
    {

        public static void Start()
        {
            Console.Clear();
            StreamReader sr = new StreamReader(Login.loggedname + "_zus.txt");
            int tmp =(int) Convert.ToInt64(sr.ReadLine());
            sr.Close();

            CW.WL("Zadej částku", ConsoleColor.Green);
            string vstupS=Console.ReadLine();
            int vstupI;
            if (!int.TryParse(vstupS, out vstupI)||vstupI<1)
            {
                CW.WL("Chyba", ConsoleColor.Red);
                Console.ReadKey();
                Start();
            }

            if (vstupI > tmp)
            {
                CW.WL("Nedostatečný zůstatek!", ConsoleColor.Red);
                Console.ReadKey();
                Start();
            }

            tmp-=vstupI;


            StreamWriter sw = new StreamWriter(Login.loggedname+"_zus.txt");
            sw.WriteLine(tmp);
            sw.Flush();
            sw.Close();

            StreamWriter sw1 = new StreamWriter(Login.loggedname + "_his.txt",true);
            sw1.WriteLine(DateTime.Now +" -"+vstupI);
            sw1.Flush();
            sw1.Close();

            Console.Clear();

            Menu.Start();


        }


    }
}
