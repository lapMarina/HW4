using System;

namespace HW4
{
    class Program
    {
        static int GetPower(int a, int b) 
        {
            int result = 1;
            for (int i = 1; i <= b ; i++)
                result = result * a;
            return result;
        }
        static int GetSum(int a)
        {
            int result = 0;
            string _a = $"{a}";
            for (int i = 0; i < _a.Length; i++)
                result += Convert.ToInt32($"{_a[i]}");
            return result;
        }
        static int[] GetArray(int lenght, int min_value, int max_value)
        {
            int[] numbers = new int[lenght];
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                int random_int = random.Next(min_value, max_value);
                numbers[i] = random_int;
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое хотите возвести в степень");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую хотите возвести число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetPower(b: b, a: a));
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSum(a));

            Console.WriteLine("Введите число, которое будет указывать длину массива");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальный диапазон");
            int min_value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальный диапазон");
            int max_value = Convert.ToInt32(Console.ReadLine());
            int[] array = GetArray(lenght, min_value, max_value);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

        }
    }
}
