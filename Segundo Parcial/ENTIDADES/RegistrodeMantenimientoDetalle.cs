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
        public int TallerId { get; set; }
        public int ArticulosId { get; set; } 
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        
        [ForeignKey("ArticulosId")]
        public virtual RegistrodeArticulos RegistrodeArticulos { get; set; }

        public RegistrodeMantenimientoDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
        }

        public RegistrodeMantenimientoDetalle(int id, int mantenimientoId , int tallerId, int articulosId,string articulo, int cantidad,decimal precio, decimal importe) 
        {
            Id = id;
            MantenimientoId = mantenimientoId;
         
            TallerId = tallerId;
            ArticulosId = articulosId;
       
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
        
      

        public RegistrodeMantenimientoDetalle( int mantenimientoId, int articulosId,string articulo, int cantidad, decimal precio, decimal importe)
        {
           
            MantenimientoId = mantenimientoId;
            ArticulosId = articulosId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
