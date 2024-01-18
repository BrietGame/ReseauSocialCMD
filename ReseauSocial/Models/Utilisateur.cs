using ReseauSocial.Models;
using System;
using System.Collections.Generic;

namespace ReseauSocial
{
    internal class Utilisateur
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Email { get; set; }

        public List<Utilisateur> Amis { get; set; } = new List<Utilisateur>();

        public List<Publication> Publications { get; set; } = new List<Publication>();

        public Utilisateur(int id, string nom, string email)
        {
            Id = id;
            Nom = nom;
            Email = email;
            ConsoleUtils.consoleGreen($"L'utilisateur {nom} a été créé");
        }

        public void AjouterAmi(Utilisateur ami)
        {
            if (Amis != null)
                Amis.Add(ami);
        }

        public void SupprimerAmi(Utilisateur ami)
        {
            if (Amis != null)
                Amis.Remove(ami);
        }

        public void CreerPublication(Publication publication)
        {
            if (publication != null)
                Publications.Add(publication);
        }

        public void AfficherProfil()
        {
            ConsoleUtils.consoleYellow($"Profil de {Email} ({Nom})");
            ConsoleUtils.consoleYellow("Amis :");
            if (Amis != null && Amis.Count > 0)
                foreach (Utilisateur ami in Amis)
                    Console.WriteLine($"- {ami.Nom}");
            else
                ConsoleUtils.consoleRed("Aucun ami");

            ConsoleUtils.consoleYellow("Publications :");
            if (Publications != null && Publications.Count > 0)
                foreach (Publication publication in Publications)
                    publication.Afficher();
            else
                ConsoleUtils.consoleRed("Aucune publication");
        }
    }
}
