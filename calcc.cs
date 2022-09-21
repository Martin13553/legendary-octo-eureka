using System;

class Program
{
    public static void Main(string[] args)
    {
        int command = 10;
        do
        {
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть из первого второе");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            command = Convert.ToInt32(Console.ReadLine());
            if (command < 6)
            {
                Console.WriteLine("Введите первое число");
                Double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                Double b = Convert.ToDouble(Console.ReadLine());

                if (command == 1)
                {
                    Console.WriteLine($"{a} + {b} = {a + b}");
                }
                else if (command == 2)
                {
                    Console.WriteLine($"{a} - {b} = {a - b}");
                }
                else if (command == 3)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
                else if (command == 4)
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
                else if (command == 5)
                {
                    Console.WriteLine("Введите степень N");
                    Double N = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Число {a} в степени {N} = {Math.Pow(a, N)}");
                }
            }
            else if (command < 9)
            {
                Console.WriteLine("Введите число");
                Double a = Convert.ToDouble(Console.ReadLine());
                if (command == 6)
                {
                    Console.WriteLine($"Корень из {a} = {Math.Sqrt(a)}");
                }
                else if (command == 7)
                {
                    Console.WriteLine($"1 процент от {a} = {a * 0.01}");
                }
                else if (command == 8)
                {
                    int f = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        f *= i;
                    }
                    Console.WriteLine($"Факториал {a} = {f}");
                }
            }
        }
        while (command != 9);
    }
}