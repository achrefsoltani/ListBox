using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtSaisie.Text != "") {
                lb1.Items.Add(txtSaisie.Text);
                txtSaisie.Text = "";
            }
            
        }

        private void btnEffacerL1_Click(object sender, EventArgs e)
        {
            lb1.Items.RemoveAt(lb1.SelectedIndex);
        }

        private void btnEffacerL2_Click(object sender, EventArgs e)
        {
            lb2.Items.RemoveAt(lb2.SelectedIndex);
        }

        private void btnEffacerTL1_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
        }

        private void btnEffacerTL2_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
        }

        private void btnAjouterL2_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                lb2.Items.Add(lb1.SelectedItem.ToString());
                lb1.Items.RemoveAt(lb1.SelectedIndex);
            }
            
        }

        private void btnAjouterL1_Click(object sender, EventArgs e)
        {
            if (lb2.SelectedItem != null)
            {
                lb1.Items.Add(lb2.SelectedItem.ToString());
                lb2.Items.RemoveAt(lb2.SelectedIndex);
            }
        }

        private void btnAjouterTL2_Click(object sender, EventArgs e)
        {
            int i;
            for (i=0; i < lb1.Items.Count; i++)
            {
                lb2.Items.Add(lb1.Items[i]);
            }
            lb1.Items.Clear();
        }

        private void btnAjouterTL1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < lb2.Items.Count; i++)
            {
                lb1.Items.Add(lb2.Items[i]);
            }
            lb2.Items.Clear();
        }
    }
}
