namespace Task2_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter.Rate = 30.5;

            var converter1 = new Converter(1300);
            var result1 = converter1.ConvertCurrency();
            Console.WriteLine(result1);

            var converter2 = new Converter(1500);
            var result2 = converter2.ConvertCurrency();
            Console.WriteLine(result2);

            Converter.Rate = 31.5;

            result1 = converter1.ConvertCurrency();
            Console.WriteLine(result1);

            result2 = converter2.ConvertCurrency();
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}