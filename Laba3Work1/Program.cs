﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Калькулятор
{
    class Calculator
    {
        public static string input;
        public static double number1 = 0;
        public static double number2 = 0;
        public static double number = 0;
        static Calculator()
        {
            Calculator.Repeat();
        }
        private static void Repeat()
        {
            Console.WriteLine("Введіть математичну операцію: ");
            Console.WriteLine("Для того,щоб задати числа та знак операції окремо у вертикальному виді, після кожного числа, та знаку операції, введіть '+' ");
            input = Convert.ToString(Console.ReadLine());
            int q = 0;
            if (input == "+")
            {
                Console.WriteLine("Введіть числа та знак операції через Enter:");
                Console.WriteLine("Введіть перше число: ");
                string str1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введіть знак математичної операції (+, -, *): ");
                string icon2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введіть друге число: ");
                string str2 = Convert.ToString(Console.ReadLine());
                string new_str1 = "";
                string new_str2 = "";
                int g = 0;
                foreach (char n in str1)
                {
                    if (n == '+' || n == '*' || n == '-')
                    {
                        g++;
                        if (g > 0)
                        {
                            Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                            Calculator.Repeat();
                        }
                    }
                    if (n == '1' || n == '2' || n == '3' || n == '4' || n == '5' || n == '6' || n == '7' || n == '8' || n == '9' || n == '0' || n == ',' || n == '.')
                    {
                        if (n == '.')
                        {
                            q++;
                            new_str1 = ",";
                            continue;
                        }
                        if (n == ',')
                        {
                            q++;
                        }
                        new_str1 = new_str1 + Convert.ToString(n);
                    }
                }
                if (q > 1)
                {
                    Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                    Calculator.Repeat();
                }
                q = 0;
                foreach (char n in icon2)
                {
                    if (icon2 != "+" && icon2 != "-" && icon2 != "*")
                    {
                        Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                        Calculator.Repeat();
                    }
                }
                foreach (char n in str2)
                {
                    if (n == '+' || n == '*' || n == '-')
                    {
                        g++;
                        if (g > 0)
                        {
                            Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                            Calculator.Repeat();
                        }
                    }
                    if (n == '1' || n == '2' || n == '3' || n == '4' || n == '5' || n == '6' || n == '7' || n == '8' || n == '9' || n == '0' || n == ',' || n == '.')
                    {
                        if (n == '.')
                        {
                            q++;
                            new_str2 = ",";
                            continue;
                        }
                        if (q == ',')
                        {
                            q++;
                        }
                        new_str2 = new_str2 + Convert.ToString(n);
                    }
                }
                if (q > 1)
                {
                    Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                    Calculator.Repeat();
                }
                number1 = Convert.ToDouble(new_str1);
                number2 = Convert.ToDouble(new_str2);
                if (icon2 == "+")
                {
                    Calculator.Summa();
                    Repeat();
                }
                else if (icon2 == "-")
                {
                    Calculator.Minus();
                    Repeat();
                }
                else if (icon2 == "*")
                {
                    Calculator.Dobytok();
                    Repeat();
                }
            }
            else
            {
                q = 0;
                int count = input.Length;
                string[] massive_str = new string[count];
                int p = 0;
                int g = 0;
                string icon = "";
                string str = "";
                foreach (char n in input)
                {
                    if (n == ',' || n == '.')
                    {
                        q++;
                    }
                    if (n == '+' || n == '-' || n == '*')
                    {
                        g++;
                        if (g > 1)
                        {
                            Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                            Calculator.Repeat();
                        }
                        if (q > 1)
                        {
                            Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                            Calculator.Repeat();
                        }
                        icon = Convert.ToString(n);
                    }
                    massive_str[p] = Convert.ToString(n);
                    p++;
                }
                if (icon == "")
                {
                    Console.WriteLine("Введена некоректна математична операція (відсутні знаки множення, додавання, віднімання, інше)");
                    Calculator.Repeat();
                }
                p = 0;
                for (int i = 0; i < massive_str.Length; i++)
                {
                    if (massive_str[i] == "+" || massive_str[i] == "-" || massive_str[i] == "*" || massive_str[i] == "1" || massive_str[i] == "2" || massive_str[i] == "3" || massive_str[i] == "4" || massive_str[i] == "5" || massive_str[i] == "6" || massive_str[i] == "7" || massive_str[i] == "8" || massive_str[i] == "9" || massive_str[i] == "0" || massive_str[i] == "." || massive_str[i] == ",")
                    {
                        p++;
                    }
                }
                string[] new_massive_str = new string[p + 1];
                p = 1;
                for (int i = 0; i < massive_str.Length; i++)
                {
                    if (massive_str[i] == "+" || massive_str[i] == "-" || massive_str[i] == "*" || massive_str[i] == "1" || massive_str[i] == "2" || massive_str[i] == "3" || massive_str[i] == "4" || massive_str[i] == "5" || massive_str[i] == "6" || massive_str[i] == "7" || massive_str[i] == "8" || massive_str[i] == "9" || massive_str[i] == "0" || massive_str[i] == "." || massive_str[i] == ",")
                    {
                        new_massive_str[p] = massive_str[i];
                        p++;
                    }
                }
                int w = 0;
                for (int i = 1; i < new_massive_str.Length + 1; i++)
                {
                    if (new_massive_str[i - 1] == "+" || new_massive_str[i - 1] == "-" || new_massive_str[i - 1] == "*")
                    {
                        break;
                    }
                    if (new_massive_str[i] == "+" || new_massive_str[i] == "-" || new_massive_str[i] == "*")
                    {
                        foreach (char n in str)
                        {
                            if (str == "," || str == ".")
                            {
                                q++;
                            }
                        }
                        if (q > 1)
                        {
                            Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                            Calculator.Repeat();
                        }
                        number1 = Double.Parse(str);
                        w = str.Length;
                        str = "";
                    }
                    else if (new_massive_str[i] != "+" || new_massive_str[i] != "-" || new_massive_str[i] != "*")
                    {
                        if (new_massive_str[i] == ".")
                        {
                            new_massive_str[i] = ",";
                        }
                        str = str + new_massive_str[i];
                    }
                }
                for (int i = 1; i < new_massive_str.Length + 1; i++)
                {
                    if (new_massive_str[i - 1] == "+" || new_massive_str[i - 1] == "-" || new_massive_str[i - 1] == "*")
                    {
                        str = str + new_massive_str[i];
                    }
                    if (i == new_massive_str.Length - 1)
                    {
                        str = str + new_massive_str[i];
                        break;
                    }
                    if (new_massive_str[i] == "1" || new_massive_str[i] == "2" || new_massive_str[i] == "3" || new_massive_str[i] == "4" || new_massive_str[i] == "5" || new_massive_str[i] == "6" || new_massive_str[i] == "7" || new_massive_str[i] == "8" || new_massive_str[i] == "9" || new_massive_str[i] == "0" || new_massive_str[i] == "." || new_massive_str[i] == ",")
                    {
                        if (new_massive_str[i] == ".")
                        {
                            new_massive_str[i] = ",";
                        }
                        str = str + new_massive_str[i];
                    }
                }
                w++;
                q = 0;
                foreach (char n in str)
                {
                    if (str == "." || str == ",")
                    {
                        q++;
                        if (q > 1)
                        {
                            Console.WriteLine("Введена некоректна математична операція(відсутні знаки множення, додавання, віднімання, інше)");
                            Calculator.Repeat();
                        }
                    }
                }
                number2 = Convert.ToDouble(str.Substring(w));
                if (icon == "+")
                {
                    Calculator.Summa();
                    Repeat();
                }
                else if (icon == "-")
                {
                    Calculator.Minus();
                    Repeat();
                }
                else if (icon == "*")
                {
                    Calculator.Dobytok();
                    Repeat();
                }
            }
        }
        static public void Summa()
        {
            number = number1 + number2;
            Console.WriteLine("Відповідь: " + number);
        }
        static public void Minus()
        {
            number = number1 - number2;
            Console.WriteLine("Відповідь: " + number);
        }
        static public void Dobytok()
        {
            number = number1 * number2;
            Console.WriteLine("Відповідь: " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Calculator operation = new Calculator();
            Console.ReadLine();
        }
    }
}