using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebMvc.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        [Display(Name = "课程编号")]
        [Description("课程编号")]
        [Column("CourseID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int CourseID { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [DisplayName("内容")]
        [Description("内容")]
        [Column("Title", TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "长度")]
        public string Title { get; set; }
        /// <summary>
        /// 凭证
        /// </summary>
        [DisplayName("凭证")]
        [Description("凭证")]
        [Column("Credits")]
        [Range(0, 5)]
        public int Credits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "院系ID")]
        public int DepartmentID { get; set; }

        #region 导航属性
        /// <summary>
        /// 院系
        /// </summary>
        [Display(Name = "院系")]
        public Department Department { get; set; }

        /// <summary>
        /// 入学登记
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }
        /// <summary>
        /// 课程分配
        /// </summary>
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        #endregion
    }
}