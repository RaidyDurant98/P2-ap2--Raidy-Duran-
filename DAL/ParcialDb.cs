using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ParcialDb : DbContext
    {
        public ParcialDb() : base("ConStr")
        {

        }

        public DbSet<Retenciones> Retencion { get; set; }
        public DbSet<TiposEmails> TipoEmail { get; set; }
    }
}
