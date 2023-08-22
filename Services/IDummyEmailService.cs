namespace HangfireDemo.Services
{
    public interface IDummyEmailService
    {
        void SendEmail(string backGroundJobType, string startTime);
    }
}
