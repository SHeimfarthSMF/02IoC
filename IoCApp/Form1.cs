namespace IoCApp
{
    public partial class Registration : Form
    {
        private readonly IRegistrationService _registrationService;

        public Registration(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            _registrationService.Register(firstNameTextBox.Text, secondNameTextBox.Text, eMailTextBox.Text);
        }
    }
}