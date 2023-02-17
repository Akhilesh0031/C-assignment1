using Employee_Assign1.Models;
using Employee_Assign1.Repository.Interface;
using Employee_Assign1.Shared;

namespace Employee_Assign1.Repository
{
    public class TemporaryEmployee : ITEmployee
    {
        public readonly DBApplicationContext _dBApplicationContext1;
        public TemporaryEmployee(DBApplicationContext dBApplicationContext)
        {
            _dBApplicationContext1 = dBApplicationContext;
        }
        public void AddEmployee(Employee employee)
        {
            var addemployee = new Employee()
            {

                firstname = employee.firstname,
                lastname = employee.lastname,
                phone = employee.phone,
                emailaddress = employee.emailaddress,
                mailingaddress = employee.mailingaddress,
                type = employee.type
            };
            _dBApplicationContext1.employees.Add(addemployee);
            _dBApplicationContext1.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public string GetEmployeePhoneNumber(int id)
        {
            throw new NotImplementedException();
        }
    }
}
