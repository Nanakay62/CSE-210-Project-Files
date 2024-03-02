using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


     List<int> numbers = new List<int>();
     int number;

     Console.WriteLine("Enter a list of numbers. When you are done, press zero (0). The sum, average and max numbers will be provided");

     do {

        Console.Write("Write a series of numbers: ");
        number = int.Parse(Console.ReadLine());

        if (number != 0) {
            numbers.Add(number);
        }
     }

     while(number !=0);

     int sum = numbers.Sum();
     double average = numbers.Average();
     int max = numbers.Max();

     Console.WriteLine($"The sum is : {sum}.");
     Console.WriteLine($"The average is :{average}.");
     Console.WriteLine($"The max is: {max}");


     int minPositive = numbers.Where(i => i >0).Min();
     Console.WriteLine($"The least positive number is: {minPositive}");

     numbers.Sort();
     Console.WriteLine("The sorted list of numbers are:");

     foreach(int num in numbers) {
        Console.WriteLine(num);

     }








    }
}