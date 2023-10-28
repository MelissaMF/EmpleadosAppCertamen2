using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoDAL
    {
        public bool GuardarEmpleado(Empleado empleado)
        {
            string fechanac = empleado.FechaNacimiento.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO empleado(nombre, apellido, fechanacimiento, departamento, salario) VALUES ('{empleado.Nombre}', '{empleado.Apellido}', '{fechanac}', {empleado.Departamento}, {empleado.Salario})";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0) {
                return false;
            }
            return true;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            string query = "SELECT * FROM empleado";
            DataTable dt = DatabaseHelper.Instance.ExecuteQuery(query);
            List<Empleado> empleados = new List<Empleado>();
            foreach (DataRow row in dt.Rows) { 
                Empleado e = new Empleado();
                e.Nombre = row["nombre"].ToString();
                e.Apellido = row["apellido"].ToString() ;
                e.FechaNacimiento = DateTime.Parse(row["fechanacimiento"].ToString();
                e.Departamento = row["departamento"].ToString();
                e.Salario = float.Parse(row["salario"].ToString());
                empleados.Add(e);
            }
            return empleados;
        }

        public bool EliminarEmpleado(int id)
        {
            string query = $"DELETE FROM empleado WHERE id = '{id}'";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;
        }
    }
}
