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
    public class RegistrodeArticulosBLL
    {
        public static bool Guardar(RegistrodeArticulos registrodeArticulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.registrodeArticulos.Add(registrodeArticulos) != null)
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
               RegistrodeArticulos registrodeArticulos = contexto.registrodeArticulos.Find(id);

                if (registrodeArticulos != null)
                {
                    contexto.Entry(registrodeArticulos).State = EntityState.Deleted;
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



        public static bool Editar(RegistrodeArticulos registrodeArticulos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(registrodeArticulos).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static RegistrodeArticulos Buscar(int id)
        {

            RegistrodeArticulos registrodeArticulos = new RegistrodeArticulos();
            Contexto contexto = new Contexto();

            try
            {
                registrodeArticulos = contexto.registrodeArticulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registrodeArticulos;

        }



        public static List<RegistrodeArticulos> GetList(Expression<Func<RegistrodeArticulos, bool>> expression)
        {
            List<RegistrodeArticulos> registro = new List<RegistrodeArticulos>();
            Contexto contexto = new Contexto();

            try
            {
                registro = contexto.registrodeArticulos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return registro;
        }


        public static decimal CalcularCosto(decimal Ganancia,decimal precio)
        {
            
                Ganancia /= 100;

                return Convert.ToDecimal(precio) * Convert.ToDecimal(Ganancia);
        
           
        }

        public static decimal CalcularGanancia(decimal Costo,decimal Precio)
        {
            decimal pg = Precio - Costo;



            return (Convert.ToDecimal(pg) / Convert.ToDecimal(Costo)) * 100;
          
           

        }

        public static decimal CalcularPrecio(decimal Costo, decimal Ganancia)
        {
           
                Ganancia /= 100;
                Ganancia *= Costo;
                return Convert.ToDecimal(Costo) + Convert.ToDecimal(Ganancia);
            
       
        }

        public static string RetornarDescripcion(string nombre)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Descripcion.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Descripcion;
            }

            return descripcion;
        }


    }
}
