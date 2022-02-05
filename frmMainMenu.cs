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
    public partial class frmMainMnu : Form
    {
        public frmMainMnu()
        {
            InitializeComponent();
        }

        private void nCToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddClient addForm = new frmAddClient();
            addForm.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeClAccToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseClient closeClient = new frmCloseClient();
            closeClient.Show();
        }

        private void printClStatToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrintStatement printStatement = new frmPrintStatement();
            printStatement.Show();
        }

        private void makeResToolStripMnu_Click(object sender, EventArgs e)
        {
            //this.Hide();
           // frmMakeReservation showForm = new frmMakeReservation();
            //showForm.Show();
        }

        private void cancelResToolStripMnu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmCancelReservation cancelRes = new frmCancelReservation();
            //cancelRes.Show();
        }

        private void cCarToolStripMnu_Click(object sender, EventArgs e)
        {
           // this.Hide();
            //frmCollectCar frmCollect = new frmCollectCar();
            //frmCollect.Show();
        }

        private void rCarToolStripMnu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmReturnCar frmReturn = new frmReturnCar();
            //frmReturn.Show();
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
