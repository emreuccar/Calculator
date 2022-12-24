namespace Calculator.Operations
{
    public class Fraction : Division
    {
        public Fraction(double x, double y) : base(x, y)
        {
        }

        public override string print()
        {
            return $"({X} / {Y})";
        }
    }
}