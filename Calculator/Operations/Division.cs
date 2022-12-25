namespace Calculator.Operations
{
    public class Division : Operation
    {
        public Division(double x, double y)
        {
            X = x;
            Y = y;

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = y.ToString();
        }

        public Division(double x, Operation coOperation)
        {
            X = x;
            Y = coOperation.toResult();

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = coOperation.printWithoutResult();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = coOperation.printSentenceWithoutResult();
        }

        public Division(Operation coOperation, double y)
        {
            X = coOperation.toResult();
            Y = y;

            FirstParameterTextForPrint = coOperation.printWithoutResult();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = coOperation.printSentenceWithoutResult();
            SecondParameterTextForSentence = y.ToString();
        }

        public Division(Operation coOperation1, Operation coOperation2)
        {
            X = coOperation1.toResult();
            Y = coOperation2.toResult();

            FirstParameterTextForPrint = coOperation1.printWithoutResult();
            SecondParameterTextForPrint = coOperation2.printWithoutResult();

            FirstParameterTextForSentence = coOperation1.printSentenceWithoutResult();
            SecondParameterTextForSentence = coOperation2.printSentenceWithoutResult();
        }

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