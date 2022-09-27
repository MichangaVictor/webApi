﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [StringLength(100)]
         public string firstName { get; set; }
        [StringLength(100)]
        public string middleName { get; set; }
        [StringLength(100)]
        public string lastName { get; set; }
        [StringLength(12)]
        public string mobile { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        public int age { get; set; }
        [StringLength(3)]
        public string course { get; set; }
        [StringLength(100)]
        public string address { get; set; }
    }
}
