using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Segundo_Parcial.ENTIDADES
{
    public class RegistrodeMantenimientoDetalle
    {
        [Key]

        public int Id { get; set; }
        public int MantenimientoId { get; set; }
        public int VehiculoId { get; set; }
        public string Servicio { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
        

        [ForeignKey("VehiculoId")]
        public virtual Vehiculos vehiculos { get; set; }

        public RegistrodeMantenimientoDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
        }

  
        public RegistrodeMantenimientoDetalle(int id, int mantenimientoId, int vehiculoId, string servicio, int cantidad, int precio, int importe)
        {
            Id = id;
            MantenimientoId = mantenimientoId;
            VehiculoId = vehiculoId;
            Servicio = servicio;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }

        public RegistrodeMantenimientoDetalle( int mantenimientoId, int vehiculoId, string servicio, int cantidad, int precio, int importe)
        {
           
            MantenimientoId = mantenimientoId;
            VehiculoId = vehiculoId;
            Servicio = servicio;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }


    }
}
