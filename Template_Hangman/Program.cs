/// <summary>
/// Returns a string with a single character replaced at the given position.
/// <param name="text">String to be modified.</param>
/// <param name="position">The index where the character will be replaced.</param>
/// <param name="letter">The replacement character.</param>
/// <returns>A string with the given character replaced at the given index.</returns>
/// </summary>
static string ReplaceCharInString(string text, int position, char letter)
{
    text = text.Remove(position, 1);
    text = text.Insert(position, letter.ToString());

    return text;
}

///Skapa ett Hangman spel!
///Be först användaren mata in ett ord.
///Be sedan användaren (eller en annan användare) att mata in en bokstav.
///Kontrollera om bokstav finns i det inmatade ordet.
///Om bokstaven finns, använd ReplaceCharInString metoden för att sätta in bokstaven på rätt plats eller platser.
///Om bokstaven inte finns, ta bort ett liv och informera användaren att gissningen var inkorrekt.
///Repetera tills användaren har gissat ordet korrekt eller fått slut på liv.
///
// Spelare börjar med att spelare 1 matar in ordet 
Console.WriteLine("Spelare 1, skriv in ett ord:");

string word = Console.ReadLine();

word = word.ToLower();

Console.Clear();

string shown = "";

// Det som visas för gissaren är till en början bara understrecker

for (int i = 0; i < word.Length; i++)

{

    shown = shown + "_";

}
// Antal liv och fel som tillåts innan gubben är hängd.
int lives = 6;

while (lives > 0 && shown != word)

{

    Console.WriteLine();

    Console.WriteLine("Ord: " + shown);

    Console.WriteLine("Liv kvar: " + lives);

    Console.WriteLine("Gissa en bokstav wlak:");

    string input = Console.ReadLine();
    //Max en bokstav tillåts eller om en ogiltig längd matas in så det inte kraschas.
    if (input.Length != 1)

    {

        Console.WriteLine("Skriv exakt en bokstav Cringe....");

    }

    else

    {

        char letter = char.ToLower(input[0]);

        if (word.Contains(letter))

        {

            for (int i = 0; i < word.Length; i++)

            {

                if (word[i] == letter)

                {

                    shown = ReplaceCharInString(shown, i, letter);

                }

            }

        }
        // fel gisstning kostar ett liv
        else

        {

            lives = lives - 1;

            Console.WriteLine("Fel! Bokstaven finns inte i ordet lol.");

        }

    }

}
//Loopen avslutas antingen för att ordet är hittat eller för att alla liven tog slut.

if (lives > 0)

{

    Console.WriteLine("Du vann! Ordet var " + word);

}

else

{

    Console.WriteLine("Du förlorade. Ordet var " + word);

}
