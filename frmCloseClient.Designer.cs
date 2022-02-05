
namespace RentACar
{
    partial class frmCloseClient
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
            this.findClientTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findClientBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGrdClient = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeGrdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // findClientTxtBox
            // 
            this.findClientTxtBox.Location = new System.Drawing.Point(305, 56);
            this.findClientTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findClientTxtBox.Name = "findClientTxtBox";
            this.findClientTxtBox.Size = new System.Drawing.Size(202, 31);
            this.findClientTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter client ID number";
            // 
            // findClientBtn
            // 
            this.findClientBtn.Location = new System.Drawing.Point(742, 56);
            this.findClientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findClientBtn.Name = "findClientBtn";
            this.findClientBtn.Size = new System.Drawing.Size(234, 59);
            this.findClientBtn.TabIndex = 4;
            this.findClientBtn.Text = "Search Client";
            this.findClientBtn.UseVisualStyleBackColor = true;
            this.findClientBtn.Click += new System.EventHandler(this.findClientBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1067, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(73, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // closeGrdClient
            // 
            this.closeGrdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closeGrdClient.Location = new System.Drawing.Point(70, 155);
            this.closeGrdClient.Name = "closeGrdClient";
            this.closeGrdClient.RowHeadersWidth = 62;
            this.closeGrdClient.RowTemplate.Height = 33;
            this.closeGrdClient.Size = new System.Drawing.Size(1043, 437);
            this.closeGrdClient.TabIndex = 6;
            this.closeGrdClient.Visible = false;
            // 
            // frmCloseClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 842);
            this.Controls.Add(this.closeGrdClient);
            this.Controls.Add(this.findClientBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findClientTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCloseClient";
            this.Text = "frmCloseClient";
            this.Load += new System.EventHandler(this.frmCloseClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeGrdClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox findClientTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findClientBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView closeGrdClient;
    }
}