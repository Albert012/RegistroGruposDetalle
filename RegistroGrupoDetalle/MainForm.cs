using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RegistroGrupoDetalle.UI.Registros;
using RegistroGrupoDetalle.UI.Consultas;

namespace RegistroGrupoDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rRegistroGrupo registro = new rRegistroGrupo();
            registro.MdiParent = this.MdiParent;
            registro.ShowDialog();

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cConsultaGrupo consulta = new cConsultaGrupo();
            consulta.MdiParent = this.MdiParent;
            consulta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperamos Que Vuelva!!", "Salida Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
