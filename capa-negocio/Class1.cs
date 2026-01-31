using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class EmpleadosNegocio
    {
        private EmpleadoDatos datos = new EmpleadoDatos();

        public bool ValidarEmpleado( Empleados emp)
        {
            if (string.IsNullOrWhiteSpace(emp.Id)) return false;
            if (string.IsNullOrWhiteSpace(emp.Nombre)) return false;
            if (string.IsNullOrWhiteSpace(emp.Apellidos)) return false;
            if (string.IsNullOrWhiteSpace(emp.Direccion)) return false;
            if (string.IsNullOrWhiteSpace(emp.Telefono)) return false;
            if (string.IsNullOrWhiteSpace(emp.Email)) return false;
            if (string.IsNullOrWhiteSpace(emp.Cargo)) return false;
            if (emp.Salario <= 0) return false;
            if (string.IsNullOrWhiteSpace(emp.Genero)) return false;

            return true;
        }

        public void Guardar(string ruta, Empleados emp)
        {
            datos.GuardarArchivo(ruta, emp);
        }
    }
}

