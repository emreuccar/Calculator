namespace Calculator.Operations
{
    public class Faculty : Operation
    {
        public Faculty(int x) : base(x)
        {
            
        }

        public override double toResult()
        {
            Validate();

            return CalculateFactorial();
        }

        private void Validate()
        {
            if (X < 0)
            {
                throw new ArgumentException("Factorials don't exist for negative numbers!");
            }
        }

        private double CalculateFactorial()
        {
            int result = 1;

            for (int i = 1; i <= X; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}