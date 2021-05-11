using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Passengers")]
    public class Passenger
    {
        
        public string HovaTen { get; set; }
        public string GioiTinh { get; set; }
        [Key]
        public string HoChieu { get; set; }
    }
}