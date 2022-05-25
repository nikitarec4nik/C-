using System;

namespace job1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat("Falt", 15, 5);
            FlatInTheCenter flatInTheCenter = new FlatInTheCenter("Flat", 15, 5);

            Console.WriteLine($"flat: {flat}; Cost: {flat.CalculateCost()}");
            Console.WriteLine($"flatInTheCenter: {flatInTheCenter}; Cost: {flatInTheCenter.CalculateCost()}");
        }
    }
}
