using Employee_Assign1.Shared;

namespace Employee_Assign1.Models
{
    public class AddEmployee
    {
        public string firstname { get; set; } 
        public string lastname { get; set; }
        public string phone { get; set; }
        public string emailaddress { get; set; }
        public string mailingaddress { get; set; }
        public Employeetype type { get; set; }
    }
}
