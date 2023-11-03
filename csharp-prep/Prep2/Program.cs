using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter grade:");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Looks like you need some more practice. Don't give up, try again. You can do eeet!");
        }
    }
}