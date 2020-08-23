using System.Collections.Generic;

namespace WebMvc.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        /// <summary>
        /// 讲师
        /// </summary>
        public IEnumerable<Instructor> Instructors { get; set; }
        /// <summary>
        /// 课程
        /// </summary>
        public IEnumerable<Course> Courses { get; set; }
        /// <summary>
        /// 登记
        /// </summary>
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}


