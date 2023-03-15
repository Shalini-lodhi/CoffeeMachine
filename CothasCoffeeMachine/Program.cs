using CothasCoffeeMachine;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        SystemMessages.WelcomeMessage();
        
        IngradiantType beverage = new IngradiantType();

        SystemMessages.OptionsMessage();
        beverage.Name = (Beverage)int.Parse(Console.ReadLine());
        
        SystemMessages.CupSizeOptionMessage();
        beverage.CupSize = (Amount)int.Parse(Console.ReadLine());



        SystemMessages.ServingMessage(beverage.Name, beverage.CupSize);
        SystemMessages.EndMessage();
    }
}