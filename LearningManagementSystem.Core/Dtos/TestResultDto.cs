using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Core.Dtos
{
    public class TestResultDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int Score { get; set; }
        public DateTime AttemptDateTime { get; set; }

        public List<TestDto> Tests { get; set; } = new List<TestDto>();
        public List<UserDto> User { get; set; } = new List<UserDto>(); 
        
    }
}
