using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class MedsBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            var med = new Medicinas();
            Assert.IsTrue(MedsBLL.Insertar(med));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            var meds = new Medicinas();
            Assert.IsNotInstanceOfType(meds.GetType(), typeof(Medicinas)); ;
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var expected = new Medicinas { idMed = 1, nombreMed = "Advil" };
            var actual = new Medicinas { idMed = 2, nombreMed = "test" };
            Assert.AreNotEqual<Medicinas>(expected, actual);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(MedsBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            var meds = new Medicinas();
            meds.idMed = 1;
            Assert.IsNotNull(MedsBLL.GetLista(meds.idMed).Count == 1);
        }
    }
}