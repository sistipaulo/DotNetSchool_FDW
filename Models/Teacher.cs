﻿using System.ComponentModel.DataAnnotations;

namespace DotNetSchool.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; }
    }
}
