using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    [Table("CompanyEmployee")]
    public class Employee
    {
        [Display(Name = "員工編號")]
        [Column("EmployeeId")]
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [Required]
        [StringLength(50, ErrorMessage = "必須輸入姓名")]
        public string Name { get; set; }

        [Display(Name = "電話")]
        [StringLength(15)]
        public string Mobile { get; set; }

        [Display(Name = "電子信箱")]
        [Required, StringLength(255)]
        [Column("PersonalEmail")]
        public string Email { get; set; }

        [Display(Name = "部門")]
        public string Department { get; set; }

        [Display(Name = "職稱")]
        public string Title { get; set; }
    }
}