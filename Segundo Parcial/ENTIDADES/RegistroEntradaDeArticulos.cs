﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Segundo_Parcial.ENTIDADES
{
    public class RegistroEntradaDeArticulos
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }

 

        public RegistroEntradaDeArticulos()
        {
            

            EntradaId = 0;
            Fecha =DateTime.Now;
            ArticuloId = 0;
            Cantidad = 0;
        }

    

     
    }
}
