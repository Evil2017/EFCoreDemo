using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvc.Models
{
    /// <summary>
    /// 讲师
    /// </summary>
    public class Instructor
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "姓氏")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "名字")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "入职日期")]
        public DateTime HireDate { get; set; }

        [Display(Name = "全名")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }
        #region 导航属性

        /// <summary>
        /// 课程配置
        /// </summary>
        private ICollection<CourseAssignment> _courseAssignments;
        public ICollection<CourseAssignment> CourseAssignments
        {
            get
            {
                return _courseAssignments ?? (_courseAssignments = new List<CourseAssignment>());
            }
            set
            {
                _courseAssignments = value;
            }
        }
        /// <summary>
        /// 办公室配置
        /// </summary>
        public OfficeAssignment OfficeAssignment { get; set; }
        #endregion
    }
}


