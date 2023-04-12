using MoviesRental.DataBase;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Infra.SQL.EmployeeModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesRental.WindowsApp.Features.AccountModule
{
    public partial class NewAccessAccountScreen : UserControl
    {
        public EmployeeSQL employeeSQL;

        public List<Employee> employees;

        public NewAccessAccountScreen()
        {
            InitializeComponent();
            EnterButton.Enabled = false;
            employeeSQL = new EmployeeSQL();
            employees = new List<Employee>();
        }

        #region CodeMethods

        private void VerifyTextsToAbleEnterButton()
        {
            if (TextEmail.Text.Length >= 0 && TextPassword.Text.Length >= 0 && TextPassword.Text.Length >= 0 || AccessKeyText.Text.Length >= 0)
            {
                EnterButton.Enabled = true;
            }
            else
            {
                EnterButton.Enabled = false;
            }
        }

        #endregion

        #region ButtonsClick

        private void EnterButton_Click(object sender, EventArgs e)
        {
            employees = employeeSQL.SelectAll();

            foreach (var item in employees)
            {
                if (item.Email == TextEmail.Text && item.Password == TextPassword.Text || item.AccessKey == AccessKeyText.Text)
                {
                    MainForm.instance.ShowMenuStripOptions();
                    AccountForm.instance.CloseForm();
                    CurrentAccount.EmployeeName = item.Name;
                    MainForm.instance.ChangeAccountName();
                    MainForm.instance.ShowAccountDashboard();
                    return;
                }
                else
                {
                    AccessStatus.Text = "The account cannot be connected because there is a wrong register";
                }                    
            }
        }

        #endregion

        #region LeaveEvents

        private void TextEmail_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void AccessKeyText_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        #endregion

        private void ForgottenPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TextEmail.Text == string.Empty)
                AccessStatus.Text = "Input the email to retrieve your password and access key";
            else
            {
                Employee employee = MainForm.instance.GetEmployee(TextEmail.Text);

                if (employee != null)
                {
                    new EmailConnection().SendEmailOnline(employee.Email, employee.Name, employee.AccessKey + $" and your password: {employee.Password}");

                    MessageBox.Show($"Mail sent to {TextEmail.Text} with your password and access key");
                }
                else
                    AccessStatus.Text = "This account doesn't exist, try again";
            }
        }
    }
}
