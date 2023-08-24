namespace IoCApp
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;

        public RegistrationService(IUserRepository userRepository, IMailService mailService)
        {
            _userRepository = userRepository;
            _mailService = mailService;
        }

        public void Register(string firstName, string secondName, string email)
        {
            if (firstName == null) throw new ArgumentNullException(nameof(firstName));
            if (secondName == null) throw new ArgumentNullException(nameof(secondName));
            if (email == null) throw new ArgumentNullException(nameof(email));

            var user = _userRepository.FindUser(firstName, secondName);

            if (user is null)
            {
                user = _userRepository.CreateUser(firstName, secondName, email);
                _mailService.SendMail("Welcome to our service", "Welcome", user.Email!);
            }
            else
            {
                _mailService.SendMail("Welcome back", "Welcome", user.Email!);
            }
        }
    }
}
