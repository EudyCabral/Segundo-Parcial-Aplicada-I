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

        public static string RetornarDescripcion(string nombre)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Articulos.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Articulos;
            }

            return descripcion;
        }
    }
}
