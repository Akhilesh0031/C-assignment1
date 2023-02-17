using Employee_Assign1.Models;
using Employee_Assign1.Repository.Interface;
using Employee_Assign1.Shared;

namespace Employee_Assign1.Repository
{
    public class PermanentEmployee : IPEmployee
    {
        public readonly DBApplicationContext _dBApplicationContext1;
        public PermanentEmployee(DBApplicationContext dBApplicationContext)
        {
            _dBApplicationContext1= dBApplicationContext;
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
            Console.WriteLine(id);
            Employee details= new Employee();
            details = _dBApplicationContext1.employees.Find(id);
            Console.WriteLine(details);
            return details;
        }

        public string GetEmployeePhoneNumber(int id)
        {
            var num = _dBApplicationContext1.employees.Where(x => x.id == id).Select(x => x.phone).Single();
            //var num = _dBApplicationContext1.employees.Find(id).phone;
            return num;
        }
    }
}
