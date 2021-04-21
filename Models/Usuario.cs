using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace WebMySQL.Models
{

    [Table("Usuario")]
    public class Usuario
    {


        public static string CurrentDate { get; private set; }
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cargo")]
        [Column("Cargo")]
        public string Cargo { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Display(Name = "Instagram")]
        [Column("Instagram")]
        public string Instagram { get; set; }


        [Display(Name = "Data de Nascimento")]
        [Column("DataNascimento")]
        public DateTime Data { get; set; }


 


       

    }
}
