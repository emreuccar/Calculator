namespace Calculator.Operations
{
    public abstract class Operation
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string FirstParameterText { get; set; }
        public string SecondParameterText { get; set; }
        public abstract double toResult();
        public string print()
        {
            return printWithoutResult() + " = " + toResult();
        }
        public abstract string printWithoutResult();

    }
}