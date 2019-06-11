using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_MUSCUTIME
{
    class DonnéesPubliques
    {
        #region déclaration des paramètres de connexion du serveur
        public static String myValuelogin = "sa"; // login du serveur SQL Server
        public static String myValueMpd = "info"; // mot de passe du serveur SQL Server
        public static String myValueServeur = Environment.MachineName; // nom du serveur SQL Server
        public static String myValueBD = "BCA_MUSCUTIME"; // nom de la base de données 
        #endregion
        public static String nom;
        public static bool Insert;


        // Définition des 5 exercices :
        public static String Squats = "Squats";
        public static String Pompes = "Pompes";
        public static String Tractions = "Tractions";
        public static String Course = "Course";
        public static String DevCouche = "Développé Couché";

        // Définition des 5 exercices inséré
        public static String EXO1;
        public static String EXO2;
        public static String EXO3;
        public static String EXO4;
        public static String EXO5;

        // Temps des exo 

        public static int SQUATS = 10;
        public static int POMPES = 10;
        public static int TRACTIONS = 20;
        public static int COURSE = 60;
        public static int DEVCOUCHE = 20;

        public static int totaltempsexo = (SQUATS + POMPES + TRACTIONS + COURSE + DEVCOUCHE);

        // Temps du programme
        public static int TempsProg;

    }
}
