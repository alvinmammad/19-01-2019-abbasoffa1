using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _190119.Models
{
    public class Group
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName ="money")]
        public decimal Cost { get; set; }

        public List<Student> Students { get; set; }
    }
}