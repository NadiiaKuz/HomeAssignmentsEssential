namespace Task1_Calculator
{
    static class Calculator
    {
        public static int Mul(int a, int b) =>
            a * b;

        public static double Div(int a, int b) =>
           (double)a / b;

        public static int Add(int a, int b) =>
            a + b;

        public static int Sub(int a, int b) =>
            a - b;

        public static string Calculate(int answer, int a, int b)
        {
            return answer switch
            {
                1 => $"a*b={Mul(a, b)}",
                2 => b != 0 ? $"a/b={Div(a, b)}" : "Can not divide by 0",
                3 => $"a+b={Add(a, b)}",
                4 => $"a-b={Sub(a, b)}",
                _ => "Unknown operation"
            };
        }
    }
}
