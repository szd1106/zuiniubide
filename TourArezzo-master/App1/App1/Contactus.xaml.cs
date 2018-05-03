using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contactus : ContentPage
	{
        private Button[] b = new Button[6];
        public Contactus()
        {
            InitializeComponent();
            b[0] = TphoneNumber;
            b[1] = PphoneNumber;
            b[2] = SphoneNumber;
            b[3] = Temail;
            b[4] = Pemail;
            b[5] = Semail;
            
            b[0].Clicked += (sender, e) =>
            {
                var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
                if (PhoneCallTask.CanMakePhoneCall)
                    PhoneCallTask.MakePhoneCall(b[0].Text);

            };

            b[1].Clicked += (sender, e) =>
            {
                var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
                if (PhoneCallTask.CanMakePhoneCall)
                    PhoneCallTask.MakePhoneCall(b[1].Text);

            };


            b[2].Clicked += (sender, e) =>
            {
                var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
                if (PhoneCallTask.CanMakePhoneCall)
                    PhoneCallTask.MakePhoneCall(b[2].Text);

            };

            b[3].Clicked += (sender, e) =>
            {
                var sentemail = CrossMessaging.Current.EmailMessenger;
                if (sentemail.CanSendEmail)
                    sentemail.SendEmail(b[3].Text);
            };
            b[4].Clicked += (sender, e) =>
            {
                var sentemail = CrossMessaging.Current.EmailMessenger;
                if (sentemail.CanSendEmail)
                    sentemail.SendEmail(b[4].Text);
            };
            b[5].Clicked += (sender, e) =>
            {
                var sentemail = CrossMessaging.Current.EmailMessenger;
                if (sentemail.CanSendEmail)
                    sentemail.SendEmail(b[5].Text);
            };

        }
        async private void Back(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }

        

    }
}