namespace WebMvc.Models
{
    /// <summary>
    /// 课程配置
    /// </summary>
    public class CourseAssignment
    {
        /// <summary>
        /// 讲师ID
        /// </summary>
        public int InstructorID { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }

        #region 导航属性

        /// <summary>
        /// 讲师
        /// </summary>
        public Instructor Instructor { get; set; }
       /// <summary>
       /// 课程
       /// </summary>
        public Course Course { get; set; }
        #endregion
    }
}