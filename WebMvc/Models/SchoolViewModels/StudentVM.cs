using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMvc.Models.SchoolViewModels
{
    public class StudentVM
    {
        [DisplayName("主键")]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        [DisplayName("姓氏")]
        public string LastName { get; set; }
        [DisplayName("名字")]
        public string FirstMidName { get; set; }
        [DisplayName("入学时间")]
        public DateTime EnrollmentDate { get; set; }
    }
}


