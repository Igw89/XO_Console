using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для начала игры введите номер строки a, b, c" + "\n" +
                    "и номер столбца 1, 2, 3, например a1" + "\n" + "\n" +
                    "Игровое поле" + "\n" + "    1 2 3" + "\n" +
                           " a |.|.|.|\n" +
                           " b |.|.|.|\n" +
                           " c |.|.|.|\n");
            while (true)
            {
                Random rnd = new Random();
                string[] pole = new string[] { "|.|", ".|", ".|", "|.|", ".|", ".|", "|.|", ".|", ".|", };
                string[] kletki = new string[] { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3"};
                string[] alltxt = new string[] {"\nВведите номер первой клетки\n",
                                                "\nНеверное значение\n",
                                                "\nХод компьютера...\n",
                                                "\nВведите номер второй клетки\n",
                                                "\nКлетка занята, идите на хуй сэр\n",
                                                "\nВведите номер третьей клетки\n",
                                                "\nВы победили!\n",
                                                "\nВы проиграли!\n",
                                                "\nНичья!\n"};



//ПЕРВЫЙ ВВОД
                Console.WriteLine(alltxt[0]);
                string n1 = Console.ReadLine();

                if (n1 == "a1")
                    {
                        pole[0] = "|X|";
                    }

                    else if (n1 == "a2")
                    {
                        pole[1] = "X|";
                    }

                    else if (n1 == "a3")
                    {
                        pole[2] = "X|";
                    }

                    else if (n1 == "b1")
                    {
                        pole[3] = "|X|";
                    }

                    else if (n1 == "b2")
                    {
                        pole[4] = "X|";
                    }

                    else if (n1 == "b3")
                    {
                        pole[5] = "X|";
                    }

                    else if (n1 == "c1")
                    {
                        pole[6] = "|X|";
                    }

                    else if (n1 == "c2")
                    {
                        pole[7] = "X|";
                    }

                    else if (n1 == "c3")
                    {
                        pole[8] = "X|";
                    }

                    else
                    {
                        Console.WriteLine(alltxt[1]);
                        continue;
                    }

                Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n"+
                           "\nВы походили на клетку" + n1 + "\n");



//ХОД КОМПЬЮТЕРА 1
                string pcn1 = "";
                Console.WriteLine(alltxt[2]);
                while (true)
                {
                    int r2 = rnd.Next(0, 8);
                    pcn1 = kletki[r2];

                    if (pcn1 == n1)
                        continue;

                    else if (pcn1 == "a1")
                    {
                        pole[0] = "|O|";
                        break;
                    }

                    else if (pcn1 == "a2")
                    {
                        pole[1] = "O|";
                        break;
                    }

                    else if (pcn1 == "a3")
                    {
                        pole[2] = "O|";
                        break;
                    }

                    else if (pcn1 == "b1")
                    {
                        pole[3] = "|O|";
                        break;
                    }

                    else if (pcn1 == "b2")
                    {
                        pole[4] = "O|";
                        break;
                    }

                    else if (pcn1 == "b3")
                    {
                        pole[5] = "O|";
                        break;
                    }

                    else if (pcn1 == "c1")
                    {
                        pole[6] = "|O|";
                        break;
                    }

                    else if (pcn1 == "c2")
                    {
                        pole[7] = "O|";
                        break;
                    }

                    else if (pcn1 == "c3")
                    {
                        pole[8] = "O|";
                        break;
                    }
                }
                Console.WriteLine("    1 2 3" + "\n" +
           " a " + pole[0] + pole[1] + pole[2] + "\n" +
           " b " + pole[3] + pole[4] + pole[5] + "\n" +
           " c " + pole[6] + pole[7] + pole[8] + "\n" +
           "\nКомпьютер походил на клетку " + pcn1 + "\n");



//ВТОРОЙ ВВОД
                Console.WriteLine(alltxt[3]);
                string n2 = Console.ReadLine();

                if (n2 == pcn1 || n2 == n1)
                {
                    Console.WriteLine(alltxt[4]);
                    continue;
                }
               
                else if (n2 == "a1")
                {
                    pole[0] = "|X|";
                }

                else if (n2 == "a2")
                {
                    pole[1] = "X|";
                }

                else if (n2 == "a3")
                {
                    pole[2] = "X|";
                }

                else if (n2 == "b1")
                {
                    pole[3] = "|X|";
                }

                else if (n2 == "b2")
                {
                    pole[4] = "X|";
                }

                else if (n2 == "b3")
                {
                    pole[5] = "X|";
                }

                else if (n2 == "c1")
                {
                    pole[6] = "|X|";
                }

                else if (n2 == "c2")
                {
                    pole[7] = "X|";
                }

                else if (n2 == "c3")
                {
                    pole[8] = "X|";
                }

                else
                {
                    Console.WriteLine(alltxt[1]);
                    continue;
                }
                Console.WriteLine("    1 2 3" + "\n" +
           " a " + pole[0] + pole[1] + pole[2] + "\n" +
           " b " + pole[3] + pole[4] + pole[5] + "\n" +
           " c " + pole[6] + pole[7] + pole[8] + "\n" +
           "\nВы походили на клетку " + n1 + "\n");



//ХОД КОМПЬЮТЕРА 2
                string pcn2 = "";
                Console.WriteLine(alltxt[2]);
                while (true)
                {
                    int r2_2 = rnd.Next(0, 8);
                    pcn2 = kletki[r2_2];

                    if (pcn2 == pcn1 || pcn2 == n1 || pcn2 == n2)
                        continue;

                    else if (pcn2 == "a1")
                    {
                        pole[0] = "|O|";
                        break;
                    }

                    else if (pcn2 == "a2")
                    {
                        pole[1] = "O|";
                        break;
                    }

                    else if (pcn2 == "a3")
                    {
                        pole[2] = "O|";
                        break;
                    }

                    else if (pcn2 == "b1")
                    {
                        pole[3] = "|O|";
                        break;
                    }

                    else if (pcn2 == "b2")
                    {
                        pole[4] = "O|";
                        break;
                    }

                    else if (pcn2 == "b3")
                    {
                        pole[5] = "O|";
                        break;
                    }

                    else if (pcn2 == "c1")
                    {
                        pole[6] = "|O|";
                        break;
                    }

                    else if (pcn2 == "c2")
                    {
                        pole[7] = "O|";
                        break;
                    }

                    else if (pcn2 == "c3")
                    {
                        pole[8] = "O|";
                        break;
                    }
                }
                Console.WriteLine("    1 2 3" + "\n" +
                " a " + pole[0] + pole[1] + pole[2] + "\n" +
                " b " + pole[3] + pole[4] + pole[5] + "\n" +
                " c " + pole[6] + pole[7] + pole[8] + "\n" +
                "\nКомпьютер походил на клетку " + pcn2 + "\n");



//ТРЕТИЙ ВВОД
                Console.WriteLine(alltxt[5]);
                string n3 = Console.ReadLine();

                if (n3 == pcn1 || n3 == n1 || n3 == n2 || n3 == pcn2)
                {
                    Console.WriteLine(alltxt[4]);
                    continue;
                }

                else if (n3 == "a1")
                {
                    pole[0] = "|X|";
                }

                else if (n3 == "a2")
                {
                    pole[1] = "X|";
                }

                else if (n3 == "a3")
                {
                    pole[2] = "X|";
                }

                else if (n3 == "b1")
                {
                    pole[3] = "|X|";
                }

                else if (n3 == "b2")
                {
                    pole[4] = "X|";
                }

                else if (n3 == "b3")
                {
                    pole[5] = "X|";
                }

                else if (n3 == "c1")
                {
                    pole[6] = "|X|";
                }

                else if (n3 == "c2")
                {
                    pole[7] = "X|";
                }

                else if (n3 == "c3")
                {
                    pole[8] = "X|";
                }

                else
                {
                    Console.WriteLine(alltxt[1]);
                    continue;
                }
                Console.WriteLine("    1 2 3" + "\n" +
                " a " + pole[0] + pole[1] + pole[2] + "\n" +
                " b " + pole[3] + pole[4] + pole[5] + "\n" +
                " c " + pole[6] + pole[7] + pole[8] + "\n" +
                "\nВы походили на клетку " + n3 + "\n");



//ХОД КОМПЬЮТЕРА 3
                string pcn3 = "";
                Console.WriteLine(alltxt[2]);
                while (true)
                {
                    int r2_3 = rnd.Next(0, 8);
                    pcn3 = kletki[r2_3];

                    if (pcn3 == pcn1 || pcn3 == n1 || pcn3 == pcn2|| pcn3 == n2|| pcn3 == n3)
                        continue;

                    else if (pcn3 == "a1")
                    {
                        pole[0] = "|O|";
                        break;
                    }

                    else if (pcn3 == "a2")
                    {
                        pole[1] = "O|";
                        break;
                    }

                    else if (pcn3 == "a3")
                    {
                        pole[2] = "O|";
                        break;
                    }

                    else if (pcn3 == "b1")
                    {
                        pole[3] = "|O|";
                        break;
                    }

                    else if (pcn3 == "b2")
                    {
                        pole[4] = "O|";
                        break;
                    }

                    else if (pcn3 == "b3")
                    {
                        pole[5] = "O|";
                        break;
                    }

                    else if (pcn3 == "c1")
                    {
                        pole[6] = "|O|";
                        break;
                    }

                    else if (pcn3 == "c2")
                    {
                        pole[7] = "O|";
                        break;
                    }

                    else if (pcn3 == "c3")
                    {
                        pole[8] = "O|";
                        break;
                    }
                }
                Console.WriteLine("    1 2 3" + "\n" +
                " a " + pole[0] + pole[1] + pole[2] + "\n" +
                " b " + pole[3] + pole[4] + pole[5] + "\n" +
                " c " + pole[6] + pole[7] + pole[8] + "\n" +
                "\nКомпьютер походил на клетку " + pcn3 + "\n");



//ВЫВОД РЕЗУЛЬТАТА
                if (pole[0] == "|X|" && pole[1] == "X|" && pole[2] == "X|")
                    Console.WriteLine(alltxt[6]);
                else if (pole[3] == "|X|" && pole[4] == "X|" && pole[5] == "X|")
                    Console.WriteLine(alltxt[6]);
                else if(pole[6] == "|X|" && pole[7] == "X|" && pole[8] == "X|")
                    Console.WriteLine(alltxt[6]);
                else if (pole[0] == "|X|" && pole[3] == "|X|" && pole[6] == "|X|")
                    Console.WriteLine(alltxt[6]);
                else if (pole[1] == "X|" && pole[4] == "X|" && pole[7] == "X|")
                    Console.WriteLine(alltxt[6]);
                else if (pole[2] == "X|" && pole[5] == "X|" && pole[8] == "X|")
                    Console.WriteLine(alltxt[6]);
                else if (pole[0] == "|X|" && pole[4] == "X|" && pole[8] == "X|")
                    Console.WriteLine(alltxt[6]);
                else if (pole[2] == "|X|" && pole[4] == "X|" && pole[6] == "X|")
                    Console.WriteLine(alltxt[6]);



                else if(pole[0] == "|O|" && pole[1] == "O|" && pole[2] == "O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[3] == "|O|" && pole[4] == "|O|" && pole[5] == "|O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[6] == "|O|" && pole[7] == "O|" && pole[8] == "O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[0] == "|O|" && pole[3] == "O|" && pole[6] == "O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[1] == "O|" && pole[4] == "O|" && pole[7] == "O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[2] == "O|" && pole[5] == "O|" && pole[8] == "O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[0] == "|O|" && pole[4] == "O|" && pole[8] == "O|")
                    Console.WriteLine(alltxt[7]);
                else if (pole[2] == "|O|" && pole[4] == "O|" && pole[6] == "O|")
                    Console.WriteLine(alltxt[7]);

                else
                    Console.WriteLine(alltxt[8]);
            }

        }
    }
}
