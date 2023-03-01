using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEmpleado
{
    internal class ClsEmpleado
    {
        //variables
        private string nombre;
        private double sueldo;

        //Metodos
        public void CargarDatos()
        {
            Console.WriteLine("Por favor digite su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor digite su sueldo");
            sueldo = double.Parse(Console.ReadLine());

        }

        public void ImprimirDatos()
        {
            Console.WriteLine(nombre + " " + "su sueldo es " + " " + sueldo);
        }

        public void PagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }
    }
}
