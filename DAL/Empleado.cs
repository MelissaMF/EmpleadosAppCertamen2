using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Empleado
    {
        public Empleado() { }
        public Empleado(int id, string nombre, string apellido, DateTime fechanacimiento, string departamento, float salario) {

            this.ID = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechanacimiento;
            this.Departamento = departamento;
            this.Salario = salario;


        }

        public Empleado(string nombre, string apellido, DateTime fechanacimiento, string departamento, float salario)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechanacimiento;
            this.Departamento = departamento;
            this.Salario = salario;


        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public DateTime FechaNacimiento { get; set;}
        public string Departamento { get;set;}
        public float Salario { get; set;}
    
    }
}
