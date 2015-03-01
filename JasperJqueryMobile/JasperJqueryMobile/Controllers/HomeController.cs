using JasperJqueryMobile.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JasperJqueryMobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String page, String rows)
        {
            List<City> cities = getAllCities(page, rows);
            return View(cities);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<City> getAllCities(String page, String rows)
        {
            if(page == null || rows == null)
            {
                page = "1";
                rows = "20";
            }
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
    }
}