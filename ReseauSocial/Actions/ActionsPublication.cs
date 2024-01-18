using ReseauSocial.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReseauSocial.Actions
{
    internal class ActionsPublication : Actions
    {
        public void showMenu(List<Utilisateur> utilisateurs, Utilisateur utilisateur)
        {
            ConsoleUtils.consoleYellow("Menu publication");
            ConsoleUtils.consoleWhite("1. Afficher les publications");
            ConsoleUtils.consoleWhite("2. Ajouter une publication");
            ConsoleUtils.consoleWhite("3. Supprimer une publication");
            ConsoleUtils.consoleWhite("4. Retour");
            switch (Console.ReadLine())
            {
                case "1":
                    AfficherPublications(utilisateur);
                    break;
                case "2":
                    AjouterPublication(utilisateur);
                    break;
                case "3":
                    SupprimerPublication(utilisateur);
                    break;
                case "4":
                    break;
                default:
                    ConsoleUtils.consoleRed("Veuillez choisir un menu valide");
                    break;
            }
        }

        private void AfficherPublications(Utilisateur utilisateur)
        {
            ConsoleUtils.consoleYellow("Publications :");
            if (utilisateur.Publications != null && utilisateur.Publications.Count > 0)
                foreach (Publication publication in utilisateur.Publications)
                    AfficherUnePublication(utilisateur);
            else
                ConsoleUtils.consoleRed("Aucune publication");
        }

        private void AfficherUnePublication(Utilisateur utilisateur)
        {
            ConsoleUtils.consoleYellow("Choisir un ID de publication :");
            int id = int.Parse(Console.ReadLine());
            Publication publication = utilisateur.Publications.Where(p => p.Id == id).FirstOrDefault();
            if (publication != null)
            {
                publication.Afficher();
                ConsoleUtils.consoleYellow("Voulez-vous commentez, likez ?");
                ConsoleUtils.consoleWhite("1. Commenter");
                ConsoleUtils.consoleWhite("2. Liker");
                ConsoleUtils.consoleWhite("3. Retour");
                switch (Console.ReadLine())
                {
                    case "1":
                        CommenterPublication(utilisateur, publication);
                        break;
                    case "2":
                        LikerPublication(utilisateur, publication);
                        break;
                    case "3":
                        break;
                    default:
                        ConsoleUtils.consoleRed("Veuillez choisir un menu valide");
                        break;
                }
            } else {
                ConsoleUtils.consoleRed("Aucune publication trouvée avec cet ID");
            }
        }

        private void AjouterPublication(Utilisateur utilisateur)
        {
            ConsoleUtils.consoleWhite("Contenu de la publication : ");
            string contenu = Console.ReadLine();
            Publication publication = new Publication();
            publication.Id = utilisateur.Publications.Count + 1;
            publication.Contenu = contenu;
            publication.Auteur = utilisateur;
            utilisateur.CreerPublication(publication);
        }

        private void SupprimerPublication(Utilisateur utilisateur)
        {
            ConsoleUtils.consoleWhite("Contenu de la publication : ");
            string contenu = Console.ReadLine();
            Publication publication = utilisateur.Publications.Where(p => p.Contenu == contenu).FirstOrDefault();
            if (publication != null)
                utilisateur.Publications.Remove(publication);
            else
                ConsoleUtils.consoleRed("Aucune publication trouvée avec ce contenu");
        }

        private void CommenterPublication(Utilisateur utilisateur, Publication publication)
        {
            ConsoleUtils.consoleYellow("Commentaire :");
            string commentaire = Console.ReadLine();
            Commentaire commentairePublication = new Commentaire();
            commentairePublication.Texte = commentaire;
            publication.AjouterCommentaire(commentairePublication);
        }

        private void LikerPublication(Utilisateur utilisateur, Publication publication)
        {
            Like like = new Like(utilisateur, publication);
            publication.AjouterLike(like);
        }
    }
}
