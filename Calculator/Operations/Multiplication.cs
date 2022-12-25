namespace Calculator.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(double x, double y) : base(x, y)
        {

        }

        public Multiplication(double x) : base(x)
        {

        }

        public Multiplication(double x, Operation coOperation) : base(x, coOperation)
        {
        }

        public Multiplication(Operation coOperation, double y) : base(coOperation, y)
        {
        }

        public Multiplication(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2)
        {

        }

        public override double toResult()
        {
            switch (Scenario)
            {
                case 1:
                    return X * Y;
                case 3:
                    return X * CoOperation1.toResult();
                case 4:
                    return CoOperation1.toResult() * Y;
                case 5:
                    return CoOperation1.toResult() * CoOperation2.toResult();
            }

            return 0;
        }

        public override string printWithoutResult()
        {
            switch (Scenario)
            {
                case 1:
                    return $"({X} * {Y})";
                case 3:
                    return $"({X} * {CoOperation1.printWithoutResult()})";
                case 4:
                    return $"({CoOperation1.printWithoutResult()} * {Y})";
                case 5:
                    return $"({CoOperation1.printWithoutResult()} * {CoOperation2.printWithoutResult()})";
            }

            return "";
        }
    }
}