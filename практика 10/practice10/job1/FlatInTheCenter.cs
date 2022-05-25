namespace job1
{
    internal class FlatInTheCenter : Flat
    {
        private const double Coeff = 0.01;

        public FlatInTheCenter(string name, double cost, double square) :
            base(name, cost, square)
        {
        }

        public override double CalculateCost()
        {
            double baseCost = base.CalculateCost();
            return baseCost + baseCost * Coeff;
        }
    }
}
