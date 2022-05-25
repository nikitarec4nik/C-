namespace job1
{
    internal class Flat
    {
        public string Name;
        public double Cost;
        public double Square;

        public Flat(string name, double cost, double square)
        {
            Name = name;
            Cost = cost;
            Square = square;
        }

        public virtual double CalculateCost()
        {
            return Cost * Square;
        }

        public override string ToString()
        {
            return $"{Name}; {Cost}; {Square}";
        }
    }
}
