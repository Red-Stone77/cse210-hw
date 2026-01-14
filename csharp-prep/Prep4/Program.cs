using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        string number = "-1";

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != "0"){
            Console.Write("Enter Number: ");
            number = Console.ReadLine();
            int num = int.Parse(number);
            list.Add(num);

        } 

        int sum = list.Sum(); Console.WriteLine($"The sum is: {sum}");
        double average = list.Average(); Console.WriteLine($"The average is: {average}");
        int max = list.Max(); Console.WriteLine($"The largest number is: {max}");
    }
}