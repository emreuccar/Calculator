namespace Calculator.Operations
{
    public class Subtraction : Operation
    {
        public Subtraction(double x, double y) : base(x, y) { }
        public Subtraction(double x, Operation coOperation) : base(x, coOperation) { }
        public Subtraction(Operation coOperation, double y) : base(coOperation, y) { }
        public Subtraction(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2) { }

        public override double toResult()
        {
            return X - Y;
        }

        internal override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint} - {SecondParameterTextForPrint})";
        }

        internal override string printSentenceWithoutResult()
        {
            return $"subtraction of {FirstParameterTextForSentence} and {SecondParameterTextForSentence}";
        }
    }
}