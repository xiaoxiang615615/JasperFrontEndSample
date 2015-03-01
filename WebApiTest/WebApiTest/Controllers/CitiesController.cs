using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class CitiesController : ApiController
    {
        public IEnumerable<City> getAllCities()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=1986;username=jasper;password=wenwen927");
            MySqlCommand command = new MySqlCommand("Select * from world.city", connection);
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

        public City getCountry(int id)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=1986;username=jasper;password=wenwen927");
            String sqlCommand = "Select * from world.city where id = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sqlCommand, connection);
            connection.Open();
            City city = new City();
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.Read())
                {   
                    city.Name = dataReader.GetString("Name");
                    city.Country = dataReader.GetString("CountryCode");
                    city.District = dataReader.GetString("District");
                    city.Population = dataReader.GetString("Population");
                }
            }
            connection.Close();
            return city;
        }

        public City getCountryWithName(String name)
        {

            MySqlConnection connection = new MySqlConnection("server=localhost;port=1986;username=jasper;password=wenwen927");
            String sqlCommand = "Select * from world.city where name = '" + name + "'";
            MySqlCommand command = new MySqlCommand(sqlCommand, connection);
            connection.Open();
            City city = new City();
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    city.Name = dataReader.GetString("Name");
                    city.Country = dataReader.GetString("CountryCode");
                    city.District = dataReader.GetString("District");
                    city.Population = dataReader.GetString("Population");
                }
            }
            connection.Close();
            return city;
        }

        [Route("jasper/test/{var1}/{var2}")]
        [HttpGet]
        public String jaspertest(String var1 = "1", String var2 = "2")
        {
            return "Jaspertest2: "+var1 +" , " +var2;
        }


    }
}
