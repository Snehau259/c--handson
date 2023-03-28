public class whatsapp : IChatSystem
{
    public void receiveMessage()
    {
        Console.WriteLine("Receiving whatsapp messsage");
    }

    public void sendMessage()
    {
        Console.WriteLine("Sending whatsapp message");
    }
}