namespace DependencyInjection_ch10.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly NetworkClient _client; 
        private readonly MessageFactory _factory;

        public EmailSender(NetworkClient client, MessageFactory factory)
        {
            _client = client;
            _factory = factory;
        }

        public void SendEmail(string username)
        {
            var email = _factory.Create(username);
            _client.SendEmail(email);
            Console.WriteLine($"Email sent to {username}");
        }

    }
}
