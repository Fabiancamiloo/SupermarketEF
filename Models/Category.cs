﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
    public class Category
    {
        public int Id { get; set; } // Sera la llave primaria
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } // Propiedad de navegacion
    }
}
