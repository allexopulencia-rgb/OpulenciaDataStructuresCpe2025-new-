namespace OpulenciaDataStructureCpe2025
{
    partial class FrmQueue
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
            this.ltbQueue = new System.Windows.Forms.ListBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltbQueue
            // 
            this.ltbQueue.FormattingEnabled = true;
            this.ltbQueue.ItemHeight = 16;
            this.ltbQueue.Location = new System.Drawing.Point(43, 44);
            this.ltbQueue.Name = "ltbQueue";
            this.ltbQueue.Size = new System.Drawing.Size(278, 148);
            this.ltbQueue.TabIndex = 4;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(341, 152);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(174, 30);
            this.btnCount.TabIndex = 14;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(341, 116);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(174, 30);
            this.btnPeek.TabIndex = 13;
            this.btnPeek.Text = "Display top Item";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(341, 80);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(174, 30);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(341, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 30);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ltbQueue);
            this.Name = "FrmQueue";
            this.Text = "FrmQueue";
            this.Load += new System.EventHandler(this.FrmQueue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbQueue;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnBack;
    }
}