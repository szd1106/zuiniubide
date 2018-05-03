using App1.dataobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using Xamarin.Forms;
using App1.model;
using App1.bigview;


namespace App1
{
	public partial class App : Application
	{

        Model model;
        database d;
        public App ()
		{
            model = new Model();
            d = new database();
            List<FoodAndWineEntry> l = new List<FoodAndWineEntry>();
            List<AH> l1 = new List<AH>();
            List<ShoppingEntry> l2 = new List<ShoppingEntry>();
            l = d.fatchFoodWineData();
            l1 = d.fatchah();
            l2 = d.fatchshooping();
            model.updatefaw(l);
            model.updateAH(l1);
            model.updateshopping(l2);
			InitializeComponent();

            //MainPage = new App1.bigview.FoodAndWine();
            MainPage= new NavigationPage(new MainPage(model));
           
            
          
            
		}

       


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
