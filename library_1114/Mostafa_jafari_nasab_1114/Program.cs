using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mostafa_jafari_nasab_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(1, 0);
            string hi = "Hi , Welcome to this application  ^_^";
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char b in hi)
            {
                Console.Write(b);
                Thread.Sleep(70);
            }
            Thread.Sleep(1000);
            Console.Clear();
            int goo;
            do
            {
                goo = 0;
                try
                {

                    ////

                    //Console.SetCursorPosition(1, 0);
                    string int_number = "Please enter the number : ";//?
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (char b in int_number)
                    {
                        Console.Write(b);
                        Thread.Sleep(70);
                    }
                    Console.ResetColor();
                    int Number = int.Parse(Console.ReadLine());
                    Thread.Sleep(1000);
                    Console.Clear();

                    ////

                    //Console.SetCursorPosition(35, 10);
                    string thanks = "Thanks, the number was registered successfully.";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foreach (char b in thanks)
                    {
                        Console.Write(b);
                        Thread.Sleep(50);
                    }
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.Clear();

                ///

                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(70);
                    Console.WriteLine("       ╔═════════════════════════════════════════╗");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║              Menu Librarian             ║");//?
                    Thread.Sleep(70);
                    Console.WriteLine("       ╠═════════════════════════════════════════╣");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║ 1-Input Users                           ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╟─────────────────────────────────────────╢");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║ 2-Input Books                           ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╟─────────────────────────────────────────╢");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║ 3-Users Show                            ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╟─────────────────────────────────────────╢");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║ 4-Books Show                            ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╟─────────────────────────────────────────╢");
                    Thread.Sleep(60);
                    Console.WriteLine("       ║ 5-Books Subject                         ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╟─────────────────────────────────────────╢");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║ 6-Edit Users                            ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╟─────────────────────────────────────────╢");
                    Thread.Sleep(70);
                    Console.WriteLine("       ║ 7-Exit                                  ║");
                    Thread.Sleep(70);
                    Console.WriteLine("       ╚═════════════════════════════════════════╝");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("");

                }

                /////

                catch
                {
                    Console.Clear();
                    string erorr = "pleas Enter just number...";
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (char b in erorr)
                    {
                        Console.Write(b);
                        Thread.Sleep(70);
                    }
                    Console.ResetColor();
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goo = 1;
                }
            } while (goo == 1);

            ////

            Console.Write("       Please Select The Desired Option: ");
            int Meno = int.Parse(Console.ReadLine());
            switch (Meno)
            {
                case 1:
                    Console.Clear();
                    //string /**/ = "Thanks, the number was registered successfully.";
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //foreach (char b in /**/)
                    //{
                    //    Console.Write(b);
                    //    Thread.Sleep(50);
                    //}
                    //Console.ResetColor();
                    break;

                case 2:
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    break;

                case 7:
                    Console.Clear();
                    string int_number = "Are you sure you want to Exit ? (yes) ";
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (char b in int_number)
                    {
                        Console.Write(b);
                        Thread.Sleep(70);
                    }
                    Console.ResetColor();
                    string exit = Console.ReadLine();
                    if (exit == "yes" || exit == "y" ||exit=="bale")
                    {
                        break;
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
            }

            Console.ReadKey();
        }
    }
}
