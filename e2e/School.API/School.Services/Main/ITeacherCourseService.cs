﻿using System.Collections.Generic;
using System.Threading.Tasks;
using School.Models;

namespace School.Services.Main
{
    public interface ITeacherCourseService
    {
        Task<bool> AddTeacherCourse(TeacherCourse course);
        Task<bool> EditTeacherCourse(TeacherCourse course);
        Task<IEnumerable<TeacherCourse>> GetAllTeacherCourses(string UserId);
        Task<TeacherCourse> GetTeacherCourseById(int CourseId);
        Task<bool> CourseExists(int courseId, string TeacherId);
        Task<bool> TeacherHasCourse(int courseId, string TeacherId);
        Task<bool> RemoveTeacherCourse(TeacherCourse course);
    }
}