using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of vehicle you want (car, bike, truck):");
        string vehicleType = Console.ReadLine();

        try
        {
            // Use the factory to get the desired vehicle
            IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
            vehicle.Drive();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
