using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPListeDeroulante
{
    public partial class FrmListeSimple : Form
    {
        public FrmListeSimple()
        {
            InitializeComponent();
        }

        private void chkLocked_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLocked.Checked)
                lstItems.SelectionMode = SelectionMode.None;
            else
                lstItems.SelectionMode = SelectionMode.One;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtSaisie.Text!="")
                lstItems.Items.Add(txtSaisie.Text);
            else
                MessageBox.Show("Rien à ajouter dans la liste");
        }

        private void rdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
                lstItems.SelectionMode= SelectionMode.One;
        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn2.Checked)
                lstItems.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn3.Checked)
                lstItems.SelectionMode= SelectionMode.MultiExtended;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstItems.Items.Remove(lstItems.SelectedItems);
        }
    }
}
