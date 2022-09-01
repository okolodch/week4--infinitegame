

//programm küsib kasutajalt sisestada pinkoodi;
//programm võrdleb sisestatud PIN- koodi arvuga 1234;
// kui sisestatud pin kood on 1234, siis konsool kuvab "tere tulemst";
// kui sisestatud pin kood on midagi muud, siis konsool kuvab "vale pin. proovi uuesti";
//Kasutajal on 3 katset; i<3
//katsete arv on piiramatu

NewMethod();

static void NewMethod()
{
    bool loopActive = true; // true või false 
    int i = 0;
    while (loopActive)
    {

        Console.WriteLine("Sisestage PIN:");
        int userPIN = Convert.ToInt32(Console.ReadLine());
        
        if(userPIN == 1234)    
            {
            Console.WriteLine("Tere tulemast!");
            loopActive = false;
        }
        else
        {   
            i++;
            Console.WriteLine("vale PIN, proovige uuesti");
            Console.WriteLine($"Oled vale PIN- koodi {i} korda sisestanud");
        }
        Console.WriteLine("Kena päeva!");
    }



}