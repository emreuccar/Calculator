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