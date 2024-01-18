using System;

namespace ReseauSocial.Models
{
    internal class PublicationImage : Publication
    {
        public string CheminImage { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"Image : {CheminImage}");
        }
    }
}
