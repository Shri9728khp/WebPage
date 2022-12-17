using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models
{
    public class WebFrom
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="* Date can t black")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "* Name can t black")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* Email can t black")]
        public string Email { get; set; }
        [Required(ErrorMessage = "* Mobile can t black")]
        public long Mobile { get; set; }
        [Required(ErrorMessage = "* Salary can t black")]
        public Decimal Salary { get; set; }
        [Required(ErrorMessage = "* Location can t black")]
        public string Location { get; set; }
        [Required(ErrorMessage = "* Department can t black")]
        public string Department { get; set; }

    }
}
