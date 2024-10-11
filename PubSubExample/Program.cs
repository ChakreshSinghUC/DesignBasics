using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an example to run:");
        Console.WriteLine("1: Pub-Sub Without a Broker");
        Console.WriteLine("2: Pub-Sub With a Broker");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                PubSubWithoutBroker.Run();
                break;
            case "2":
                PubSubWithBroker.Run();
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}
