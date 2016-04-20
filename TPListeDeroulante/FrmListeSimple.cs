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
        private void FrmListeSimple_Load(object sender, EventArgs e)
        {
            lstItems.Items.Add("Marie");
            lstItems.Items.Add("Jean");
            lstItems.Items.Add("Pierre");
            lstItems.Items.Add("Julien");
            lstItems.Items.Add("Françoise");
            lstItems.Items.Add("Hélène");
        }

        private void chkLocked_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLocked.Checked)
            { 
                lstItems.SelectionMode = SelectionMode.None;
                lstItems.Enabled = false;
            }
            else {
                lstItems.SelectionMode = SelectionMode.One;
                lstItems.Enabled = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtSaisie.Text != "")
            {
                lstItems.Items.Add(txtSaisie.Text);
                txtSaisie.Clear();
            }
            else
                MessageBox.Show("Rien à ajouter dans la liste");
        }
        
        private void rdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                lstItems.SelectionMode = SelectionMode.None;
                lstItems.SelectionMode = SelectionMode.One;
            }

        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn2.Checked)
            {
                lstItems.SelectionMode = SelectionMode.None;
                lstItems.SelectionMode = SelectionMode.MultiSimple;
            }
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn3.Checked)
            {
                lstItems.SelectionMode = SelectionMode.None;
                lstItems.SelectionMode = SelectionMode.MultiExtended;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            /** 
            Va supprimer les élements sélectionnés en fonction du mode de sélection 
            Penser à chercher à améliorer la suppression
            **/
            if(rdBtn1.Checked)
                lstItems.Items.Remove(lstItems.SelectedItem);
            else
            {
                for(int i=0;i<lstItems.SelectedItems.Count; i++)
                    lstItems.Items.Remove(lstItems.SelectedItems[i]);
                lstItems.Items.Remove(lstItems.SelectedItem);
            }
        }

        private void btnAffiche_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach(string item in lstItems.SelectedItems)
                message += item + "\n";
            MessageBox.Show(message);
        }
    }
}
