using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalNotificationDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ILocalNotificationService>().ShowLocalNotification("My Title", "Hello World! This is my first notification!", "ic_notification");
        }
    }
}
