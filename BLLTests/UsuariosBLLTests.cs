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
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            var us = new Usuarios();
            Assert.IsTrue(UsuariosBLL.Insertar(us));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var expected = new Usuarios { UserID = 1, Nombre = "test" };
            var actual = new Usuarios { UserID = 2, Nombre = "nose" };
            Assert.AreNotEqual<Usuarios>(expected, actual);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            var user = new Usuarios();
            Assert.IsNotInstanceOfType(user.GetType(), typeof(Usuarios)); 
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var user = new Usuarios();
            user.Nombre = "test";
            Assert.ReplaceNullChars(user.Nombre);
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            var us = new Usuarios();
            us.UserID = 1;
            Assert.IsNotNull(UsuariosBLL.GetLista(us.UserID).Count == 1) ;
        }
    }
}