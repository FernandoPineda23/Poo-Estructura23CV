using Poo_Estructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Estructura.Services
{
    public class AlumnoService
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno alumno = new Alumno()
                {
                    Id = 1,
                    Name = "Fernando",
                    apellido = "Pineda",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 9.5,
                };
                return alumno;
            }
            catch (Exception ex)
            {
                throw new Exception("sucedio un error" + ex.Message);
            }
            
        }
        public bool ValidarProm
    }
}
