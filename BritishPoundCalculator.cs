namespace H1_Opgaver
{
    public class BritishPoundCalculator : Calculator
    {
        public override string Calculate(double amount)
        {
            return "Pound amount: " + amount * 0.11;
        }
    }
}
