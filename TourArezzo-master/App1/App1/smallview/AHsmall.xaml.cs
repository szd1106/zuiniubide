using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.dataobject;
using App1.bigview;

namespace App1.smallview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AHsmall : ContentView
    {
        public AHsmall()
        {
            InitializeComponent();
        }

        public AHsmall(AH value)
        {
            InitializeComponent();
            Image image = new Image
            {
                Source = value.MainImage
                //I feel there needs more detail settings
            };
            image.Aspect = Xamarin.Forms.Aspect.Fill;
            this.contentViewforFirstImage.Content = image;
            this.reviewScore.Text = value.AhreviewScore;
            this.AttractionName.Text = value.AttractionName;
            this.AHaddress.Text = value.AHaddress;
            this.AHdistance.Text = "" + value.AHdistance + " km";

            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += async (sender, args) =>
            {
                await Navigation.PushAsync(new bigview.arthistoryDescription(value));
            };
            this.GestureRecognizers.Add(tapGesture);
        }
    }
}