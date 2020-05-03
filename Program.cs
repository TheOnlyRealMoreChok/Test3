using System;

namespace UdemyDZ
{
    class Program
    {
        static void Main(string[] args)
        {
                string name = "";
                while (true)
                {
                    Console.WriteLine("Выберите и введите команду:\n" +
                                      "Ввод имени - SetName\n" +
                                      "Многократное выведение имени на экран - DisplayName\n" +
                                      "Изменение цвета шрифта - SetColor\n" +
                                      "Прямоугольник с вашим именем в центре - DisplayBoxWithName");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "SetName":
                            if (name != "")
                            {
                                Console.WriteLine($"Вы уже вводили имя {name}. Введите новое имя:");
                                name = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Введите имя:");
                                name = Console.ReadLine();
                            }
                            break;
                        case "DisplayName":
                            Console.WriteLine("Сколько раз вы хотите увидеть своё имя?");
                            int count = Convert.ToInt32(Console.ReadLine());
                            if (name == "")
                            {
                                Console.WriteLine("Введите имя:");
                                name = Console.ReadLine();
                            }
                            Console.WriteLine("Ваше имя:");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(name);
                            }
                            break;
                        case "SetColor":
                            Console.WriteLine("Введите цвет букв: Красный, Желтый, Белый, Серый, Зеленый, Синий");
                            string color = Console.ReadLine();
                            switch (color)
                            {
                                case "Красный":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case "Желтый":
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;
                                case "Белый":
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case "Серый":
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                case "Зеленый":
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                case "Синий":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                            }
                            break;
                        case "DisplayBoxWithName":
                            string line = "";
                            if (name == "")
                            {
                                Console.WriteLine("Введите имя:");
                                name = Console.ReadLine();
                            }
                            for (int i = 0; i < name.Length + 2; i++)
                            {
                                line += '#';
                            }
                            Console.WriteLine(line);
                            Console.WriteLine("#" + name + "#");
                            Console.WriteLine(line);
                            break;
                    }
                }
            }

        }
    }
