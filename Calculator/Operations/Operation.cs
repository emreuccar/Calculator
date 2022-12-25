namespace Calculator.Operations
{
    public abstract class Operation
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string FirstParameterTextForPrint { get; set; }
        public string SecondParameterTextForPrint { get; set; }
        public string FirstParameterTextForSentence { get; set; }
        public string SecondParameterTextForSentence { get; set; }
        public abstract double toResult();
        public string print()
        {
            return printWithoutResult() + " = " + toResult();
        }
        public abstract string printWithoutResult();
        public abstract string printSentenceWithoutResult();
        public string printSentence()
        {
            return printSentenceWithoutResult() + " is " + toResult();
        }
    }
}