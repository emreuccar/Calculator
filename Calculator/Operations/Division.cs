namespace Calculator.Operations
{
    public class Division : Operation
    {
        public Division(double x, double y) : base(x, y)
        {

        }

        public Division(double x) : base(x)
        {

        }

        public Division(double x, Operation coOperation) : base(x, coOperation)
        {
        }

        public Division(Operation coOperation, double y) : base(coOperation, y)
        {
        }

        public Division(Operation coOperation1, Operation coOperation2) : base(coOperation1, coOperation2)
        {

        }

        public override double toResult()
        {
            double firstNumber = 0;
            double secondNumber = 0;

            switch (Scenario)
            {
                case 1:
                    firstNumber = X;
                    secondNumber = Y;
                    break;
                case 3:
                    firstNumber = X;
                    secondNumber = CoOperation1.toResult();
                    break;
                case 4:
                    firstNumber = CoOperation1.toResult();
                    secondNumber = Y;
                    break;
                case 5:
                    firstNumber = CoOperation1.toResult();
                    secondNumber = CoOperation2.toResult();
                    break;
            }

            Validate(secondNumber);

            return firstNumber / secondNumber;
        }

        public override string printWithoutResult()
        {
            switch (Scenario)
            {
                case 1:
                    return $"({X} / {Y})";
                case 3:
                    return $"({X} / {CoOperation1.printWithoutResult()})";
                case 4:
                    return $"({CoOperation1.printWithoutResult()} / {Y})";
                case 5:
                    return $"({CoOperation1.printWithoutResult()} / {CoOperation2.printWithoutResult()})";
            }

            return "";
        }

        private void Validate(double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
        }
    }
}