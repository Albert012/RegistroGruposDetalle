using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using RegistroGrupoDetalle.Entidades;
namespace RegistroGrupoDetalle.UI.Consultas
{
    public partial class cConsultaGrupo : Form
    {
        public cConsultaGrupo()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtro = g => true;
            int id;

            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0://Buscar Sin Filtro
                    filtro = g => g.Fecha >= Desde_dateTimePicker.Value.Date && g.Fecha <= Hasta_dateTimePicker.Value.Date;
                    break;
                case 1://GrupoId
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = g => (g.GrupoId.Equals(id)) && (g.Fecha >= Desde_dateTimePicker.Value.Date && g.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 2://Descripcion
                    filtro = g => (g.Descripcion.Contains(Criterio_textBox.Text)) && (g.Fecha >= Desde_dateTimePicker.Value.Date && g.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 3://Cantidad
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = g => (g.Cantidad.Equals(id)) && (g.Fecha >= Desde_dateTimePicker.Value.Date && g.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 4://Grupos
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = g => (g.Grupo.Equals(id)) && (g.Fecha >= Desde_dateTimePicker.Value.Date && g.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 5://Integrantes
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = g => (g.Integrantes.Equals(id)) && (g.Fecha >= Desde_dateTimePicker.Value.Date && g.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;

            }

            ConsultaDataGridView.DataSource = BLL.GruposBLL.GetList(filtro);





        }
    }
}
