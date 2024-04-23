namespace hwLesson4
{
    class Truck : Car, IRecycable
    {
        public Truck(string color, int speed, int weight)
            : base(color, speed, weight)
        {
        }

        public override void Drive() =>
            Console.WriteLine($"The truck is moving at a speed of {Speed} km/h");

        public void CarryCargo() =>
            Console.WriteLine($"The truck is carrying a large amount of cargo");

        public override void CarryPassengers() =>
            Console.WriteLine("The truck does not carry passengers");

        public override void Park() =>
            Console.WriteLine("The truck is parked in a special parking lot");

        public void RecycleToMetal()
        {
            double metalWeight = Weight * 0.7;

            Console.WriteLine($"The amount of metal received from the truck is {metalWeight} kg.");
        }
    }
}
