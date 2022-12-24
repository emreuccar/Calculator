namespace Calculator.Operations
{
    public class Faculty : Operation
    {
        public Faculty(double x) : base(x)
        {
            X = x;
        }

        public override double toResult()
        {
            int result = 1;

            for (int i = 1; i <= X; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}