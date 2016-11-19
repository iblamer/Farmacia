using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using BLL;


namespace BLL.Tests
{
    [TestClass()]
    public class LaboratoriosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            var lab = new Laboratorios();
            Assert.IsTrue(LaboratoriosBLL.Insertar(lab));
        }

        [TestMethod()]
        public void BorrarTest()
        {
            var lab = new Laboratorios();
            Assert.IsNotInstanceOfType(lab.GetType(), typeof(Laboratorios));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var expected = new Laboratorios { labId = 1, labName = "Enel" };
            var actual = new Laboratorios { labId = 2, labName = "Fabio" };
            Assert.AreNotEqual<Laboratorios>(expected, actual);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(LaboratoriosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Laboratorios lab = new Laboratorios();
            lab.labId = 1;
            Assert.IsNotNull(LaboratoriosBLL.GetLista(lab.labId).Count == 1);
        }
    }
}