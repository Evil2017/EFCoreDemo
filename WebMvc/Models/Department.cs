using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebMvc.Models
{
    /// <summary>
    /// 院系
    /// </summary>
    public class Department
    {
        [DisplayName("ID")]
        public int DepartmentID { get; set; }
        [Display(Name = "名称")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        /// <summary>
        /// 学费
        /// </summary>
        [Display(Name = "学费")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "开学时间")]
        public DateTime StartDate { get; set; }
        [Display(Name = "讲师")]
        public int? InstructorID { get; set; }
        [Display(Name = "领导")]
        public Instructor Administrator { get; set; }
        [Display(Name = "跟踪属性")]
        [Column(TypeName = "RowVersion")]
        [Timestamp]
        public byte[] RowVersion { get; set; }
        #region 导航属性
        [Display(Name = "课程")]
        public ICollection<Course> Courses { get; set; }
        #endregion
    }
}