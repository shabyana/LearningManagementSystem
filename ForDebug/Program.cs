using LearningManagementSystem.Core;
using Microsoft.EntityFrameworkCore;
using LearningManagementSystem.Core.Dtos;

namespace ForDebug
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();

            dataContext.Database.EnsureCreated();

            dataContext.Users.Add(new UserDto() { Role = "Администратор", FullName = "Иванов Сергей Дмитриевич" });
            dataContext.Users.Add(new UserDto() { Role = "Администратор", FullName = "Петрова Анна Викторовна" });
            dataContext.Users.Add(new UserDto() { Role = "Преподаватель", FullName = "Смирнов Алексей Николаевич" });
            dataContext.Users.Add(new UserDto() { Role = "Преподаватель", FullName = "Кузнецова Мария Александровна" });
            dataContext.Users.Add(new UserDto() { Role = "Преподаватель", FullName = "Соколов Дмитрий Андреевич" });
            dataContext.Users.Add(new UserDto() { Role = "Студент", FullName = "Лебедева Ольга Евгеньевна" });
            dataContext.Users.Add(new UserDto() { Role = "Студент", FullName = "Новиков Михаил Борисович" });
            dataContext.Users.Add(new UserDto() { Role = "Студент", FullName = "Морозова Екатерина Павловна" });
            dataContext.Users.Add(new UserDto() { Role = "Студент", FullName = "Волков Владимир Игоревич" });
            dataContext.Users.Add(new UserDto() { Role = "Студент", FullName = "Зайцева Наталья Сергеевна" });

            dataContext.Courses.Add(new CourseDto() { Title = "Unity", AuthorID = 2 });
            dataContext.Courses.Add(new CourseDto() { Title = "PostgreSQL", AuthorID = 2 });
            dataContext.Courses.Add(new CourseDto() { Title = "HTML", AuthorID = 3 });
            dataContext.Courses.Add(new CourseDto() { Title = "C#", AuthorID = 3 });
            dataContext.Courses.Add(new CourseDto() { Title = "ADO.NET", AuthorID = 2 });

            dataContext.SaveChanges();

           

        }
    }
}
