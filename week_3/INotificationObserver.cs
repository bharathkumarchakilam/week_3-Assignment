using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    interface INotificationObserver
    {
        void Update(string message);
    }

    class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(INotificationObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

    //class Program19
    //{
    //    static void Main()
    //    {
    //        NotificationService service = new NotificationService();

    //        EmailNotifier emailNotifier = new EmailNotifier();
    //        SMSNotifier smsNotifier = new SMSNotifier();

    //        service.Subscribe(emailNotifier);
    //        service.Subscribe(smsNotifier);

    //        service.Notify("New message received!");

    //        service.Unsubscribe(smsNotifier);

    //        service.Notify("Another message received!");
    //    }
    //}
}
