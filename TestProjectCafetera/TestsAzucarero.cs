using NUnit.Framework;
using Maquina_de_cafe;

namespace TestProjectCafetera
{
    public class TestsAzucarero
    {
        Azucarero azucarero;
        [SetUp]
        public void Setup()
        {
            azucarero = new(10);
        }

        [Test]
        public void TestHayAzucar()
        {
            Assert.IsTrue(azucarero.HasAzucar(10));
        }

        [Test]
        public void TestRestarAzucar()
        {
            azucarero.GiveAzucar(3);
            Assert.AreEqual(7, azucarero.GetCantidadDeAzucar());
        }

        [Test]
        public void TestNoHayAzucar()
        {
            Assert.IsFalse(azucarero.HasAzucar(15));
        }

    }
}
