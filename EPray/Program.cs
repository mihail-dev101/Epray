using EPray.EntityFramework;
using EPray.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var prayerService = new PrayerService();
            var options = new DbContextOptionsBuilder<PrayerContext>().UseSqlServer("Server=DESKTOP-KI3RFNG; Initial Catalog=EPray;Integrated Security=true;").Options;
            using var db = new PrayerContext(options);
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            //var prayers = prayerService.PopulatePrayerDB();
            //db.Prayers.AddRange(prayers);
            //db.SaveChanges();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
