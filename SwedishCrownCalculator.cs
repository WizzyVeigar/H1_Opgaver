namespace H1_Opgaver
{
    public class SwedishCrownCalculator : Calculator
    {
        public override string Calculate(double amount)
        {
            return "Swedish crown amount: " + amount * 1 * .43;
        }
    }
}
