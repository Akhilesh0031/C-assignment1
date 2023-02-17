using Employee_Assign1.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Assign1.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(25)]
        public string firstname { get; set; }
        [MaxLength(25)]
        public string lastname { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string emailaddress { get; set; }
        public string mailingaddress { get; set; }
        public Employeetype type { get; set; }

  
    }
}
