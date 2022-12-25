﻿namespace Calculator.Operations
{
    public class Summation : Operation
    {
        public Summation(double x, double y)
        {
            X = x;
            Y = y;

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = y.ToString();
        }

        public Summation(double x, Operation coOperation)
        {
            X = x;
            Y = coOperation.toResult();

            FirstParameterTextForPrint = x.ToString();
            SecondParameterTextForPrint = coOperation.printWithoutResult();

            FirstParameterTextForSentence = x.ToString();
            SecondParameterTextForSentence = coOperation.printSentenceWithoutResult();
        }

        public Summation(Operation coOperation, double y)
        {
            X = coOperation.toResult();
            Y = y;

            FirstParameterTextForPrint = coOperation.printWithoutResult();
            SecondParameterTextForPrint = y.ToString();

            FirstParameterTextForSentence = coOperation.printWithoutResult();
            SecondParameterTextForSentence = y.ToString();
        }

        public Summation(Operation coOperation1, Operation coOperation2)
        {
            X = coOperation1.toResult();
            Y = coOperation2.toResult();

            FirstParameterTextForPrint = coOperation1.printWithoutResult();
            SecondParameterTextForPrint = coOperation2.printWithoutResult();

            FirstParameterTextForSentence = coOperation1.printWithoutResult();
            SecondParameterTextForSentence = coOperation2.printWithoutResult();
        }

        public override double toResult()
        {
            return X + Y;
        }

        public override string printWithoutResult()
        {
            return $"({FirstParameterTextForPrint} + {SecondParameterTextForPrint})";
        }

        public override string printSentenceWithoutResult()
        {
            return $"sum of {FirstParameterTextForSentence} and {SecondParameterTextForSentence}";
        }
    }
}