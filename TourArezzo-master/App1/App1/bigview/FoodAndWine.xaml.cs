using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.dataobject;
using App1.model;
using CarouselView.FormsPlugin.Abstractions;

namespace App1.bigview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodAndWine : ContentPage
	{
		public FoodAndWine ()
		{
			InitializeComponent ();
            FoodAndWineEntry entry = new FoodAndWineEntry {
                MainImage = "https://s3-media4.fl.yelpcdn.com/bphoto/OGcA8vvKqCyDY4IUMydjfA/o.jpg",
                RestaurantName="dfsafs",
                ReviewScore="2.7",
                Special="haha",
                Address="nima",
                Distance=28

            };
            this.Content = new ContentView {
                
                Content = new StackLayout { Children = { new smallview.FoodAndWine(entry) } }
                
            };
		}
        public FoodAndWine(Model model) {
            InitializeComponent();
         
           
            for (int index = 0; index < model.FoodAndWineEntries.Count(); index++) {
                FoodAndWineEntry temp = model.FoodAndWineEntries[index];
                App1.smallview.FoodAndWine temp1 = new smallview.FoodAndWine(temp);
                innerOne.Children.Add(temp1);

            }
           
            searchBar.TextChanged +=(sender, args) => {
                string temp = searchBar.Text;
                StackLayout temp2 = new StackLayout();
                List<FoodAndWineEntry> temp1 = model.FoodAndWineEntries;
                for (int index = 0; index < temp1.Count; index++) {
                    if (temp1[index].contain(temp)) {
                        temp2.Children.Add(new smallview.FoodAndWine(temp1[index]));
                    }

                }
                scrollview.Content = temp2;

            };
            searchBar.Focused += (sender, args) => {
                
            };





        }
	}
}