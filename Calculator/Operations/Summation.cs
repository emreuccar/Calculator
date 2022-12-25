namespace Calculator.Operations
{
    public class Summation : Operation
    {
        public Summation(double x, double y) : base(x, y) { }
        public Summation(double x, Operation coOperation) : base(x, coOperation) { }
        public Summation(Operation coOperation, double y) : base(coOperation, y) { }
        public Summation(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2) { }

        public override double toResult()
        {
            return X + Y;
        }

        internal override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint} + {SecondParameterTextForPrint})";
        }

        internal override string printSentenceWithoutResult()
        {
            return $"sum of {FirstParameterTextForSentence} and {SecondParameterTextForSentence}";
        }
    }
}