namespace Calculator.Operations
{
    public abstract class Operation
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Operation CoOperation1 { get; set; }
        public Operation CoOperation2 { get; set; }

        public byte Scenario { get; set; }

        public Operation(double x, double y)
        {
            X = x;
            Y = y;
            Scenario = 1;
        }

        public Operation(double x)
        {
            X = x;
            Scenario = 2;
        }

        public Operation(double x, Operation coOperation)
        {
            X = x;
            CoOperation1 = coOperation;
            Scenario = 3;
        }

        public Operation(Operation coOperation, double y)
        {
            Y = y;
            CoOperation1 = coOperation;
            Scenario = 4;
        }

        public Operation(Operation coOperation1, Operation coOperation2)
        {
            CoOperation1 = coOperation1;
            CoOperation2 = coOperation2;
            Scenario = 5;
        }

        public Operation(Operation coOperation1)
        {
            CoOperation1 = coOperation1;
            Scenario = 6;
        }

        public abstract double toResult();
        public string print()
        {
            return printWithoutResult() + " = " + toResult();
        }
        public abstract string printWithoutResult();

    }
}