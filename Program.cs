using System.Text;

namespace PixelFonts
{
    internal class Program
    {
        private static bool checkInput(string str)
        {
            foreach (char c in str)
            {
                if (int.TryParse(c.ToString(), out var key) || c == ' ' || c == ',' || c == '.')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static void symbolAdd(string[] arrayForAdd, string[] finalArray)
        {
            for (int i = 0; i < arrayForAdd.Length; i++)
            {
                finalArray[i] += arrayForAdd[i];
                finalArray[i] += " ";
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введите любое число (точки, запятые и пробелы допустимы): ");
            string[] result =
                    {
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                };

            var checker = true;

            while (checker)
            {
                var input = Console.ReadLine();
                if (input == null || !checkInput(input))
                {
                    Console.WriteLine("Ошибка ввода! Попробуйте еще раз.");
                }
                else
                {
                    Console.Clear();
                    foreach (char c in input)
                    {
                        switch (c)
                        {
                            case ('.'):
                                string[] dot =
                                {
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "●●   ",
                               "●●   ",
                               "     ",
                            };
                                symbolAdd(dot, result);
                                break;

                            case (' '):
                                if (result[result.Length - 2].EndsWith("     "))
                                {
                                    continue;
                                }
                                string[] space =
                                {
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                            };
                                symbolAdd(space, result);
                                break;

                            case (','):
                                string[] comma =
                                {
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "     ",
                               "●●   ",
                               "●●   ",
                               "●    ",
                            };
                                symbolAdd(comma, result);
                                break;

                            case ('0'):
                                string[] digit0 =
                                {
                               " ●●● ",
                               "●   ●",
                               "●  ●●",
                               "● ● ●",
                               "●●  ●",
                               "●   ●",
                               " ●●● ",
                               "     ",
                            };
                                symbolAdd(digit0, result);
                                break;

                            case ('1'):
                                string[] digit1 =
                                {
                               "  ●  ",
                               " ●●  ",
                               "  ●  ",
                               "  ●  ",
                               "  ●  ",
                               "  ●  ",
                               " ●●● ",
                               "     ",
                            };
                                symbolAdd(digit1, result);
                                break;

                            case ('2'):
                                string[] digit2 =
                                {
                               " ●●● ",
                               "●   ●",
                               "    ●",
                               "   ● ",
                               "  ●  ",
                               " ●   ",
                               "●●●●●",
                               "     ",
                            };
                                symbolAdd(digit2, result);
                                break;

                            case ('3'):
                                string[] digit3 =
                                {
                               "●●●●●",
                               "   ● ",
                               "  ●  ",
                               "   ● ",
                               "    ●",
                               "●   ●",
                               " ●●● ",
                               "     ",
                            };
                                symbolAdd(digit3, result);
                                break;

                            case ('4'):
                                string[] digit4 =
                                {
                               "   ● ",
                               "  ●● ",
                               " ● ● ",
                               "●  ● ",
                               "●●●●●",
                               "   ● ",
                               "   ● ",
                               "     ",
                            };
                                symbolAdd(digit4, result);
                                break;

                            case ('5'):
                                string[] digit5 =
                                {
                               "●●●●●",
                               "●    ",
                               "●●●● ",
                               "    ●",
                               "    ●",
                               "●   ●",
                               " ●●● ",
                               "     ",
                            };
                                symbolAdd(digit5, result);
                                break;

                            case ('6'):
                                string[] digit6 =
                                {
                               "  ●● ",
                               " ●   ",
                               "●    ",
                               "●●●● ",
                               "●   ●",
                               "●   ●",
                               " ●●● ",
                               "     ",
                            };
                                symbolAdd(digit6, result);
                                break;

                            case ('7'):
                                string[] digit7 =
                                {
                               "●●●●●",
                               "    ●",
                               "   ● ",
                               "  ●  ",
                               "  ●  ",
                               "  ●  ",
                               "  ●  ",
                               "     ",
                            };
                                symbolAdd(digit7, result);
                                break;

                            case ('8'):
                                string[] digit8 =
                                {
                               " ●●● ",
                               "●   ●",
                               "●   ●",
                               " ●●● ",
                               "●   ●",
                               "●   ●",
                               " ●●● ",
                               "     ",
                            };
                                symbolAdd(digit8, result);
                                break;

                            case ('9'):
                                string[] digit9 =
                                {
                               " ●●● ",
                               "●   ●",
                               "●   ●",
                               " ●●●●",
                               "    ●",
                               "   ● ",
                               " ●●  ",
                               "     ",
                            };
                                symbolAdd(digit9, result);
                                break;
                        } 
                    }
                    checker = false;
                }
            }
            var x = (Console.WindowWidth - result[0].Length + 1) / 2;
            var y = (Console.WindowHeight - 8) / 2;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
                Console.SetCursorPosition(x, ++y);
            }
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}