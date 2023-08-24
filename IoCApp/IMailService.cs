namespace IoCApp;

public interface IMailService
{
    void SendMail(string message, string subject, string address);
}