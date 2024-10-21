using System;
namespace Brigde;
public interface INotification
{
    void Send(string recipient, string message);
}

public class EmailNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Отправка Email на {recipient}: {message}");
    }
}

public class SmsNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Отправка SMS на {recipient}: {message}");
    }
}

public abstract class NotificationSender
{
    protected INotification _notification;

    protected NotificationSender(INotification notification)
    {
        _notification = notification;
    }

    public abstract void SendNotification(string recipient, string message);
}

public class TextNotificationSender : NotificationSender
{
    public TextNotificationSender(INotification notification) : base(notification) { }

    public override void SendNotification(string recipient, string message)
    {
        _notification.Send(recipient, message);
    }
}

public class HtmlNotificationSender : NotificationSender
{
    public HtmlNotificationSender(INotification notification) : base(notification) { }

    public override void SendNotification(string recipient, string message)
    {
        _notification.Send(recipient, $"<html><body>{message}</body></html>");
    }
}
