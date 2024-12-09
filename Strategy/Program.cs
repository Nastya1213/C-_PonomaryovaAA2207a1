using System;

// Интерфейс для оружия
public interface IWeapon
{
    void UseWeapon();
}

// Реализация поведения для меча
public class Sword : IWeapon
{
    public void UseWeapon()
    {
        Console.WriteLine("Вы размахиваете мечом, нанося мощный удар!");
    }
}

// Реализация поведения для лука
public class Bow : IWeapon
{
    public void UseWeapon()
    {
        Console.WriteLine("Вы натягиваете тетиву и выпускаете стрелу.");
    }
}

// Реализация поведения для топора
public class Axe : IWeapon
{
    public void UseWeapon()
    {
        Console.WriteLine("Вы сокрушаете врага мощным ударом топора.");
    }
}

// Класс игрока
public class Player
{
    private IWeapon _currentWeapon;

    public Player(IWeapon initialWeapon)
    {
        _currentWeapon = initialWeapon;
    }

    public void SetWeapon(IWeapon weapon)
    {
        _currentWeapon = weapon;
        Console.WriteLine($"Вы сменили оружие на {weapon.GetType().Name}.");
    }

    public void Attack()
    {
        if (_currentWeapon == null)
        {
            Console.WriteLine("Оружие не выбрано!");
            return;
        }
        _currentWeapon.UseWeapon();
    }
}

// Класс игры
public class Game
{
    private Player _player;

    public Game()
    {
        Console.WriteLine("Добро пожаловать в игру!");

        // По умолчанию игроку дается меч
        _player = new Player(new Sword());
    }

    public void Start()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Атаковать");
            Console.WriteLine("2. Сменить оружие");
            Console.WriteLine("3. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _player.Attack();
                    break;

                case "2":
                    ChangeWeapon();
                    break;

                case "3":
                    isPlaying = false;
                    Console.WriteLine("Игра завершена. До новых встреч!");
                    break;

                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    private void ChangeWeapon()
    {
        Console.WriteLine("\nВыберите оружие:");
        Console.WriteLine("1. Меч");
        Console.WriteLine("2. Лук");
        Console.WriteLine("3. Топор");

        string weaponChoice = Console.ReadLine();

        switch (weaponChoice)
        {
            case "1":
                _player.SetWeapon(new Sword());
                break;

            case "2":
                _player.SetWeapon(new Bow());
                break;

            case "3":
                _player.SetWeapon(new Axe());
                break;

            default:
                Console.WriteLine("Неверный выбор. Оружие не изменено.");
                break;
        }
    }
}


public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Start();
    }
}
