using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMvc.Enums;



namespace WebMvc.Models
{
    /// <summary>
    /// 入学登记
    /// </summary>
    public class Enrollment
    {
        [DisplayName("学号")]
        [Description("学号")]
        [Column("EnrollmentID", TypeName = "int")]
        public int EnrollmentID { get; set; }
        [DisplayName("课程编号")]
        [Description("课程编号")]
        [Column("CourseID", TypeName = "int")]
        public int CourseID { get; set; }
        [DisplayName("学号")]
        [Description("学号")]
        [Column("StudentID", TypeName = "int")]
        public int StudentID { get; set; }
        [DisplayName("成绩")]
        [Description("成绩")]
        [Column("Grade", TypeName = "varchar(50)")]
        [DisplayFormat(NullDisplayText = "没有成绩")]
        public Grade? Grade { get; set; }
        #region 导航属性
        /// <summary>
        /// 课程
        /// </summary>
        public Course Course { get; set; }
        /// <summary>
        /// 学生
        /// </summary>
        public Student Student { get; set; }
        #endregion
    }
}