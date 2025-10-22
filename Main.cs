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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            frmArray frmArray = new frmArray();
            frmArray.ShowDialog();
        }

        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.ShowDialog();
        }

        private void btnPrelimExam_Click(object sender, EventArgs e)
        {
            FrmPrelimExamOpulencia frmPrelimExamOpulencia = new FrmPrelimExamOpulencia();
            frmPrelimExamOpulencia.ShowDialog();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            FrmStack frmStack = new FrmStack();
            frmStack.ShowDialog();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            FrmQueue frmQueue = new FrmQueue();
            frmQueue.ShowDialog();
        }

        private void btnMidtermExam_Click(object sender, EventArgs e)
        {
            FrmMidtermOpulencia frmMidtermOpulencia = new FrmMidtermOpulencia();
            frmMidtermOpulencia.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
