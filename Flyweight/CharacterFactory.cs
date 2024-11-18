using System;
using System.Collections.Generic;
namespace Flyweight{
    // 3. Фабрика для создания и хранения легковесных объектов
public class CharacterFactory
{
    private readonly Dictionary<string, Character> _characters = new Dictionary<string, Character>();

    // Получаем персонажа по имени и типу, создаем новый, если такой еще не существует
    public Character GetCharacter(string name, string type, string image)
    {
        string key = $"{name}-{type}";
        if (!_characters.ContainsKey(key))
        {
            _characters[key] = new Character(name, type, image);
        }
        return _characters[key];
    }

    // Выводим всех персонажей, которые были созданы
    public void PrintAllCharacters()
    {
        Console.WriteLine("Created Characters:");
        foreach (var character in _characters.Values)
        {
            Console.WriteLine(character);
        }
    }
}
}