using Segundo_Parcial.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace Segundo_Parcial.DAL
{
   public class Contexto : DbContext
   {

        public DbSet<Vehiculos> vehiculos { get; set; }
        public DbSet<RegistrodeMantenimiento>  registrodeMantenimientos { get; set; }
        public DbSet<RegistrodeMantenimientoDetalle> Detalles { get; set; }
        public Contexto() : base("ConStr")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

   }

}
