using NUnit.Framework;
using Maquina_de_cafe;

namespace TestProjectCafetera
{
    public class TestsCafetera
    {
        [Test]
        public void TestHayCafe()
        {
            Cafetera cafetera = new(10);
            Assert.IsTrue(cafetera.HasCafe(5));
        }

        [Test]
        public void TestNoHayCafe()
        {
            Cafetera cafetera = new(10);
            Assert.IsFalse(cafetera.HasCafe(15));
        }

        [Test]
        public void TestRestarCafe()
        {
            Cafetera cafetera = new(10);
            cafetera.GiveCafe(1);
            Assert.AreEqual(9, cafetera.GetCantidadDeCafe());
        }

    }
}