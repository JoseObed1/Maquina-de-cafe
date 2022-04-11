using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_cafe
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public void SetCantidadDeCafe(int cantidad)
        {
            cantidadCafe = cantidad;
        }

        public int GetCantidadDeCafe()
        {
            return cantidadCafe;
        }

        public bool HasCafe(int cantidadCafe)
        {
            if (this.cantidadCafe >= cantidadCafe)
            {
                return true;
            }
            return false;
        }

        public bool GiveCafe(int cantidadCafe)
        {
            if (HasCafe(cantidadCafe))
            {
                this.cantidadCafe -= cantidadCafe;
                return true;
            }
            return false;
        }

    }
}
