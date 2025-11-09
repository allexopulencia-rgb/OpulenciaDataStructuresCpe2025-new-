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
    public partial class FrmStack : Form
    {
        Stack myStack = new Stack();
        public FrmStack()
        {
            InitializeComponent();
        }

        private void FrmStack_Load(object sender, EventArgs e)
        {
            LoadStack();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Main main = new Main();
            //main.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            myClass.DisplayDSvalue(ltbStack, myStack);
            //displayStack();

            //ltbStack.Items.Clear();
            //while (myStack.Count > 0)
            //{
            //    ltbStack.Items.Add(myStack.Pop());
            //}
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            displayStack();
            MessageBox.Show("Top element is " + myStack.Peek());
        }
        public void LoadStack()
        {
            myStack.Push("love");
            myStack.Push("babe");
            myStack.Push("baby");
            myStack.Push("lovey");
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            myStack.Pop();
            displayStack();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total number of elements/s " + myStack.Count);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            myStack.Push(txtValue.Text);
            displayStack();
        }
        public void displayStack()
        {
            ltbStack.Items.Clear();
            foreach (var item in myStack)
            {
                ltbStack.Items.Add(item);
            }
        }
    }
}
