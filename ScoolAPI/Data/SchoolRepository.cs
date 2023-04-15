﻿using ScoolAPI.Data.Interfaces;
using ScoolAPI.Models;
using System.Runtime.CompilerServices;


namespace ScoolAPI.Data
{
    public class SchoolRepository : ISchoolRepository
    {

        private SchoolDBContext _dbContext;
        public SchoolRepository()
        {
            _dbContext = new SchoolDBContext();
        }

        public void CreateTeacher(Teacher teacher)
        {
            _dbContext.Teachers.Add(teacher);
            _dbContext.SaveChanges();
        }

        public bool DeleteTeacher(Teacher teacher)
        {
            try
            {
                _dbContext.Teachers.Remove(teacher);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
            

            

            
      }

        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAllTeachers()
        {
            return _dbContext.Teachers.ToList();
        }

        public Teacher? GetTeacherById(int id)
        {
            return _dbContext.Teachers.Where(t => t.TeacherId ==  id).FirstOrDefault();
        }

        public Teacher? UpdateTeacher(int id, Teacher teacherFromBody)
        {
            Teacher? teacherFromDB = GetTeacherById(id);

            if (teacherFromDB == null)
            {
                return null;
            }

            teacherFromDB.FirstName = teacherFromBody.FirstName;
            teacherFromDB.LastName = teacherFromBody.LastName;
            teacherFromDB.Subjects = teacherFromBody.Subjects;

            _dbContext.SaveChanges();

            return teacherFromDB;
        }
    }
}
