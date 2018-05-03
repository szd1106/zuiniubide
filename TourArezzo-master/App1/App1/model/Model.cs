using App1.dataobject;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.model
{
    public class Model
    {
        
        private List<FoodAndWineEntry> foodAndWineEntries;
        public List<FoodAndWineEntry> FoodAndWineEntries { set { foodAndWineEntries = value; } get { return foodAndWineEntries; } }

        private List<AH> ahs;
        public List<AH> AHs {set{ ahs = value;} get{ return ahs; } }

        private List<ShoppingEntry> shoppingEntries;
        public List<ShoppingEntry> ShoppingEntries {set{ shoppingEntries = value; }get { return shoppingEntries; } }

        public Model() {
            FoodAndWineEntries = new List<FoodAndWineEntry>();
            AHs = new List<AH>();
            shoppingEntries = new List<ShoppingEntry>();
         
                FoodAndWineEntry temp = new FoodAndWineEntry
                {
                    RestaurantName = "Mr Sushi",
                    ReviewScore = "4.5/5",
                    Special = "Sushi bars, seafood, Ramen",
                    Address = "1204 n interstate Dr,Ste 130, Norman",
                    Distance = new Random().Next(135,800),
                    MainImage = "https://s3-media4.fl.yelpcdn.com/bphoto/OGcA8vvKqCyDY4IUMydjfA/o.jpg",
                    AveragePrice = "5.3",
                    Description = "But the real star is the food. Tables laden with delicacies line the walls. Everything you can think of, and things you have never" +
                    " dreamed of, lie in wait. Whole roasted cows and pigs and goats still turning on spits. Huge platters of fowl stuffed with savoury fruit and nuts." +
                    " Ocean creatures drizzled in sauces or begging to be dipped in spicy concoctions. Countless cheeses, breads, vegetables, sweets, waterfalls of wine, " +
                    "and streams of spirits that flicker with flames.",
                    ImageList = new List<string> { "https://ss2.bdstatic.com/70cFvnSh_Q1YnxGkpoWK1HF6hhy/it/u=519346092,2976750614&fm=27&gp=0.jpg",
                    "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1523130641138&di=eb7711ba8645b454a315e1defb2b31b5&imgtype=0&src=http%3A%2F%2Fimgsrc.baidu.com%2Fimgad%2Fpic%2Fitem%2Fd53f8794a4c27d1ebf4654ff10d5ad6eddc438ac.jpg",
                    "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1523130641661&di=2abd404c658770f46e30d11011e84006&imgtype=0&src=http%3A%2F%2Fimgsrc.baidu.com%2Fimage%2Fc0%253Dpixel_huitu%252C0%252C0%252C294%252C40%2Fsign%3D2806cf299cdda144ce0464f2dbcfb5ce%2F91ef76c6a7efce1bb9c7a3f0a451f3deb48f651f.jpg"},
                    PhoneNumber = "405-625-" + (2780),
                    Direction = "Direction"
                };

                AH ahtemp = new AH {
                    AttractionName = "Devon Energy Hall",
                    AHaddress= "110 W Boyd St Norman, OK 73069",
                    AHdistance = new Random().Next(0, 200),
                    MainImage = "http://www.yorkmetal.com/Websites/yorkmetals/PhotoGallery/2268949/DSC_8957.jpg?46432",
                    AhreviewScore = "5/5",
                    AHimageList = new List<string> { "http://www.zfiengr.com/assets/images/OU_Devon_Energy_Hall.jpg",
                    "http://1.bp.blogspot.com/-6vRzQkfqkV0/VC32RZ6GSqI/AAAAAAAAJZc/f9qSM0kyr44/s1600/devon%2Benergy%2Bhall.jpg",
                    "http://www.yorkmetal.com/Websites/yorkmetals/PhotoGallery/2268949/DSC_8957.jpg?46432"
                    },
                    Direction = "Direction",
                    AHdescription = "OU Devon Energy Hall and Rawl Engineering Practice Facility+/n" +
                    "Norman, Oklahoma+/n" +
                    "The Devon Energy Hall serves as instructional and research space for the College " +
                    "of Engineering at the University of Oklahoma."
                    
                };
                ShoppingEntry setrmp = new ShoppingEntry {
                    StoreName = "OKC Outlets",
                    ReviewScore = "4.4/5",
                    Distance = new Random().Next(0, 20),
                    Special = "OKC shopping mall",
                    Address = "7624 W Reno Ave #380, Oklahoma City, OK 73127",
                    ImageList = new List<string> { "http://www.labelscar.com/wp-content/uploads/2007/09/crossroads-mall-okc-25.jpg",
                    "http://www.labelscar.com/wp-content/uploads/2007/09/crossroads-mall-okc-24.jpg",
                    "http://www.bwsaddleback.com/Content/images/CommanFile/EVTOutlet-Shoppes-of-Oklahoma-CityOutlet_mall.jpg"
                    },
                    Direction = "Direction",
                    MainImage= "https://res.cloudinary.com/simpleview/image/upload/crm/oklahoma/282132_253120241373411_137215209630582_977182_5067870_n3_5b5fa1b8-5056-a36a-06a75ff07f88544e.jpg",
                    Description = "Located on I-40, OKC Outlets offers a variety of over " +
                    "90 stores including Nike, Coach, Columbia Sportswear, Michael Kors, Carter's" +
                    " and Disney. Dining options include local favorites Smashburger, City Bites and more!",

                };





                foodAndWineEntries.Add(temp);
                ahs.Add(ahtemp);
                shoppingEntries.Add(setrmp);
            

        }
        public void updatefaw(List<FoodAndWineEntry> l) {
            foodAndWineEntries.AddRange(l);

        }
        public void updateAH(List<AH> l)
        {
            ahs.AddRange(l);

        }
        public void updateshopping(List<ShoppingEntry> l)
        {
            shoppingEntries.AddRange(l);

        }
    }
}
