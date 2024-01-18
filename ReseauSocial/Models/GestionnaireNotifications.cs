using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Models
{
    internal class GestionnaireNotifications
    {
        public List<Notification> Notifications { get; set; }

        public void AjouterNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AfficherToutesNotifications()
        {
            foreach(Notification notification in Notifications)
            {
                Console.WriteLine($"{notification.DateHeureNotification} : {notification.Message}");
            }
        }

        public void AfficherEtMarquerCommeLue(string cmd, Notification notification)
        {
            if (cmd == "mark")
            {
                Console.WriteLine($"{notification.DateHeureNotification} : {notification.Message}");
                notification.DateHeureNotification = DateTime.Now;
            } else if (cmd == "delete")
            {
                Notifications.Remove(notification);
            }
        }
    }
}
