using System;
using System.Collections.Generic;

namespace ReseauSocial.Models
{
    internal class Publication
    {
        public int Id { get; set; }

        public string Contenu { get; set; }

        public DateTime DateHeurePublication { get; set; }

        public Utilisateur Auteur { get; set; }

        public List<Like> Likes { get; set; } = new List<Like>();

        public List<Commentaire> Commentaires { get; set; } = new List<Commentaire>();

        public void AjouterLike(Like like)
        {
            Likes.Add(like);
        }

        public void AjouterCommentaire(Commentaire commentaire)
        {
            Commentaires.Add(commentaire);
        }

        public void Afficher()
        {
            Console.WriteLine($"Publication de {Auteur?.Nom} :");
            Console.WriteLine(Contenu);
            Console.WriteLine($"Likes {Likes.Count}");
            foreach(Like like in Likes)
            {
                Console.WriteLine($"- {like.Utilisateur?.Nom}");
            }
            Console.WriteLine($"Commentaires {Commentaires.Count}");
            foreach (Commentaire commentaire in Commentaires)
            {
                Console.WriteLine($"- {commentaire.Auteur?.Nom} dit :");
                Console.WriteLine(commentaire.Texte);
                if (commentaire.Reponses != null && commentaire.Reponses.Count > 0)
                {
                    foreach (Commentaire reponses in commentaire.Reponses)
                    {
                        Console.WriteLine($"- {reponses.Auteur.Nom} dit \"{reponses.Texte}\"");
                    }
                }
            }
        }
    }
}
