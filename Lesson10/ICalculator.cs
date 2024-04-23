namespace Lesson10
{
    interface ICalculator<T>
    {
        T Add(T valueA, T valueB);

        T Sub(T valueA, T valueB);

        T Mul(T valueA, T valueB);

        T Div(T valueA, T valueB);
    }
}
