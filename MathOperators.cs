namespace problems
{
    internal class MathOperators
    {
        Func<int, int, int> add = (a, b) => a + b;
        Func<int, int, int> subtract = (a, b) => a - b;
        Func<int, int, int> multiply = (a, b) => a * b;
        Func<int, int, int> divide = (a, b) =>
            {
                if (b == 0) throw
                    new ArgumentException();
                return a / b;
            };
    }
}
