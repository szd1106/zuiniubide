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
    public partial class ArtandHistory : ContentPage
    {
        public ArtandHistory()
        {
            InitializeComponent();
            AH entry = new AH
            {

                AHaddress = "nima",
                AHdistance = 28,
                AttractionName = "sda"
            };

            this.Content = new ContentView
            {

                Content = new StackLayout { Children = { new smallview.AHsmall(entry) } }

            };


        }
        public ArtandHistory(Model model)
        {
            InitializeComponent();


            for (int index = 0; index < model.AHs.Count(); index++)
            {
                AH temp = model.AHs[index];
                App1.smallview.AHsmall temp1 = new smallview.AHsmall(temp);
                innerOne.Children.Add(temp1);

            }

            searchBar.TextChanged += (sender, args) =>
            {
                string temp = searchBar.Text;
                StackLayout temp2 = new StackLayout();
                List<AH> temp1 = model.AHs;
                for (int index = 0; index < temp1.Count; index++)
                {
                    if (temp1[index].contain(temp))
                    {
                        temp2.Children.Add(new smallview.AHsmall(temp1[index]));
                    }

                }
                scrollview.Content = temp2;

            };
            searchBar.Focused += (sender, args) =>
            {

            };
        }
    }
}