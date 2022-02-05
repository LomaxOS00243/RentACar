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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void backToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu mainMenu = new frmMainMnu();
            mainMenu.Show();
        }

        private void exitToolStripMnu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confim please", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clientIdTxt.Text.Equals(""))
            {
                MessageBox.Show("client ID Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientIdTxt.Focus();
                return;
            }
            else if (clientNmeTxt.Text.Equals(""))
            {
                MessageBox.Show("Company name Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientNmeTxt.Focus();
                return;
            }
            else if (clientAddTxt.Text.Equals(""))
            {
                MessageBox.Show("Company Address Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientAddTxt.Focus();
                return;
            }
            else if (clientTownTxt.Text.Equals(""))
            {
                MessageBox.Show("Town Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientTownTxt.Focus();
                return;
            }
            else if (clientConTxt.Text.Equals(""))
            {
                MessageBox.Show("Country Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientConTxt.Focus();
                return;
            }
           
            else if (clientZipTxt.Text.Equals(""))
            {
                MessageBox.Show(" Zipcode Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientZipTxt.Focus();
                return;
            }
            else if (clientEmailTxt.Text.Equals(""))
            {
                MessageBox.Show("Email Address Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientEmailTxt.Focus();
                return;
            }
            else if (clientTelTxt.Text.Equals(""))
            {
                MessageBox.Show("Telephone Number Must Be Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clientTelTxt.Focus();
                return;
            }
            

            
            MessageBox.Show("Client Account Createed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset ui
            clientIdTxt.Clear();
            clientNmeTxt.Clear();
            clientAddTxt.Clear();
            clientAddTxt.Clear();
            clientTownTxt.Clear();
            clientConTxt.Clear();
            clientZipTxt.Clear();
            clientEmailTxt.Clear();
            clientTelTxt.Clear();
           


         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            //getNext Product ID;
            clientIdTxt.Text = Clients.getNextClientId().ToString("0000");
        }


        private void newTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
