using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOI_ARASL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbnom.Text = "";
            tbprenom.Text = "";
            tbdob.DateTime = DateTime.Today;
            tbvillage.Text = "";
            tbtel.Text = "";
            tbmail.Text = "";
            tblieu.Text = "";
            tbdipl.Text = "";
            richform.Clear();

        }

        private void btvalid_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbdob.DateTime.ToShortDateString());

            try
            {
                using (ARASLEntities per=new ARASLEntities())
                {

                }
            }
            catch 
            {

                MessageBox.Show("Une erreur s'est produite. veuillez vérifier les informations et réessayer");
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }
    }
}
