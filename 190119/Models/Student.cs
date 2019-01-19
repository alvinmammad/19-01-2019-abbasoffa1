using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _190119.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(30)]
        public string Phone { get; set; }

        [Required,Column(TypeName ="date")]
        public DateTime Birthday { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}