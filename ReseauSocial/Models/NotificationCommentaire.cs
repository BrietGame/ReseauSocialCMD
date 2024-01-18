using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Models
{
    internal class NotificationCommentaire
    {
        public Commentaire CommentaireNouveau { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"Vous avez un nouveau commentaire de {CommentaireNouveau.Auteur.Nom} : {CommentaireNouveau.Texte}");
        }
    }
}
