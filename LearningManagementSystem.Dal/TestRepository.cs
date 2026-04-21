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
    internal class TestRepository : ITestRepository
    {
        private DataContext _context;

        public TestRepository(DataContext context)
        {
            _context = context;
        }
        public int Add(TestDto test)
        {
            if (test == null)
            {
                throw new ArgumentNullException("test");
            }
            else if (test.Title == null || test.Title.Trim().Length == 0)
            {
                throw new ArgumentException("no title!");
            }

            _context.Tests.Add(test);
            _context.SaveChanges();

            return test.Id;
        }

        public void DeleteById(int id)
        {
            var crnt = GetById(id);
            _context.Tests.Remove(crnt);
            _context.SaveChanges();
        }

        public List<TestDto> GetAll()
        {
            var result = _context.Tests.ToList();
            return result;
        }

        public TestDto GetById(int id)
        {
            var result = _context.Tests.FirstOrDefault(t => t.Id == id);

            if (result == null)
            {
                throw new ArgumentException("Теста с таким ID нет");
            }

            return result;
        }

        public void Update(TestDto test)
        {
            var crnt = GetById(test.Id);
            crnt.Title = test.Title;

            _context.SaveChanges();
        }

    }
}
