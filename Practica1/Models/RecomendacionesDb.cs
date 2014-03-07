using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityApp.Models
{
    public class RecomendacionesDb : DbContext
    {
        public RecomendacionesDb()
            : base("database")
        {
            
        }

        public DbSet<Recomendacion> Recomendaciones { get; set; }
    }
}