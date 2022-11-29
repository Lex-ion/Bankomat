using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Vypis
    {
        public static void Start()
        {
            Console.Clear();


            StreamReader sr = new StreamReader(Login.loggedname+"_zus.txt");

            int tmp=(int)Convert.ToInt64(sr.ReadLine());
            sr.Close();

            CW.WL(tmp.ToString(), ConsoleColor.Green);
            Console.ReadKey();

            Menu.Start();
        }



    }
}
