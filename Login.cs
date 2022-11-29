using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Bankomat
{
    internal class Login
    {

        public static string loggedname;

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Login      (1)");
            Console.WriteLine("Registrace (2)");
            int tmp = Convert.ToInt32(Console.ReadLine());
            switch (tmp)
            {

                default:
                Start();
                    break;


                case 1:
                    Log();
                    break;

                case 2:
                    Reg();
                    break;


            }



        }
        public static void Log()
        {
            Console.Clear();

            CW.WL("Zadej číslo účtu:", ConsoleColor.DarkGreen);
            string name = Console.ReadLine();
            CW.WL("Zadej pin pro účet:", ConsoleColor.Red);
            string pin = Console.ReadLine();

            if (!File.Exists(name + ".txt") )
            {
                Console.Clear();

                CW.WL("Neplatný login nebo heslo",ConsoleColor.DarkRed);
                Console.WriteLine();
                Start();
            }
            StreamReader sr = new StreamReader(name + ".txt");
            if (sr.ReadLine() != pin)
            {
                Console.Clear();

                CW.WL("Neplatný login nebo heslo", ConsoleColor.DarkRed);
                Console.WriteLine();
                Start();
            }
            loggedname = name;
            sr.Close();
            Menu.Start();








        }

        public static void Reg()
        {
            Console.Clear();

            CW.WL("Zadej číslo účtu:", ConsoleColor.DarkGreen);
            string name = Console.ReadLine();
            CW.WL("Zadej pin pro účet:", ConsoleColor.Red);
            string pin = Console.ReadLine();


            StreamWriter sw = new StreamWriter(name + ".txt");
            StreamWriter sw1 = new StreamWriter(name + "_his.txt");
            StreamWriter sw2 = new StreamWriter(name + "_zus.txt");
            sw.WriteLine(pin);
            sw.Flush();
            sw.Close();


            sw1.Write("");
            sw1.Flush();
            sw1.Close();

            sw2.WriteLine("0");
            sw2.Flush();
            sw2.Close();

            Console.Clear();
            Start();
            


        }





    }
}
