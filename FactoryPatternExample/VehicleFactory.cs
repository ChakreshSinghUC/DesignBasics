using System;
public static class VehicleFactory
{
    public static IVehicle GetVehicle(string vehicleType)
    {
        switch (vehicleType.ToLower())
        {
            case "car":
                return new Car();
            case "bike":
                return new Bike();
            case "truck":
                return new Truck();
            default:
                throw new ArgumentException("Invalid vehicle type");
        }
    }
}
