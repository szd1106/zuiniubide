using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.dataobject
{
   public class ShoppingEntry
    {
        private string mainImage;
        private string storeName;
        private string reviewScore;
        private string special;
        private string storeaddresss;
        private double distance;
        private List<string> imageList;
        private string phoneNumber;
        private string direction;
        private string description;
        private string averagePrice;

        public string MainImage
        {
            set
            {
                mainImage = value;

            }
            get
            {
                return mainImage;

            }
        }

        public string StoreName { set { storeName = value; } get { return storeName; } }
        public string ReviewScore { set { reviewScore = value; } get { return reviewScore; } }
        public string Special { set { special = value; } get { return special; } }
        public string Address { set { storeaddresss = value; } get { return storeaddresss; } }
        public double Distance { set { distance = value; } get { return distance; } }
        public List<string> ImageList { set { imageList = value; } get { return imageList; } }
        public string PhoneNumber { set { phoneNumber = value; } get { return phoneNumber; } }
        public string Direction { set { direction = value; } get { return direction; } }
        public string Description { set { description = value; } get { return description; } }
        public string AveragePrice { set { averagePrice = value; } get { return averagePrice; } }


        public bool contain(string value)
        {
            // this is for ios search bar cancel button pressed
            if (value == null)
            {
                return true;
            }

            if (storeName.ToUpper().Contains(value.ToUpper()) || special.ToUpper().Contains(value.ToUpper()) || storeaddresss.ToUpper().Contains(value.ToUpper()) || description.ToUpper().Contains(value.ToUpper()))
            {
                return true;
            }



            else
            {
                return false;
            }
        }

    }
}
