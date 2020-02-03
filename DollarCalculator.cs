namespace H1_Opgaver
{
    public class DollarCalculator : Calculator
    {
        public override string Calculate(double amount)
        {
            return "Dollar amount: " + amount * 0.15;
        }
    }
}
