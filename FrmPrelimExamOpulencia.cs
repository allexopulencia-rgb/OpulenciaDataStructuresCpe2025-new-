using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpulenciaDataStructureCpe2025
{
    public partial class FrmPrelimExamOpulencia : Form
    {
        string[] myString = { "the", "fox", "jumps", "over", "the", "dog" };
        LinkedList<string> myLinkedList = new LinkedList<string>();
        public FrmPrelimExamOpulencia()
        {
            InitializeComponent();
        }

        private void FrmPrelimExamOpulencia_Load(object sender, EventArgs e)
        {
            myLinkedList = new LinkedList<string>(myString);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            displayLinkedlist();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ltbLinkedlist.Items.Clear();
        }
        #region "Add Item"
        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            myLinkedList.AddFirst(txtAdd.Text);
            displayLinkedlist();
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            myLinkedList.AddLast(txtAdd.Text);
            displayLinkedlist();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            myLinkedList.Remove(txtAdd.Text);
            displayLinkedlist();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool containsValue = myLinkedList.Contains(txtSearch.Text);
            if (containsValue == true)
            {
                MessageBox.Show("Item found in Linked List");
            }
            else
            {
                MessageBox.Show("Item not found in Linked List");
            }
        }
        private void displayLinkedlist()
        {
            ltbLinkedlist.Items.Clear();
            foreach (string str in myLinkedList)
            {
                ltbLinkedlist.Items.Add(str);
            }
        }
    }
}
#endregion