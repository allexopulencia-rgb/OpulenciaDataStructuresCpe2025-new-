namespace OpulenciaDataStructureCpe2025
{
    partial class FrmStack
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
            this.ltbStack = new System.Windows.Forms.ListBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltbStack
            // 
            this.ltbStack.FormattingEnabled = true;
            this.ltbStack.ItemHeight = 16;
            this.ltbStack.Location = new System.Drawing.Point(42, 48);
            this.ltbStack.Name = "ltbStack";
            this.ltbStack.Size = new System.Drawing.Size(278, 148);
            this.ltbStack.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(335, 48);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(74, 22);
            this.txtValue.TabIndex = 4;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(424, 44);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(85, 30);
            this.btnPush.TabIndex = 5;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(515, 44);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(85, 30);
            this.btnPop.TabIndex = 6;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(335, 80);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(335, 116);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(174, 30);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(335, 152);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(174, 30);
            this.btnPeek.TabIndex = 9;
            this.btnPeek.Text = "Display top Item";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(335, 188);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(174, 30);
            this.btnCount.TabIndex = 10;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // FrmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.ltbStack);
            this.Name = "FrmStack";
            this.Text = "FrmStack";
            this.Load += new System.EventHandler(this.FrmStack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbStack;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnCount;
    }
}