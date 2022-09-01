NewMethod();
static void NewMethod()
{
    //programm genereerib juhusliku numbrit 
    //kasutaja peab seda numbrit ära arvama 1-10
    // kui kasutaja suutis seda numbrit äraarvata siis kasutaja on mängu võitnud 
    // katsete arv piiramatu 

    //programm genereerib 1 korda
    bool loopActive = true;
    Random random = new Random();
    int cpu = random.Next(1, 11);
    int i = 0;  
    Console.WriteLine("Welcome to GuessingGame");
   




    while ( loopActive)

    {
        
        Console.WriteLine("Please enter number 1-10:");
        int UserTry = Convert.ToInt32(Console.ReadLine());

        if (cpu == UserTry)    
        {
            Console.WriteLine("Your win!!!");
            break;
        }

        else
        {
            Console.WriteLine("Please try again!");
        }
           
    }




    
}