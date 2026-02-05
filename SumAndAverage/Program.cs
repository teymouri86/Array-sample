using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            Console.WriteLine("چند عدد می خواهید وارد کنید؟");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            // گرفتن اعداد از کاربر
            for (int i = 0; i < n; i++)
            {
                Console.Write($"عدد {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / n;

            Console.WriteLine("\nنتیجه:");
            Console.WriteLine($"مجموع اعداد: {sum}");
            Console.WriteLine($"میانگین اعداد: {average:F2}");
            Console.ReadKey();
        }
    }
}
