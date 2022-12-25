namespace Calculator.Operations
{
    public class Faculty : Operation
    {
        public Faculty(double x) : base(x)
        {
            
        }
        public Faculty(Operation coOperation) : base(coOperation)
        {

        }

        public override double toResult()
        {
            double theNumber = 1;

            switch (Scenario)
            {
                case 2:
                    theNumber = X;
                    break;
                case 6:
                    theNumber = CoOperation1.toResult();
                    break;
            }

            Validate(theNumber);

            return CalculateFactorial(theNumber);
        }

        public override string printWithoutResult()
        {
            switch (Scenario)
            {
                case 2:
                    return $"({X}!)";
                case 6:
                    return $"({CoOperation1.printWithoutResult()}!)";
            }

            return "";
        }

        private void Validate(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("There is no factorial for negative numbers!");
            }

            if (x % 1 != 0)
            {
                throw new ArgumentException("There is no factorial for fractional numbers!");
            }
        }

        private double CalculateFactorial(double x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}