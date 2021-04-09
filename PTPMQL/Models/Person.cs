using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string CCCD { get; set; }
        public string FullName { get; set; }
    }
}