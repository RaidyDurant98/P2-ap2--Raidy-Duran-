using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
        public int RetencionId { get; set; }

        public virtual List<Retenciones> Retenciones { get; set; }

        public Empleados()
        {
            Retenciones = new List<Entidades.Retenciones>();
        }
    }
}
