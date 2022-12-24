namespace Calculator.Operations
{
    public class Summation : Operation
    {
        public Summation(double x, double y) : base(x, y)
        {
        }

        public override double toResult()
        {
            return X + Y;
        }
    }
}