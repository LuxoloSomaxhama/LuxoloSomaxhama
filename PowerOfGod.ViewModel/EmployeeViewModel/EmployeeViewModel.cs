using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfGod.ViewModel.EmployeeViewModel
{
    public class EmployeeViewModel
    {
        [Key]
        public string EmpNum { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        [Display(Name = "Position")]
        public string UserRole { get; set; }
        [DisplayName("Upload Image")]
        public byte[] Picture { get; set; }
        public string email { get; set; }
        public string deptName { get; set; }
        public string typeName { get; set; }
    }
}
