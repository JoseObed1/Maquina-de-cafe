using System;

namespace Maquina_de_cafe
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadVasos, int contenido)
        {
            SetCantidadVasos(cantidadVasos);
            SetContenido(contenido);
        }

        public void SetCantidadVasos(int cantidad)
        {
            cantidadVasos = cantidad;
        }

        public int GetCantidadVasos()
        {
            return cantidadVasos;
        }

        public void SetContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int GetContenido()
        {
            return contenido;
        }

        public bool HasVasos(int cantidad)
        {
            if(cantidad <= cantidadVasos)
            {
                return true;
            }
            return false;
        }

        public bool GiveVasos(int cantidad)
        {
            if (HasVasos(cantidad))
            {
                cantidadVasos -= cantidad;
                return true;
            }
            return false;
            
        }

    }
}
