namespace Calculator.Operations
{
    public class Faculty : Operation
    {
        public Faculty(double x)
        {
            X = x;
            FirstParameterText = x.ToString();
        }
        public Faculty(Operation coOperation)
        {
            X = coOperation.toResult();
            FirstParameterText = coOperation.printWithoutResult();
        }

        public override double toResult()
        {
            Validate();

            return CalculateFactorial();
        }

        public override string printWithoutResult()
        {
            return $"({FirstParameterText}!)";
        }

        private void Validate()
        {
            if (X < 0)
            {
                throw new ArgumentException("There is no factorial for negative numbers!");
            }

            if (X % 1 != 0)
            {
                throw new ArgumentException("There is no factorial for fractional numbers!");
            }
        }

        private double CalculateFactorial()
        {
            int result = 1;

            for (int i = 1; i <= X; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}