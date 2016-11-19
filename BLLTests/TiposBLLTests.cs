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
    public class TiposBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            TipoUsuarios tu = new TipoUsuarios();
            Assert.IsTrue(TiposBLL.Insertar(tu));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            var tu = new TipoUsuarios();
            Assert.IsNotInstanceOfType(tu.GetType(), typeof(TipoUsuarios));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var expected = new TipoUsuarios { Id = 1, NomTipo = "test" };
            var actual = new TipoUsuarios { Id = 2, NomTipo = "nose" };
            Assert.AreNotEqual<TipoUsuarios>(expected, actual);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(TiposBLL.GetList().Count > 0);
        }

        [TestMethod()]
        public void GetListTest1()
        {
            TipoUsuarios tu = new TipoUsuarios();
            tu.Id = 1;
            Assert.IsNotNull(TiposBLL.GetList(tu.Id).Count == 1);
        }
    }
}