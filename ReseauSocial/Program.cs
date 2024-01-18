using ReseauSocial.Actions;
using ReseauSocial.Models;
using System;
using System.Collections.Generic;

namespace ReseauSocial
{
    internal class Program
    {
        private static List<Utilisateur> utilisateurs = new List<Utilisateur>();

        private static List<Notification> notifications = new List<Notification>();

        private static List<Publication> publications = new List<Publication>();

        private static Utilisateur utilisateur;

        static void Main(string[] args)
        {
            ConsoleUtils.consoleYellow("Bienvenue dans le réseau social");
            CreerUtilisateur();

            while(true)
            {
                ConsoleUtils.consoleWhite("Menus :");
                ConsoleUtils.consoleWhite("1. Menu utilisateur");
                ConsoleUtils.consoleWhite("2. Menu publication");
                ConsoleUtils.consoleWhite("3. Menu notification");
                ConsoleUtils.consoleWhite("4. Quitter");
                switch (Console.ReadLine())
                {
                    case "1":
                        MenuUtilisateur();
                        break;
                    case "2":
                        MenuPublication();
                        break;
                    case "3":
                        MenuNotification();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        ConsoleUtils.consoleRed("Veuillez choisir un menu valide");
                        break;
                }
            }
        }

        private static void CreerUtilisateur()
        {
            ConsoleUtils.consoleYellow("Veuillez créer un compte");
            ConsoleUtils.consoleWhite("Nom : ");
            string nom = Console.ReadLine();
            ConsoleUtils.consoleWhite("Email : ");
            string email = Console.ReadLine();
            utilisateur = new Utilisateur(1, nom, email);
            utilisateurs.Add(utilisateur);
        }

        private static void MenuUtilisateur()
        {
            ActionsUtilisateur actionsUtilisateur = new ActionsUtilisateur();
            actionsUtilisateur.showMenu(utilisateurs, utilisateur, publications);
        }

        private static void MenuPublication()
        {
            ActionsPublication actionsPublication = new ActionsPublication();
            actionsPublication.showMenu(utilisateurs, utilisateur);
        }

        private static void MenuNotification()
        {
            ActionsNotification actionsNotification = new ActionsNotification();
            actionsNotification.showMenu(utilisateurs, utilisateur, notifications);
        }
    }
}
