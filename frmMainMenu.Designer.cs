
namespace RentACar
{
    partial class frmMainMnu
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
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.nCToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeClAccToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.printClStatToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.rntToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.makeResToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelResToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.cCarToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.rCarToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.bilToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.mnuStrip1.SuspendLayout();
            this.mnuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mnuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clToolStripMnu,
            this.rntToolStripMnu,
            this.bilToolStripMnu,
            this.adminToolStripMnu});
            this.mnuStrip1.Location = new System.Drawing.Point(0, 1);
            this.mnuStrip1.Name = "mnuStrip1";
            this.mnuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuStrip1.Size = new System.Drawing.Size(436, 33);
            this.mnuStrip1.TabIndex = 0;
            this.mnuStrip1.Text = "menuStrip1";
            this.mnuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clToolStripMnu
            // 
            this.clToolStripMnu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCToolStripMnu,
            this.closeClAccToolStripMnu,
            this.printClStatToolStripMnu});
            this.clToolStripMnu.Name = "clToolStripMnu";
            this.clToolStripMnu.Size = new System.Drawing.Size(90, 29);
            this.clToolStripMnu.Text = "Clients";
            // 
            // nCToolStripMnu
            // 
            this.nCToolStripMnu.Name = "nCToolStripMnu";
            this.nCToolStripMnu.Size = new System.Drawing.Size(306, 34);
            this.nCToolStripMnu.Text = "New Client ";
            this.nCToolStripMnu.Click += new System.EventHandler(this.nCToolStripMnu_Click);
            // 
            // closeClAccToolStripMnu
            // 
            this.closeClAccToolStripMnu.Name = "closeClAccToolStripMnu";
            this.closeClAccToolStripMnu.Size = new System.Drawing.Size(306, 34);
            this.closeClAccToolStripMnu.Text = "Close Client Account";
            this.closeClAccToolStripMnu.Click += new System.EventHandler(this.closeClAccToolStripMnu_Click);
            // 
            // printClStatToolStripMnu
            // 
            this.printClStatToolStripMnu.Name = "printClStatToolStripMnu";
            this.printClStatToolStripMnu.Size = new System.Drawing.Size(306, 34);
            this.printClStatToolStripMnu.Text = "Print Client Statement";
            this.printClStatToolStripMnu.Click += new System.EventHandler(this.printClStatToolStripMnu_Click);
            // 
            // rntToolStripMnu
            // 
            this.rntToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeResToolStripMnu,
            this.cancelResToolStripMnu,
            this.cCarToolStripMnu,
            this.rCarToolStripMnu});
            this.rntToolStripMnu.Name = "rntToolStripMnu";
            this.rntToolStripMnu.Size = new System.Drawing.Size(93, 29);
            this.rntToolStripMnu.Text = "Rentals";
            // 
            // makeResToolStripMnu
            // 
            this.makeResToolStripMnu.Name = "makeResToolStripMnu";
            this.makeResToolStripMnu.Size = new System.Drawing.Size(285, 34);
            this.makeResToolStripMnu.Text = "Make Reservation";
            this.makeResToolStripMnu.Click += new System.EventHandler(this.makeResToolStripMnu_Click);
            // 
            // cancelResToolStripMnu
            // 
            this.cancelResToolStripMnu.Name = "cancelResToolStripMnu";
            this.cancelResToolStripMnu.Size = new System.Drawing.Size(285, 34);
            this.cancelResToolStripMnu.Text = "Cancel Reservation";
            this.cancelResToolStripMnu.Click += new System.EventHandler(this.cancelResToolStripMnu_Click);
            // 
            // cCarToolStripMnu
            // 
            this.cCarToolStripMnu.Name = "cCarToolStripMnu";
            this.cCarToolStripMnu.Size = new System.Drawing.Size(285, 34);
            this.cCarToolStripMnu.Text = "Collect Car";
            this.cCarToolStripMnu.Click += new System.EventHandler(this.cCarToolStripMnu_Click);
            // 
            // rCarToolStripMnu
            // 
            this.rCarToolStripMnu.Name = "rCarToolStripMnu";
            this.rCarToolStripMnu.Size = new System.Drawing.Size(285, 34);
            this.rCarToolStripMnu.Text = "Return Car";
            this.rCarToolStripMnu.Click += new System.EventHandler(this.rCarToolStripMnu_Click);
            // 
            // bilToolStripMnu
            // 
            this.bilToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueInvoicesToolStripMenuItem,
            this.recordClientToolStripMenuItem});
            this.bilToolStripMnu.Name = "bilToolStripMnu";
            this.bilToolStripMnu.Size = new System.Drawing.Size(86, 29);
            this.bilToolStripMnu.Text = "Billing";
            // 
            // issueInvoicesToolStripMenuItem
            // 
            this.issueInvoicesToolStripMenuItem.Name = "issueInvoicesToolStripMenuItem";
            this.issueInvoicesToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.issueInvoicesToolStripMenuItem.Text = "Issue Invoices";
            // 
            // recordClientToolStripMenuItem
            // 
            this.recordClientToolStripMenuItem.Name = "recordClientToolStripMenuItem";
            this.recordClientToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.recordClientToolStripMenuItem.Text = "Record Client";
            // 
            // adminToolStripMnu
            // 
            this.adminToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem});
            this.adminToolStripMnu.Name = "adminToolStripMnu";
            this.adminToolStripMnu.Size = new System.Drawing.Size(158, 29);
            this.adminToolStripMnu.Text = "Administration";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            // 
            // mnuStrip2
            // 
            this.mnuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuStrip2.Location = new System.Drawing.Point(1200, 9);
            this.mnuStrip2.Name = "mnuStrip2";
            this.mnuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuStrip2.Size = new System.Drawing.Size(72, 33);
            this.mnuStrip2.TabIndex = 1;
            this.mnuStrip2.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(0, 45);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1272, 749);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // frmMainMnu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 796);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.mnuStrip1);
            this.Controls.Add(this.mnuStrip2);
            this.MainMenuStrip = this.mnuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainMnu";
            this.Text = "CarRentalSYS";
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
            this.mnuStrip2.ResumeLayout(false);
            this.mnuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem nCToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem closeClAccToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem printClStatToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem rntToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem makeResToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem cancelResToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem cCarToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem rCarToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem bilToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem issueInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox;
    }
}

