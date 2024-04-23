namespace hwLesson4
{
    class SportCar : Car, IRecycable
    {
        public SportCar(string color, int speed, int weight) : 
            base(color, speed, weight)
        {
        }

        public override void Drive() =>
            Console.WriteLine($"The sports car is moving at a speed of {Speed} km/h");

        public void RecycleToMetal()
        {
            double metalWeight = Weight * 0.7;

            Console.WriteLine($"The amount of metal received from the sports car is {metalWeight} kg.");
        }

        public override void CarryPassengers() =>
            Console.WriteLine("The sports car carrying one passenger");

        public override void Park() =>
            Console.WriteLine("The sports car is parked in any parking lot");

        public void Drift() => Console.WriteLine($"Drift on sports car is fun");
    }
}
