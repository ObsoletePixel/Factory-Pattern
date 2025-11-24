namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            int wheelNumber =  int.Parse(Console.ReadLine());
            
            IVehicle vehicle = VehicleFactory.BuildVehicle(wheelNumber);
            vehicle.Drive();
        }
    }
}
