using System;

namespace MyFirstProject
{
    class  Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;

            string answer;

            Console.WriteLine("Calculator");
            Console.WriteLine("Please enter your first number.");

        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your second number.");

        num2 = float.Parse(Console.ReadLine());

Console.WriteLine("What type of operation would you like to use? ");

answer = Console.ReadLine();

if (answer == "+")
{
    result = num1 + num2;
}
else if (answer == "-")
{
    result = num1 - num2;
}
else if (answer == "*")
{
    result = num1 *  num2;
}
else if (answer == "/")
{
    result = num1 / num2;
}
else
{
if (num2 != 0)
{
    result = num1 / num2;
}
else
{
    result = float.NaN;
}
}

if (float.IsNaN(result)){
    Console.WriteLine("Invalid operation - Cannot divide by 0!");
}
else {
  Console.WriteLine("the result is " + result);
}
            Console.ReadKey();
        }
    }
}
