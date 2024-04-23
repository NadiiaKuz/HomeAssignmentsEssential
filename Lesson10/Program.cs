namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input A:");
                double a = Double.Parse(Console.ReadLine());

                Console.Write("Input B:");
                double b = Double.Parse(Console.ReadLine());

                Console.Write("Input the sign of the math operation: ");
                char operation = Char.Parse(Console.ReadLine());

                if (operation == '/' && b == 0)
                {
                    Console.WriteLine("Divided by 0");
                    continue;
                }

                CalculatorDouble calculatorDouble = new CalculatorDouble();

                double result = operation switch
                {
                    '+' => calculatorDouble.Add(a, b),
                    '-' => calculatorDouble.Sub(a, b),
                    '*' => calculatorDouble.Mul(a, b),
                    '/' => calculatorDouble.Div(a, b),
                };

                Console.WriteLine($"{a} {operation} {b} = {result}");
            }
        }
    }
}