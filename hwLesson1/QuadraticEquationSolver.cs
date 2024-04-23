namespace hwLesson1
{
    class QuadraticEquationSolver
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public QuadraticEquationSolver(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }
        
        #region Metods
        public string GetResult()
        {
            double discriminant = CalculateDiscriminant();

            if (discriminant > 0)
            {
                double x1 = (-B + Math.Sqrt(discriminant)) / 2 * A;
                double x2 = (-B - Math.Sqrt(discriminant)) / 2 * A;
                return $"Дискримінант більше 0. Тому х1={x1} та x2={x2}";
            }

            if (discriminant == 0)
            {
                double x = -B / 2 * A;
                return $"Дискримінант дорівнює 0. Тому x={x}";
            }

            return $"Дискримінант менше 0. Значення х не існує";
        }

        private double CalculateDiscriminant() => 
            Math.Pow(B, 2) - 4 * A * C;
        #endregion
    }
}
