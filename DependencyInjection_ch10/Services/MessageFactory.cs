namespace DependencyInjection_ch10.Services
{
    public class MessageFactory
    {
        public Email Create(string emailAddress)
        {
            return new Email
            {
                Address = emailAddress,
                Message = "От души за регистрацию брат!"
            };
        }
        
    }
}
