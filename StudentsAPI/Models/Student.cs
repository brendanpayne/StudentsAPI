﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public string CollegeProgram { get; set; }
        
        public string YearInProgram { get; set; }
    }
}
