using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1._3_a_
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        #region creacion objetos de cada proyecto
        Hola_CSharp.frm_inicial holaCSharp = new Hola_CSharp.frm_inicial();
        Ejemplo1._1.frm_ingreso ejemplo1_1 = new Ejemplo1._1.frm_ingreso();
        Ejemplo1._1.frm_acceso ejemplo1_2 = new Ejemplo1._1.frm_acceso();
        Ejemplo1._2.frm_ingreso ejemplo2_1 = new Ejemplo1._2.frm_ingreso();
        Ejemplo1._2.frm_acceso ejemplo2_2 = new Ejemplo1._2.frm_acceso();
        #endregion

            public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void tst_btn_HolaCSharp_Click(object sender, EventArgs e)
        {
            holaCSharp.MdiParent = this;
            holaCSharp.Show();
        }

        private void tsp_btn_ejemplo1_1_Click(object sender, EventArgs e)
        {
            ejemplo1_1.MdiParent = this;
            ejemplo1_2.MdiParent = this;
            ejemplo1_1.Show();
        }

        private void tsp_btn_Ejemplo1_2_Click(object sender, EventArgs e)
        {
            ejemplo2_1.MdiParent = this;
            ejemplo2_2.MdiParent = this;
            ejemplo2_1.Show();
        }

        private void tsmi_Hola_Click(object sender, EventArgs e)
        {
            tst_btn_HolaCSharp_Click(sender, e);
        }

        private void tsmi_Ejemplo11_Click(object sender, EventArgs e)
        {
            tsp_btn_ejemplo1_1_Click(sender, e);
        }

        private void tsmi_Ejemplo12_Click(object sender, EventArgs e)
        {
            tsp_btn_Ejemplo1_2_Click(sender, e);
        }
    }
}
