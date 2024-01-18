namespace ReseauSocial.Models
{
    internal class Like
    {
        public Utilisateur Utilisateur { get; set; }

        public Publication Publication { get; set; }

        public Like(Utilisateur utilisateur, Publication publication)
        {
            Utilisateur = utilisateur;
            Publication = publication;
        }
    }
}
