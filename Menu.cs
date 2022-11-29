using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Menu
    {

        public static void Start()
        {
            Console.Clear();

            Console.WriteLine("Vložit peníze    (1)");
            Console.WriteLine("Vybrat peníze    (2)");
            Console.WriteLine("Zůstatek na účtu (3)");
            Console.WriteLine("Historie         (4)");
            Console.WriteLine("Odhlásit         (5)");
            Console.WriteLine("Vypnout          (6)");

            int volba = Convert.ToInt32(Console.ReadLine());

        //    char volba =Convert.ToChar( Console.ReadKey());

            switch (volba)
            {
                default:
                    Start();
                    break;

                case 1:

                    Console.Clear();
                    Vklad.Start();
                    break;

                case 2:
                    Vyber.Start();
                    break;

                case 3:
                    Vypis.Start();
                    break;

                case 4:
                    Historie.Start();
                    break;

                case 5:
                    Login.Start();
                    break;

                case 6:
                    break;

            }





        }


    }
}
