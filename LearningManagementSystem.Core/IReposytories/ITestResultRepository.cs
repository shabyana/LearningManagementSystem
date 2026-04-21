using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core.Dtos;

namespace LearningManagementSystem.Core.IReposytories
{
    public interface ITestResultRepository
    {
        public int Add(TestResultDto resultDto);

        public List<TestResultDto> GetAll();

        public TestResultDto GetById(int id);

        public void Update(TestResultDto result);

        public void DeleteById(int id);


    }
}
