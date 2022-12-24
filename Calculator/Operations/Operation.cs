namespace Calculator.Operations
{
    public abstract class Operation
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Operation(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Operation(int x)
        {
            X = x;
        }

        public abstract double toResult();
        public abstract string print();
    }
}