using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegistroGrupoDetalle.Entidades;

namespace RegistroGrupoDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupos { get; set; }

        public DbSet<Personas> Personas { get; set; }

        public Contexto() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
