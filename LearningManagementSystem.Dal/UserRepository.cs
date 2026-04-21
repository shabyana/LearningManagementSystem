using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core;
using LearningManagementSystem.Core.Dtos;
using LearningManagementSystem.Core.IReposytories;
using Microsoft.EntityFrameworkCore;

namespace LearningManagementSystem.Dal
{
    internal class UserRepository : IUserRepository
    {
        private DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public int Add(UserDto user)
        {

            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            else if (user.FullName == null || user.FullName.Trim().Length == 0)
            {
                throw new ArgumentException("no title!");
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }

        public void DeleteById(int id)
        {
            var crnt = GetById(id);
            _context.Users.Remove(crnt);
            _context.SaveChanges();
        }

        public List<UserDto> GetAll()
        {
            var result = _context.Users.ToList();
            return result;
        }

        public UserDto GetById(int id)
        {
            var result = _context.Users.FirstOrDefault(u => u.Id == id);

            if (result == null)
            {
                throw new ArgumentException("Пользователя с таким ID нет");
            }

            return result;
        }

        public void Update(UserDto user)
        {
            var crnt = GetById(user.Id);
            crnt.FullName = user.FullName;

            _context.SaveChanges();
        }
    }
}
