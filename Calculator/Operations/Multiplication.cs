namespace Calculator.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(double x, double y) : base(x, y)
        {
        }

        public override double toResult()
        {
            return X * Y;
        }
    }
}