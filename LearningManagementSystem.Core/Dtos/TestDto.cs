using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Core.Dtos
{
    public class TestDto
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string Title { get; set; }
=======
        public string   Title { get; set; }
>>>>>>> origin/main
        public CourseDto Course { get; set; } = new CourseDto();
        public TestResultDto TestResults { get; set; } 
    }
    
}
