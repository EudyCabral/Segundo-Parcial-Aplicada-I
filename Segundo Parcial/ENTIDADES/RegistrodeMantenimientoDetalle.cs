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
        public int TallerId { get; set; }
        public int ArticulosId { get; set; }
        public int EntradaId { get; set; }

        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
        

        [ForeignKey("EntradaId")]
        public virtual RegistroEntradaDeArticulos RegistroEntradaDeArticulos { get; set; }

        public RegistrodeMantenimientoDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
        }

        public RegistrodeMantenimientoDetalle(int id, int mantenimientoId, int vehiculoId, int tallerId, int articulosId, int entradaId,string articulo, int cantidad, int precio, int importe) 
        {
            Id = id;
            MantenimientoId = mantenimientoId;
            VehiculoId = vehiculoId;
            TallerId = tallerId;
            ArticulosId = articulosId;
            EntradaId = entradaId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
        
      

        public RegistrodeMantenimientoDetalle(int articulosId,string articulo, int cantidad, int precio, int importe)
        {
            ArticulosId = articulosId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
