internal class Program
{
    private static void Main(string[] args)
    {
        //prova de push
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Geography();
                    break;

               /* case ConsoleKey.D2:
                    History();
                    break;

                case ConsoleKey.D3:
                    Science();
                    break;*/

                case ConsoleKey.D0:
                    MsgNextScreen("Press any key to exit");
                    break;

                default:
                    MsgNextScreen("Error. Prem una tecla per a tornar al menu... ");
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void ShowOptions()
    {
        Console.WriteLine("Choose one topic");

        Console.WriteLine("1- Geography");
        Console.WriteLine("2- History");
        Console.WriteLine("3- Science");
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    public static void Geography()
    {
        int questionNum;
        Console.WriteLine("Digues un num del 1 - 5");
        questionNum = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (questionNum == 1)
            {
                char answer;
                Console.WriteLine("Quina es la capital d'Espanya");
                Console.WriteLine("a. Madrid");
                Console.WriteLine("b. Oslo");
                Console.WriteLine("c. Barcelona");
                Console.WriteLine("d. Berlin");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'a') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
                


            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }


}