using System;
namespace Brigde;

class Program
{
    static void Main(string[] args)
    {
        INotification email = new EmailNotification();
        INotification sms = new SmsNotification();

        NotificationSender textEmailSender = new TextNotificationSender(email);
        textEmailSender.SendNotification("user@example.com", "Привет! Это текстовое сообщение.");

        NotificationSender htmlSmsSender = new HtmlNotificationSender(sms);
        htmlSmsSender.SendNotification("+1234567890", "Это HTML-уведомление.");
    }
}
