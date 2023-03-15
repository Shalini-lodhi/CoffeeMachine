namespace CothasCoffeeMachine
{
    public class SystemMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Wecolme to Cothas Coffee");
        }

        // Cup size
        public static void CupSizeOptionMessage()
        {
            Console.WriteLine("Make Cupt size choice:\n" +
                "0.Full Cup\n" +
                "1.Half Cup");
        }
        public static void OptionsMessage() 
        {
            Console.WriteLine("Make the choice:\n" +
                "1.Coffee\n" +
                "2.Tea\n" +
                "3.Milk\n" +
                "4.Water");
        }

        //Serving Message
        public static void ServingMessage(Beverage name, Amount amount)
        {
            Console.WriteLine($"Serving {name}, {amount}");
        }

        //End Message
        public static void EndMessage()
        {
            Console.WriteLine("Thank You");
        }
    }
}
