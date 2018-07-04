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
    public class RegistrodeMantenimientoBLL
    {
        public static bool Guardar(RegistrodeMantenimiento registrodeMantenimiento )
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.registrodeMantenimientos.Add(registrodeMantenimiento) != null)
                {

                    foreach (var item in registrodeMantenimiento.Detalle)
                    {
                        contexto.registroEntradaDeArticulos.Find(item.EntradaId).Cantidad -= item.Cantidad;
                    }

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
                RegistrodeMantenimiento registrodeMantenimiento = contexto.registrodeMantenimientos.Find(id);


                if (registrodeMantenimiento != null)
                {
                    foreach (var item in registrodeMantenimiento.Detalle)
                    {
                        var ENTRADA = contexto.registroEntradaDeArticulos.Find(item.EntradaId);
                        ENTRADA.Cantidad += item.Cantidad;
                    }

                    registrodeMantenimiento.Detalle.Count();
                    contexto.registrodeMantenimientos.Remove(registrodeMantenimiento);
                }




                if (contexto.SaveChanges() > 0)
                {

                    paso = true;
                }
                contexto.Dispose();


            }
            catch (Exception) { throw; }
            return paso;
        }


       

        public static RegistrodeMantenimiento Buscar(int id)
        {
            RegistrodeMantenimiento registrodeMantenimiento = new RegistrodeMantenimiento();
            Contexto contexto = new Contexto();

            try
            {
                registrodeMantenimiento = contexto.registrodeMantenimientos.Find(id);
                if (registrodeMantenimiento != null)
                {
                    registrodeMantenimiento.Detalle.Count();

                    foreach (var item in registrodeMantenimiento.Detalle)
                    {

                        string s = item.RegistroEntradaDeArticulos.Articulos;
                    }

                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registrodeMantenimiento;
        }

        public static bool Editar(RegistrodeMantenimiento registrodeMantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var Mantenimiento = BLL.RegistrodeMantenimientoBLL.Buscar(registrodeMantenimiento.MantenimientoId);


                if (Mantenimiento != null)
                {


                    foreach (var item in Mantenimiento.Detalle) 
                    {
                       
                        contexto.registroEntradaDeArticulos.Find(item.EntradaId).Cantidad -= item.Cantidad;


                       
                        if (!registrodeMantenimiento.Detalle.ToList().Exists(v => v.Id == item.Id))
                        {
                            contexto.registroEntradaDeArticulos.Find(item.EntradaId).Cantidad += item.Cantidad;

                            item.RegistroEntradaDeArticulos= null; 
                            contexto.Entry(item).State = EntityState.Deleted;
                        }




                    }


                    foreach (var item in registrodeMantenimiento.Detalle)
                    {
                        
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }

                    contexto.Entry(registrodeMantenimiento).State = EntityState.Modified;
                }
              


                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }



        public static List<RegistrodeMantenimiento> GetList(Expression<Func<RegistrodeMantenimiento, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<RegistrodeMantenimiento> registrodeMantenimientos = new List<RegistrodeMantenimiento>();

            try
            {
                registrodeMantenimientos = contexto.registrodeMantenimientos.Where(expression).ToList();

                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return registrodeMantenimientos;

        }

        public static decimal CalcularImporte(decimal precio, int cantidad)
        {
            return Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
        }

        

    }
}
