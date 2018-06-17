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
            rGrupo rgrupo = new rGrupo();
            rgrupo.MdiParent = this.MdiParent;
            rgrupo.ShowDialog();

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cGrupo cgrupo = new cGrupo();
            cgrupo.MdiParent = this.MdiParent;
            cgrupo.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperamos Que Vuelva!!", "Salida Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersona rpersona = new rPersona();
            rpersona.MdiParent = this.MdiParent;
            rpersona.ShowDialog();
        }

        private void personasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPersonas cpersona = new cPersonas();
            cpersona.MdiParent = this.MdiParent;
            cpersona.ShowDialog();
        }

        private void gruposDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rGruposDetalle grupodetalle = new rGruposDetalle();
            grupodetalle.MdiParent = this.MdiParent;
            grupodetalle.ShowDialog();
        }
    }
}
