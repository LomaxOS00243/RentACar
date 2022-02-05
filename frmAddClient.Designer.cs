
namespace RentACar
{
    partial class frmAddClient
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
            this.addMnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.clientTelTxt = new System.Windows.Forms.TextBox();
            this.clientEmailTxt = new System.Windows.Forms.TextBox();
            this.clientAddTxt = new System.Windows.Forms.TextBox();
            this.clientZipTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientConTxt = new System.Windows.Forms.TextBox();
            this.clientTownTxt = new System.Windows.Forms.TextBox();
            this.clientNmeTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.addMnuStrip1.SuspendLayout();
            this.newClientBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMnuStrip1
            // 
            this.addMnuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addMnuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.addMnuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.addMnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMnu});
            this.addMnuStrip1.Location = new System.Drawing.Point(1017, 11);
            this.addMnuStrip1.Name = "addMnuStrip1";
            this.addMnuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.addMnuStrip1.Size = new System.Drawing.Size(73, 33);
            this.addMnuStrip1.TabIndex = 0;
            this.addMnuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMnu
            // 
            this.backToolStripMnu.Name = "backToolStripMnu";
            this.backToolStripMnu.Size = new System.Drawing.Size(64, 29);
            this.backToolStripMnu.Text = "Back";
            this.backToolStripMnu.Click += new System.EventHandler(this.backToolStripMnu_Click);
            // 
            // newClientBox1
            // 
            this.newClientBox1.Controls.Add(this.label14);
            this.newClientBox1.Controls.Add(this.clientTelTxt);
            this.newClientBox1.Controls.Add(this.clientEmailTxt);
            this.newClientBox1.Controls.Add(this.clientAddTxt);
            this.newClientBox1.Controls.Add(this.clientZipTxt);
            this.newClientBox1.Controls.Add(this.label5);
            this.newClientBox1.Controls.Add(this.clientConTxt);
            this.newClientBox1.Controls.Add(this.clientTownTxt);
            this.newClientBox1.Controls.Add(this.clientNmeTxt);
            this.newClientBox1.Controls.Add(this.label10);
            this.newClientBox1.Controls.Add(this.label9);
            this.newClientBox1.Controls.Add(this.label8);
            this.newClientBox1.Controls.Add(this.label7);
            this.newClientBox1.Controls.Add(this.label6);
            this.newClientBox1.Controls.Add(this.label3);
            this.newClientBox1.Controls.Add(this.label2);
            this.newClientBox1.Location = new System.Drawing.Point(81, 152);
            this.newClientBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newClientBox1.Name = "newClientBox1";
            this.newClientBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newClientBox1.Size = new System.Drawing.Size(653, 572);
            this.newClientBox1.TabIndex = 1;
            this.newClientBox1.TabStop = false;
            this.newClientBox1.Text = "Enter Client Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Zip Code";
            // 
            // clientTelTxt
            // 
            this.clientTelTxt.Location = new System.Drawing.Point(282, 477);
            this.clientTelTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientTelTxt.Name = "clientTelTxt";
            this.clientTelTxt.Size = new System.Drawing.Size(268, 31);
            this.clientTelTxt.TabIndex = 6;
            // 
            // clientEmailTxt
            // 
            this.clientEmailTxt.Location = new System.Drawing.Point(282, 409);
            this.clientEmailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientEmailTxt.Name = "clientEmailTxt";
            this.clientEmailTxt.Size = new System.Drawing.Size(268, 31);
            this.clientEmailTxt.TabIndex = 5;
            // 
            // clientAddTxt
            // 
            this.clientAddTxt.Location = new System.Drawing.Point(282, 156);
            this.clientAddTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientAddTxt.Name = "clientAddTxt";
            this.clientAddTxt.Size = new System.Drawing.Size(268, 31);
            this.clientAddTxt.TabIndex = 1;
            // 
            // clientZipTxt
            // 
            this.clientZipTxt.Location = new System.Drawing.Point(282, 343);
            this.clientZipTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientZipTxt.Name = "clientZipTxt";
            this.clientZipTxt.Size = new System.Drawing.Size(181, 31);
            this.clientZipTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // clientConTxt
            // 
            this.clientConTxt.Location = new System.Drawing.Point(282, 279);
            this.clientConTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientConTxt.Name = "clientConTxt";
            this.clientConTxt.Size = new System.Drawing.Size(268, 31);
            this.clientConTxt.TabIndex = 3;
            // 
            // clientTownTxt
            // 
            this.clientTownTxt.Location = new System.Drawing.Point(282, 218);
            this.clientTownTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientTownTxt.Name = "clientTownTxt";
            this.clientTownTxt.Size = new System.Drawing.Size(268, 31);
            this.clientTownTxt.TabIndex = 2;
            // 
            // clientNmeTxt
            // 
            this.clientNmeTxt.Location = new System.Drawing.Point(282, 98);
            this.clientNmeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientNmeTxt.Name = "clientNmeTxt";
            this.clientNmeTxt.Size = new System.Drawing.Size(268, 31);
            this.clientNmeTxt.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tel No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // clientIdTxt
            // 
            this.clientIdTxt.Enabled = false;
            this.clientIdTxt.Location = new System.Drawing.Point(210, 73);
            this.clientIdTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientIdTxt.Name = "clientIdTxt";
            this.clientIdTxt.Size = new System.Drawing.Size(95, 31);
            this.clientIdTxt.TabIndex = 2;
            this.clientIdTxt.TextChanged += new System.EventHandler(this.newTxtBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClientID: ";
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(833, 639);
            this.addClientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(180, 85);
            this.addClientBtn.TabIndex = 2;
            this.addClientBtn.Text = "Create Account";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 854);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.newClientBox1);
            this.Controls.Add(this.addMnuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientIdTxt);
            this.MainMenuStrip = this.addMnuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddClient";
            this.Text = "New Client Account";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.addMnuStrip1.ResumeLayout(false);
            this.addMnuStrip1.PerformLayout();
            this.newClientBox1.ResumeLayout(false);
            this.newClientBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip addMnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMnu;
        private System.Windows.Forms.GroupBox newClientBox1;
        private System.Windows.Forms.TextBox clientTelTxt;
        private System.Windows.Forms.TextBox clientEmailTxt;
        private System.Windows.Forms.TextBox clientZipTxt;
        private System.Windows.Forms.TextBox clientConTxt;
        private System.Windows.Forms.TextBox clientTownTxt;
        private System.Windows.Forms.TextBox clientAddTxt;
        private System.Windows.Forms.TextBox clientNmeTxt;
        private System.Windows.Forms.TextBox clientIdTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Label label14;
    }
}