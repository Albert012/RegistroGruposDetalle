using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using RegistroGrupoDetalle.Entidades;

namespace RegistroGrupoDetalle.UI.Consultas
{
    public partial class cPersonas : Form
    {
        public cPersonas()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            Expression<Func<Personas, bool>> filtro = p => true;
            int id;

            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0://Buscar Sin Filtro
                    filtro = p => p.Fecha >= Desde_dateTimePicker.Value.Date && p.Fecha <= Hasta_dateTimePicker.Value.Date;
                    break;
                case 1://PersonasId
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = p => (p.PersonaId.Equals(id)) && (p.Fecha >= Desde_dateTimePicker.Value.Date && p.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 2://Nombres
                    filtro = p => (p.Nombres.Contains(Criterio_textBox.Text)) && (p.Fecha >= Desde_dateTimePicker.Value.Date && p.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 3://Direccion                    
                    filtro = p => (p.Direccion.Contains(Criterio_textBox.Text)) && (p.Fecha >= Desde_dateTimePicker.Value.Date && p.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 4://Cedula
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = p => (p.Cedula.Equals(id)) && (p.Fecha >= Desde_dateTimePicker.Value.Date && p.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;
                case 5://Telefono
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = p => (p.Telefono.Equals(id)) && (p.Fecha >= Desde_dateTimePicker.Value.Date && p.Fecha <= Hasta_dateTimePicker.Value.Date);
                    break;

            }

            ConsultaDataGridView.DataSource = BLL.PersonasBLL.GetList(filtro);


        }
    }
}
