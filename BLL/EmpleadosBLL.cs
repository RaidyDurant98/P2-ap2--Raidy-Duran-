using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Entidades.Empleados empleado)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.Guardar(empleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(Entidades.Empleados empleado)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.Eliminar(empleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(Entidades.Empleados empleado)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.Modificar(empleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static Entidades.Empleados Buscar(Expression<Func<Entidades.Empleados, bool>> criterio)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.Buscar(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Empleados> GetList(Expression<Func<Entidades.Empleados, bool>> criterio)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Empleados> GetListAll()
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.GetListAll();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
