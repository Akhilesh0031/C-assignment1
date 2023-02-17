using Employee_Assign1.Models;

namespace Employee_Assign1.Repository.Interface
{
    public interface IPEmployee
    {
        Employee GetEmployee(int id);
        void AddEmployee(Employee employee);
        string GetEmployeePhoneNumber(int id);
    }
}
