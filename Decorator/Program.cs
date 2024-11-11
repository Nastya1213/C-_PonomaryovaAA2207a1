using System;

namespace Decorator{
public class Program
{
    public static void Main()
    {
        INotifier notifier = new EmailNotifier();
        notifier = new SmsNotifier(notifier);
        notifier = new FacebookNotifier(notifier);
        // Отправка сообщения через все каналы (email, SMS, Facebook)
        notifier.Send("Critical system update");
    }
}
}