# Publisher-Subscriber Model in C#

This project demonstrates the **Publisher-Subscriber (Pub-Sub) model** using two examples:
1. **Pub-Sub without a broker** – Direct communication between the publisher and subscribers.
2. **Pub-Sub with a broker** – Communication between the publisher and subscribers is mediated by an event broker.

## What is Pub-Sub?

The **Publisher-Subscriber model** is a messaging pattern where the publisher sends messages (or events) to subscribers. This decouples the publisher from the subscribers, meaning that the publisher doesn't need to know who is receiving the message.

### Pub-Sub Without a Broker

In this example, the publisher directly notifies all the subscribers when a message is published.

### Pub-Sub With a Broker

In this example, an event broker (or event bus) acts as an intermediary between the publisher and subscribers. The broker handles message distribution based on event topics.

## Project Structure

- **PubSubWithoutBroker.cs**: Contains the code for the Pub-Sub model without a broker.
- **PubSubWithBroker.cs**: Contains the code for the Pub-Sub model with a broker.
- **Program.cs**: The main entry point where the user can select which example to run.

## How to Run the Project

### Prerequisites

To run this project, you'll need:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 7.0 or later)

### Running the Project

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/yourusername/PubSubExample.git
    cd PubSubExample
    ```

2. Build the project:

    ```bash
    dotnet build
    ```

3. Run the project:

    ```bash
    dotnet run
    ```

4. Select the example to run:

    - Enter **1** to run the Pub-Sub model without a broker.
    - Enter **2** to run the Pub-Sub model with a broker.

### Example Output

- **Option 1: Pub-Sub without a broker**

    ```plaintext
    Publisher: Sending message to all subscribers...
    Subscriber 1 received message: Hello Subscribers!
    Subscriber 2 received message: Hello Subscribers!
    ```

- **Option 2: Pub-Sub with a broker**

    ```plaintext
    Subscriber 1 received: Breaking News: Market hits all-time high!
    Subscriber 2 received: Sports Update: Local team wins championship!
    ```

## How it Works

### Pub-Sub Without a Broker
In this implementation:
- The **publisher** maintains a list of **subscribers**.
- When the publisher sends a message, it directly notifies all the subscribers by calling their `Receive` method.

### Pub-Sub With a Broker
In this implementation:
- The **event broker** holds a list of event topics and associated subscribers.
- The **publisher** sends messages to the broker, and the broker forwards the messages to subscribers of the relevant topics.

## Contributing

If you'd like to contribute to this project, feel free to fork the repository, make changes, and submit a pull request. Feedback and suggestions are welcome!

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
