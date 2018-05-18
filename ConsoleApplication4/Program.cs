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
            while (true)
            {
                string[] pole = new string[] { "|.|", ".|", ".|", "|.|", ".|", ".|", "|.|", ".|", ".|", };



//ПЕРВЫЙ ВВОД
                Console.WriteLine("Для начала игры введите номер строки a, b, c" + "\n" + 
                    "и номер столбца 1, 2, 3, например a1" + "\n" + "\n" +
                    "Игровое поле" + "\n" + "    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                Console.WriteLine("\nВведите номер первой клетки\n");
                string n1 = Console.ReadLine();
                if (n1 == "a1")
                    {
                        pole[0] = "|X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }
                    else if (n1 == "a2")
                    {
                        pole[1] = "X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }
                    else if (n1 == "a3")
                    {
                        pole[2] = "X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }

                    else if (n1 == "b1")
                    {
                        pole[3] = "|X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }
                    else if (n1 == "b2")
                    {
                        pole[4] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                    else if (n1 == "b3")
                    {
                        pole[5] = "X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }

                    else if (n1 == "c1")
                    {
                        pole[6] = "|X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }
                    else if (n1 == "c2")
                    {
                        pole[7] = "X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }
                    else if (n1 == "c3")
                    {
                        pole[8] = "X|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nНеверное значение");
                        continue;
                    }



//ХОД КОМПЬЮТЕРА 1
                string[] pc1 = new string[] { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3", };
                Random r1 = new Random();
                string pcn1 = "";
                Console.WriteLine("\nХод компьютера...");
                while (true)
                {
                    int r2 = r1.Next(0, 8);
                    pcn1 = pc1[r2];

                    if (pcn1 == n1)
                        continue;

                    else if (pcn1 == "a1")
                    {
                        pole[0] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn1 == "a2")
                    {
                        pole[1] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn1 == "a3")
                    {
                        pole[2] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }

                    else if (pcn1 == "b1")
                    {
                        pole[3] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn1 == "b2")
                    {
                        pole[4] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn1 == "b3")
                    {
                        pole[5] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }

                    else if (pcn1 == "c1")
                    {
                        pole[6] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn1 == "c2")
                    {
                        pole[7] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn1 == "c3")
                    {
                        pole[8] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                }
                Console.WriteLine("\nКомпьютер походил на клетку " + pcn1);





                //ВТОРОЙ ВВОД
                Console.WriteLine("\nВведите номер второй клетки\n");
                string n2 = Console.ReadLine();
                if (n2 == pcn1)
                {
                    Console.WriteLine("Клетка занята, идите на хуй сэр\n");
                    continue;
                }
                else if (n2 == n1)
                {
                    Console.WriteLine("Клетка занята, идите на хуй сэр\n");
                    continue;
                }

                else if (n2 == "a1")
                {
                    pole[0] = "|X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n2 == "a2")
                {
                    pole[1] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n2 == "a3")
                {
                    pole[2] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }

                else if (n2 == "b1")
                {
                    pole[3] = "|X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n2 == "b2")
                {
                    pole[4] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n2 == "b3")
                {
                    pole[5] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }

                else if (n2 == "c1")
                {
                    pole[6] = "|X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n2 == "c2")
                {
                    pole[7] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n2 == "c3")
                {
                    pole[8] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else
                {
                    Console.WriteLine("\nНеверное значение");
                    continue;
                }


//ХОД КОМПЬЮТЕРА 2
                string[] pc1_2 = new string[] { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3", };
                Random r1_2 = new Random();
                string pcn2 = "";
                Console.WriteLine("\nХод компьютера...");
                while (true)
                {
                    int r2_2 = r1_2.Next(0, 8);
                    pcn2 = pc1_2[r2_2];

                    if (pcn2 == pcn1)
                        continue;
                    else if (pcn2 == n1)
                        continue;
                    else if (pcn2 == n2)
                        continue;
                    else if (pcn2 == "a1")
                    {
                        pole[0] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn2 == "a2")
                    {
                        pole[1] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn2 == "a3")
                    {
                        pole[2] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }

                    else if (pcn2 == "b1")
                    {
                        pole[3] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn2 == "b2")
                    {
                        pole[4] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn2 == "b3")
                    {
                        pole[5] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }

                    else if (pcn2 == "c1")
                    {
                        pole[6] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn2 == "c2")
                    {
                        pole[7] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn2 == "c3")
                    {
                        pole[8] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                }
                Console.WriteLine("\nКомпьютер походил на клетку " + pcn2);






//ТРЕТИЙ ВВОД
                Console.WriteLine("\nВведите номер третьей клетки\n");
                string n3 = Console.ReadLine();
                if (n3 == pcn1)
                {
                    Console.WriteLine("Клетка занята, идите на хуй сэр\n");
                    continue;
                }
                else if (n3 == n1)
                {
                    Console.WriteLine("Клетка занята, идите на хуй сэр\n");
                    continue;
                }
                else if (n3 == n2)
                {
                    Console.WriteLine("Клетка занята, идите на хуй сэр\n");
                    continue;
                }
                else if (n3 == pcn2)
                {
                    Console.WriteLine("Клетка занята, идите на хуй сэр\n");
                    continue;
                }

                else if (n3 == "a1")
                {
                    pole[0] = "|X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n3 == "a2")
                {
                    pole[1] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n3 == "a3")
                {
                    pole[2] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }

                else if (n3 == "b1")
                {
                    pole[3] = "|X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n3 == "b2")
                {
                    pole[4] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n3 == "b3")
                {
                    pole[5] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }

                else if (n3 == "c1")
                {
                    pole[6] = "|X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n3 == "c2")
                {
                    pole[7] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else if (n3 == "c3")
                {
                    pole[8] = "X|";
                    Console.WriteLine("    1 2 3" + "\n" +
                       " a " + pole[0] + pole[1] + pole[2] + "\n" +
                       " b " + pole[3] + pole[4] + pole[5] + "\n" +
                       " c " + pole[6] + pole[7] + pole[8] + "\n");
                }
                else
                {
                    Console.WriteLine("\nНеверное значение");
                    continue;
                }







//ХОД КОМПЬЮТЕРА 3
                string[] pc1_3 = new string[] { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3", };
                Random r1_3 = new Random();
                string pcn3 = "";
                Console.WriteLine("\nХод компьютера...");
                while (true)
                {
                    int r2_3 = r1_3.Next(0, 8);
                    pcn3 = pc1_3[r2_3];
                    if (pcn3 == pcn1)
                        continue;
                    else if (pcn3 == n1)
                        continue;
                    else if(pcn3 == pcn2)
                        continue;
                    else if (pcn3 == n2)
                        continue;
                    else if (pcn3 == n3)
                        continue;
                    else if (pcn3 == "a1")
                    {
                        pole[0] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn3 == "a2")
                    {
                        pole[1] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn3 == "a3")
                    {
                        pole[2] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }

                    else if (pcn3 == "b1")
                    {
                        pole[3] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn3 == "b2")
                    {
                        pole[4] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn3 == "b3")
                    {
                        pole[5] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }

                    else if (pcn3 == "c1")
                    {
                        pole[6] = "|O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn3 == "c2")
                    {
                        pole[7] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                    else if (pcn3 == "c3")
                    {
                        pole[8] = "O|";
                        Console.WriteLine("    1 2 3" + "\n" +
                           " a " + pole[0] + pole[1] + pole[2] + "\n" +
                           " b " + pole[3] + pole[4] + pole[5] + "\n" +
                           " c " + pole[6] + pole[7] + pole[8] + "\n");
                        break;
                    }
                }
                Console.WriteLine("\nКомпьютер походил на клетку " + pcn3+ "\n");

                if (pole[0] == "|X|" && pole[1] == "X|" && pole[2] == "X|")
                    Console.WriteLine("\nВы победили!\n");
                else if (pole[3] == "|X|" && pole[4] == "X|" && pole[5] == "X|")
                    Console.WriteLine("\nВы победили!\n");
                else if(pole[6] == "|X|" && pole[7] == "X|" && pole[8] == "X|")
                    Console.WriteLine("\nВы победили!\n");
                else if (pole[0] == "|X|" && pole[3] == "|X|" && pole[6] == "|X|")
                    Console.WriteLine("\nВы победили!\n");
                else if (pole[1] == "X|" && pole[4] == "X|" && pole[7] == "X|")
                    Console.WriteLine("\nВы победили!\n");
                else if (pole[2] == "X|" && pole[5] == "X|" && pole[8] == "X|")
                    Console.WriteLine("\nВы победили!\n");
                else if (pole[0] == "|X|" && pole[4] == "X|" && pole[8] == "X|")
                    Console.WriteLine("\nВы победили!\n");
                else if (pole[2] == "|X|" && pole[4] == "X|" && pole[6] == "X|")
                    Console.WriteLine("\nВы победили!\n");



                else if(pole[0] == "|O|" && pole[1] == "O|" && pole[2] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[3] == "|O|" && pole[4] == "|O|" && pole[5] == "|O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[6] == "|O|" && pole[7] == "O|" && pole[8] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[0] == "|O|" && pole[3] == "O|" && pole[6] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[1] == "O|" && pole[4] == "O|" && pole[7] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[2] == "O|" && pole[5] == "O|" && pole[8] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[0] == "|O|" && pole[4] == "O|" && pole[8] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");
                else if (pole[2] == "|O|" && pole[4] == "O|" && pole[6] == "O|")
                    Console.WriteLine("\nВы проиграли!\n");

                else
                    Console.WriteLine("\nНичья!\n");
            }

        }
    }
}
