using NUnit.Framework;
using Maquina_de_cafe;

namespace TestProjectCafetera
{
    public class TestsVaso
    {
        [Test]
        public void TestHayVasos()
        {
            Vaso vaso = new(5, 5);
            bool result = vaso.HasVasos(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestNoHayVasos()
        {
            Vaso vaso = new(5, 5);
            bool result = vaso.HasVasos(6);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestRestarVasos()
        {
            Vaso vaso = new(5, 5);
            vaso.GiveVasos(1);
            Assert.AreEqual(4, vaso.GetCantidadVasos());
        }

    }
}