using System;
using System.Collections.Generic;
using System.Text;


namespace App1.dataobject
{
    public class AH
    {
        private string attractionname;
        private string ahaddress;
        private double ahdistance;
        private List<string> ahimageList;
        private string ahdescription;
        private string reviewScore;
        private string mainImage;
        private string direction;



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



        public string AttractionName { set { attractionname=value; } get { return attractionname; } }
        public string AHaddress {set{ ahaddress = value; } get{ return ahaddress; } }
        public  double AHdistance {set{ ahdistance = value; }get { return ahdistance; } }
        public List<string> AHimageList { set { ahimageList = value; } get { return ahimageList; } }
        public string AHdescription { set{ ahdescription = value; }get{ return ahdescription; } }
        public string AhreviewScore { set { reviewScore = value; } get { return reviewScore; } }
        public string Direction { set { direction = value; } get { return direction; } }

        public bool contain(string value)
        {
            // this is for ios search bar cancel button pressed
            if (value == null)
            {
                return true;
            }

            if (attractionname.ToUpper().Contains(value.ToUpper()) || ahaddress.ToUpper().Contains(value.ToUpper()))
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
