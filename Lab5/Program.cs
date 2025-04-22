using System.Globalization;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
        foreach (string i in seasons)
        Console.WriteLine(i);
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        Console.WriteLine(days[0]);
        string[] book = {"Goosebumps", "The Lord of the Rings", "West with Girrafes"};
        string[] author = {"R.L. Stine", "J.R.R Tolkien", "Lynda Rutledge"};
        Console.WriteLine(book[1]);
        Console.WriteLine(author[1]);
        int[] temperature = {65, 72, 78, 70, 68};
        Array.Sort(temperature);
        foreach (int i in temperature)
        Console.WriteLine(i);
        Console.WriteLine(temperature.Max());
        Console.WriteLine(temperature.Min());
        int[] numbers = { 1, 2, 3, 4, 5 };
int[] reversedNumbers = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
}

foreach (int number in reversedNumbers)
{
    Console.Write(number + " ");
}
    }
}
