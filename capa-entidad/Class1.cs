using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class Empleados
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; } 
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Genero { get; set; }
    }
}
