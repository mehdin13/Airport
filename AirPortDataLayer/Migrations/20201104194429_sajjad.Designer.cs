﻿// <auto-generated />
using System;
using AirPortDataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirPortDataLayer.Migrations
{
    [DbContext(typeof(AppDatabaseContext))]
    [Migration("20201104194429_sajjad")]
    partial class sajjad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirPortModel.Models.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AdressId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnName("AdressCityId")
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnName("AdressDetail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<double>("LocationR")
                        .HasColumnName("AdressLocationR")
                        .HasColumnType("float");

                    b.Property<double>("LocationX")
                        .HasColumnName("AdressLocationX")
                        .HasColumnType("float");

                    b.Property<double>("LocationY")
                        .HasColumnName("AdressLocationY")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Tbl_Adress");
                });

            modelBuilder.Entity("AirPortModel.Models.AirPlane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AirPlaneId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlineId")
                        .HasColumnName("AirlineId")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnName("AirPlaneBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrandId")
                        .HasColumnName("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("DetailId")
                        .HasColumnName("DetailId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
                        .HasColumnName("AirPlaneGalleryId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("AirPlaneModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("AirPlaneName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("DetailId");

                    b.HasIndex("GalleryId");

                    b.ToTable("Tbl_AirPlane");
                });

            modelBuilder.Entity("AirPortModel.Models.AirPort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AirPortId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirPortAddressId")
                        .HasColumnName("AirPortAddressId")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnName("AirPortCode")
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .HasColumnName("Detail")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("GalleryId")
                        .HasColumnName("GalleryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("AirPortName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .HasColumnName("MapImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirPortAddressId");

                    b.HasIndex("GalleryId");

                    b.ToTable("Tbl_AirPort");
                });

            modelBuilder.Entity("AirPortModel.Models.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AirlineId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetailId")
                        .HasColumnName("AirlineDetailId")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnName("AirlineLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("AirlineName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DetailId");

                    b.ToTable("Tbl_AirLine");
                });

            modelBuilder.Entity("AirPortModel.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BrandId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandIcon")
                        .HasColumnName("BrandIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandName")
                        .HasColumnName("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Brand");
                });

            modelBuilder.Entity("AirPortModel.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Icon")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Tbl_Category");
                });

            modelBuilder.Entity("AirPortModel.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CityId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityStateId")
                        .HasColumnName("CityStateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("CityName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityStateId");

                    b.ToTable("Tbl_City");
                });

            modelBuilder.Entity("AirPortModel.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnName("CustomerAdress")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("BDate")
                        .HasColumnName("CustomerBDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnName("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Isactive")
                        .HasColumnName("Isactive")
                        .HasColumnType("bit");

                    b.Property<bool>("Isdelete")
                        .HasColumnName("Isdelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("CustomerLastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnName("CustomerMobile")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("CustomerName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnName("CustomerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnName("CustomerProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnName("CustomerSex")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Customer");
                });

            modelBuilder.Entity("AirPortModel.Models.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DetailId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Rating")
                        .HasColumnName("DetailRating")
                        .HasColumnType("float");

                    b.Property<int>("TypeId")
                        .HasColumnName("TypeDetailId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnName("DetailValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Tbl_Detail");
                });

            modelBuilder.Entity("AirPortModel.Models.DetailValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ValueId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeacherId")
                        .HasColumnName("FeatrueId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnName("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeacherId");

                    b.ToTable("Tbl_DetailValue");
                });

            modelBuilder.Entity("AirPortModel.Models.Featrue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FeatrueId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnName("FeatrueIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("FeatrueName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TypeId")
                        .HasColumnName("TypeDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Tbl_Feature");
                });

            modelBuilder.Entity("AirPortModel.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FlightId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirPortId")
                        .HasColumnName("AirPortId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnName("FlighttDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Delay")
                        .HasColumnName("FlightDelay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTimeDate")
                        .HasColumnName("FlightEndTimeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlightAirPlaneId")
                        .HasColumnName("FlightAirPlaneId")
                        .HasColumnType("int");

                    b.Property<int>("FlightEndAirportId")
                        .HasColumnName("FlightEndAirportId")
                        .HasColumnType("int");

                    b.Property<int>("FlightstatusId")
                        .HasColumnName("FlightstatusId")
                        .HasColumnType("int");

                    b.Property<int>("GateId")
                        .HasColumnName("FlightGateId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnName("FlightNumber")
                        .HasColumnType("int");

                    b.Property<int>("StartAirPortId")
                        .HasColumnName("StartAirPortId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTimeDate")
                        .HasColumnName("FlightStartTimeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnName("FlightTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AirPortId");

                    b.HasIndex("FlightAirPlaneId");

                    b.HasIndex("FlightEndAirportId");

                    b.HasIndex("FlightstatusId");

                    b.HasIndex("GateId");

                    b.HasIndex("StartAirPortId");

                    b.ToTable("Tbl_Flight");
                });

            modelBuilder.Entity("AirPortModel.Models.FlightStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FlightStatusId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusType")
                        .IsRequired()
                        .HasColumnName("FlightStatusType")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Tbl_FlightStatus");
                });

            modelBuilder.Entity("AirPortModel.Models.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GalleryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("GalleryName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tbl_Gallery");
                });

            modelBuilder.Entity("AirPortModel.Models.GalleryImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GalleryId")
                        .HasColumnName("GalleryId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnName("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("GalleryId");

                    b.ToTable("Tbl_GalleryImage");
                });

            modelBuilder.Entity("AirPortModel.Models.Gate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GateId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("GetName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Terminal")
                        .HasColumnName("GateTerminal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("terminalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("terminalId");

                    b.ToTable("Tbl_Gate");
                });

            modelBuilder.Entity("AirPortModel.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PlaceId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnName("PlaceAdress")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("CategoryId")
                        .HasColumnName("PlaceCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DetailId")
                        .HasColumnName("PlaceDetailId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
                        .HasColumnName("PlaceGalleryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("PlaceName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PlaceCustomer")
                        .HasColumnName("PlaceCustomer")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("active")
                        .HasColumnName("PlaceIsactive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DetailId");

                    b.HasIndex("GalleryId");

                    b.ToTable("Tbl_Place");
                });

            modelBuilder.Entity("AirPortModel.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StateId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StateName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tbl_State");
                });

            modelBuilder.Entity("AirPortModel.Models.Terminal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TerminalId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirPortId")
                        .HasColumnName("AirPortId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnName("TerminalImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("TerminalName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AirPortId");

                    b.ToTable("Tbl_Terminal");
                });

            modelBuilder.Entity("AirPortModel.Models.TypeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypeDetailId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("TypeDetailName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tbl_TypeDetail");
                });

            modelBuilder.Entity("AirPortModel.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("UserName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Tbl_User");
                });

            modelBuilder.Entity("AirPortModel.Models.Adress", b =>
                {
                    b.HasOne("AirPortModel.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.AirPlane", b =>
                {
                    b.HasOne("AirPortModel.Models.Brand", "Brands")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.Detail", "Detail")
                        .WithMany()
                        .HasForeignKey("DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.Gallery", "Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.AirPort", b =>
                {
                    b.HasOne("AirPortModel.Models.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AirPortAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.Gallery", "Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.Airline", b =>
                {
                    b.HasOne("AirPortModel.Models.Detail", "Detail")
                        .WithMany()
                        .HasForeignKey("DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.City", b =>
                {
                    b.HasOne("AirPortModel.Models.State", "state")
                        .WithMany()
                        .HasForeignKey("CityStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.Detail", b =>
                {
                    b.HasOne("AirPortModel.Models.TypeDetail", "TypeDetail")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.DetailValue", b =>
                {
                    b.HasOne("AirPortModel.Models.Featrue", "Featrue")
                        .WithMany()
                        .HasForeignKey("FeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.Featrue", b =>
                {
                    b.HasOne("AirPortModel.Models.TypeDetail", "TypeDetail")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.Flight", b =>
                {
                    b.HasOne("AirPortModel.Models.AirPort", "AirPort")
                        .WithMany()
                        .HasForeignKey("AirPortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.AirPlane", "AirPlane")
                        .WithMany("Flights")
                        .HasForeignKey("FlightAirPlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.AirPort", "EndAirport")
                        .WithMany()
                        .HasForeignKey("FlightEndAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.FlightStatus", "FlightStatus")
                        .WithMany()
                        .HasForeignKey("FlightstatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.Gate", "Gate")
                        .WithMany()
                        .HasForeignKey("GateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.AirPort", "StartAirPort")
                        .WithMany()
                        .HasForeignKey("StartAirPortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.GalleryImage", b =>
                {
                    b.HasOne("AirPortModel.Models.Gallery", "Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.Gate", b =>
                {
                    b.HasOne("AirPortModel.Models.Terminal", "terminal")
                        .WithMany()
                        .HasForeignKey("terminalId");
                });

            modelBuilder.Entity("AirPortModel.Models.Place", b =>
                {
                    b.HasOne("AirPortModel.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.Detail", "Detail")
                        .WithMany()
                        .HasForeignKey("DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirPortModel.Models.Gallery", "Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.Terminal", b =>
                {
                    b.HasOne("AirPortModel.Models.AirPort", "AirPort")
                        .WithMany()
                        .HasForeignKey("AirPortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirPortModel.Models.User", b =>
                {
                    b.HasOne("AirPortModel.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}