namespace InjectingMultipleImplementations_ch10.Models
{
    public class UnregisteredSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            throw new Exception("I'm never registered so shouldn't be called");
        }
    }
}
