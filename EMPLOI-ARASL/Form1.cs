using DevExpress.XtraGrid.Views.Grid;
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
            

            try
            {
                //Vérifier que les champs ne sont pas vide
                if (tbnom.Text=="")
                {
                    if (tbprenom.Text=="")
                    {
                        if (tbtel.Text == "")
                        {
                            if (tbmail.Text == "")
                            {
                                if (tbdipl.Text == "")
                                {
                                    MessageBox.Show("Vous devez renseigner  le nom, le prénom, le numéro de téléphone, l'adresse mail et le diplôme obtenu", "Information");
                                }
                            }
                        }

                    }

                }

                else
                {
                    using (var bd = new ARASLEntities())
                    {
                        var personne = new Chomeur()
                        {
                            actif = (bool)radioacrif.EditValue,
                            diplome = tbdipl.Text,
                            dob = tbdob.DateTime.Date,
                            employe = (bool)radioemp.EditValue,
                            formation = richform.Text,
                            lieuresidenc = tblieu.Text,
                            mail = tbmail.Text,
                            nom = tbnom.Text,
                            prenom = tbprenom.Text,
                            tel = (string)tbtel.EditValue,
                            villagenaiss = tbvillage.Text,
                        };

                        bd.Chomeurs.Add(personne);

                        bd.SaveChanges();
                        //gridControl1.DataSource = "";
                        //gridControl1.DataSource = chomeursBindingSource;
                        gridControl1.RefreshDataSource();

                    }

                    MessageBox.Show("Insertion effectuée avec succès");
                }
               

            }
            catch (Exception b )
            {
                //MessageBox.Show("  " + radioacrif.EditValue + "  " + tbdipl.Text + "  " + tbdob.DateTime.Date + "  " + radioemp.EditValue + "  " + richform.Text + "  " + tblieu.Text +
                //  "  " + tbmail.Text + "  " + tbnom.Text + "  " + tbtel.Text + "  " + tbvillage.Text);
              MessageBox.Show("Une erreur s'est produite. veuillez vérifier les informations et réessayer \n" +b.ToString());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'aRASLDataSet.Chomeurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chomeursTableAdapter.Fill(this.aRASLDataSet.Chomeurs);

        }

        private void btprint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void tbdel_Click(object sender, EventArgs e)
        {
           // int valeur = (int)gridView1.GetFocusedRowCellValue("Id");
          //  MessageBox.Show(" " + valeur);

            try
            {

                using (var db = new ARASLEntities())
                {
                    int valeur = (int)gridView1.GetFocusedRowCellValue("Id");
                    var supp = (from ch in db.Chomeurs
                                where ch.Id == valeur
                                select ch).First();

                    if (supp != null)
                    {
                        db.Chomeurs.Remove(supp);
                    }
                    db.SaveChanges();
                    gridControl1.RefreshDataSource();
                    MessageBox.Show("Personne supprimée de la base");

                }

            }
            catch (Exception )
            {

                MessageBox.Show(" Une erreur s'est produite lors de la suppression, veuillez réessayer");
            }



        }
    }
}
