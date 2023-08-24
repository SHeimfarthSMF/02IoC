namespace IoCApp
{
    public partial class Registration : Form
    {
        private readonly RegistrationService _registrationService;

        public Registration(RegistrationService registrationService)
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