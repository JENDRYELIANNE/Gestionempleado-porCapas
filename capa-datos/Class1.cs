using capa_entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capa_datos
{
    public class EmpleadoDatos
    {
        public void GuardarArchivo(string ruta, Empleados emp)
        {

            using (StreamWriter sw = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                sw.WriteLine("ID | Nombre | Apellidos | Dirección | Teléfono | Email | Cargo | Salario | Fecha Ingreso | Género");
                sw.WriteLine("-----------------------------------------------------------------------------------------------");

                sw.WriteLine(
                    $"{emp.Id} | {emp.Nombre} | {emp.Apellidos} | {emp.Direccion} | {emp.Telefono} | " +
                    $"{emp.Email} | {emp.Cargo} | {emp.Salario} | {emp.FechaIngreso.ToShortDateString()} | {emp.Genero}"
                );
            }
        }

        public string LeerArchivo(string ruta)
        {
            return File.ReadAllText(ruta);
        }
    }
}
