using CarouselView.FormsPlugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.dataobject;
using Plugin.Messaging;

namespace App1.bigview
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    
	public partial class arthistoryDescription : ContentPage
	{
      
        public arthistoryDescription()
        {
            InitializeComponent();
            myCarousel.ItemsSource = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            myCarousel.Position = 0;
        }

        public arthistoryDescription(AH value) {
            InitializeComponent();
            List<String> imageList = value.AHimageList;
            myCarousel.ItemsSource = imageList;
            //indicator which image is showing
            myCarousel.PositionSelected += (sender, e) => {
                position.Text = (e.NewValue + 1) + "/" + imageList.Count();
            };

            description.Text = value.AHdescription;

            Ahdirection.Clicked += (sender, e) => {
                     if (Device.RuntimePlatform == Device.Android)
                     {
                         // opens the 'task chooser' so the user can pick Maps, Chrome or other mapping app
                         Device.OpenUri(new Uri("http://maps.google.com/?daddr=" + value.AHaddress + "+&saddr=660+Parrington+Oval+,+Norman,+OK"));
                     }
                     else if (Device.RuntimePlatform == Device.iOS)
                     {
                         //https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                         Device.OpenUri(new Uri("http://maps.apple.com/?daddr=" + value.AHaddress + "+CA&saddr=660+Parrington+Oval+,+Norman,+OK"));
                     }
                 };
            Explore.Clicked += (sender, e) => {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    //https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                    Device.OpenUri(new Uri("http://maps.apple.com/?q=394+Pacific+Ave+San+Francisco+CA"));
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    // opens the Maps app directly
                    Device.OpenUri(new Uri("geo:0,0?q= Hall"));

                }
               

            };


        }
       
         
    }
	}
