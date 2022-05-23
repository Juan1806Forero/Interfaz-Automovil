using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Deportivo
{
    static void main() { }
}
public class Camionetas
{
    static void main() { }
}

namespace Interfaz_Automovil_
{
    internal class Vehículo : Object
    {
        private string carro;
        private string bicicleta;

        public Vehículo() { }

        public Vehículo(String carro, String bicicleta)
        {
            this.carro = carro;
            this.bicicleta = bicicleta; 
        }
        public String getcarro() 
        {
            return carro;        
        }

        public void setcarro(String carro) 
        {
         this.carro=carro;
        }

        public String getbicicleta() 
        {
            return bicicleta;
        }

        public void setbicicleta(String bicicleta)
        {
            this.bicicleta=bicicleta;
        }
        

    }
}
