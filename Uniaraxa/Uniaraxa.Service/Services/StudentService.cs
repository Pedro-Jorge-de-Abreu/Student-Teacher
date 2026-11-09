using System;
using System.Collections.Generic;
using System.Text;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interface;

namespace Uniaraxa.Service.Services
{
    public class StudentService : IStudentservice
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
           return _studentRepository.GetStudentById(id);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            _studentRepository.AddTeacher(teacher);
        }

        public void DeleteTeacher(int id)
        {
            _studentRepository.DeleteTeacher(id);
        }

        public List<Teacher> GetAllTeachers()
        {
            return _studentRepository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return _studentRepository.GetTeacherById(id);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _studentRepository.UpdateTeacher(teacher);
        }
    }
}
