namespace Calculator.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(double x, double y) : base(x, y) { }
        public Multiplication(double x, Operation coOperation) : base(x, coOperation) { }
        public Multiplication(Operation coOperation, double y) : base(coOperation, y) { }
        public Multiplication(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2) { }

        public override double toResult()
        {
            return X * Y;
        }

        internal override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint} * {SecondParameterTextForPrint})";
        }

        internal override string printSentenceWithoutResult()
        {
            return $"multiplication of {FirstParameterTextForSentence} and {SecondParameterTextForSentence}";
        }
    }
}