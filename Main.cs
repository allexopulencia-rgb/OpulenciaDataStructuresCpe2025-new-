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
            myClass.formClose(this);
            frmArray frmArray = new frmArray();
            myClass.formShow(frmArray, this.splitContainer2.Panel2);

            //frmArray frmArray = new frmArray();
            //this.Hide();
            //frmArray.ShowDialog();
        }

        private void formShow (Form formToShow, Panel formToShowParent)
        {
            formToShow.TopLevel = false;
            formToShow.WindowState = FormWindowState.Maximized;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Parent = formToShowParent;
            formToShow.Visible = true;

            formToShowParent.Controls.Clear();
            formToShowParent.Controls.Add(formToShow);
        }

        public static void formClose(Form formToClose)
        {
            Form openForm = null;
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                openForm = Application.OpenForms[index];
                if (openForm != formToClose && !(openForm is Main))
                {
                    openForm.Close();
                    openForm.Dispose();
                    openForm = null;
                }
            }
        }


        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmLinkedList linkedList = new FrmLinkedList();
            myClass.formShow(linkedList, this.splitContainer2.Panel2);

            //LinkedList linkedList = new LinkedList();
            //this.Hide();
            //linkedList.ShowDialog();
        }

        private void btnPrelimExam_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmPrelimExamOpulencia frmPrelimExamOpulencia = new FrmPrelimExamOpulencia();
            myClass.formShow(frmPrelimExamOpulencia, this.splitContainer2.Panel2);

            //FrmPrelimExamOpulencia frmPrelimExamOpulencia = new FrmPrelimExamOpulencia();
            //this.Hide();
            //frmPrelimExamOpulencia.ShowDialog();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmStack frmStack = new FrmStack();
            myClass.formShow(frmStack, this.splitContainer2.Panel2);

            //FrmStack frmStack = new FrmStack();
            //this.Hide();
            //frmStack.ShowDialog();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmQueue frmQueue = new FrmQueue();
            myClass.formShow(frmQueue, this.splitContainer2.Panel2);

            //FrmQueue frmQueue = new FrmQueue();
            //this.Hide();
            //frmQueue.ShowDialog();
        }

        private void btnMidtermExam_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmMidtermOpulencia frmMidtermOpulencia = new FrmMidtermOpulencia();
            myClass.formShow(frmMidtermOpulencia, this.splitContainer2.Panel2);

            //FrmMidtermOpulencia frmMidtermOpulencia = new FrmMidtermOpulencia();
            //this.Hide();
            //frmMidtermOpulencia.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmLinearSearch frmLinearSearch = new FrmLinearSearch();
            myClass.formShow(frmLinearSearch, this.splitContainer2.Panel2);

            //FrmLinearSearch frmLinearSearch = new FrmLinearSearch();
            //this.Hide();
            //frmLinearSearch.ShowDialog();
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            myClass.formClose(this);
            FrmBinarySearch frmBinarySearch = new FrmBinarySearch();
            myClass.formShow(frmBinarySearch, this.splitContainer2.Panel2);

            //FrmBinarySearch frmBinarySearch = new FrmBinarySearch();
            //this.Hide();
            //frmBinarySearch.ShowDialog();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
