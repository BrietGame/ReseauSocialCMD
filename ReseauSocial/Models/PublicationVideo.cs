using System;

namespace ReseauSocial.Models
{
    internal class PublicationVideo : Publication
    {
        public string CheminVideo { get; set; }

        public TimeSpan Duree { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"Video : {CheminVideo} d'une durée de {Duree}");
        }
    }
}
