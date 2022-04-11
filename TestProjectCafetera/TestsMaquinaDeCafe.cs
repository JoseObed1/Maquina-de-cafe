using NUnit.Framework;
using Maquina_de_cafe;

namespace TestProjectCafetera
{
    public class TestsMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMedianos;
        Vaso vasosGrandes;
        Azucarero azucarero;
        MaquinaDeCafe maquina;


        [SetUp]
        public void Setup()
        {
            cafetera = new(50);
            vasosPequenos = new(5, 10);
            vasosMedianos = new(5, 20);
            vasosGrandes = new(5, 30);
            azucarero = new(20);

            maquina = new();
            maquina.SetCafetera(cafetera);
            maquina.SetVasosPequeno(vasosPequenos);
            maquina.SetVasosMediano(vasosMedianos);
            maquina.SetVasosGrande(vasosGrandes);
            maquina.SetAzucarero(azucarero);
        }

        [Test]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            Assert.AreEqual(vasosPequenos, vaso);
        }

        [Test]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquina.GetTipoVaso("mediano");
            Assert.AreEqual(vasosMedianos, vaso);
        }

        [Test]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquina.GetTipoVaso("grande");
            Assert.AreEqual(vasosGrandes, vaso);
        }

        [Test]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 10, 2);

            Assert.AreEqual("No hay vasos", resultado);
        }

        [Test]
        public void DeberiaDevolverNoHayCafe()
        {
            cafetera = new(5);
            maquina.SetCafetera(cafetera);

            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 1, 2);

            Assert.AreEqual("No hay cafe", resultado);
        }

        [Test]
        public void DeberiaDevolverNoHayAzucar()
        {
            azucarero = new(2);
            maquina.SetAzucarero(azucarero);

            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("No hay azucar", resultado);
        }

        [Test]
        public void DeberiaRestarCafe()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            maquina.GetVasoDeCafe(vaso, 1, 3);

            int resultado = maquina.GetCafetera().GetCantidadDeCafe();

            Assert.AreEqual(40, resultado);
        }

        [Test]
        public void DeberiaRestarVaso()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            maquina.GetVasoDeCafe(vaso, 1, 3);

            int? resultado = maquina.GetCantidadVasos("pequeño");

            Assert.AreEqual(4, resultado);
        }

        [Test]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            maquina.GetVasoDeCafe(vaso, 1, 1);
            maquina.GetCantidadVasos("pequeño");

            int result = maquina.GetAzucarero().GetCantidadDeAzucar();

            Assert.AreEqual(19, result);
        }

        [Test]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquina.GetTipoVaso("pequeño");
            string resultado = maquina.GetVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("Felicidades", resultado);
        }

    }
}