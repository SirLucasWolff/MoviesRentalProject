using MovieRental.Application.ClientModule;
using MovieRental.Application.EmployeModule;
using MovieRental.Application.MovieModule;
using MovieRental.Application.RentModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public class RentOperations : IRegister
    {
        private RentAppService rentAppService = null;

        private ClientAppService clientAppService = null;

        private EmployeAppService employeeAppService = null;

        private MovieAppService movieAppService = null;

        private RentTable rentTable = null;

        public List<Rent> rentList;

        public RentOperations(RentAppService appService, ClientAppService clientAppService, EmployeAppService employeAppService, MovieAppService movieAppService)
        {
            this.rentAppService = appService;
            this.clientAppService = clientAppService;
            this.employeeAppService = employeAppService;
            this.movieAppService = movieAppService;
            rentTable = new RentTable(appService);
            rentList = new List<Rent>();
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

            if (MessageBox.Show($"Do you have sure about to delete: [{rentSelected.EmployeName}] ?",
                "Rent deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (rentAppService.DeleteRent(id))
                {
                    rentTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Rent: [{rentSelected.EmployeName}] deleted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter($"It wasn't possible to delete the rent {rentSelected.EmployeName}");
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

                    if (GetDaysQuantity(item.ReturnDate) < 1 && item.Status == "Near return" && item.Status != "Pending")
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

        public void EditRegister()
        {
            int id = rentTable.GetIdSelected();

            if (id == 0)
            {
                EditStatusRegister();
                return;
            }

            Rent rentSelected = rentAppService.SelectRentId(id);

            RentForm form = new RentForm(employeeAppService, movieAppService, clientAppService);
            form.Rent = rentSelected;

            form.DesableTableMovies();

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                string result = rentAppService.EditRent(id, form.Rent);

                if (result == "Is_Valid")
                {
                    rentTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Rent: [{form.Rent.EmployeName}] edited with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
            }
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
            RentForm form = new RentForm(employeeAppService, movieAppService, clientAppService);

            if (form.ShowDialog() == DialogResult.OK)
            {
                string result = rentAppService.InsertNewRent(form.Rent);

                if (result == "Is_Valid")
                {
                    rentTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Rent {form.Rent.EmployeName} inserted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
            }
        }
    }
}
