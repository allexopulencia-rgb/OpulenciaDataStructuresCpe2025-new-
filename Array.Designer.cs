namespace OpulenciaDataStructureCpe2025
{
    partial class frmArray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputValue2 = new System.Windows.Forms.TextBox();
            this.btnInsert2 = new System.Windows.Forms.Button();
            this.ltbArray = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDisplayIndex = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValueInsert = new System.Windows.Forms.TextBox();
            this.btnInsertIndex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndexInsert = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputValue2
            // 
            this.txtInputValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputValue2.Location = new System.Drawing.Point(40, 41);
            this.txtInputValue2.Name = "txtInputValue2";
            this.txtInputValue2.Size = new System.Drawing.Size(159, 30);
            this.txtInputValue2.TabIndex = 0;
            // 
            // btnInsert2
            // 
            this.btnInsert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert2.Location = new System.Drawing.Point(205, 41);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Size = new System.Drawing.Size(113, 30);
            this.btnInsert2.TabIndex = 1;
            this.btnInsert2.Text = "Insert";
            this.btnInsert2.UseVisualStyleBackColor = true;
            this.btnInsert2.Click += new System.EventHandler(this.btnInsert2_Click);
            // 
            // ltbArray
            // 
            this.ltbArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbArray.FormattingEnabled = true;
            this.ltbArray.ItemHeight = 25;
            this.ltbArray.Location = new System.Drawing.Point(40, 197);
            this.ltbArray.Name = "ltbArray";
            this.ltbArray.Size = new System.Drawing.Size(308, 154);
            this.ltbArray.TabIndex = 2;
            this.ltbArray.SelectedIndexChanged += new System.EventHandler(this.ltbArray_SelectedIndexChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(468, 75);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(147, 40);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display All Array Value";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisplayIndex
            // 
            this.btnDisplayIndex.Location = new System.Drawing.Point(154, 29);
            this.btnDisplayIndex.Name = "btnDisplayIndex";
            this.btnDisplayIndex.Size = new System.Drawing.Size(139, 30);
            this.btnDisplayIndex.TabIndex = 4;
            this.btnDisplayIndex.Text = "Display";
            this.btnDisplayIndex.UseVisualStyleBackColor = true;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(86, 29);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(62, 30);
            this.txtIndex.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Index";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplayIndex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Index Value";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtValueInsert);
            this.groupBox2.Controls.Add(this.btnInsertIndex);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIndexInsert);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 166);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Index Value in an Array";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtValueInsert
            // 
            this.txtValueInsert.Location = new System.Drawing.Point(142, 68);
            this.txtValueInsert.Name = "txtValueInsert";
            this.txtValueInsert.Size = new System.Drawing.Size(110, 30);
            this.txtValueInsert.TabIndex = 7;
            // 
            // btnInsertIndex
            // 
            this.btnInsertIndex.Location = new System.Drawing.Point(200, 118);
            this.btnInsertIndex.Name = "btnInsertIndex";
            this.btnInsertIndex.Size = new System.Drawing.Size(83, 33);
            this.btnInsertIndex.TabIndex = 4;
            this.btnInsertIndex.Text = "Insert";
            this.btnInsertIndex.UseVisualStyleBackColor = true;
            this.btnInsertIndex.Click += new System.EventHandler(this.btnInsertIndex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Index";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIndexInsert
            // 
            this.txtIndexInsert.Location = new System.Drawing.Point(142, 29);
            this.txtIndexInsert.Name = "txtIndexInsert";
            this.txtIndexInsert.Size = new System.Drawing.Size(110, 30);
            this.txtIndexInsert.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(633, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.txtInputValue2);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnInsert2);
            this.groupBox3.Controls.Add(this.ltbArray);
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1152, 871);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Array";
            // 
            // frmArray
            // 
            this.ClientSize = new System.Drawing.Size(1600, 887);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArray";
            this.Text = "Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtlnputValue;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInputValue2;
        private System.Windows.Forms.Button btnInsert2;
        private System.Windows.Forms.ListBox ltbArray;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDisplayIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsertIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndexInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValueInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}