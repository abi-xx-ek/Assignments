namespace Maths.Operations_
{
    public class ArithmeticOperation
    {
        public double add(double a, double b)
        {
            return a + b;
        }
        public double sub(double a, double b)
        {
            return a - b;
        }
    }
    public class RelationalOperation
    {
        public bool greaterthan(double a, double b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool equal(double a, double b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
