﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.DataTransferObject.Course
{
   public class CourseViewDto
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string Department { get; set; }




    }
}
