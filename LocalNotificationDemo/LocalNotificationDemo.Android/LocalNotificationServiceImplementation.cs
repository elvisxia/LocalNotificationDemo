using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using LocalNotificationDemo.Droid;

[assembly:Dependency(typeof(LocalNotificationServiceImplementation))]
namespace LocalNotificationDemo.Droid
{
    public class LocalNotificationServiceImplementation :Java.Lang.Object, ILocalNotificationService
    {
        public void ShowLocalNotification(string title, string text, string icon)
        {
            
            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(Forms.Context)
                .SetContentTitle(title)
                .SetContentText(text);

            if (icon == "ic_notification")
            {
                builder.SetSmallIcon(Resource.Drawable.ic_notification);
            }

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager =
                Forms.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);
        }
    }
}