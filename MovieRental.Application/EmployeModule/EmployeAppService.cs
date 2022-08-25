using MoviesRental.Domain.EmployeeModule;

namespace MovieRental.Application.EmployeModule
{
    public class EmployeAppService
    {
        EmployeeRepository employeRepository;

        public EmployeAppService (EmployeeRepository employeRepository)
        {
            this.employeRepository = employeRepository;
        }

        public string InsertNewEmploye (Employee employe)
        {
            string ValidationResult = employe.Validation();

            if (ValidationResult == "Is_Valid")
            {
                try
                {
                    employeRepository.InsertNew(employe);
                }
                catch (Exception ex)
                {
                    return "The employee cannot be insert";
                }
            }

            return ValidationResult;
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                employeRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public string EditEmployee (int id, Employee employe)
        {
            string ValidationResult = employe.Validation();

            if (ValidationResult == "Is_Valid")
            {
                try
                {
                    employe.Id = id;
                    employeRepository.Edit(id, employe);
                }
                catch (Exception ex)
                {

                }
            }

            return ValidationResult;
        }

        public Employee SelectEmployeeId (int id)
        {
            try
            {
                Employee employeeSelected = employeRepository.SelectById(id);
                return employeeSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Employee> SelectAllEmployees()
        {
            try
            {
                List<Employee> allEmployeesSelected = employeRepository.SelectAll();
                return allEmployeesSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}