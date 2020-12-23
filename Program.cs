using System;
namespace sud
{
    class Program
    {
        static void Start(ref int width, ref int height)
        {
            Console.SetWindowSize(width + 1, height);
            Console.SetBufferSize(width + 1, height);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================================");
            Console.WriteLine("SUDOKU");
            Console.WriteLine("==============================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose one of three difficulty levels");
            Console.Write("Type in 'easy', 'medium' or 'hard': ");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            try
            {
                int width = 45;
                int height = 35;
                Start(ref width, ref height);
                string level = Console.ReadLine();
                int n = 0, f = 0;
                int[,] A = new int[9, 9];
                int[,] M = new int[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        A[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                    }
                };
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        M[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                    }
                };
                Console.WriteLine();
                if (level == "easy")
                {
                    Console.Clear();
                    n = 3;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("==============================================");
                    Console.Write("SUDOKU");
                    Console.Write("       ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("easy");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
                    Console.ResetColor();
                }
                else if (level == "medium")
                {
                    Console.Clear();
                    n = 51;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("==============================================");
                    Console.Write("SUDOKU");
                    Console.Write("       ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write("medium");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
                    Console.ResetColor();
                }
                else if (level == "hard")
                {
                    Console.Clear();
                    n = 58;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("==============================================");
                    Console.Write("SUDOKU");
                    Console.Write("       ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write("hard");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Перевiрте введенi данi");
                }


                for (int k = 0; k < n; k++)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(0, 9);
                    int y = rnd.Next(0, 9);
                    M[x, y] = 0;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-––––-*-–––-*-––––-");
                Console.ResetColor();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (M[i, j] == 0)
                        {
                            if (j == 3 || j == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("|");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write(M[i, j]);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("|");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write(M[i, j]);
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            if (j == 3 || j == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("|");
                                Console.ResetColor();
                                Console.Write(M[i, j]);
                            }
                            else
                            {
                                Console.Write("|");
                                Console.Write(M[i, j]);
                            }
                        }

                    }
                    Console.Write("|");
                    Console.WriteLine();
                    if (i == 2 || i == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-––––-*-–––-*-––––-");
                        Console.ResetColor();
                    }
                };
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-––––-*-–––-*-––––-");
                Console.ResetColor();
                Console.WriteLine();

                for (int d = 0; d < n; d++)
                {
                    Console.Write("enter an empty cell value ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    bool a = true;
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (M[i, j] == 0)
                            {
                                M[i, j] = m;
                                a = false;
                                break;
                            }
                        }
                        if (a == false)
                        { break; }
                    };

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-––––-*-–––-*-––––-");
                    Console.ResetColor();

                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (M[i, j] == 0)
                            {
                                if (j == 3 || j == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("|");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.Write(M[i, j]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Write("|");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.Write(M[i, j]);
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                if (j == 3 || j == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("|");
                                    Console.ResetColor();
                                    Console.Write(M[i, j]);
                                }
                                else
                                {
                                    Console.Write("|");
                                    Console.Write(M[i, j]);
                                }
                            }
                        }
                        Console.Write("|");
                        Console.WriteLine();
                        if (i == 2 || i == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("-––––-*-–––-*-––––-");
                            Console.ResetColor();
                        }

                    };
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-––––-*-–––-*-––––-");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine("your answer:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-––––-*-–––-*-––––-");
                Console.ResetColor();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (A[i, j] == M[i, j])
                        {
                            if (j == 3 || j == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("|");
                                Console.ResetColor();
                                Console.Write(M[i, j]);
                            }
                            else
                            {

                                Console.Write("|" + M[i, j]);
                            }
                        }
                        else
                        {
                            if (j == 3 || j == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("|");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(M[i, j]);
                                Console.ResetColor();
                            }
                            else
                            {

                                Console.Write("|");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(M[i, j]);
                                Console.ResetColor();
                            }
                            f += 1;
                        }
                    }
                    Console.Write("|");
                    Console.WriteLine();
                    if (i == 2 || i == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-––––-*-–––-*-––––-");
                        Console.ResetColor();
                    }

                };
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-––––-*-–––-*-––––-");
                Console.ResetColor();
                if (f > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("you lose");
                    Console.ResetColor();
                }
                else if (f == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("you win!");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виключення: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трасування стеку: {ex.StackTrace}");
            }
        }
    }
}
