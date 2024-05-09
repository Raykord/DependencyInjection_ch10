namespace InjectingMultipleImplementations_ch10.Models
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
