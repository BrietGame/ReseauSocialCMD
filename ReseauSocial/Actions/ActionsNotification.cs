using ReseauSocial.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReseauSocial.Actions
{
    internal class ActionsNotification
    {
        public void showMenu(List<Utilisateur> utilisateurs, Utilisateur utilisateur, List<Notification> notifications)
        {
            ConsoleUtils.consoleYellow("Menu notification");
            ConsoleUtils.consoleWhite("1. Afficher les notifications");
            ConsoleUtils.consoleWhite("2. Ajouter une notification");
            ConsoleUtils.consoleWhite("3. Supprimer une notification");
            ConsoleUtils.consoleWhite("4. Retour");
            switch (Console.ReadLine())
            {
                case "1":
                    AfficherNotifications(notifications);
                    break;
                case "2":
                    AjouterNotification(notifications);
                    break;
                case "3":
                    SupprimerNotification(notifications);
                    break;
                case "4":
                    break;
                default:
                    ConsoleUtils.consoleRed("Veuillez choisir un menu valide");
                    break;
            }
        }

        private void AfficherNotifications(List<Notification> notifications)
        {
            if (notifications != null && notifications.Count > 0)
                foreach (Notification notification in notifications)
                    notification.Afficher();
            else
                ConsoleUtils.consoleRed("Aucune notification");
        }

        private void AjouterNotification(List<Notification> notifications)
        {
            ConsoleUtils.consoleWhite("Contenu de la notification : ");
            string contenu = Console.ReadLine();
            Notification notification = new Notification();
            notification.Message = contenu;
            notification.DateHeureNotification = DateTime.Now;
            notifications.Add(notification);
        }

        private void SupprimerNotification(List<Notification> notifications)
        {
            ConsoleUtils.consoleWhite("Contenu de la notification : ");
            string contenu = Console.ReadLine();
            Notification notification = notifications.Where(p => p.Message == contenu).FirstOrDefault();
            if (notification != null)
                notifications.Remove(notification);
            else
                ConsoleUtils.consoleRed("Aucune notification");
        }
    }
}
