using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmCloseClient : Form
    {
        public frmCloseClient()
        {
            InitializeComponent();
        }

        private void findClientBtn_Click(object sender, EventArgs e)
        {
            if (findClientTxtBox.Text.Equals(""))
            {
                MessageBox.Show("You must enter the client ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                findClientTxtBox.Focus();
                return;
            }
            else
                closeGrdClient.Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu backForm = new frmMainMnu();
            backForm.Show();
        }

        private void frmCloseClient_Load(object sender, EventArgs e)
        {

        }
    }
}
