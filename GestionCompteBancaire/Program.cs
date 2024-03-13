namespace GestionCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new CompteBancaire("Diana", 1000);
            Console.WriteLine($"Le Compte {account.Numero} a été crée pour {account.Proprietaire} avec un solde de {account.Solde} Euros");

            account.FaireRetrait(500, DateTime.Now, "Paiement du loyer");  // Ajoutez du code de test
            Console.WriteLine(account.Solde);
            account.FaireDepot(100, DateTime.Now, "Reboursement des copains");
            Console.WriteLine(account.Solde);
            CompteBancaire compte = null;
            int choix = 1;
            do
            {
                String saisie = AfficherMenu();
                choix = Convert.ToInt32(saisie);
                switch (choix)

                {
                    case 1:
                        account = CreerCompte();
                        break;
                    case 2:
                        Console.WriteLine("Faire un depot");
                        break;
                    case 3:
                        Console.WriteLine("Faire un retrait");
                        break;
                    case 4:
                        Console.WriteLine("Afficher des Transaction");
                        break;
                    case 5:
                        Console.WriteLine("Afficher le solde");
                        break;
                    case 0:
                        Console.WriteLine("Au revoir...");
                        break;
                }

            } while (choix != 0);
        }

        private static String AfficherMenu()
        {
            int choix;
            Console.WriteLine("--=== Menu ===--");
            Console.WriteLine("\t 0 Quitter: 1 Cree un Compte: 2 Faire un Depot: 3 Faire un retrait: 4 Afficher des Transaction: 5 le solde");
            Console.WriteLine("0: Quitter");
            Console.WriteLine("Votre choix");
            var saisie = Console.ReadLine();
            return saisie;
        }
        private static CompteBancaire CreerCompte()
        {
            CompteBancaire compte = null;
            string nom, solde;
            decimal valeur = 0;
            Console.WriteLine("Creer un compte");
            Console.WriteLine("Quel votre nom?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre solde actuelle?");
            solde = Console.ReadLine(); 
            valeur = Convert.ToDecimal(solde);
            compte = new CompteBancaire(nom, valeur);
            Console.WriteLine("Votre compte bancaire viens d'être fait");
            return compte;
        }
    }
}
