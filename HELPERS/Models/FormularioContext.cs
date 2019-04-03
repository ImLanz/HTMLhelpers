using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HTMLhelpers.Models
{
    public class FormularioContext:DbContext
    {   
        public FormularioContext()
            : base("FormularioDatBase")
        { 
        }

        public DbSet<Formulario> formulario { get; set; }
    }
}