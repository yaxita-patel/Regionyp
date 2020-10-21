﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerritoryYP.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }

        public static List<Province> GetProvince()
        {
            List<Province> province = new List<Province> {
                new Province () {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",                   
                },
                new Province () {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",                  
                },
                new Province () {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                },
                new Province () {
                    ProvinceCode = "QC",
                    ProvinceName = "Quebec",
                },
            };
            return province;
        }
    }
}
