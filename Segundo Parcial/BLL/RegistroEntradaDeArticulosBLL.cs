using Segundo_Parcial.DAL;
using Segundo_Parcial.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Segundo_Parcial.BLL
{
    public class RegistroEntradaDeArticulosBLL
    {
        public static bool Guardar(RegistroEntradaDeArticulos registroEntradaDeArticulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


            try
            {

                    if (contexto.registroEntradaDeArticulos.Add(registroEntradaDeArticulos) != null)
                {

                    RegistrodeArticulos articulo = BLL.RegistrodeArticulosBLL.Buscar(registroEntradaDeArticulos.ArticuloId);
                    articulo.Inventario += registroEntradaDeArticulos.Cantidad;
                   BLL.RegistrodeArticulosBLL.Editar(articulo);

                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                RegistroEntradaDeArticulos registroEntradaDeArticulos = contexto.registroEntradaDeArticulos.Find(id);

                if (registroEntradaDeArticulos != null)
                {
                    RegistrodeArticulos articulo = BLL.RegistrodeArticulosBLL.Buscar(registroEntradaDeArticulos.ArticuloId);
                    articulo.Inventario -= registroEntradaDeArticulos.Cantidad;
                    BLL.RegistrodeArticulosBLL.Editar(articulo);

                    contexto.Entry(registroEntradaDeArticulos).State = EntityState.Deleted;
                }


                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception) { throw; }

            return paso;
        }



        public static bool Editar(RegistroEntradaDeArticulos registroEntradaDeArticulos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                RegistroEntradaDeArticulos EntradaAnterior = BLL.RegistroEntradaDeArticulosBLL.Buscar(registroEntradaDeArticulos.EntradaId);

                //identificar la diferencia ya sea restada o sumada
                int diferencia;

                diferencia = registroEntradaDeArticulos.Cantidad - EntradaAnterior.Cantidad;

                //aplicar diferencia al inventario
                RegistrodeArticulos articulo = BLL.RegistrodeArticulosBLL.Buscar(registroEntradaDeArticulos.ArticuloId);
                articulo.Inventario += diferencia;
                BLL.RegistrodeArticulosBLL.Editar(articulo);

                contexto.Entry(registroEntradaDeArticulos).State = EntityState.Modified;

       

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }



                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }




        public static RegistroEntradaDeArticulos Buscar(int id)
        {

            RegistroEntradaDeArticulos registroEntradaDeArticulos = new RegistroEntradaDeArticulos();
            Contexto contexto = new Contexto();

            try
            {
                registroEntradaDeArticulos = contexto.registroEntradaDeArticulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registroEntradaDeArticulos;

        }



        public static List<RegistroEntradaDeArticulos> GetList(Expression<Func<RegistroEntradaDeArticulos, bool>> expression)
        {
            List<RegistroEntradaDeArticulos> ENTRADA = new List<RegistroEntradaDeArticulos>();
            Contexto contexto = new Contexto();

            try
            {
                ENTRADA = contexto.registroEntradaDeArticulos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return ENTRADA;
        }

       
    }
}
