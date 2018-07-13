﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Segundo_Parcial.ENTIDADES
{
    public class RegistrodeArticulos
    {
        [Key]

        public int ArticulosId { get; set; }
        public string Descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal Ganancia { get; set; }
        public decimal precio { get; set; }
        public int Inventario { get; set; }

        public RegistrodeArticulos()
        {
            ArticulosId =0;
            Descripcion =string.Empty;
            this.costo = 0;
            Ganancia = 0;
            this.precio = 0;
            Inventario = 0;
        }

      

         public override string ToString()
         {
             return this.Descripcion;
         }

    }
}
