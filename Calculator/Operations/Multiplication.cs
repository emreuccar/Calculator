namespace Calculator.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(double x, double y)
        {
            X = x;
            Y = y;
            FirstParameterText = x.ToString();
            SecondParameterText = y.ToString();
        }

        public Multiplication(double x, Operation coOperation)
        {
            X = x;
            Y = coOperation.toResult();
            FirstParameterText = x.ToString();
            SecondParameterText = coOperation.printWithoutResult();
        }

        public Multiplication(Operation coOperation, double y)
        {
            X = coOperation.toResult();
            Y = y;
            FirstParameterText = coOperation.printWithoutResult();
            SecondParameterText = y.ToString();
        }

        public Multiplication(Operation coOperation1, Operation coOperation2)
        {
            X = coOperation1.toResult();
            Y = coOperation2.toResult();
            FirstParameterText = coOperation1.printWithoutResult();
            SecondParameterText = coOperation2.printWithoutResult();
        }

        public override double toResult()
        {
            return X * Y;
        }

        public override string printWithoutResult()
        {
            return $"({FirstParameterText} * {SecondParameterText})";
        }
    }
}