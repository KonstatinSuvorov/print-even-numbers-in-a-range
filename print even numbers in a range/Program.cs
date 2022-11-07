using System;
/*
Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется про-
извести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20.
*/

namespace print_even_numbers_in_a_range
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Введите два числа:\t");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > a)
            {
                for(int i = a; i < b; i++)
                {
                    if (i % 2 == 0)Console.WriteLine(i);
                }
            }
            if (a > b)
            {
                for (int i = b; i < a; i++)
                {
                    if (i % 2 == 0)Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
