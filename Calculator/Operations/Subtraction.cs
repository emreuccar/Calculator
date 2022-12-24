namespace Calculator.Operations
{
    public class Subtraction : Operation
    {
        public Subtraction(double x, double y) : base(x, y)
        {
        }

        public override double toResult()
        {
            return X - Y;
        }
    }
}