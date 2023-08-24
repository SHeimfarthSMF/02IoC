namespace IoCApp;

public class UserRepository : IUserRepository
{
    private readonly IDataBaseConnection _dataBaseConnection;

    public UserRepository(IDataBaseConnection dataBaseConnection)
    {
        _dataBaseConnection = dataBaseConnection;
    }

    public User? FindUser(string firstName, string secondName)
    {
        if(firstName=="John" && secondName=="Smith")
        {
            return new User
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                SecondName = "Smith",
                Email = ""
            };
        }

        return null;    
    }

    public User CreateUser(string firstName, string secondName, string email)
    {

        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            SecondName = secondName,
            Email = email
        };

        _dataBaseConnection.Save(user);

        return user;
    }
}