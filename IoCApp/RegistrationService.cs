using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCApp
{
    public class RegistrationService
    {
        public void Register(string firstName, string secondName, string email)
        {
            if (firstName == null) throw new ArgumentNullException(nameof(firstName));
            if (secondName == null) throw new ArgumentNullException(nameof(secondName));
            if (email == null) throw new ArgumentNullException(nameof(email));

            var userRepository = new UserRepository(new DataBaseConnection("Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;Integrated Security=yes;"));
            var mailService = new MailService();

            var user = userRepository.FindUser(firstName, secondName);

            if (user is null)
            {
                user = userRepository.CreateUser(firstName, secondName, email);
                mailService.SendMail("Welcome to our service", "Welcome", user.Email!);
            }
            else
            {
                mailService.SendMail("Welcome back", "Welcome", user.Email!);
            }
        }
    }

    public class MailService
    {
        public void SendMail(string message, string subject, string address)
        {
            // ReSharper disable once LocalizableElement
            Console.WriteLine($"Sending mail to {address} with subject {subject} and message {message}");
        }
    }

    public class DataBaseConnection
    {
        public DataBaseConnection(string connectionString)
        {
             
        }

        public void Save(User user)
        {
            // dummy implementation
        }
    }

    public class UserRepository
    {
        private readonly DataBaseConnection _dataBaseConnection;

        public UserRepository(DataBaseConnection dataBaseConnection)
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
}
