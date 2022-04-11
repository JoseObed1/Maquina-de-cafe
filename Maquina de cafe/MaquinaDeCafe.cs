using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_cafe
{
    public class MaquinaDeCafe
    {
        private Cafetera cafe;
        private Vaso vasosPequenos;
        private Vaso vasosMedianos;
        private Vaso vasosGrandes;
        private Azucarero azucar;


        public void SetCafetera(Cafetera cafetera)
        {
            cafe = cafetera;
        }

        public void SetVasosPequeno(Vaso vaso)
        {
            vasosPequenos = vaso;
        }

        public void SetVasosMediano(Vaso vaso)
        {
            vasosMedianos = vaso;
        }

        public void SetVasosGrande(Vaso vaso)
        {
            vasosGrandes = vaso;
        }

        public void SetAzucarero(Azucarero azucarero)
        {
            azucar = azucarero;
        }

        public Cafetera GetCafetera()
        {
            return cafe;
        }

        public Azucarero GetAzucarero()
        {
            return azucar;
        }

        public int GetCantidadCafe()
        {
            return cafe.GetCantidadDeCafe();
        }

        public int? GetCantidadVasos(string tipo)
        {
            switch (tipo)
            {
                case "pequeño":
                    return vasosPequenos.GetCantidadVasos();
                case "mediano":
                    return vasosMedianos.GetCantidadVasos();
                case "grande":
                    return vasosGrandes.GetCantidadVasos();
                default:
                    return null;
            }   
        }

        public Vaso GetTipoVaso(string tipo)
        {
            if(tipo == "pequeño")
            {
                return vasosPequenos;
            }

            if (tipo == "mediano")
            {
                return vasosMedianos;
            }

            if (tipo == "grande")
            {
                return vasosGrandes;
            }

            return null;
        }

        public dynamic GetVasoDeCafe(Vaso tipo, int cantidadDeVasos, int cantidadDeAzucar)
        {
            bool _vasos = tipo.GiveVasos(cantidadDeVasos);
            bool _azucar = azucar.GiveAzucar(cantidadDeAzucar);
            bool _cafe = cafe.GiveCafe(tipo.GetContenido());

            if (!_vasos)
            {
                return "No hay vasos";
            }

            if (!_azucar)
            {
                return "No hay azucar";
            }

            if (!_cafe)
            {
                return "No hay cafe";
            }

            tipo.SetContenido(1);

            return "Felicidades";
        }


    }
}
