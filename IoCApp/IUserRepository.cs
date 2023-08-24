namespace IoCApp;

public interface IUserRepository
{
    User? FindUser(string firstName, string secondName);
    User CreateUser(string firstName, string secondName, string email);
}