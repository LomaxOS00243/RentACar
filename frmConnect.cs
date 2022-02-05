using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace RentACar
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                lbl1.Text = "Connection is Open";
            }
            catch(Exception rx)
            {
               MessageBox.Show("Unable to connect to the database!\n"+ rx.ToString());
             
            }
            

           
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Close();
            lbl1.Text = "Connection is Close";
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
