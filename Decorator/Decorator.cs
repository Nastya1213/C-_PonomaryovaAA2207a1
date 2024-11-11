using System;
namespace Decorator{
// Интерфейс для отправки уведомлений
public interface INotifier
{
    void Send(string message);
}

// Конкретный компонент - отправка уведомлений по email
public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

// Базовый декоратор для добавления новых каналов уведомлений
public abstract class NotifierDecorator : INotifier
{
    protected INotifier _notifier;

    public NotifierDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}

// Конкретный декоратор для отправки SMS
public class SmsNotifier : NotifierDecorator
{
    public SmsNotifier(INotifier notifier) : base(notifier) {}

    public override void Send(string message)
    {
        base.Send(message); // вызов базового метода (email)
        Console.WriteLine($"SMS sent: {message}");
    }
}

// Конкретный декоратор для отправки сообщений через Facebook
public class FacebookNotifier : NotifierDecorator
{
    public FacebookNotifier(INotifier notifier) : base(notifier) {}

    public override void Send(string message)
    {
        base.Send(message); // вызов базового метода (email)
        Console.WriteLine($"Facebook message sent: {message}");
    }
}
}