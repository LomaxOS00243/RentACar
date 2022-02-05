
namespace RentACar
{
    partial class frmPrintStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintStatement));
            this.printClientBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printClientTxtBox = new System.Windows.Forms.TextBox();
            this.stateGrpBox = new System.Windows.Forms.GroupBox();
            this.printPreviewBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stateGrpBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printClientBtn
            // 
            this.printClientBtn.Location = new System.Drawing.Point(150, 142);
            this.printClientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printClientBtn.Name = "printClientBtn";
            this.printClientBtn.Size = new System.Drawing.Size(234, 59);
            this.printClientBtn.TabIndex = 8;
            this.printClientBtn.Text = "Find Client Statement";
            this.printClientBtn.UseVisualStyleBackColor = true;
            this.printClientBtn.Click += new System.EventHandler(this.printClientBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 429);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter client ID number";
            // 
            // printClientTxtBox
            // 
            this.printClientTxtBox.Location = new System.Drawing.Point(271, 45);
            this.printClientTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printClientTxtBox.Name = "printClientTxtBox";
            this.printClientTxtBox.Size = new System.Drawing.Size(202, 31);
            this.printClientTxtBox.TabIndex = 5;
            // 
            // stateGrpBox
            // 
            this.stateGrpBox.Controls.Add(this.printPreviewBtn);
            this.stateGrpBox.Controls.Add(this.printBtn);
            this.stateGrpBox.Controls.Add(this.richTextBox1);
            this.stateGrpBox.Location = new System.Drawing.Point(630, 70);
            this.stateGrpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateGrpBox.Name = "stateGrpBox";
            this.stateGrpBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateGrpBox.Size = new System.Drawing.Size(622, 786);
            this.stateGrpBox.TabIndex = 9;
            this.stateGrpBox.TabStop = false;
            this.stateGrpBox.Text = "Statement";
            this.stateGrpBox.Visible = false;
            // 
            // printPreviewBtn
            // 
            this.printPreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPreviewBtn.Location = new System.Drawing.Point(359, 675);
            this.printPreviewBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printPreviewBtn.Name = "printPreviewBtn";
            this.printPreviewBtn.Size = new System.Drawing.Size(211, 89);
            this.printPreviewBtn.TabIndex = 2;
            this.printPreviewBtn.Text = "Print Preview";
            this.printPreviewBtn.UseVisualStyleBackColor = true;
            this.printPreviewBtn.Click += new System.EventHandler(this.printPreviewBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Location = new System.Drawing.Point(56, 675);
            this.printBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(211, 89);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 41);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 603);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1220, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(73, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmPrintStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 884);
            this.Controls.Add(this.stateGrpBox);
            this.Controls.Add(this.printClientBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printClientTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrintStatement";
            this.Text = "frmPrintStatement";
            this.Load += new System.EventHandler(this.frmPrintStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stateGrpBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printClientBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox printClientTxtBox;
        private System.Windows.Forms.GroupBox stateGrpBox;
        private System.Windows.Forms.Button printPreviewBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}