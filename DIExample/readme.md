# DIExample

This is a basic example of using **Dependency Injection (DI)** in a C# .NET project. The purpose of this project is to demonstrate how DI can be used to decouple the creation of dependencies from the business logic, making the code more flexible and easier to maintain.

## Technologies Used
- **.NET Core**
- **Microsoft.Extensions.DependencyInjection**

## Project Structure

The project consists of the following key parts:
1. **IEmailService**: An interface that defines the contract for sending emails.
2. **EmailService**: A concrete implementation of `IEmailService` that sends emails.
3. **Notification**: A class that depends on `IEmailService` to send notifications.
4. **Dependency Injection (DI)**: DI is used to inject the `EmailService` into `Notification` to decouple their dependencies.

## Getting Started

### Prerequisites

To run this project, you need to have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (make sure it is added to your PATH)
- A C# editor such as Visual Studio Code (VS Code) or Visual Studio

### Installing Dependencies

The project relies on **Microsoft.Extensions.DependencyInjection** for handling dependency injection. To install this package, run the following command in the project directory:

```bash
dotnet add package Microsoft.Extensions.DependencyInjection
