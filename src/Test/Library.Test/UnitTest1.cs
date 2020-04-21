using NUnit.Framework;

namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string fecha="03/20/1998";
            string final= "1998-20-03";
            Assert.AreEqual(final,Library.DateFormat.FechaConBarras_RetornaFechaInvertidaConGuiones(fecha));    
        }
        [Test]
        public void Test2()
        {
            string fecha="03/20/1998";
            string final= "03-20-1998";
            Assert.AreEqual(final,Library.ParaTest2.FechaConBarras_FechaConGuiones(fecha));

        }
        

    }
}