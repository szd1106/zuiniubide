using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Text;
using App1.dataobject;

namespace App1
{
    public class database
    {
        List<FoodAndWineEntry> list;
        List<AH> list1;
        List<ShoppingEntry> list2;
        ShoppingEntry temp2;
        FoodAndWineEntry temp;
        AH temp1;
        Random r = new Random();
      

        SqlConnectionStringBuilder builder;
        public database()
        {

            try
            {
                builder = new SqlConnectionStringBuilder();
                builder.DataSource = "arezzo.database.windows.net";
                builder.UserID = "qpan0831";
                builder.Password = "Pan890831";
                builder.InitialCatalog = "ArezzoData";
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public List<FoodAndWineEntry> fatchFoodWineData()
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {


                list = new List<FoodAndWineEntry>();
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM FoodAndWine");

                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            temp = new FoodAndWineEntry();
                            temp.RestaurantName = reader.GetValue(1).ToString();
                            temp.ReviewScore = reader.GetValue(2).ToString();
                            temp.Special = reader.GetValue(3).ToString();
                            temp.Address = reader.GetValue(4).ToString();
                            temp.AveragePrice = reader.GetValue(5).ToString();
                            temp.Description = reader.GetValue(6).ToString();
                            temp.ImageList = new List<string> { reader.GetValue(7).ToString() };
                            temp.MainImage = reader.GetValue(7).ToString();
                            temp.PhoneNumber = reader.GetValue(8).ToString();
                            temp.Direction = "DIRECTION";
                            temp.Distance = r.Next(400,1100);
                            list.Add(temp);

                        }
                    }

                    return list;

                }

            }

        }



        public List<AH> fatchah()
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {


                list1 = new List<AH>();
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM FoodAndWine");

                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            temp1 = new AH();

                            temp1.AttractionName = reader.GetValue(1).ToString();
                            temp1.AhreviewScore = reader.GetValue(2).ToString();
                            temp1.AHaddress = reader.GetValue(4).ToString();
                            temp1.AHdescription = reader.GetValue(6).ToString();
                            temp1.AHimageList = new List<string> { reader.GetValue(7).ToString() };
                            temp1.MainImage = reader.GetValue(7).ToString();
                            temp1.Direction = "DIRECTION";
                            temp1.AHdistance = r.Next(200, 1300);
                            list1.Add(temp1);

                        }
                    }

                    return list1;

                }



            }
        }



        public List<ShoppingEntry> fatchshooping()
        {
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {


                list2 = new List<ShoppingEntry>();
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM FoodAndWine");

                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            temp2 = new ShoppingEntry();

                            temp2.StoreName = reader.GetValue(1).ToString();
                            temp2.ReviewScore = reader.GetValue(2).ToString();
                            temp2.Special = reader.GetValue(3).ToString();
                            temp2.Address = reader.GetValue(4).ToString();
                            temp2.AveragePrice = reader.GetValue(5).ToString();
                            temp2.Description = reader.GetValue(6).ToString();
                            temp2.ImageList = new List<string> { reader.GetValue(7).ToString() };
                            temp2.MainImage = reader.GetValue(7).ToString();
                            temp2.Direction = "DIRECTION";
                            temp2.Distance = r.Next(1200, 1500);
                            list2.Add(temp2);
                        }
                    }

                    return list2;

                }



            }
        }
    }
}