using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNotificationDemo
{
    public interface ILocalNotificationService
    {
        void ShowLocalNotification(string title, string text, string icon);
    }
}
