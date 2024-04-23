namespace Task2_Converter
{
    class Converter
    {
        public static double Rate { get; set; }

        public double Amount { get; set; }

        public Converter(double amount)
        {
            Amount = amount;
        }

        public double ConvertCurrency() =>
            Amount * Rate;
    }
}
