using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Segundo_Parcial.ENTIDADES
{
    public class Vehiculos          
    {
        [Key]
        public int VehiculosId { get; set; }
        public string Descripcion { get; set; }
        public int Mantenimiento { get; set; }

        public Vehiculos()
        {
            VehiculosId = 0;
            Descripcion = string.Empty;
            Mantenimiento = 0;
        }
    }
}
