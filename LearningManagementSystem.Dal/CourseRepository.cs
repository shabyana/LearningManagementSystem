using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core;
using LearningManagementSystem.Core.Dtos;
using LearningManagementSystem.Core.IReposytories;

namespace LearningManagementSystem.Dal
{
    public class CourseRepository : ICourseRepository
    {
        private DataContext _context;

        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public int Add(CourseDto course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course");
            }
            else if (course.Title == null || course.Title.Trim().Length == 0)
            {
                throw new ArgumentException("no title!");
            }

            _context.Courses.Add(course);
            _context.SaveChanges();

            return course.Id;
        }

        public void DeleteById(int id)
        {
            var crnt = GetById(id);
            _context.Courses.Remove(crnt);
            _context.SaveChanges();
        }

        public List<CourseDto> GetAll()
        {
            var result = _context.Courses.ToList();
            return result;
        }

        public CourseDto GetById(int id)
        {
            var result = _context.Courses.FirstOrDefault(c => c.Id == id);

            if (result == null)
            {
                throw new ArgumentException("Курса с таким ID нет");
            }

            return result;
        }

        public void Update(CourseDto course)
        {
            var crnt = GetById(course.Id);
            crnt.Title = course.Title;

            _context.SaveChanges();
        }
    }
}
