namespace Calculator.Operations
{
    public class Faculty : Operation
    {
        public Faculty(double x) : base(x) { }
        public Faculty(Operation coOperation) : base(coOperation) { }

        public override double toResult()
        {
            Validate();

            return CalculateFactorial();
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

        internal override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint}!)";
        }

        internal override string printSentenceWithoutResult()
        {
            return $"faculty of {FirstParameterTextForSentence}";
        }
    }
}