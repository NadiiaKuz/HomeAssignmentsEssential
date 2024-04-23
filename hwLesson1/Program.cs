using System.Text;

namespace hwLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            Console.Write("Input a value: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input b value: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input c value: ");
            double c = Convert.ToDouble(Console.ReadLine());

            var solver = new QuadraticEquationSolver(a, b, c);

            Console.WriteLine(solver.GetResult());
        }
    }
}