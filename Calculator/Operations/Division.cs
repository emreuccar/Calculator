namespace Calculator.Operations
{
    public class Division : Operation
    {
        public Division(double x, double y) : base(x, y) { }
        public Division(double x, Operation coOperation) : base(x, coOperation) { }
        public Division(Operation coOperation, double y) : base(coOperation, y) { }
        public Division(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2) { }

        public override double toResult()
        {
            Validate();

            return X / Y;
        }
        private void Validate()
        {
            if (Y == 0)
            {
                throw new DivideByZeroException();
            }
        }

        internal override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint} / {SecondParameterTextForPrint})";
        }

        internal override string printSentenceWithoutResult()
        {
            return $"division of {FirstParameterTextForSentence} by {SecondParameterTextForSentence}";
        }
    
    }
}