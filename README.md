Sum and Average Calculator (C# Console)

A simple C# console application that allows the user to input multiple numbers, calculates their sum, and computes the average.
This program is a beginner-friendly example for learning arrays, loops, and basic input/output in C#.

---

📌 Overview

The application:

- Asks the user how many numbers they want to enter
- Takes input for each number
- Calculates the sum of all entered numbers
- Computes the average and displays it with 2 decimal precision

Example output:

چند عدد می‌خواهید وارد کنید؟ 3
عدد 1: 5
عدد 2: 10
عدد 3: 15

نتیجه:
مجموع اعداد: 30
میانگین اعداد: 10.00

---

⭐ Features

- ✔️ Dynamic number of inputs (based on user input)
- ✔️ Uses arrays to store numbers
- ✔️ Calculates sum and average efficiently
- ✔️ Beginner-friendly and easy to modify
- ✔️ Console-based — no GUI required

---

📂 Code Snippet

Console.Write("چند عدد می‌خواهید وارد کنید؟ ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

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

---

🛠 Requirements

- Windows, macOS, or Linux
- .NET SDK installed
- Any C# IDE or text editor (Visual Studio, Visual Studio Code, Rider, etc.)

---

🚀 How to Run

1. Copy the code into a ".cs" file (e.g., "Program.cs")
2. Open a terminal/console and navigate to the file directory
3. Compile the program using:

csc Program.cs

4. Run the compiled program:

Program.exe

5. Follow the on-screen instructions to enter numbers

---

📜 License

This project is free to use for learning, educational, and personal purposes.

---

🤝 Contributions

Feel free to submit pull requests or suggest improvements, such as:

- Validating input for non-numeric entries
- Handling empty or negative input gracefully
- Extending to calculate median, max, min, etc.

---

⭐ Support

If you find this project useful, give it a star ⭐ on GitHub!
