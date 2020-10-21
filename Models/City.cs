using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TerritoryYP.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int Population { get; set; }

        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        public Province Province { get; set; }

        public static List<City> GetCities()
        {
            List<City> city = new List<City>() {
              new City {
                  CityId = 1,
                  CityName = "Surrey",
                  Population = 300000,
                  ProvinceCode = "BC"
              },
               new City {
                  CityId = 2,
                  CityName = "Burnaby",
                  Population = 253007,
                  ProvinceCode = "BC"
              },
                new City {
                  CityId = 3,
                  CityName = "Kelowna",
                  Population = 142146,
                  ProvinceCode = "BC"
              },
              new City {
                  CityId = 4,
                  CityName = "Toronto",
                  Population = 2965713,
                  ProvinceCode = "ON"
              },
              new City {
                  CityId = 5,
                  CityName = "Ottawa",
                  Population = 150000,
                  ProvinceCode = "ON"
              },
              new City {
                  CityId = 6,
                  CityName = "Brampton",
                  Population = 696975,
                  ProvinceCode = "ON"
              },
              new City {
                  CityId = 7,
                  CityName = "Mirabel",
                  Population = 51000,
                  ProvinceCode = "QC"                  
              },
               new City {
                  CityId = 8,
                  CityName = "Montréal",
                  Population = 1806022,
                  ProvinceCode = "QC"
              },
                new City {
                  CityId = 9,
                  CityName = "Gatineau",
                  Population = 287868,
                  ProvinceCode = "QC"
              },
          };
            return city;
        }

    }
}
