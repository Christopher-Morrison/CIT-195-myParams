using System;

class Program
{
    public static int sum(params int[] arrayIndex)
    {
        int total = 0;
        foreach (int i in arrayIndex)
        {
            total += i;
        }
        return total;
    }
    public static int product(params int[] arrayIndex)
    {
        int total = 1;
        foreach (int i in arrayIndex)
        {
            total *= i;
        }
        return total;
    }
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers would you like to generate?");
        int totalNumbers = int.Parse(Console.ReadLine());
        int[] numbers = new int[totalNumbers];
        for (int i = 0; i < totalNumbers; i++)
        {
            numbers[i] = r.Next(1, 10);
        }

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine($"Total Sum of the numbers: {sum(numbers)}");
        Console.WriteLine($"Combined product of the numbers: {product(numbers)}");
    }
}
