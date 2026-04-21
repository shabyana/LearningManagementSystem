using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core.Dtos;

namespace LearningManagementSystem.Core.IReposytories
{
    public interface IUserRepository
    {
        public int Add(UserDto user);

        public List<UserDto> GetAll();

        public UserDto GetById(int id);

        public void Update(UserDto user);

        public void DeleteById(int id);
    }
}
