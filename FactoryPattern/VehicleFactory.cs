namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle BuildVehicle(int wheelCount)
    {
        switch (wheelCount)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            default:
                return new Car();
        }
    }
}