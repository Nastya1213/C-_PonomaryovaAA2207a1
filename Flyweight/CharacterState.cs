using System;
using System.Collections.Generic;
namespace Flyweight{
    // 2. Состояние персонажа, которое является изменяемым (уровень, опыт)
    public class CharacterState
{
    public int Level { get; set; }
    public int Experience { get; set; }

    public CharacterState(int level, int experience)
    {
        Level = level;
        Experience = experience;
    }

    // Вывод информации о состоянии
    public override string ToString()
    {
        return $"Level: {Level}, Experience: {Experience}";
    }
}

}