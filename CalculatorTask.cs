using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first Number");
        float a = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Please enter second number");
        float b = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Please Choose Operation ( + , - , * , / )");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                ICalculator add = new Add();
                Console.WriteLine("Result = " + add.Calc(a, b));
                break;

            case "-":
                ICalculator sub = new Sub();
                Console.WriteLine("Result = " + sub.Calc(a, b));
                break;

            case "*":
                ICalculator multi = new Multi();
                Console.WriteLine("Result = " + multi.Calc(a, b));
                break;

            case "/":
                ICalculator div = new Div();
                Console.WriteLine("Result = " + div.Calc(a, b));
                break;

            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}

interface ICalculator
{
    float Calc(float x, float y);
}

public class Add : ICalculator
{
    public float Calc(float x, float y)
    {
        return x + y;
    }
}

public class Sub : ICalculator
{
    public float Calc(float x, float y)
    {
        return x - y;
    }
}

public class Multi : ICalculator
{
    public float Calc(float x, float y)
    {
        return x * y;
    }
}

public class Div : ICalculator
{
    public float Calc(float x, float y)
    {
        if (y == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
        return x / y;
    }
}
