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
    public partial class FrmProgramme : Form
    {
        public string nom;
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
        private void MaDeconnexion()
        {
            gObjetConnection.Close();
        }

        public FrmProgramme()
        {
            InitializeComponent();
        }
        public string RecupIDProgram()
        {
            
            #region exécution de la requête de selection : nombre de villageois
            // Initialisation de la requête de selection
            strRequete = "SELECT ID FROM PROGRAMME WHERE NOM = '" + nom + "'";
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
                return nb1 = command.ExecuteScalar().ToString();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
                return "nothing";
            }
            #endregion

        }
        void NomProg ()
        {
            LblNomProgramme.Text = nom;

        }
        void InsertFinal()
        {
            String ID = RecupIDProgram();
            
            #region POS1
            if (PbxCourse_POS1.Visible)
            {
                // INSERT
                strRequete = "INSERT INTO POSSEDE (IDPRO,IDEXERCICE1) VALUES (" + ID + "," + 1 + ")";
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO1 = DonnéesPubliques.Course;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxDevCouche_POS1.Visible)
            {
                // INSERT
                strRequete = "INSERT INTO POSSEDE (IDPRO,IDEXERCICE1) VALUES (" + ID + "," + 2 + ")";
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO1 = DonnéesPubliques.DevCouche;


                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxPompes_POS1.Visible)
            {
                // INSERT
                strRequete = "INSERT INTO POSSEDE (IDPRO,IDEXERCICE1) VALUES (" + ID + "," + 3 + ")";
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO1 = DonnéesPubliques.Pompes;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxSquats_POS1.Visible)
            {
                // INSERT
                strRequete = "INSERT INTO POSSEDE (IDPRO,IDEXERCICE1) VALUES (" + ID + "," + 4 + ")";
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO1 = DonnéesPubliques.Squats;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxTractions_POS1.Visible)
            {
                // INSERT
                strRequete = "INSERT INTO POSSEDE (IDPRO,IDEXERCICE1) VALUES (" + ID + "," + 5 + ")";
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO1 = DonnéesPubliques.Tractions;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            #endregion
            #region POS2
            if (PbxTractions_POS2.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE2 = " + 5 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO2 = DonnéesPubliques.Tractions;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxSquats_POS2.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE2 = " + 4 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO2 = DonnéesPubliques.Squats;


                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxPompes_POS2.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE2 = " + 3 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO2 = DonnéesPubliques.Pompes;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxDevCouche_POS2.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE2 = " + 2 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO2 = DonnéesPubliques.DevCouche;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxCourse_POS2.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE2 = " + 1 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO2 = DonnéesPubliques.Course;


                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            #endregion
            #region POS3
            if (PbxCourse_POS3.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE3 = " + 1 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO3 = DonnéesPubliques.Course;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxDevCouche_POS3.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE3 = " + 2 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO3 = DonnéesPubliques.DevCouche ;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxPompes_POS3.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE3 = " + 3 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO3 = DonnéesPubliques.Pompes;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxSquats_POS3.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE3 = " + 4 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO3 = DonnéesPubliques.Squats;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxTractions_POS3.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE3 = " + 5 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO3 = DonnéesPubliques.Tractions;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            #endregion
            #region POS4
            if (PbxTractions_POS4.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE4 = " + 5 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO4 = DonnéesPubliques.Tractions;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxSquats_POS4.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE4 = " + 4 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO4 = DonnéesPubliques.Squats;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxPompes_POS4.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE4 = " + 3 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO4 = DonnéesPubliques.Pompes;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxDevCouche_POS4.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE4 = " + 2 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO4 = DonnéesPubliques.DevCouche;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxCourse_POS4.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE4 = " + 1 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO4 = DonnéesPubliques.Course;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            #endregion
            #region POS5
            if (PbxTractions_POS5.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE5 = " + 5 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO5 = DonnéesPubliques.Tractions;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxSquats_POS5.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE5 = " + 4 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO5 = DonnéesPubliques.Squats;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxPompes_POS5.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE5 = " + 3 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO5 = DonnéesPubliques.Pompes;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxDevCouche_POS5.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE5 = " + 2 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO5 = DonnéesPubliques.DevCouche;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            if (PbxCourse_POS5.Visible)
            {
                // INSERT
                strRequete = "UPDATE POSSEDE SET IDEXERCICE5 = " + 1 + " where IDPRO = " + ID;
                // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
                try
                {
                    command = new SqlCommand(strRequete, gObjetConnection);
                    command.ExecuteNonQuery();
                    DonnéesPubliques.EXO5 = DonnéesPubliques.Course;

                }
                catch (System.Data.SqlClient.SqlException probleme)
                {
                    MessageBox.Show("Problème dans la requete : " + probleme.Message);
                }
            }
            #endregion
        }
        private void FrmProgramme_Load(object sender, EventArgs e)
        {
            nom = DonnéesPubliques.nom;
            NomProg();
            defaultvisible();
        }
        void defaultvisible()
        {
            // Course
            PbxCourse_POS1.Visible = false;
            PbxCourse_POS2.Visible = false;
            PbxCourse_POS3.Visible = false;
            PbxCourse_POS4.Visible = false;
            PbxCourse_POS5.Visible = false;
            // Dev Couche
            PbxDevCouche_POS1.Visible = false;
            PbxDevCouche_POS2.Visible = false;
            PbxDevCouche_POS3.Visible = false;
            PbxDevCouche_POS4.Visible = false;
            PbxDevCouche_POS5.Visible = false;
            // Pompes
            PbxPompes_POS1.Visible = false;
            PbxPompes_POS2.Visible = false;
            PbxPompes_POS3.Visible = false;
            PbxPompes_POS4.Visible = false;
            PbxPompes_POS5.Visible = false;
            // Squats
            PbxSquats_POS1.Visible = false;
            PbxSquats_POS2.Visible = false;
            PbxSquats_POS3.Visible = false;
            PbxSquats_POS4.Visible = false;
            PbxSquats_POS5.Visible = false;
            // Tractions
            PbxTractions_POS1.Visible = false;
            PbxTractions_POS2.Visible = false;
            PbxTractions_POS3.Visible = false;
            PbxTractions_POS4.Visible = false;
            PbxTractions_POS5.Visible = false;
            // Close 
            Pbx_POS1_CLOSE.Visible = false;
            Pbx_POS2_CLOSE.Visible = false;
            Pbx_POS3_CLOSE.Visible = false;
            Pbx_POS4_CLOSE.Visible = false;
            Pbx_POS5_CLOSE.Visible = false;
        }
        private void PbxCourse_Click(object sender, EventArgs e)
        {
            #region Clique possibilité Position
            if (PbxDevCouche_POS1.Visible || PbxPompes_POS1.Visible || PbxSquats_POS1.Visible || PbxTractions_POS1.Visible || PbxCourse_POS1.Visible)
            {
                if (PbxDevCouche_POS2.Visible || PbxPompes_POS2.Visible || PbxSquats_POS2.Visible || PbxTractions_POS2.Visible || PbxCourse_POS2.Visible)
                {
                    if (PbxDevCouche_POS3.Visible || PbxPompes_POS3.Visible || PbxSquats_POS3.Visible || PbxTractions_POS3.Visible || PbxCourse_POS3.Visible)
                    {
                        if (PbxDevCouche_POS4.Visible || PbxPompes_POS4.Visible || PbxSquats_POS4.Visible || PbxTractions_POS4.Visible || PbxCourse_POS4.Visible)
                        {
                            if (PbxDevCouche_POS5.Visible || PbxPompes_POS5.Visible || PbxSquats_POS5.Visible || PbxTractions_POS5.Visible || PbxCourse_POS5.Visible)
                            {
                                MessageBox.Show("Nous avons un soucis, votre programme est plein", "Problème", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                PbxCourse_POS5.Visible = true;
                                Pbx_POS5_CLOSE.Visible = true;
                            }
                        }
                        else
                        {
                            PbxCourse_POS4.Visible = true;
                            Pbx_POS4_CLOSE.Visible = true;
                        }
                    }
                    else
                    {
                        PbxCourse_POS3.Visible = true;
                        Pbx_POS3_CLOSE.Visible = true;
                    }
                }
                else
                {
                    PbxCourse_POS2.Visible = true;
                    Pbx_POS2_CLOSE.Visible = true;
                }
            }
            else
            {
                PbxCourse_POS1.Visible = true;
                Pbx_POS1_CLOSE.Visible = true;
            } 
            #endregion
        }

        private void PbxDevCouche_Click(object sender, EventArgs e)
        {
            #region Clique possibilité Position
            if (PbxCourse_POS1.Visible || PbxPompes_POS1.Visible || PbxSquats_POS1.Visible || PbxTractions_POS1.Visible || PbxDevCouche_POS1.Visible)
            {
                if (PbxCourse_POS2.Visible || PbxPompes_POS2.Visible || PbxSquats_POS2.Visible || PbxTractions_POS2.Visible || PbxDevCouche_POS2.Visible)
                {
                    if (PbxCourse_POS3.Visible || PbxPompes_POS3.Visible || PbxSquats_POS3.Visible || PbxTractions_POS3.Visible || PbxDevCouche_POS3.Visible)
                    {
                        if (PbxCourse_POS4.Visible || PbxPompes_POS4.Visible || PbxSquats_POS4.Visible || PbxTractions_POS4.Visible || PbxDevCouche_POS4.Visible)
                        {
                            if (PbxCourse_POS5.Visible || PbxPompes_POS5.Visible || PbxSquats_POS5.Visible || PbxTractions_POS5.Visible || PbxDevCouche_POS5.Visible)
                            {
                                MessageBox.Show("Nous avons un soucis, votre programme est plein", "Problème", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                PbxDevCouche_POS5.Visible = true;
                                Pbx_POS5_CLOSE.Visible = true;
                            }
                        }
                        else
                        {
                            PbxDevCouche_POS4.Visible = true;
                            Pbx_POS4_CLOSE.Visible = true;
                        }
                    }
                    else
                    {
                        PbxDevCouche_POS3.Visible = true;
                        Pbx_POS3_CLOSE.Visible = true;
                    }
                }
                else
                {
                    PbxDevCouche_POS2.Visible = true;
                    Pbx_POS2_CLOSE.Visible = true;
                }
            }
            else
            {
                PbxDevCouche_POS1.Visible = true;
                Pbx_POS1_CLOSE.Visible = true;
            }
            #endregion
        }

        private void PbxPompes_Click(object sender, EventArgs e)
        {
            #region Clique possibilité Position
            if (PbxCourse_POS1.Visible || PbxDevCouche_POS1.Visible || PbxSquats_POS1.Visible || PbxTractions_POS1.Visible || PbxPompes_POS1.Visible)
            {
                if (PbxCourse_POS2.Visible || PbxDevCouche_POS2.Visible || PbxSquats_POS2.Visible || PbxTractions_POS2.Visible || PbxPompes_POS2.Visible)
                {
                    if (PbxCourse_POS3.Visible || PbxDevCouche_POS3.Visible || PbxSquats_POS3.Visible || PbxTractions_POS3.Visible || PbxPompes_POS3.Visible)
                    {
                        if (PbxCourse_POS4.Visible || PbxDevCouche_POS4.Visible || PbxSquats_POS4.Visible || PbxTractions_POS4.Visible || PbxPompes_POS4.Visible)
                        {
                            if (PbxCourse_POS5.Visible || PbxDevCouche_POS5.Visible || PbxSquats_POS5.Visible || PbxTractions_POS5.Visible || PbxPompes_POS5.Visible)
                            {
                                MessageBox.Show("Nous avons un soucis, votre programme est plein", "Problème", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                PbxPompes_POS5.Visible = true;
                                Pbx_POS5_CLOSE.Visible = true;
                            }
                        }
                        else
                        {
                            PbxPompes_POS4.Visible = true;
                            Pbx_POS4_CLOSE.Visible = true;
                        }
                    }
                    else
                    {
                        PbxPompes_POS3.Visible = true;
                        Pbx_POS3_CLOSE.Visible = true;
                    }
                }
                else
                {
                    PbxPompes_POS2.Visible = true;
                    Pbx_POS2_CLOSE.Visible = true;
                }
            }
            else
            {
                PbxPompes_POS1.Visible = true;
                Pbx_POS1_CLOSE.Visible = true;
            }
            #endregion
        }

        private void PbxSquats_Click(object sender, EventArgs e)
        {
            #region Clique possibilité Position
            if (PbxDevCouche_POS1.Visible || PbxPompes_POS1.Visible || PbxCourse_POS1.Visible || PbxTractions_POS1.Visible || PbxSquats_POS1.Visible)
            {
                if (PbxDevCouche_POS2.Visible || PbxPompes_POS2.Visible || PbxCourse_POS2.Visible || PbxTractions_POS2.Visible || PbxSquats_POS2.Visible)
                {
                    if (PbxDevCouche_POS3.Visible || PbxPompes_POS3.Visible || PbxCourse_POS3.Visible || PbxTractions_POS3.Visible || PbxSquats_POS3.Visible)
                    {
                        if (PbxDevCouche_POS4.Visible || PbxPompes_POS4.Visible || PbxCourse_POS4.Visible || PbxTractions_POS4.Visible || PbxSquats_POS4.Visible)
                        {
                            if (PbxDevCouche_POS5.Visible || PbxPompes_POS5.Visible || PbxCourse_POS5.Visible || PbxTractions_POS5.Visible || PbxSquats_POS5.Visible)
                            {
                                MessageBox.Show("Nous avons un soucis, votre programme est plein", "Problème", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                PbxSquats_POS5.Visible = true;
                                Pbx_POS5_CLOSE.Visible = true;
                            }
                        }
                        else
                        {
                            PbxSquats_POS4.Visible = true;
                            Pbx_POS4_CLOSE.Visible = true;
                        }
                    }
                    else
                    {
                        PbxSquats_POS3.Visible = true;
                        Pbx_POS3_CLOSE.Visible = true;
                    }
                }
                else
                {
                    PbxSquats_POS2.Visible = true;
                    Pbx_POS2_CLOSE.Visible = true;
                }
            }
            else
            {
                PbxSquats_POS1.Visible = true;
                Pbx_POS1_CLOSE.Visible = true;
            }
            #endregion
        }

        private void PbxTractions_Click(object sender, EventArgs e)
        {
            #region Clique possibilité Position
            if (PbxDevCouche_POS1.Visible || PbxPompes_POS1.Visible || PbxCourse_POS1.Visible || PbxSquats_POS1.Visible || PbxTractions_POS1.Visible)
            {
                if (PbxDevCouche_POS2.Visible || PbxPompes_POS2.Visible || PbxCourse_POS2.Visible || PbxSquats_POS2.Visible || PbxTractions_POS2.Visible)
                {
                    if (PbxDevCouche_POS3.Visible || PbxPompes_POS3.Visible || PbxCourse_POS3.Visible || PbxSquats_POS3.Visible || PbxTractions_POS3.Visible)
                    {
                        if (PbxDevCouche_POS4.Visible || PbxPompes_POS4.Visible || PbxCourse_POS4.Visible || PbxSquats_POS4.Visible || PbxTractions_POS4.Visible)
                        {
                            if (PbxDevCouche_POS5.Visible || PbxPompes_POS5.Visible || PbxCourse_POS5.Visible || PbxSquats_POS5.Visible || PbxTractions_POS5.Visible)
                            {
                                MessageBox.Show("Nous avons un soucis, votre programme est plein", "Problème", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                PbxTractions_POS5.Visible = true;
                                Pbx_POS5_CLOSE.Visible = true;
                            }
                        }
                        else
                        {
                            PbxTractions_POS4.Visible = true;
                            Pbx_POS4_CLOSE.Visible = true;
                        }
                    }
                    else
                    {
                        PbxTractions_POS3.Visible = true;
                        Pbx_POS3_CLOSE.Visible = true;
                    }
                }
                else
                {
                    PbxTractions_POS2.Visible = true;
                    Pbx_POS2_CLOSE.Visible = true;
                }
            }
            else
            {
                PbxTractions_POS1.Visible = true;
                Pbx_POS1_CLOSE.Visible = true;
            }
            #endregion
        }

        private void Pbx_POS1_CLOSE_Click(object sender, EventArgs e)
        {
            PbxTractions_POS1.Visible = false;
            PbxSquats_POS1.Visible = false;
            PbxPompes_POS1.Visible = false;
            PbxDevCouche_POS1.Visible = false;
            PbxCourse_POS1.Visible = false;
            Pbx_POS1_CLOSE.Visible = false;
        }

        private void Pbx_POS2_CLOSE_Click(object sender, EventArgs e)
        {
            PbxTractions_POS2.Visible = false;
            PbxSquats_POS2.Visible = false;
            PbxPompes_POS2.Visible = false;
            PbxDevCouche_POS2.Visible = false;
            PbxCourse_POS2.Visible = false;
            Pbx_POS2_CLOSE.Visible = false;
        }

        private void Pbx_POS3_CLOSE_Click(object sender, EventArgs e)
        {
            PbxTractions_POS3.Visible = false;
            PbxSquats_POS3.Visible = false;
            PbxPompes_POS3.Visible = false;
            PbxDevCouche_POS3.Visible = false;
            PbxCourse_POS3.Visible = false;
            Pbx_POS3_CLOSE.Visible = false;
        }

        private void Pbx_POS4_CLOSE_Click(object sender, EventArgs e)
        {
            PbxTractions_POS4.Visible = false;
            PbxSquats_POS4.Visible = false;
            PbxPompes_POS4.Visible = false;
            PbxDevCouche_POS4.Visible = false;
            PbxCourse_POS4.Visible = false;
            Pbx_POS4_CLOSE.Visible = false;
        }

        private void Pbx_POS5_CLOSE_Click(object sender, EventArgs e)
        {
            PbxTractions_POS5.Visible = false;
            PbxSquats_POS5.Visible = false;
            PbxPompes_POS5.Visible = false;
            PbxDevCouche_POS5.Visible = false;
            PbxCourse_POS5.Visible = false;
            Pbx_POS5_CLOSE.Visible = false;
        }

        private void PbxInfoCourse_Click(object sender, EventArgs e)
        {
            MaConnexion();
            #region exécution de la requête de selection : nombre de villageois
            // Initialisation de la requête de selection
            strRequete = "SELECT NOM,DUREE,DESCRIPTION FROM EXERCICE WHERE ID = 1";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                SqlDataReader SdrListe;
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete
                String nb1;
                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                SdrListe = command.ExecuteReader();
                // affectation du résultat dans le label
                while (SdrListe.Read())
                {
                    nb1 = "Description de l'exercice " + SdrListe["NOM"] + "\nNom : " + SdrListe["NOM"] + "\nDurée : " + SdrListe["DUREE"] + "\nDescription :  " + SdrListe["DESCRIPTION"];
                    MessageBox.Show(nb1, "OK");
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            #endregion
            MaDeconnexion();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
             this.Close();
            DonnéesPubliques.Insert = true;
            MaConnexion();
            InsertFinal();
            MaDeconnexion();
            String PrgInsere = "> Premier exercice : " + DonnéesPubliques.EXO1 + "\n> Deuxième exercice : " + DonnéesPubliques.EXO2 + "\n> Troisième exercice : " + DonnéesPubliques.EXO3 + "\n> Quatrième exercice : " + DonnéesPubliques.EXO4 + "\n> Cinquième exercice : " + DonnéesPubliques.EXO5;
            MessageBox.Show(PrgInsere, "Votre programme : " + nom, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Owner.Show();
            
        }

        private void PbxInfoDevCouche_Click(object sender, EventArgs e)
        {
            MaConnexion();
            #region exécution de la requête de selection : nombre de villageois
            // Initialisation de la requête de selection
            strRequete = "SELECT NOM,DUREE,DESCRIPTION FROM EXERCICE WHERE ID = 2";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                SqlDataReader SdrListe;
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete
                String nb1;
                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                SdrListe = command.ExecuteReader();
                // affectation du résultat dans le label
                while (SdrListe.Read())
                {
                    nb1 = "Description de l'exercice " + SdrListe["NOM"] + "\nNom : " + SdrListe["NOM"] + "\nDurée : " + SdrListe["DUREE"] + "\nDescription :  " + SdrListe["DESCRIPTION"];
                    MessageBox.Show(nb1, "OK");
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            #endregion
            MaDeconnexion();
        }

        private void PbxInfoPompes_Click(object sender, EventArgs e)
        {
            MaConnexion();
            #region exécution de la requête de selection : nombre de villageois
            // Initialisation de la requête de selection
            strRequete = "SELECT NOM,DUREE,DESCRIPTION FROM EXERCICE WHERE ID = 3";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                SqlDataReader SdrListe;
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete
                String nb1;
                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                SdrListe = command.ExecuteReader();
                // affectation du résultat dans le label
                while (SdrListe.Read())
                {
                    nb1 = "Description de l'exercice " + SdrListe["NOM"] + "\nNom : " + SdrListe["NOM"] + "\nDurée : " + SdrListe["DUREE"] + "\nDescription :  " + SdrListe["DESCRIPTION"];
                    MessageBox.Show(nb1, "OK");
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            #endregion
            MaDeconnexion();
        }

        private void PbxInfoSquats_Click(object sender, EventArgs e)
        {
            MaConnexion();
            #region exécution de la requête de selection : nombre de villageois
            // Initialisation de la requête de selection
            strRequete = "SELECT NOM,DUREE,DESCRIPTION FROM EXERCICE WHERE ID = 4";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                SqlDataReader SdrListe;
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete
                String nb1;
                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                SdrListe = command.ExecuteReader();
                // affectation du résultat dans le label
                while (SdrListe.Read())
                {
                    nb1 = "Description de l'exercice " + SdrListe["NOM"] + "\nNom : " + SdrListe["NOM"] + "\nDurée : " + SdrListe["DUREE"] + "\nDescription :  " + SdrListe["DESCRIPTION"];
                    MessageBox.Show(nb1, "OK");
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            #endregion
            MaDeconnexion();
        }

        private void PbxInfoTractions_Click(object sender, EventArgs e)
        {
            MaConnexion();
            #region exécution de la requête de selection : nombre de villageois
            // Initialisation de la requête de selection
            strRequete = "SELECT NOM,DUREE,DESCRIPTION FROM EXERCICE WHERE ID = 5";
            // Tentative (Try) d'éxécution de la requête sur la base de données correspondante à notre connexion
            try
            {
                SqlDataReader SdrListe;
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete
                String nb1;
                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                SdrListe = command.ExecuteReader();
                // affectation du résultat dans le label
                while (SdrListe.Read())
                {
                    nb1 = "Description de l'exercice " + SdrListe["NOM"] + "\nNom : " + SdrListe["NOM"] + "\nDurée : " + SdrListe["DUREE"] + "\nDescription :  " + SdrListe["DESCRIPTION"];
                    MessageBox.Show(nb1, "OK");
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            #endregion
            MaDeconnexion();
        }
    }
}
