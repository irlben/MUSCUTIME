using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_MUSCUTIME
{
    public partial class FrmCreation : Form
    {
        Form frmProgramme = new FrmProgramme();
        SqlConnection gObjetConnection = new SqlConnection();
        String strRequete;
        SqlCommand command;
        private void MaConnexion()
        {
            // La propriété ConnectionString de notre objet gObjetConnection doit contenir les paramètres de connexion au serveur
            gObjetConnection.ConnectionString = "User ID = " + DonnéesPubliques.myValuelogin + ";PWD= " + DonnéesPubliques.myValueMpd + " ; Server= " + DonnéesPubliques.myValueServeur + "; Database= " + DonnéesPubliques.myValueBD + "; ";
            try //Tentative (try) d'ouverture d'un connexion avec le serveur de base de données
            {
                // Oyvrir la connexion en utilisant la méthode open() sur notre objet gObjetConnection
                gObjetConnection.Open();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Impossible de se connecter au serveur de base de données." + probleme.Message);
            }
        }
        public void declaration()
        {
            
        }
        private void MaDeconnexion()
        {
            gObjetConnection.Close();
        }

        public String VerifNom() {
            MaConnexion();
            #region verif nom
            // Initialisation de la requête de selection
            strRequete = "SELECT COUNT(ID) as NbDoublons FROM PROGRAMME WHERE NOM = '"+ TxtBoxNOM.Text + "'";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete
                String nb1;
                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                nb1 = command.ExecuteScalar().ToString();
                // affectation du résultat dans le label
                MaDeconnexion();
                return nb1;

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MaDeconnexion();
                return "";
            }
            #endregion
            

        }
        public FrmCreation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cpnt-ben.fr");
        }
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            MaConnexion();
            #region exécution de la requête de INSERT : PROGRAMME
            // Initialisation de la requête de selection
            String NOM = TxtBoxNOM.Text;
            String DESCRIPTION = TxtBoxDESC.Text;
            Double DUREE = Convert.ToDouble(TXTDUREE.Text);
            String AUTEUR = TxtBoxAuteur.Text;
            String IFSTATS = CbxStats.Text;
            strRequete = "INSERT INTO PROGRAMME (NOM,DUREE,DESCRIPTION,AUTEUR,IFSTATS) VALUES ('"+NOM+"',"+DUREE+",'"+DESCRIPTION+"','"+AUTEUR+"','"+IFSTATS+"')";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                command = new SqlCommand(strRequete, gObjetConnection);
                command.ExecuteNonQuery();
                

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            #endregion
            MaDeconnexion();
            DonnéesPubliques.nom = TxtBoxNOM.Text;
            this.Hide();
            frmProgramme.Owner = this;
            frmProgramme.ShowDialog();
            if (DonnéesPubliques.Insert)
            {
                this.Close();
                this.Owner.Show();
            }
            
        }
        private void TxtBoxNOM_TextChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(VerifNom()) > 1 )
            {
                MessageBox.Show("Erreur", "Erreur");
                TxtBoxNOM.Clear();
            }

           
        }
        private void FrmCreation_Load(object sender, EventArgs e)
        {
            LblNomValeurMax.Visible = false;
        }
    }
}
