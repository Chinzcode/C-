/*
    - Kan ikke lage objekt uten å lage en klasse.
    - En klasse er en mal for objekter.
    - Det er en sterk typing av objekter:
        - Hvilke felt denne type objekt skal ha og hvilke datatyper de feltene skal inneholde.
    
    - Klassen person er en mal for en type objekt.
    - Variablen "trym" kan ikke inneholde objekter av andre klasser enn person.
 */

namespace IntroToClassesFromJS
{
    internal class Demo1SimpleObject
    {
        public static void Run()
        {
            // Alternativ A
            var trym1 = new Person
            {
                FirstName = "Trym",
                BirthYear = 1998
            };

            // Alternativ B
            var trym2 = new Person(); //Deklarasjon av nytt objekt av klassen "Person"
            trym2.FirstName = "Trym";
            trym2.BirthYear = 1998;

        }
    }
}
