using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroGrupoDetalle.BLL;
using RegistroGrupoDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroGrupoDetalle.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Personas persona = new Personas();
            persona.PersonaId = 2;
            persona.Nombres = "Albert De Jesus Rosario";
            persona.Direccion = "La Bomba De Cenovi, El Canal";
            persona.Cedula = "056-0181541-7";
            persona.Telefono = "829-208-3210";

            paso = BLL.PersonasBLL.Guardar(persona);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Personas persona = new Personas();
            persona.PersonaId = 1;
            persona.Nombres = "Albert De Jesus Rosario Mendoza";
            persona.Direccion = "La Bomba De Cenovi, El Canal, cjon. Cuba";
            persona.Cedula = "056-0181541-7";
            persona.Telefono = "829-208-3210";

            paso = BLL.PersonasBLL.Guardar(persona);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = BLL.PersonasBLL.Eliminar(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Personas persona = new Personas();
            persona = BLL.PersonasBLL.Buscar(1);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = BLL.PersonasBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}