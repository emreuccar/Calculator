namespace Calculator.Operations
{
    public class Subtraction : Operation
    {
        public Subtraction(double x, double y)
        {
            X = x;
            Y = y;

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = y.ToString();
        }

        public Subtraction(double x, Operation coOperation)
        {
            X = x;
            Y = coOperation.toResult();

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = coOperation.printWithoutResult();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = coOperation.printSentenceWithoutResult();
        }

        public Subtraction(Operation coOperation, double y)
        {
            X = coOperation.toResult();
            Y = y;

            FirstParameterTextForPrint = coOperation.printWithoutResult();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = coOperation.printSentenceWithoutResult();
            SecondParameterTextForSentence = y.ToString();
        }

        public Subtraction(Operation coOperation1, Operation coOperation2)
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