using JasperJqueryMobile.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace JasperJqueryMobile
{
    /// <summary>
    /// Summary description for JJWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class JqueryMobileWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public  string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public  List<City> getAllCities(String page, String rows)
        {
            int start = Convert.ToInt32(rows) * Convert.ToInt32(page) - Convert.ToInt32(rows);
            MySqlConnection connection = new MySqlConnection("server=localhost;port=1986;username=jasper;password=wenwen927");
            MySqlCommand command = new MySqlCommand("Select * from world.city limit " + start + " , 20 ", connection);
            List<City> cities = new List<City>();
            connection.Open();
            String data = "";
            int counter = 0;
           
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    City city = new City();
                    city.Name = dataReader.GetString("Name");
                    city.Country = dataReader.GetString("CountryCode");
                    city.District = dataReader.GetString("District");
                    city.Population = dataReader.GetString("Population");
                    cities.Add(city);
                }
            }
            connection.Close();

            return cities;
        }

        [WebMethod]
        public String getAllCities2(String page, String rows)
        {
            int start = Convert.ToInt32(rows) * Convert.ToInt32(page) - Convert.ToInt32(rows);
            MySqlConnection connection = new MySqlConnection("server=localhost;port=1986;username=jasper;password=wenwen927");
            MySqlCommand command = new MySqlCommand("Select * from world.city limit " + start + " , 20 ", connection);
            List<City> cities = new List<City>();
            connection.Open();
            String data = "";
            int counter = 0;

            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    City city = new City();
                    city.Name = dataReader.GetString("Name");
                    city.Country = dataReader.GetString("CountryCode");
                    city.District = dataReader.GetString("District");
                    city.Population = dataReader.GetString("Population");
                    cities.Add(city);
                }
            }
            connection.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Serialize(cities);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld2()
        {
            return "Hello World";
        }
    }
}
