using System.Diagnostics;

namespace programflyt;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Vi skal se på programflyt, og her skal vi prøve å lage tilgangskontroll for et utested.


        Vi skal kunne se på en alder age, og basert på alderen, se om de får slippe inn på utestedet. 

        vi trenger en age variable. age er en form for telling, så vi kan ha det som en integer.

        vi trenger å kunne sammenlinge age med en form for maksgrense, f.eks lowerLimit, for å unngå implicit cast issues kan dette også være en integer.

        Vi trenger så å bestemme om vedkommene kommer inn basert på sammenligning.

        Vi kan tenke oss at koden skal se slik ut:

        int age (har et tall)
        int lowerLimit = 21;

        hvis age < lowerLimit
            Vedkommende kommer ikke inn.
        Ellers 
            Vedkommende kommer inn. 
         */

         int age = 25;
         int lowerLimit = 21;

         if (age < lowerLimit)
         {
           Console.WriteLine("You are not old enough to enter."); 
         }
         else
         {
            Console.WriteLine("Welcome in!");
         }


         /* 
         Vi kan lage flere grener i programmet vårt via else if / ellers hvis

         f.eksempel:
         programmet vårt over skal kunne styre tilgang til to forskjellige utesteder.
         Ene utestedet slipper inn personer eldre enn 18, og det andre eldre enn 21.

         int age (et tall)
         int lowestLimit = 18;
         int lowerLimit = 21;
         
         hvis age mindre enn lowest limit
            Ingen tilgang
        ellers hvis age er mindre enn lowerLimit
            Tilgang til utested 1
        ellers
            Tilgang til begge.
          */

        int customerAge = 17;
        /* int lowestLimit = 18;
        int higherLimit = 21; */

        /* if (customerAge < lowestLimit)
        {
            Console.WriteLine("You're not old enough to enter either establishment.");
        }
        else if (customerAge < higherLimit)
        {
            Console.WriteLine("You can enter 18+ establishment");
        } 
        else 
        {
            Console.WriteLine("You can enter either establishment");
        } */
        /* 
        Opperasjonen vi gjør ovenfor kan også representere via en Switch-Case statement.
        Der ser vi om verdien til en variabel "switcher" og kjører forskjellige kodeblokker, eller "caser" for hver gyldig verdi av variablen vår. */

        switch (customerAge)
        {
            case <18: 
            {
                Console.WriteLine("You're not old enough to enter either establishment.");
                break;
            }
            case <21:
            {
                Console.WriteLine("You can enter 18+ establishment");
                break;
            }
            default: 
            {
                Console.WriteLine("You can enter either establishment");
                break;
            }
        }
        

        /* 
        Nedenfor ser vi et eksempel hvor vi har to uavhengige variabler, som begge skjekkes i en if statement. 
        
        Vi skal se på to brukerinputs, en er et brukernavn, det andre er et passord. Vi skal se om de har en verdi, og lage flyt basert på dette. 
        Vi bruker her et designprinsipp som heter "early return" for å avslutte programmet vårt for hver gren.
        Det er en måte for oss å virkelig reinforce at det er ekslusivt denne grenen, og kun denne grenen som skal kjøre.
        Dette er et prinsipp som er veldig viktig når vi skal begynne med errorhåndtering. 
        I prinsipp er dette veldig likt måten en switch-case statement fungerer på, men siden den bare tillater operasjoner på en variabel om gangen,
        krever dette tilfellet en if/else blokk, hvis ikke vi finner en datatype som kan inkapsle begge verdiene våre (I en senere modul skal vi se om vi finner en som gjør dette.).*/

        string userName = string.Empty;
        string password = "1234";

        if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Username and password is required to continue");
            return;
        }
        if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Welcome in, user!");
            return;
        }
        if (string.IsNullOrEmpty(userName))
        {
            Console.WriteLine("Username is required!");
            return;
        }
        if (string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Password is required");
            return;
        }

    }
}
