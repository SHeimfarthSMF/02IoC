namespace IoCApp;

public class MailService : IMailService
{
    public void SendMail(string message, string subject, string address)
    {
        // ReSharper disable once LocalizableElement
        Console.WriteLine($"Sending mail to {address} with subject {subject} and message {message}");
    }
}