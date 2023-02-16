using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Infra.SQL.EmployeeModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    public partial class EmployeeForm : Form
    {
        EmailConnection emailConnection;

        EmployeeSQL employeeSQL;

        List<Employee> employees = new List<Employee>();

        public EmployeeForm()
        {
            InitializeComponent();
            EnterButtonEmployee.Enabled = false;
            emailConnection = new EmailConnection();
            employeeSQL = new EmployeeSQL();
        }

        //Should build the properties using the domain class of form.

        private Employee employee;

        public Employee Employee
        {
            get { return employee; }
            set
            {
                employee = value;

                TextEmail.Text = employee.Email;
                TextEmployeeName.Text = employee.Name;
                TextPassword.Text = employee.Password;
            }
        }

        #region CodeMethods

        private void VerifyTextsToAbleEnterButton()
        {
            if (TextEmail.Text.Length >= 1 && TextEmployeeName.Text.Length >= 1 && TextPassword.Text.Length >= 1 && EmployeeStatusText.Text == "The email format is correct")
            {
                EnterButtonEmployee.Enabled = true;
            }
        }

        private string VerifyIfAlreadyExistAccessKey()
        {
            employees = employeeSQL.SelectAll();

            foreach (var item in employees)
            {
                if (item.Name == TextEmployeeName.Text)
                    return item.AccessKey;
            }

            return GenerateRandomAccessKey();
        }

        private void EmailValidation(string email, string name, string accessKey)
        {
            employees = employeeSQL.SelectAll();

            foreach (var item in employees)
            {
                if (item.Email == TextEmail.Text)
                {
                    return;
                }
            }

            if (emailConnection.isConnected())
                emailConnection.SendEmailOnline(email, name, accessKey);
            else
                emailConnection.SendEmailOffline(email, name, accessKey);
        }

        private string GenerateRandomAccessKey()
        {
            char[] letters = "AHFJNVOIYERDJWSF".ToCharArray();
            Random random = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[random.Next(0, 16)].ToString();
            }

            return randomString;
        }

        #endregion

        #region ButtonsClick

        private void EnterButtonEmployee_Click(object sender, EventArgs e)
        {
            string email = TextEmail.Text;

            string name = TextEmployeeName.Text;

            string password = TextPassword.Text;

            string accessKey = VerifyIfAlreadyExistAccessKey();

            Employee = new Employee(email, name, password, accessKey);

            EmailValidation(email, name, accessKey);
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            if (TextPassword.PasswordChar == '*')
            {
                TextPassword.PasswordChar = '\0';
            }
            else
            {
                TextPassword.PasswordChar = '*';
            }
        }

        #endregion

        #region LeaveEvents

        private void TextEmail_Leave(object sender, EventArgs e)
        {

            bool EmailValidation = emailConnection.EmailFormatValidation(TextEmail.Text);

            if (EmailValidation == true)
                EmployeeStatusText.Text = "The email format is correct";

            if (EmailValidation == false)
                EmployeeStatusText.Text = "The email fomat is incorrect";

            VerifyTextsToAbleEnterButton();
        }

        private void TextEmployeeName_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        #endregion
    }
}
