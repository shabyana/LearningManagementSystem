using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core.Dtos;

namespace LearningManagementSystem.Core.IReposytories
{
    public interface ICourseRepository
    {
        int Add(CourseDto course);

        List<CourseDto> GetAll();

        CourseDto GetById(int id);

        void Update(CourseDto course);

        void DeleteById(int id);
    }
}
