using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroGrupoDetalle.Entidades;



namespace RegistroGrupoDetalle.UI.Registros
{
    public partial class rGrupo : Form
    {
        public rGrupo()
        {
            InitializeComponent();
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            grupoIdNumericUpDown.Value = 0;
            fechaDateTimePicker.ResetText();
            descripcionTextBox.Clear();
            cantidadNumericUpDown.Value = 0;
            grupoNumericUpDown.Value = 0;
            integrantesNumericUpDown.Value = 0;
        }

        private bool Validar()
        {
            bool CamposLLeno = true;


            if (descripcionTextBox.Text == "")
            {
                ValidarErrorProvider.SetError(descripcionTextBox, "Debes Introducir La Descripcion Del Estudiante");
                CamposLLeno = false;
            }
            else
                if (cantidadNumericUpDown.Value == 0)
            {
                ValidarErrorProvider.SetError(cantidadNumericUpDown, "Debes Ingresar La Cantidad De Estudiantes");
                CamposLLeno = false;
            }
            else
                if (grupoNumericUpDown.Value == 0)
            {
                ValidarErrorProvider.SetError(grupoNumericUpDown, "Debes Ingresar La Cantidad De Grupos Deseados");
                CamposLLeno = false;
            }


            return CamposLLeno;
        }

        private Grupos LlenaClase()
        {
            Grupos grupo = new Grupos();

            grupo.GrupoId = Convert.ToInt32(grupoIdNumericUpDown.Value);
            grupo.Fecha = fechaDateTimePicker.Value.Date;
            grupo.Descripcion = descripcionTextBox.Text;
            grupo.Cantidad = Convert.ToInt32(cantidadNumericUpDown.Value);
            grupo.Grupo = Convert.ToInt32(grupoNumericUpDown.Value);
            grupo.Integrantes = Convert.ToInt32(integrantesNumericUpDown.Value);


            return grupo;
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Grupos grupo = LlenaClase();

            if (Validar())
            {


                if (grupoIdNumericUpDown.Value == 0)
                {
                    paso = BLL.GruposBLL.Guardar(grupo);
                }
                else
                {
                    paso = BLL.GruposBLL.Modificar2(grupo);
                }

                if (paso)
                    MessageBox.Show("Guardado Correctamente", "Exito Al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Se Pudo Guardar", "Fallo Al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            int GrupoId = Convert.ToInt32(grupoIdNumericUpDown.Value);

            if (BLL.GruposBLL.Eliminar(GrupoId))
            {
                MessageBox.Show("Eliminado Correctamente", "Exito Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo_button.PerformClick();
            }
            else
                MessageBox.Show("No Se Pudoo Eliminar", "Fallo Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int GrupoId = Convert.ToInt32(grupoIdNumericUpDown.Value);
            Grupos grupo = BLL.GruposBLL.Buscar2(GrupoId);

            if (grupo != null)
            {
                fechaDateTimePicker.Value = grupo.Fecha;
                descripcionTextBox.Text = grupo.Descripcion;
                cantidadNumericUpDown.Value = grupo.Cantidad;
                grupoNumericUpDown.Value = grupo.Grupo;
                integrantesNumericUpDown.Value = grupo.Integrantes;

            }
            else
                MessageBox.Show("Datos No Encontrados", "Fallo Al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void grupoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (cantidadNumericUpDown.Value != 0 && grupoNumericUpDown.Value != 0)
            {
                integrantesNumericUpDown.Value = BLL.GruposBLL.CalcularIntegrantes(cantidadNumericUpDown.Value, grupoNumericUpDown.Value);
            }

        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (cantidadNumericUpDown.Value != 0 && grupoNumericUpDown.Value != 0)
            {
                integrantesNumericUpDown.Value = BLL.GruposBLL.CalcularIntegrantes(cantidadNumericUpDown.Value, grupoNumericUpDown.Value);
            }
        }
    }
}
