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
        public int costo { get; set; }
        public int Ganancia { get; set; }
        public int precio { get; set; }
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

       
    }
}
