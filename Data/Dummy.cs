using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TerritoryYP.Models;

namespace TerritoryYP.Data
{
    public static class Dummy
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
             City.GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
            Province.GetProvince()    
            );
        }
    }
}
