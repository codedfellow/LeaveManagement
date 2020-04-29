using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,25,ErrorMessage = "Choose a number from between 1 to 25")]
        [Display(Name = "Default Number of Days")]
        public int DefaultDays { get; set; }
        [Required]
        [Display(Name="Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
