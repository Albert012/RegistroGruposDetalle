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
    public partial class rPersona : Form
    {
        public rPersona()
        {
            InitializeComponent();
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            personaIdNumericUpDown.Value = 0;
            fechaDateTimePicker.ResetText();
            nombresTextBox.Clear();
            direccionTextBox.Clear();
            cedulaMaskedTextBox.Clear();
            telefonoMaskedTextBox.Clear();
        }

        private bool Validar()
        {
            bool CamposLLeno = true;

            if (nombresTextBox.Text == "")
            {
                ValidarErrorProvider.SetError(nombresTextBox, "Debes Introducir El Nombre Completo De La Persona");
                CamposLLeno = false;
            }
            else
                if(direccionTextBox.Text == "")
            {
                ValidarErrorProvider.SetError(direccionTextBox, "Debes Introducir La Direccion De La Persona");
                CamposLLeno = false;
            }
            else
                if (cedulaMaskedTextBox.Text == "")
            {
                ValidarErrorProvider.SetError(cedulaMaskedTextBox, "Debes Ingresar La Cedula De Identidad");
                CamposLLeno = false;
            }
            else
                if (telefonoMaskedTextBox.Text == "")
            {
                ValidarErrorProvider.SetError(telefonoMaskedTextBox, "Debes Ingresar El Telefono De La Persona");
                CamposLLeno = false;
            }

            return CamposLLeno;
        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();

            persona.PersonaId = Convert.ToInt32(personaIdNumericUpDown.Value);
            persona.Fecha = fechaDateTimePicker.Value.Date;
            persona.Nombres = nombresTextBox.Text;
            persona.Direccion = direccionTextBox.Text;
            persona.Cedula = cedulaMaskedTextBox.Text;
            persona.Telefono = telefonoMaskedTextBox.Text;

            return persona;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Personas persona = LlenaClase();

            if (Validar())
            {
                if (personaIdNumericUpDown.Value == 0)
                {
                    paso = BLL.PersonasBLL.Guardar(persona);
                }
                else
                {
                    paso = BLL.PersonasBLL.Modificar(persona);
                }

                if (paso)
                    MessageBox.Show("Guardado Correctamente", "Exito Al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Se Pudo Guardar", "Fallo Al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PersonaId = Convert.ToInt32(personaIdNumericUpDown.Value);

            if (BLL.PersonasBLL.Eliminar(PersonaId))
            {
                MessageBox.Show("Eliminado Correctamente", "Exito Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo_button.PerformClick();
            }
            else
                MessageBox.Show("No Se Pudoo Eliminar", "Fallo Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int PersonaId = Convert.ToInt32(personaIdNumericUpDown.Value);
            Personas persona = BLL.PersonasBLL.Buscar(PersonaId);

            if (persona != null)
            {
                fechaDateTimePicker.Value = persona.Fecha;
                nombresTextBox.Text = persona.Nombres;
                direccionTextBox.Text = persona.Direccion;
                cedulaMaskedTextBox.Text = persona.Cedula;
                telefonoMaskedTextBox.Text = persona.Telefono;

            }
            else
                MessageBox.Show("Datos No Encontrados", "Fallo Al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
