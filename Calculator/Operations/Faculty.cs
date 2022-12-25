namespace Calculator.Operations
{
    public class Faculty : Operation
    {
        public Faculty(double x)
        {
            X = x;
            FirstParameterTextForPrint = x.ToString();
            FirstParameterTextForSentence = x.ToString();
        }
        public Faculty(Operation coOperation)
        {
            X = coOperation.toResult();
            FirstParameterTextForPrint = coOperation.printWithoutResult();
            FirstParameterTextForSentence = coOperation.printSentenceWithoutResult();
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

        public override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint}!)";
        }

        public override string printSentenceWithoutResult()
        {
            return $"faculty of {FirstParameterTextForSentence}";
        }
    }
}