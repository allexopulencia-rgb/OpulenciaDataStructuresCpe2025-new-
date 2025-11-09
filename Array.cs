using System;
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
    public partial class frmArray : Form
    {
        int[] num1 = { 5, 8, 3, 1, 9 };
        public frmArray()
        {
            InitializeComponent();
        }

        private void btnInsert2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtInputValue2.Text);
            ltbArray.Items.Add(txtInputValue2.Text);
            txtInputValue2.Clear();
            txtInputValue2.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int num in num1)
            {
                ltbArray.Items.Add(num);
            }
        }

        private void btnDisplayIndex_Click(object sender, EventArgs e)
        {

        }

        private void ltbArray_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertIndex_Click(object sender, EventArgs e)
        {
            ltbArray.Items.Clear();
            num1[Convert.ToInt32(txtIndexInsert.Text)] =
                Convert.ToInt32(txtValueInsert.Text);
            displayArray();

        }

        public void displayArray()
        {
            ltbArray.Items.Clear();
            foreach (int num in num1)
            {
                ltbArray.Items.Add(num);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Main main = new Main();
            //main.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
