﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaEnLinea.Models
{
    public class CourseEnrollment
    {
        [Key]
        public int CourseEnrollmentId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
