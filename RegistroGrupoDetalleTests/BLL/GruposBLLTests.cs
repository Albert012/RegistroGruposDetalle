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
    public class GruposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            /*bool paso = false;
            Grupos grupo = new Grupos();
            grupo.GrupoId = 2;
            grupo.Descripcion = "Mate";
            grupo.Cantidad = 30;
            grupo.Grupo = 2;
            grupo.Integrantes = 15;

            paso = BLL.GruposBLL.Guardar(grupo);

            Assert.AreEqual(paso,true);*/

            Grupos grupo = new Grupos
            {
                Fecha = DateTime.Now,
                Comentarios = "Me Encanto"
            };

            grupo.Detalle.Add(new GruposDetalle(0,0,1));

            bool paso = BLL.GruposBLL.Guardar(grupo);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]
        public void ModificarTest()
        {
            /*bool paso = false;
            Grupos grupo = new Grupos();
            grupo.GrupoId = 1;
            grupo.Descripcion = "Matematica";
            grupo.Cantidad = 50;
            grupo.Grupo = 2;
            grupo.Integrantes = 25;

            paso = BLL.GruposBLL.Modificar2(grupo);

            Assert.AreEqual(paso, true);*/

            int idgrupo = BLL.GruposBLL.GetList(g => true)[0].GrupoId;
            Grupos grupo = BLL.GruposBLL.Buscar2(idgrupo);

            grupo.Detalle.Add(new GruposDetalle(0, grupo.GrupoId, 1));
            bool paso = BLL.GruposBLL.Modificar2(grupo);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = BLL.GruposBLL.Eliminar(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Grupos grupo = new Grupos();
            grupo = BLL.GruposBLL.Buscar2(1);
            Assert.IsNotNull(grupo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = BLL.GruposBLL.GetList(g => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void CalcularIntegrantesTest()
        {
            Grupos grupo = new Grupos();
            grupo = BLL.GruposBLL.Buscar2(1);

            grupo.Integrantes = BLL.GruposBLL.CalcularIntegrantes(grupo.Cantidad, grupo.Grupo);
            Assert.IsNotNull(grupo);
        }
    }
}