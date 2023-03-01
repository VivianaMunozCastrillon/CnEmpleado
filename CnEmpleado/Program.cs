using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEmpleado
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha: 26/02/2023
        /// Descripcion: Este programa solicita el nombre y sueldo de un empleado e imprime los datos ingresados y si debe pagar impuestos.
        /// </summary>
        static void Main(string[] args)
        {
            //Instancia de clase
            ClsEmpleado persona = new ClsEmpleado();

            //Llamada de metodos
            persona.CargarDatos();
            persona.ImprimirDatos();
            persona.PagarImpuestos();



            Console.ReadKey();
        }
    }
}
