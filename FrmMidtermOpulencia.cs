using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpulenciaDataStructureCpe2025
{
    public partial class FrmMidtermOpulencia : Form
    {
        Hashtable myHashtable = new Hashtable();
        public FrmMidtermOpulencia()
        {
            InitializeComponent();
        }

        public void Display_hashtable_value()
        {
            ltbhashtable.Items.Clear();
            foreach (DictionaryEntry item in myHashtable)
            {
                ltbhashtable.Items.Add(item.Key + " : " + item.Value);
            }
        }

        private void FrmMidtermOpulencia_Load(object sender, EventArgs e)
        {
            myHashtable.Add("llexa", 2);
            myHashtable.Add("sheena", 3);
            myHashtable.Add("deinne", 4);
            myHashtable.Add("deyn", 5);
            myHashtable.Add("xing", 6);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display_hashtable_value();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myHashtable.Clear();
            Display_hashtable_value();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                myHashtable.Add(Convert.ToString(txtKey.Text), Convert.ToInt32(txtValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Display_hashtable_value();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            myHashtable.Remove(Convert.ToString(txtRemoveKey.Text));
            Display_hashtable_value();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total number of elemets's: " + myHashtable.Count);
        }

        private void btnCValue_Click(object sender, EventArgs e)
        {
            if (myHashtable.ContainsValue(Convert.ToInt32(txtCVal.Text)))
            {
                MessageBox.Show("Value found: " + txtCVal.Text);
            }
            else
            {
                MessageBox.Show("Value not found: " + txtCVal.Text);
            }
        }

        private void ltbhashtable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
