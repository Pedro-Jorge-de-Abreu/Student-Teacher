using System;
using System.Collections.Generic;
using System.Text;
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Domain.Interface
{
    public interface IStudentRepository
    {
        public void AddStudent ( Student student );
        public void UpdateStudent(Student student);
        public void DeleteStudent( int id );
        public Student GetStudentById( int id );

        public List<Student> GetAllStudents();

        public void AddTeacher(Teacher teacher);
        public void UpdateTeacher(Teacher teacher);
        public void DeleteTeacher(int id);
        public Teacher GetTeacherById(int id);

        public List<Teacher> GetAllTeachers();

    }
}
