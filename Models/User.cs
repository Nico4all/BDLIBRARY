using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLIBRARY.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //TRAER LLAVE DE ROL
        public int RolId { get; set; }
        public Rol Rol { get; set; }

        //llevar llave de User a Prestamo
        public ICollection<Prestamo> Prestamos { get; set; }


    }
}
