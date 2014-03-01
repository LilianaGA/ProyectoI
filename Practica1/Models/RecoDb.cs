using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class RecoDb : DbContext
    {
        public RecoDb()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Reco> Reco { get; set; }
    }
}