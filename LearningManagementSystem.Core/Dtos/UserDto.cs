using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Core.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        
        public List<CourseDto> Courses { get; set; } = new List<CourseDto>();
        public TestResultDto Result { get; set; } 
    }
}
