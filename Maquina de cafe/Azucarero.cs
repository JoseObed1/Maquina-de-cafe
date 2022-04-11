using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_cafe
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public void SetCantidadDeAzucar(int cantidad)
        {
            cantidadDeAzucar = cantidad;
        }
         
        public int GetCantidadDeAzucar()
        {
            return cantidadDeAzucar;
        }

        public bool HasAzucar(int cantidad)
        {
            if (cantidad <= cantidadDeAzucar)
            {
                return true;
            }
            return false;
        }

        public bool GiveAzucar(int cantidad)
        {
            if (HasAzucar(cantidad))
            {
                cantidadDeAzucar -= cantidad;
                return true;
            }
            return false;
        }

    }
}
