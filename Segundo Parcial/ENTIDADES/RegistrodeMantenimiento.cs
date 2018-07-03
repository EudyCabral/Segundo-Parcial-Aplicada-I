using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Segundo_Parcial.ENTIDADES
{
    public class RegistrodeMantenimiento
    {
        [Key]
        public int MantenimientoId { get; set; }
        public DateTime Fecha { get; set; }

   

    [StringLength(100)]
        public string Taller { get; set; }

        public virtual ICollection<RegistrodeMantenimientoDetalle> Detalle { get; set; }

    public RegistrodeMantenimiento()
    {
        this.Detalle = new List<RegistrodeMantenimientoDetalle>();

    }

    public void AgregarDetalle(int id, int mantenimientoId, int vehiculoId, string servicio, int cantidad, int precio, int importe)
    {
        this.Detalle.Add(new RegistrodeMantenimientoDetalle(id,mantenimientoId,vehiculoId,servicio,cantidad,precio, importe));
    }
}
}
