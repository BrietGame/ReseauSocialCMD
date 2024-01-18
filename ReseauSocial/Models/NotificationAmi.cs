using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Models
{
    internal class NotificationAmi
    {
        public Utilisateur NouvelAmi { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"Vous avez un nouvel ami : {NouvelAmi.Nom}");
        }
    }
}
