namespace Calculator.Operations
{
    public class Division : Operation
    {
        public Division(double x, double y) : base(x, y)
        {
        }

        public override double toResult()
        {
            Validate();

            return X / Y;
        }

        public override string print()
        {
            return $"({X} / {Y}) = {toResult()}";
        }

        private void Validate()
        {
            if (Y == 0)
            {
                throw new DivideByZeroException();
            }
        }
    }
}