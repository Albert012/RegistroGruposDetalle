using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Entity;
using RegistroGrupoDetalle.DAL;
using RegistroGrupoDetalle.Entidades;


namespace RegistroGrupoDetalle.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Grupos.Add(grupo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Grupos grupo)
        {
            bool paso = true;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(grupo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Grupos grupo = contexto.Grupos.Find(id);
                contexto.Grupos.Remove(grupo);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Grupos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Grupos grupo = new Grupos();

            try
            {
                grupo = contexto.Grupos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return grupo;
        }

        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> grupos = new List<Grupos>();
            Contexto contexto = new Contexto();

            try
            {
                grupos = contexto.Grupos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return grupos;
        }

        public static Decimal CalcularIntegrantes(Decimal cantidad, Decimal grupo)
        {
            return cantidad / grupo;
        }


    }
}
