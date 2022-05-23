using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Automovil_
{
    internal class Deportivo : Especificaciones
    {
        private string _idDéportivo;
       
        public void Chasis_Fuerte()
        {
            Console.WriteLine("El chasis del coche es: ");
        }

        public void Motores_de_alta_potencia()
        {
            Console.WriteLine("El motor que tiene el coche es de: ");
        }

        public void Suspensión()
        {
            Console.WriteLine("Que tipo de suspesión desea: ");
        }

        public void Transmisión()
        {
            Console.WriteLine("La tranmisión del carro es:");
        }

        public void Uso()
        {
            Console.WriteLine("Este auto es mayormente usado para: ");
        }
    }
}
