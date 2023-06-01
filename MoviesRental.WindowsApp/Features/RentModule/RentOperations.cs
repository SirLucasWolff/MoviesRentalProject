using MovieRental.Application.ClientModule;
using MovieRental.Application.EmployeModule;
using MovieRental.Application.MovieModule;
using MovieRental.Application.RentModule;
using MoviesRental.Domain.RentModule;

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public class RentOperations : IRegisterRent
    {
        private RentAppService rentAppService = null;

        private ClientAppService clientAppService = null;

        private EmployeAppService employeeAppService = null;

        private MovieAppService movieAppService = null;

        private RentTable rentTable = null;

        public List<Rent> rentList;

        public static List<Rent> rentsToMigrate = new List<Rent>();

        public string registerType = null;

        public static RentOperations instance;

        public RentOperations(RentAppService appService, ClientAppService clientAppService, EmployeAppService employeAppService, MovieAppService movieAppService)
        {
            instance = this;
            this.rentAppService = appService;
            this.clientAppService = clientAppService;
            this.employeeAppService = employeAppService;
            this.movieAppService = movieAppService;
            rentTable = new RentTable(appService);
            rentList = new List<Rent>();
        }

        public List<Rent> GetList()
        {
            List<Rent> rents = rentAppService.SelectAllRents();

            if (rents != null)
                rentsToMigrate.AddRange(rents);

            return rents;
        }

        public void DeleteRegister()
        {
            int id = rentTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a rent to delete", "Rent deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Rent rentSelected = rentAppService.SelectRentId(id);

            if (MessageBox.Show($"Do you have sure about to delete: [{rentSelected.EmployeeName}] ?",
                "Rent deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (rentAppService.DeleteRent(id))
                {
                    rentTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Rent: [{rentSelected.EmployeeName}] deleted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter($"It wasn't possible to delete the rent {rentSelected.EmployeeName}");
                }
            }
        }

        public Image GetImage(string path)
        {
            var filePath = path;
            FileInfo fi = new FileInfo(filePath);
            Image tempImage = Image.FromFile(fi.FullName);
            return tempImage;
        }

        byte[] ConvertImageToBinaryYellow(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        byte[] ConvertImageToBinaryRed(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public int GetDaysQuantity(DateTime returnDate)
        {
            DateTime dateNow = DateTime.Now;

            int days = ((returnDate - dateNow)).Days;

            return days;
        }

        public void EditStatusRegister()
        {
            rentList = rentAppService.SelectAllRents();

            if (rentList != null)
            {
                foreach (var item in rentList)
                {
                    if (GetDaysQuantity(item.ReturnDate) <= 3 && item.Status != "Pending" && item.Status != "Near return")
                    {
                        item.Status = "Near return";
                        string path = @"D:/Movies Rental Project/Status images/Yellow Status.PNG";
                        Byte[] statusImage = ConvertImageToBinaryYellow(GetImage(path));
                        item.StatusImage = statusImage;
                        rentAppService.EditRent(item.Id, item);
                        rentTable.UpdateRegisters();
                    }

                    if (GetDaysQuantity(item.ReturnDate) < 0 && item.Status == "Near return" && item.Status != "Pending")
                    {
                        item.Status = "Pending";
                        string path = @"D:/Movies Rental Project/Status images/Red Status.PNG";
                        Byte[] statusImage = ConvertImageToBinaryRed(GetImage(path));
                        item.StatusImage = statusImage;
                        rentAppService.EditRent(item.Id, item);
                        rentTable.UpdateRegisters();
                    }
                }
            }
        }

        public void RegisterDevolution()
        {
            int id = rentTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a rent to register the devolution", "Rent devolution",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Rent rentSelected = rentAppService.SelectRentId(id);

            RentForm form = new RentForm(movieAppService, clientAppService, rentAppService, registerType = "Devolution", rentSelected.ClientName,false);

            form.Rent = rentSelected;

            form.DevolutionScreen();

            bool datasRequiredIsNull;

            do
            {
                form.ShowDialog();

                if (form.DialogResult == DialogResult.Cancel) return;

                datasRequiredIsNull = String.IsNullOrEmpty(form.Rent.ClientName)
                                     | String.IsNullOrEmpty(form.Rent.EmployeeName)
                                     | form.Rent.MovieValue == 0
                                     | form.Rent.MoviesQuantity == 0
                                     | form.Rent.DayValue == 0;

                if (datasRequiredIsNull)
                {
                    MessageBox.Show("There are empty informations", "Rent form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            while (datasRequiredIsNull);

            rentAppService.DeleteRent(form.Rent.Id);
            rentTable.UpdateRegisters();
            MainForm.instance.UpdateFooter($"Rent: [{form.Rent.EmployeeName}] completed");
        }

        public UserControl GetTable()
        {
            rentTable.UpdateRegisters();

            return rentTable;
        }

        public UserControl GetTableFiltered(string status)
        {
            rentTable.UpdateRegistersStatusSelected(status);

            return rentTable;
        }

        public void InsertNewRegister()
        {
            RentForm form = new RentForm(movieAppService, clientAppService, rentAppService, registerType = "Insert", "",true);

            form.NewRentScreen();

            bool datasRequiredIsNull;

            do
            {
                form.ShowDialog();

                if (form.DialogResult == DialogResult.Cancel) return;

                datasRequiredIsNull = String.IsNullOrEmpty(form.Rent.ClientName)
                                     | String.IsNullOrEmpty(form.Rent.EmployeeName)
                                     | form.Rent.MovieValue == 0
                                     | form.Rent.MoviesQuantity == 0
                                     | form.Rent.DayValue == 0;

                if (datasRequiredIsNull)
                {
                    MessageBox.Show("There are empty informations", "Rent form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            while (datasRequiredIsNull);

            string result = rentAppService.InsertNewRent(form.Rent);

            if (result == "Is_Valid")
            {
                rentTable.UpdateRegisters();
                MainForm.instance.UpdateFooter($"Rent {form.Rent.EmployeeName} inserted with success");
            }
            else
            {
                MainForm.instance.UpdateFooter(result);
            }
        }

        public List<Rent> DashboardRents()
        {
            List<Rent> rents = rentAppService.SelectAllRents();

            return rents;
        }
    }
}
