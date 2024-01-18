using ReseauSocial.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReseauSocial.Actions
{
    internal class ActionsUtilisateur
    {
        public void showMenu(List<Utilisateur> utilisateurs, Utilisateur utilisateur, List<Publication> publications)
        {
            ConsoleUtils.consoleYellow("Menu utilisateur");
            ConsoleUtils.consoleWhite("1. Afficher profil");
            ConsoleUtils.consoleWhite("2. Ajouter un ami");
            ConsoleUtils.consoleWhite("3. Supprimer un ami");
            ConsoleUtils.consoleWhite("4. Créer une publication");
            ConsoleUtils.consoleWhite("5. Retour");
            switch (Console.ReadLine())
            {
                case "1":
                    utilisateur.AfficherProfil();
                    break;
                case "2":
                    AjouterAmi(utilisateurs, utilisateur);
                    break;
                case "3":
                    SupprimerAmi(utilisateur);
                    break;
                case "4":
                    CreerPublication(publications, utilisateur);
                    break;
                case "5":
                    break;
                default:
                    ConsoleUtils.consoleRed("Veuillez choisir un menu valide");
                    break;
            }
        }

        private void AjouterAmi(List<Utilisateur> utilisateurs, Utilisateur utilisateur)
        {
            ConsoleUtils.consoleWhite("Email de l'ami : ");
            string email = Console.ReadLine();
            Utilisateur ami = utilisateurs.Where(u => u.Email == email).FirstOrDefault();
            if (ami != null)
                utilisateur.AjouterAmi(ami);
            else
                ConsoleUtils.consoleRed("Aucun utilisateur trouvé avec cet email");
        }

        private void SupprimerAmi(Utilisateur utilisateur)
        {
            ConsoleUtils.consoleWhite("Email de l'ami : ");
            string email = Console.ReadLine();
            Utilisateur ami = utilisateur.Amis.Where(u => u.Email == email).FirstOrDefault();
            if (ami != null)
                utilisateur.SupprimerAmi(ami);
            else
                ConsoleUtils.consoleRed("Aucun utilisateur trouvé avec cet email");
        }

        private void CreerPublication(List<Publication> publications, Utilisateur utilisateur)
        {
            Publication publication = new Publication();
            publication.Auteur = utilisateur;
            ConsoleUtils.consoleWhite("Contenu : ");
            publication.Contenu = Console.ReadLine();
            publication.DateHeurePublication = DateTime.Now;
            utilisateur.CreerPublication(publication);
        }
    }
}
