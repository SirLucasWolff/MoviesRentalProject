using MoviesRental.Domain.ClientModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesRental.WindowsApp.Features.ClientModule
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            EnterButton.Enabled = false;
        }

        //Should build the properties using the domain class of form.

        private Client client;
        
        public Client Client
        {
            get { return client; }
            set
            {
                client = value;

                TextName.Text = client.ClientName;
                TextTelephone.Text = client.Telephone.ToString();
                TextAddress.Text = client.Address;
                AgeDatePicker.Text = client.BornDate.ToString();
            }
        }

        #region CodeMethods

        private void VerifyTextsToAbleEnterButton()
        {
            try
            {
                if (TextName.Text.Length >= 1 && TextTelephone.Text.Length >= 1 && TextAddress.Text.Length >= 1 && GetTotalYears() > 10)
                {
                    EnterButton.Enabled = true;
                }
                else
                {
                    EnterButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {}
        }

        public int GetTotalYears()
        {
            int age = 0;

            try
            {
                DateTime Byrthday = Convert.ToDateTime(AgeDatePicker.Text);
                DateTime Today = DateTime.Now;

                age = Today.Year - Byrthday.Year;

                if (Byrthday > Today.AddYears(-age))
                    age--;

            }
            catch (Exception ex) { }

            return age;
        }

        #endregion

        #region ButtonsClick

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string name = TextName.Text;

            int telephone = Convert.ToInt32(TextTelephone.Text);

            string address = TextAddress.Text;

            DateTime bornDate = Convert.ToDateTime(AgeDatePicker.Text);

            Client = new Client(name, telephone, address, bornDate);
        }

        #endregion

        #region LeaveEvents

        private void TextName_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void TextTelephone_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void TextAddress_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }
        private void AgeDatePicker_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        #endregion
    }
}
