﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM.Classes.Nico
{
    class MotDePasse
    {
        private static List<MotDePasse> listeUtilisateur = new List<MotDePasse>();

        public static void ChargeUtilisateur()
        {
            listeUtilisateur.Add(new MotDePasse("Max", "pass", "Quéro","Maxime","client"));
            listeUtilisateur.Add(new MotDePasse("Nico", "pass", "Leclercq","Nicolas","client"));
            listeUtilisateur.Add(new MotDePasse("admin", "", "admin","admin","admin"));
        }

        public static List<MotDePasse> getListUtilisateur()
        {
            return listeUtilisateur;
        }

        private string pseudo;

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }
        private string motDePasse;

        public string Mdp
        {
            get { return motDePasse; }
            set { motDePasse = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public MotDePasse(string pseudo, string motDePasse, string nom, string prenom, string type)
        {
            this.pseudo = pseudo;
            this.motDePasse = motDePasse;
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
        }

    }
}
