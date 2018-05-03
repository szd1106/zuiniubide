using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.dataobject;
using App1.model;
using CarouselView.FormsPlugin.Abstractions;


namespace App1.bigview
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Shopping : ContentPage
	{
		public Shopping ()
		{
			InitializeComponent ();
            ShoppingEntry entry = new ShoppingEntry
            {
                MainImage = "https://s3-media4.fl.yelpcdn.com/bphoto/OGcA8vvKqCyDY4IUMydjfA/o.jpg",
                StoreName = "dfsafs",
                ReviewScore = "2.7",
                Special = "haha",
                Address = "nima",
                Distance = 28
            };
            this.Content = new ContentView
            {

                Content = new StackLayout { Children = { new smallview.Shopping(entry) } }

            };
        }


        public Shopping(Model model)
        {
            InitializeComponent();
            

            for (int index = 0; index < model.ShoppingEntries.Count(); index++)
            {
                ShoppingEntry temp = model.ShoppingEntries[index];
                App1.smallview.Shopping temp1 = new smallview.Shopping(temp);
                innerOne.Children.Add(temp1);

            }

            searchBar.TextChanged += (sender, args) => {
                string temp = searchBar.Text;
                StackLayout temp2 = new StackLayout();
                List<ShoppingEntry> temp1 = model.ShoppingEntries;
                for (int index = 0; index < temp1.Count; index++)
                {
                    if (temp1[index].contain(temp))
                    {
                        temp2.Children.Add(new smallview.Shopping(temp1[index]));
                    }

                }
                scrollview.Content = temp2;

            };
            searchBar.Focused += (sender, args) => {

            };





        }
    }
}