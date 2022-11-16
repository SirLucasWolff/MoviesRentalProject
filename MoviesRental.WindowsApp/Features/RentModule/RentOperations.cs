﻿using MovieRental.Application.ClientModule;
using MovieRental.Application.EmployeModule;
using MovieRental.Application.MovieModule;
using MovieRental.Application.RentModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Domain.Shared;
using MoviesRental.Infra.SQL;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GetList()
        {
            List<Rent> rents = rentAppService.SelectAllRents();

            rentsToMigrate.AddRange(rents);
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

            RentForm form = new RentForm(movieAppService, clientAppService, rentAppService, registerType = "Devolution", rentSelected.ClientName);

            form.Rent = rentSelected;

            form.DevolutionScreen();

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                rentAppService.DeleteRent(form.Rent.Id);
                rentTable.UpdateRegisters();
                MainForm.instance.UpdateFooter($"Rent: [{form.Rent.EmployeName}] completed");
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
            RentForm form = new RentForm(movieAppService, clientAppService, rentAppService, registerType = "Insert", "");

            form.NewRentScreen();

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

        public void MigrateRegister()
        {
            foreach (Rent rentToMigrate in rentsToMigrate)
            {
                Rent? rentToEdit = rentAppService.SelectRentByName(rentToMigrate);

                rentToMigrate.Id = 0;

                string? getResult = ValidateMigrate(rentToMigrate);

                if (getResult == "InsertingWhileMigrate")
                    rentAppService.InsertNewRent(rentToMigrate);

                if (getResult == "EditingWhileMigrate" && rentToEdit != null)
                    rentAppService.EditRent(rentToEdit.Id,rentToMigrate);
            }
        }

        private string? ValidateMigrate(Rent rent)
        {
            List<Rent> allRents = rentAppService.SelectAllRents();

            if (allRents.Count == 0)
                return "InsertingWhileMigrate";

            bool movieName = allRents.Exists(d => d.MovieName == rent.MovieName);
            bool clientName = allRents.Exists(d => d.ClientName == rent.ClientName);

            if (!movieName && !clientName)
                return "InsertingWhileMigrate";

            if (movieName || clientName)
                return "EditingWhileMigrate";

            return null;
        }
    }
}
