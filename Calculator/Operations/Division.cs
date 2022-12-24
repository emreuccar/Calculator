namespace Calculator.Operations
{
    public class Division : Operation
    {
        public Division(double x, double y) : base(x, y)
        {
        }

        public override double toResult()
        {
            return X / Y;
        }
    }
}