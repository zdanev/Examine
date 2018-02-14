using System;

namespace Examine.Core.Components
{
    public class Arithmetics
    { 
        public enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public static int Calc(int a, int b, Operator o)
        {
            switch (o)
            {
                case Operator.Add:
                    return a + b;
                case Operator.Subtract:
                    return a - b;
                case Operator.Multiply:
                    return a * b;
                case Operator.Divide:
                    return a / b;
                default:
                    throw new InvalidOperationException();
            }
        }

        public static string Expr(int a, int b, Operator o)
        {
            switch (o)
            {
                case Operator.Add:
                    return $"{a} + {b} = ";
                case Operator.Subtract:
                    return $"{a} - {b} = ";
                case Operator.Multiply:
                    return $"{a} * {b} = ";
                case Operator.Divide:
                    return $"{a} / {b} = ";
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}