using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Core.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string AuthorID { get; set; }

        public List<UserDto> Users  { get; set; } = new List<UserDto>();
        public List<TestDto> Tests { get; set; } = new List<TestDto>();
    }
}
