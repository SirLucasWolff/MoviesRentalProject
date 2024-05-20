using MoviesRental.Domain.ClientModule;

namespace MoviesRental.WindowsApp.Features.ClientModule
{
    public partial class ClientForm : Form
    {
        private bool IsAddOperation;

        public ClientForm(bool statusOperation)
        {
            InitializeComponent();
            IsAddOperation = statusOperation;
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
                AgeDatePicker.Text = client.BornDate.Value.Date.ToString("MM/dd/yyyy");
            }
        }

        #region CodeMethods

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
            catch (Exception ex) { throw ex; }

            return age;
        }

        #endregion

        #region ButtonsClick

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string name = TextName.Text;

            int telephone = 0;

            if (TextTelephone.Text != String.Empty)
            {
                telephone = Convert.ToInt32(TextTelephone.Text);
            }

            string address = TextAddress.Text;

            DateTime bornDate = DateTime.MinValue;

            if (AgeDatePicker.Text != "  /  /")
                bornDate = Convert.ToDateTime(AgeDatePicker.Text);

            Client = new Client(name, telephone, address, bornDate);
        }

        #endregion

        private void ClientForm_Load(object sender, EventArgs e)
        {
            if (IsAddOperation == true)
            {
                TextAddress.Text = string.Empty;
                TextTelephone.Text = string.Empty;
                TextName.Text = string.Empty;
                AgeDatePicker.Text = string.Empty;
            }
        }

        private void TextTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
