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
	public partial class FoodAndWine : ContentView
	{
		public FoodAndWine ()
		{
			InitializeComponent ();
          
		}
        public FoodAndWine(FoodAndWineEntry value) {
            InitializeComponent();
            Image image = new Image { Source=value.MainImage
                //I feel there needs more detail settings
            };
            image.Aspect = Xamarin.Forms.Aspect.Fill;
            this.contentViewforFirstImage.Content = image;
            this.restaurantName.Text = value.RestaurantName;
            this.address.Text = value.Address;
            this.reviewScore.Text = ""+(value.ReviewScore);
            this.special.Text = value.Special;
            this.distance.Text = ""+value.Distance+" km";
            this.averagePrice.Text = "\u0024" + value.AveragePrice;
            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += async (sender, args)=> {
                await Navigation.PushAsync(new bigview.FoodAndWineDescription(value));
            };
            this.GestureRecognizers.Add(tapGesture);


        }
	}
}