using System.ComponentModel.DataAnnotations;

namespace WebMvc.Models
{
    /// <summary>
    /// 办公室配置
    /// </summary>
    public class OfficeAssignment
    {
        /// <summary>
        /// 讲师
        /// </summary>
        [Key]
        public int InstructorID { get; set; }
        /// <summary>
        /// 办公室地址
        /// </summary>
        [StringLength(50)]
        [Display(Name = "办公室地址")]
        public string Location { get; set; }
        #region 导航属性
        /// <summary>
        /// 讲师
        /// </summary>
        public Instructor Instructor { get; set; }
        #endregion
    }
}


