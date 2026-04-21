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
    internal class TestResultRepository : ITestResultRepository
    {
        private DataContext _context;

        public TestResultRepository(DataContext context)
        {
            _context = context;
        }
        public int Add(TestResultDto result)
        {
            if (result == null)
            {
                throw new ArgumentNullException("result");
            }
            else if (result.Score == null)
            {
                throw new ArgumentException("no score!");
            }

            _context.Results.Add(result);
            _context.SaveChanges();

            return result.Id;
        }

        public void DeleteById(int id)
        {
            var crnt = GetById(id);
            _context.Results.Remove(crnt);
            _context.SaveChanges();
        }

        public List<TestResultDto> GetAll()
        {
            var result = _context.Results.ToList();
            return result;
        }

        public TestResultDto GetById(int id)
        {
            var result = _context.Results.FirstOrDefault(t => t.Id == id);

            if (result == null)
            {
                throw new ArgumentException("Результата теста с таким ID нет");
            }

            return result;
        }

        public void Update(TestResultDto result)
        {
            var crnt = GetById(result.Id);
            crnt.Score = result.Score;

            _context.SaveChanges();
        }
    }
}
