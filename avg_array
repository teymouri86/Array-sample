using System;

class Program
{
    static void Main()
    {
        Console.Write("چند عدد می‌خواهید وارد کنید؟ ");
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
    }
}
