NewMethod();
static void NewMethod()
{
    //programm genereerib juhusliku numbrit 
    //kasutaja peab seda numbrit ära arvama 1-10
    // kui kasutaja suutis seda numbrit äraarvata siis kasutaja on mängu võitnud 
    // katsete arv 3 korda

    //programm genereerib 1 korda
    Random random = new Random();
    int cpu = random.Next(1, 11);
    int i = 0;
    Console.WriteLine("elcome to GuessingGame");





    while (i < 3)

    {

        Console.WriteLine("Please enter number 1-10:");
        int UserTry = Convert.ToInt32(Console.ReadLine());
        

        if (cpu == UserTry)
        {
            Console.WriteLine("Your win");
            break;
        }

        else
        {
            i = i + 1;
            Console.WriteLine($"You have  {3-i} tries");
            Console.WriteLine("You have luck on another time, try again later)");
        }

    }





}