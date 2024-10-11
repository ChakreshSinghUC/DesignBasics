# Factory Pattern Example

This is a simple C# project that demonstrates the **Factory Design Pattern**. The Factory Pattern is a creational design pattern used to abstract the process of object creation, allowing subclasses or a factory class to decide which object to instantiate.

In this project, we simulate a **Vehicle Factory**, which can create different types of vehicles (such as cars, bikes, and trucks) based on input from the user. The goal is to decouple the client code from the specific implementations of these vehicles, allowing easy addition of new vehicle types.

## Features
- **Factory Design Pattern**: Learn how to implement a factory that can create objects based on user input.
- **Decoupling**: The main program does not need to know the specific classes (`Car`, `Bike`, `Truck`), it only works with the `IVehicle` interface.
- **Scalable**: You can easily add new vehicle types without modifying much of the existing code.

## Technologies Used
- **.NET 7.0**
- **C#**

## Project Structure
- **IVehicle Interface**: Defines the common behavior for all vehicle types (e.g., `Drive()`).
- **Concrete Classes**: Implements the `IVehicle` interface (e.g., `Car`, `Bike`, `Truck`).
- **VehicleFactory**: A static factory class that creates instances of `IVehicle` based on user input.

## Factory Pattern Overview

The **Factory Design Pattern** is used to create objects without specifying the exact class of the object that will be created. Instead, we use a factory class to handle the object creation logic, providing more flexibility and making the code easier to maintain.

### Example:
In this project, the `VehicleFactory` decides which vehicle to create based on the input provided by the user (e.g., "car", "bike", or "truck").

```csharp
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
