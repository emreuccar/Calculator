namespace Calculator.Operations
{
    public class Fraction : Division
    {
        public Fraction(double x, double y) : base(x, y)
        {
        }

        public Fraction(double x, Operation coOperation) : base(x, coOperation)
        {

        }

        public Fraction(Operation coOperation, double y) : base(coOperation, y)
        {
        }

        public Fraction(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2)
        {
        }

        internal override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint}/{SecondParameterTextForPrint})";
        }
        internal override string printSentenceWithoutResult()
        {
            return $"{FirstParameterTextForSentence}/{SecondParameterTextForSentence}";
        }
    }
}