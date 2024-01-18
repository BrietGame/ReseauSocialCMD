using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Models
{
    internal class NotificationLike
    {
        public Publication PublicationAimee { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"Publication aimée : {PublicationAimee.Contenu}");
        }
    }
}
