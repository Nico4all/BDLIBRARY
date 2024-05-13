﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLIBRARY.Models
{
    internal class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        //para llevar llave de rol a usuario
        public ICollection<User> Users { get; set; }

    }
}
