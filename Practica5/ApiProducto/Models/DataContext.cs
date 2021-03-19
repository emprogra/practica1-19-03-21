﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiProducto.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiProducto.Models.Producto> Productoes { get; set; }
    }
}