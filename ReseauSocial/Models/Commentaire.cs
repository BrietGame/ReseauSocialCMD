using System;
using System.Collections.Generic;

namespace ReseauSocial.Models
{
    internal class Commentaire
    {
        public string Texte { get; set; }

        public Utilisateur Auteur { get; set; }

        public Publication Publication { get; set; }

        public List<Commentaire> Reponses { get; set; }

        public void AjouterReponses(Commentaire reponse)
        {
            Reponses.Add(reponse);
        }

        public void Afficher()
        {
            Console.WriteLine($"- {Auteur.Nom} dit :");
            Console.WriteLine(Texte);
            foreach (Commentaire reponses in Reponses)
            {
                Console.WriteLine($"- {reponses.Auteur.Nom} dit \"{reponses.Texte}\"");
            }
        }
    }
}
