using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseauSocial.Actions
{
    internal interface Actions
    {
        void showMenu(List<Utilisateur> utilisateurs, Utilisateur utilisateur);
    }
}
