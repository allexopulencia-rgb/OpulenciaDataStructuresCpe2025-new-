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
    public partial class FrmLinearSearch : Form
    {
        public FrmLinearSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] input = txtArray.Text.Split(',');
                int[] numbers = Array.ConvertAll(input, s => int.Parse(s.Trim()));

                int target = int.Parse(txtSearch.Text);

                int index = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == target)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    ltbResult.Items.Add($"Value {target} found at index {index}.");
                }
                else
                {
                    ltbResult.Items.Add($"Value {target} not found at index {index}.");
                }
            }
            catch (Exception ex)
            {
                ltbResult.Items.Add("Error:" + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Main main = new Main();
            //main.ShowDialog();
        }
    }
}
