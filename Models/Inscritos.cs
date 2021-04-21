using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMySQL.Models
{
    public class Inscritos : Usuario
    {

        [Display(Name = "Canal")]
        [Column("Canal")]
        public string Canal { get; set; }

    }
}
