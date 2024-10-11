using Microsoft.Extensions.DependencyInjection;
using System;

public interface IEmailService
{
    void SendEmail(string message);
}

public class EmailService : IEmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class Notification
{
    private readonly IEmailService _emailService;

    public Notification(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void Send(string message)
    {
        _emailService.SendEmail(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Setup Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IEmailService, EmailService>()
            .AddSingleton<Notification>()
            .BuildServiceProvider();

        // Resolve dependencies
        var notification = serviceProvider.GetService<Notification>();
        notification.Send("Hello, Dependency Injection!");
    }
}
