namespace hwLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sportCar = new SportCar("red", 350, 800);
            sportCar.GetInfo();
            sportCar.Drive();
            sportCar.Drift();
            sportCar.CarryPassengers();
            sportCar.Park();
            sportCar.RecycleToMetal();

            string line = new string('-', Console.WindowWidth);
            Console.WriteLine(line);

            var truck = new Truck("white", 200, 1500);
            truck.GetInfo();
            truck.Drive();
            truck.CarryCargo();
            truck.CarryPassengers();
            truck.Park();
            truck.RecycleToMetal();
        }
    }
}