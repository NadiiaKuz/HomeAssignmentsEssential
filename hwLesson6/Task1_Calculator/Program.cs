namespace Task1_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input A:");
                int a = Int32.Parse(Console.ReadLine());

                Console.Write("Input B:");
                int b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("1-Mul, 2-Div, 3-Add, 4-Sub");

                Console.Write("Make your choice:");
                byte answer = Byte.Parse(Console.ReadLine());

                Console.WriteLine(Calculator.Calculate(answer, a, b));
            }
        }
    }
}