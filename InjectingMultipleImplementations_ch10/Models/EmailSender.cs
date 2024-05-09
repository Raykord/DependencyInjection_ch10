namespace InjectingMultipleImplementations_ch10.Models
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Email message: {message}");
        }
    }
}
