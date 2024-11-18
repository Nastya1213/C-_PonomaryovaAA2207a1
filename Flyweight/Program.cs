using System;
using System.Collections.Generic;
namespace Flyweight{
    class Program
{
    static void Main()
    {
       
        CharacterFactory factory = new CharacterFactory();
        Character hero1 = factory.GetCharacter("Arthur", "Warrior", "warrior_image.png");
        Character hero2 = factory.GetCharacter("Arthur", "Warrior", "warrior_image.png"); // Этот объект будет тем же
        Character hero3 = factory.GetCharacter("Lancelot", "Knight", "knight_image.png");

        
        Console.WriteLine(hero1);
        Console.WriteLine(hero2); 
        Console.WriteLine(hero3);

 
        CharacterState hero1State = new CharacterState(5, 100);
        CharacterState hero2State = new CharacterState(2, 50);
        CharacterState hero3State = new CharacterState(8, 300);

        Console.WriteLine($"{hero1.Name} State: {hero1State}");
        Console.WriteLine($"{hero2.Name} State: {hero2State}");
        Console.WriteLine($"{hero3.Name} State: {hero3State}");
        hero1State.Level = 6;
        hero1State.Experience = 120;
        Console.WriteLine($"{hero1.Name} Updated State: {hero1State}");
        // все созданные персонажи
        factory.PrintAllCharacters();
    }
}
}
