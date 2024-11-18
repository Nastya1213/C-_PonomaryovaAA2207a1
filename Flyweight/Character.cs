using System;
using System.Collections.Generic;
namespace Flyweight{
// 1. Легковесный класс, который хранит общие данные о персонаже (неизменяемые)
public class Character
{
    public string Name { get; private set; }
    public string Type { get; private set; }
    public string Image { get; private set; }

    public Character(string name, string type, string image)
    {
        Name = name;
        Type = type;
        Image = image;
    }

    // Вывод информации о персонаже
    public override string ToString()
    {
        return $"Character: {Name}, Type: {Type}, Image: {Image}";
    }
}
}