using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Models
{
    internal class Notification
    {
        public string Message { get; set; }

        public DateTime DateHeureNotification { get; set; }

        public void Afficher()
        {
            Console.WriteLine($"{DateHeureNotification} : {Message}");
        }
    }
}
