using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AirPortModel.Models;

namespace AirPortDataLayer.Data
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Airline> airlines { get; set; }
        public DbSet<AirPlane> airPlanes { get; set; }
        public DbSet<AirPort> AirPorts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Detail> details { get; set; }
        public DbSet<DetailValue> detailValues { get; set; }
        public DbSet<Featrue> featrues { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<FlightStatus> flightStatuses { get; set; }
        public DbSet<Gallery> galleries { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<Terminal> terminals { get; set; }
        public DbSet<TypeDetail> typeDetails { get; set; }
        public DbSet<User> users { get; set; }
    }
}
