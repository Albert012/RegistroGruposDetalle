using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistroGrupoDetalle.DAL
{
    public class Repositorio<T> :IDisposable, IRepository<T> where T : class
    {
        internal Contexto _contexto;

        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(T entity)
        {
            bool paso = false;

            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                    _contexto.SaveChanges();
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }


        public bool Modificar(T entity)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                if(_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }


        public bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);

                if(_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return paso;
        }


        public T Buscar(int id)
        {
            T entity;

            try
            {
                entity = _contexto.Set<T>().Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return entity;
        }

        public List<T> GetList(Expression<Func<T,bool>> expression)
        {
            List<T> lista = new List<T>();

            try
            {
                lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return lista;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

    }
}
