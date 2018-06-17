using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroGrupoDetalle.Entidades;
using RegistroGrupoDetalle.DAL;

namespace RegistroGrupoDetalle.UI.Registros
{
    public partial class rGruposDetalle : Form
    {
        public rGruposDetalle()
        {
            InitializeComponent();
            LlenaCombobox();
        }       
       
        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            idNumericUpDown.Value = 0;
            Fecha_dateTimePicker.Value = DateTime.Now;
            Comentarios_textBox.Clear();
            DetalleDataGridView.DataSource = null;
            ValidarErrorProvider.Clear();
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idNumericUpDown.Value);
            Grupos grupo = BLL.GruposBLL.Buscar(id);

            if (grupo != null)
            {
                LlenaCampos(grupo);
            }
            else
                MessageBox.Show("No Se Encontro!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private bool Validar()
        {
            bool CamposVacios = true;

            if(string.IsNullOrWhiteSpace(Comentarios_textBox.Text))
            {
                ValidarErrorProvider.SetError(Comentarios_textBox,"No Debe Dejar El Comentario Vacio");
                CamposVacios = false;

            }
            if(DetalleDataGridView.RowCount == 0)
            {
                ValidarErrorProvider.SetError(DetalleDataGridView,"Es Obligatorio Seleccionar La Personas");
                CamposVacios = false;
            }
            return CamposVacios;
        }

        private void LlenaCombobox()
        {
            Repositorio<Personas> repositorio = new Repositorio<Personas>(new Contexto());
            Persona_comboBox.DataSource = repositorio.GetList(p => true);
            Persona_comboBox.ValueMember = "PersonaId";
            Persona_comboBox.ValueMember = "Nombres";

        }

        private void LlenaCampos(Grupos grupo)
        {
            idNumericUpDown.Value = grupo.GrupoId;
            Fecha_dateTimePicker.Value = grupo.Fecha;
            Comentarios_textBox.Text = grupo.Comentarios;
            //cargar el detalle al grid
            DetalleDataGridView.DataSource = grupo.Detalle;

            //ocultar columnas
            DetalleDataGridView.Columns["Id"].Visible = false;
            DetalleDataGridView.Columns["PersonaId"].Visible = false;

        }

        private Grupos LlenaClase()
        {
            Grupos grupo = new Grupos();
            grupo.GrupoId = Convert.ToInt32(idNumericUpDown.Value);
            grupo.Fecha = Fecha_dateTimePicker.Value.Date;
            grupo.Comentarios = Comentarios_textBox.Text;

            //agregar cada linea al grid del detalle
            foreach (DataGridViewRow item in DetalleDataGridView.Rows)
            {
                grupo.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["GrupoId"].Value),
                    ToInt(item.Cells["PersonaId"].Value)
                    );
            }

            return grupo;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Grupos grupo;
            bool paso = false;

            if(Validar())
            {
                MessageBox.Show("Debe Revisar Que Todos Los Campos Esten Debidamente Llenos", "Fallo en Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            grupo = LlenaClase();

            if (idNumericUpDown.Value == 0)
                paso = BLL.GruposBLL.Guardar(grupo);
            else
                paso = BLL.GruposBLL.Modificar(grupo);

            if(paso)
            {
                Nuevo_button.PerformClick();
                MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Se Pudo Guardar Correctamente", "Fallo Al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Borrar_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idNumericUpDown.Value);

            if(BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No Se Pudo Eliminar Correctamente", "Fallo Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            List<GruposDetalle> detalle = new List<GruposDetalle>();

            if(DetalleDataGridView.DataSource != null)
            {
                detalle = (List<GruposDetalle>)DetalleDataGridView.DataSource;
            }

            //agregar nuevo detalle con los datos
            detalle.Add(
                new GruposDetalle(
                    id: 0, 
                    grupoId: (int)idNumericUpDown.Value, 
                    personaId: (int)Persona_comboBox.SelectedValue
                   ));
            //cargar el detalle al grid
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = detalle;

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            if(DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                //convertir el grid en lista
                List<GruposDetalle> detalle = (List<GruposDetalle>)DetalleDataGridView.DataSource;

                //remover fila
                detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);

                //cargar el detalle al grid
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = detalle;
            }
        }
    }
}
