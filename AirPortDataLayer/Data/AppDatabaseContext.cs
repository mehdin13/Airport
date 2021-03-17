using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AirPortModel.Models;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DbSet<Article> articles { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerFlight> CustomerFlight { get; set; }
        public DbSet<Detail> details { get; set; }
        public DbSet<DetailValue> detailValues { get; set; }
        public DbSet<Entertainment> Entertainment { get; set; }
        public DbSet<Faq> faqs { get; set; }
        public DbSet<Featrue> featrues { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<FlightStatus> flightStatuses { get; set; }
        public DbSet<FlightToDo> FlightToDos { get; set; }
        public DbSet<Gallery> galleries { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Gate> Gate { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<Request> requests { get; set; }
        public DbSet<RequestType> requestTypes { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<Terminal> terminals { get; set; }
        public DbSet<TypeDetail> typeDetails { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Weather> Weather { get; set; }
        public DbSet<Raiting> raitings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerFlight>().HasKey(a => new { a.CustomerId, a.FlightId });
            modelBuilder.Entity<Category>().HasData(new Category
                {
                    Id = 1,
                    CategoryName = "Hotel",
                    Icon = "1",
                    CategoryType = 1,
                    DateCreate = DateTime.Now,
                    LastUpdate = DateTime.Now,
                    IsDelete = false
                }
                );
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Restaurant", Icon = "2", CategoryType = 2, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Tour", Icon = "1", CategoryType = 3, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, CategoryName = "Shop", Icon = "1", CategoryType = 4, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, CategoryName = "Institute", Icon = "1", CategoryType = 5, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 6, CategoryName = "Cofeeshop", Icon = "1", CategoryType = 6, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 7, CategoryName = "Parking", Icon = "1", CategoryType = 7, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 8, CategoryName = "Animal", Icon = "1", CategoryType = 8, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 9, CategoryName = "Cargo", Icon = "1", CategoryType = 9, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 10, CategoryName = "Clearance", Icon = "1", CategoryType = 10, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 11, CategoryName = "Padcast", Icon = "1", CategoryType = 11, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 12, CategoryName = "News", Icon = "1", CategoryType = 12, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 13, CategoryName = "Tutorial", Icon = "1", CategoryType = 13, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 14, CategoryName = "Application", Icon = "1", CategoryType = 14, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 15, CategoryName = "Article", Icon = "1", CategoryType = 15, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 16, CategoryName = "Book", Icon = "1", CategoryType = 16, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 17, CategoryName = "Video", Icon = "1", CategoryType = 17, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 18, CategoryName = "Magazin", Icon = "1", CategoryType = 18, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 19, CategoryName = "Aviation", Icon = "1", CategoryType = 19, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 20, CategoryName = "PetKeeping", Icon = "1", CategoryType = 20, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 21, CategoryName = "PetPlay", Icon = "1", CategoryType = 21, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 22, CategoryName = "PetVet", Icon = "1", CategoryType = 22, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 23, CategoryName = "PetCleaning", Icon = "1", CategoryType = 23, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 24, CategoryName = "PetBuying", Icon = "1", CategoryType = 24, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 25, CategoryName = "PetFeeding", Icon = "1", CategoryType = 25, DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
           
            //End Category
            //type detail Data Seed

            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 5, Name = "Airline",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 6, Name = "Airport",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 7, Name = "Airplane",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 8, Name = "Flight",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 9, Name = "Book",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 10, Name = "Video",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 11, Name = "Magazain",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 12, Name = "Aviation",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 13, Name = "Hotel",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 14, Name = "Resturant",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 15, Name = "Shop",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 16, Name = "Tour",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 18, Name = "Cofeeshop",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 19, Name = "News",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 20, Name = "Padcast",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 21, Name = "Animal",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 22, Name = "Cargo",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 23, Name = "clearance",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            modelBuilder.Entity<TypeDetail>().HasData(new TypeDetail { Id = 24, Name = "Institute",  DateCreate = DateTime.Now, LastUpdate = DateTime.Now, IsDelete = false });
            //end type Detail
        }
    }
}
