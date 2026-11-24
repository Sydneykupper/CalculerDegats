namespace Calculer_degats;

/*
    CONSIGNES
    Dans votre jeu, chaque arme possède une puissance d'attaque.
    Vous devez créer une méthode CalculateWeaponDamage() qui reçoit deux paramètres :
    - weaponPower : la puissance de l'arme.
    - bonus : le bonus de dégâts du personnage.
    La méthode doit calculer les dégâts totaux et retourner le résultat.

    Dans Main() :
    1. Appelez la méthode avec une arme de puissance 40 et un bonus de 15.
    2. Récupérez le résultat dans une variable appelée degats.
    3. Affichez le nombre de dégâts infligés.
 */
class Program
{
    static void Main(string[] args)
    {
        int degats = CalculateWeaponDamage(40, 15);

        Console.WriteLine("Dégâts infligés : " + degats);

        int degatsBonus = CalculateWeaponDamage(60, 25);

        Console.WriteLine("Dégâts avec bonus : " + degatsBonus);
    }

    static int CalculateWeaponDamage(int weaponPower, int bonus)
    {
        return weaponPower + bonus;
    }
}