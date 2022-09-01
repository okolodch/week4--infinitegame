NewMethod();

static void NewMethod()
{


    //programm küsib kasutajalt sisestada pinkoodi;
    //programm võrdleb sisestatud PIN- koodi arvuga 1234;
    // kui sisestatud pin kood on 1234, siis konsool kuvab "tere tulemst";
    // kui sisestatud pin kood on midagi muud, siis konsool kuvab "vale pin. proovi uuesti";
    //Kasutajal on 3 katset; i<3


    int i = 0; // i- iteration
    while(i < 3)//while-loop
    {
       
        Console.WriteLine("Sisestage palun PIN :");

        int userPIN = Convert.ToInt32(Console.ReadLine());

        if(userPIN == 1234)
        {
            Console.WriteLine("Tere tulemast!");
            break;

        }
        else
        {
            i = i + 1;
            Console.WriteLine($"Vale PIN . {3 - i} katset on jäänud. Proovige uuesti. Kui olete unustanud oma PIN-koodi, siis palun pöörduge administraatori poole.");
        }
        //i = i + 1;

    }
    

    
    
    

   
    Console.WriteLine("Kena päeva!");
   
}
