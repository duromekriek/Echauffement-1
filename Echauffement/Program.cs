namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("je m'appele Thomas et mon jeu préféré est Project Zomboid");
        
        // Etape 2 : demandez à l'utilisateur son prénom et son âge 
        Console.WriteLine("Quel est ton prénom et ton âge?");
        string Ton_Prénom = Console.ReadLine();
        int Ton_âge = int.Parse(Console.ReadLine());
        
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (Ton_âge >= 18)
        {
            Console.WriteLine("Tu est majeur.");
        }
        else
        {
            Console.WriteLine("Tu est mineur.");
        }
        
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euros as tu?");
        int Tes_euros = int.Parse(Console.ReadLine());
        
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("je te propose un choix de quatre armes différentes.");
        Console.WriteLine("Arme 1 : 350 euros.");
        Console.WriteLine("Arme 2 : 1200 euros.");
        Console.WriteLine("Arme 3 : 3000 euros.");
        Console.WriteLine("Arme 4 : 9000 euros.");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("choisi l'arme que tu souhaites dans cette sélection.");
        int Arme = int.Parse(Console.ReadLine());
        int prix = 0;

        if (Arme == 1)
        {
            prix = 350;
        }
        else if (Arme == 2)
        {
            prix = 1200;
        }
        else if (Arme == 3)
        {
            prix = 3000;
        }
        else if (Arme == 4)
        {
            prix = 9000;

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4


        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible


        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}