using System;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the lambda problems");
            LambdaFunction lambda = new LambdaFunction(); // calling
            lambda.Validate();
        }
    }
}
