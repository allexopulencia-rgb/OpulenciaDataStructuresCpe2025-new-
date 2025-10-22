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
    public partial class FrmQueue : Form
    {
        Queue myQueue = new Queue();
        public FrmQueue()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            myClass.DisplayDSvalue(ltbQueue, myQueue);
        }

        private void FrmQueue_Load(object sender, EventArgs e)
        {
            myQueue.Enqueue("love");
            myQueue.Enqueue("babe");
            myQueue.Enqueue("baby");
            myQueue.Enqueue("lovey");
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            myClass.DisplayDSvalue(ltbQueue, myQueue);
            MessageBox.Show("Front element is " + myQueue.Peek());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total elements in Elements/s " + myQueue.Count);
        }
    }
}
