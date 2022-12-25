namespace Calculator.Operations
{
    public abstract class Operation
    {
        protected double X { get; set; }
        protected double Y { get; set; }
        protected string FirstParameterTextForPrint { get; set; }
        protected string SecondParameterTextForPrint { get; set; }
        protected string FirstParameterTextForSentence { get; set; }
        protected string SecondParameterTextForSentence { get; set; }

        public Operation(double x, double y)
        {
            X = x;
            Y = y;

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = y.ToString();
        }

        public Operation(double x, Operation coOperation)
        {
            X = x;
            Y = coOperation.toResult();

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = coOperation.printWithoutResult();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = coOperation.printSentenceWithoutResult();
        }

        public Operation(Operation coOperation, double y)
        {
            X = coOperation.toResult();
            Y = y;

            FirstParameterTextForPrint = coOperation.printWithoutResult();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = coOperation.printSentenceWithoutResult();
            SecondParameterTextForSentence = y.ToString();
        }

        public Operation(Operation coOperation1, Operation coOperation2)
        {
            X = coOperation1.toResult();
            Y = coOperation2.toResult();

            FirstParameterTextForPrint = coOperation1.printWithoutResult();
            SecondParameterTextForPrint = coOperation2.printWithoutResult();

            FirstParameterTextForSentence = coOperation1.printSentenceWithoutResult();
            SecondParameterTextForSentence = coOperation2.printSentenceWithoutResult();
        }

        public Operation(double x)
        {
            X = x;
            FirstParameterTextForPrint = x.ToString();
            FirstParameterTextForSentence = x.ToString();
        }
        public Operation(Operation coOperation)
        {
            X = coOperation.toResult();
            FirstParameterTextForPrint = coOperation.printWithoutResult();
            FirstParameterTextForSentence = coOperation.printSentenceWithoutResult();
        }

        public abstract double toResult();
        public string print()
        {
            return printWithoutResult() + " = " + toResult();
        }

        public string printSentence()
        {
            return printSentenceWithoutResult() + " is " + toResult();
        }
        internal abstract string printWithoutResult();
        internal abstract string printSentenceWithoutResult();
      
    }
}