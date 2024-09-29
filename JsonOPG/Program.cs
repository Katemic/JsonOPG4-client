using JsonOPG;
using System.Net.Sockets;
using System.Text.Json;

Console.WriteLine("This is the TCP Client");

bool keepSending = true;

TcpClient socket = new TcpClient("127.0.0.1", 7);


NetworkStream ns = socket.GetStream();
StreamReader reader = new StreamReader(ns);
StreamWriter writer = new StreamWriter(ns);

while (keepSending)
{

    Console.WriteLine("Pick a method");
    string message = Console.ReadLine();
    if (message.ToLower() == "stop")
    {
        writer.WriteLine(message);
        keepSending = false;
    }
    else
    {
        Console.WriteLine("Enter number 1");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Command command = new Command(message, number1, number2);

        string jsonMessage = JsonSerializer.Serialize(command);

        writer.WriteLine(jsonMessage);
    }



    writer.Flush();

    string response = reader.ReadLine();



    Console.WriteLine("Server respons: " + response);

    if (message.ToLower() == "stop")
    {
        keepSending = false;
    }


}