using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvc.Models
{
    [Table("Student")]
    public class Student
    {
        [DisplayName("主键")]
        [Description("主键")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID", Order = 1, TypeName = "int")]
        public int ID { get; set; }
        [Required]
        [Display(Name = "姓氏")]
        [DisplayName("姓氏")]
        [Description("姓氏")]
        [StringLength(50, MinimumLength = 2)]
        [Column("LastName", TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "名字")]
        [DisplayName("名字")]
        [Description("名字")]
        //[Column("FirstMidName", TypeName = "varchar(50)")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "入学时间")]
        [DisplayName("入学时间")]
        [Description("入学时间")]
        [Column("EnrollmentDate", TypeName = "DateTime")]
        //[DataType(DataType.DateTime)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]//显示格式
        public DateTime? EnrollmentDate { get; set; }
        [DisplayName("密钥")]
        [Description("密钥")]
        [Column("Secret", TypeName = "varchar(50)")]
        public string Secret { get; set; }
        [Display(Name = "全名")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        #region 导航属性
        /// <summary>
        /// 入学登记
        /// </summary>

        [Display(Name = "入学登记")] 
        public ICollection<Enrollment> Enrollments { get; set; }
        #endregion
    }
}


