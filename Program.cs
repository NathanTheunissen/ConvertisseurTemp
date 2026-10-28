using System.ComponentModel.Design;

namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        int answer;
        int answer2;

        Console.WriteLine("J'aimerais que tu m'indiques un nombre que je vais devoir convertir en température.");
        Console.WriteLine("Tout d'abord, choisis 1 si tu veux convertir des degrés Celsius en degrés Fahrenheit ou 2 si tu veux faire l'inverse.");
        answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 1)
        {
            Console.WriteLine("Dis moi maintenant un chiffre que je vais convertir en degrés Fahrenheit");
            answer2 = Convert.ToInt32(Console.ReadLine());
            int answerF = (answer2 * 9 / 5) + 32;
            {
                Console.WriteLine("Ton nombre en degrés Fahrenheit vaut " + answerF + " °F");
            }
        }
        else
        {
            Console.WriteLine("Dis moi maintenant un chiffre que je vais convertir en degrés Celsius");
            answer2 = Convert.ToInt32(Console.ReadLine());
            int answerC = (answer2 - 32) * 5 / 9;
            {
                Console.WriteLine("Ton nombre en degrés Celsius vaut " + answerC + " °C");
            }
        }

    }
}