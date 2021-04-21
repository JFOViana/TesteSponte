using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMySQL.Models
{
    public class Instrutor : Usuario {

        [Display(Name = "Canal")]
        [Column("Canal")]
        public string Canal { get; set; }

    }



}


