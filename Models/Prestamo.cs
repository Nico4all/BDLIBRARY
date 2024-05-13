using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLIBRARY.Models
{
    internal class Prestamo
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Inicio {  get; set; }

        [Column(TypeName = "date")]
        public DateTime Fin {  get; set; }

        //Trar llaves de Book y User

        public int UserId { get; set; }
        public User User { get; set; }

        public int BookId { get; set; }
        public Book Book {  set; get; }
    }
}
