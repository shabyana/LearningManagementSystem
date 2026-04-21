using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core.Dtos;

namespace LearningManagementSystem.Core.IReposytories
{
    public interface ITestRepository
    {
        public int Add(TestDto test);

        public List<TestDto> GetAll();

        public TestDto GetById(int id);

        public void Update(TestDto test);

        public void DeleteById(int id);
    }
}
