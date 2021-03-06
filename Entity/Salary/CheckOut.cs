using PowerOfGod.Domain.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfGod.Domain.Entity.Salary
{
    public class CheckOut
    {
        [Key]
        public int CheckOutId { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayName("End Time")]
        [RegularExpression(@"^\s*([01]?\d|2[0-3])(:([0-5]\d))(:([0-5]\d))?\s*$")]
        public TimeSpan endTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string email { get; set; }

        public int SalaryId { get; set; }
        public Salary salaries { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
