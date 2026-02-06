using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        for (int i = 0; i <20; i++){
            int top = random.Next(1, 101);
            int bot = random.Next(1, 101);
            
            Fraction frac1 = new Fraction(top, bot);
            Console.WriteLine($"Fraction {i+1}: string: {frac1.GetFractionString()} Number: {frac1.GetDecimalValue().ToString("F2")}");
        }
    }
}