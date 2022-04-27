﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsAPI.Data;

namespace StudentsAPI.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220419155728_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("StudentsAPI.Models.FavoriteFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("GlutenFree")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Vegan")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("FavoriteFoods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GlutenFree = false,
                            Name = "Pho",
                            Origin = "Vietnamese",
                            Vegan = false
                        },
                        new
                        {
                            Id = 2,
                            GlutenFree = false,
                            Name = "Fajitas",
                            Origin = "Mexico",
                            Vegan = false
                        },
                        new
                        {
                            Id = 3,
                            GlutenFree = false,
                            Name = "Pizza",
                            Origin = "Italia",
                            Vegan = false
                        },
                        new
                        {
                            Id = 4,
                            GlutenFree = false,
                            Name = "Doughnuts",
                            Origin = "Dutch",
                            Vegan = false
                        },
                        new
                        {
                            Id = 5,
                            GlutenFree = false,
                            Name = "Pasta",
                            Origin = "Asian",
                            Vegan = false
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.FavoriteMusic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FavoriteAlbum")
                        .HasColumnType("TEXT");

                    b.Property<string>("FavoriteArtist")
                        .HasColumnType("TEXT");

                    b.Property<string>("FavoriteBand")
                        .HasColumnType("TEXT");

                    b.Property<string>("FavoriteSong")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FavoriteMusics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FavoriteAlbum = "PSY - 4x2=8",
                            FavoriteArtist = "NF - Nathan John Feuerstein",
                            FavoriteBand = "Imagine Dragons",
                            FavoriteSong = "Natural - Imagine Dragons",
                            Genre = "Pop"
                        },
                        new
                        {
                            Id = 2,
                            FavoriteAlbum = "MGMT - Congratulations",
                            FavoriteArtist = "Bob Dylan",
                            FavoriteBand = "Black Country, New Road",
                            FavoriteSong = "Marty Robbins - Cool Water",
                            Genre = "Alternative"
                        },
                        new
                        {
                            Id = 3,
                            FavoriteAlbum = "Guns N’ Roses – Appetite for Destruction",
                            FavoriteArtist = "Bob Dylan",
                            FavoriteBand = "Guns N' Roses",
                            FavoriteSong = "Guns N’ Roses – Paradise City,",
                            Genre = "Rock"
                        },
                        new
                        {
                            Id = 4,
                            FavoriteAlbum = "AJR - Neotheater",
                            FavoriteArtist = "Ben Platt",
                            FavoriteBand = "Glass Animals",
                            FavoriteSong = "John Mayer - Wild Blue",
                            Genre = "Pop" 
                        },
                        new
                        {
                            Id = 5,
                            FavoriteAlbum = "Amine - ONEPOINTFIVE",
                            FavoriteArtist = "Baby Keen",
                            FavoriteBand = "One Direction",
                            FavoriteSong = "blackbear - halfalive",
                            Genre = "Pop"
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.FavoritePlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MustVisit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visited")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("FavoritePlaces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Giza",
                            Country = "Egypt",
                            Description = "The largest ancient structure in the world.",
                            MustVisit = true,
                            Name = "The Great Pyramid of Giza",
                            Visited = false
                        },
                        new
                        {
                            Id = 2,
                            City = "Yosemite National Park",
                            Country = "United States",
                            Description = "The tallest waterfall in the park.",
                            MustVisit = true,
                            Name = "Yosemite Falls",
                            Visited = true
                        },
                        new
                        {
                            Id = 3,
                            City = " Dubai",
                            Country = "United Arab Emirates",
                            Description = "The world’s tallest building.",
                            MustVisit = true,
                            Name = "Burj Khalifa",
                            Visited = false
                        },
                        new
                        {
                            Id = 4,
                            City = "Chicago",
                            Country = "United States",
                            Description = "Reflective Sculpture.",
                            MustVisit = true,
                            Name = "The Bean",
                            Visited = true
                         },
                         new
                        {
                            Id = 5,
                            City = "New York",
                            Country = "United States",
                            Description = "Historical landmark.",
                            MustVisit = true,
                            Name = "Emptire State Building",
                            Visited = true
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegeProgram")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("YearInProgram")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "David Nguyen",
                            YearInProgram = "Sophomore"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Brendan Payne",
                            YearInProgram = "Pre-Junior"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Business",
                            FullName = "Jane Doe",
                            YearInProgram = "Junior"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2002, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Amber Willis",
                            YearInProgram = "Sophomore"
                         },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2002, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Jenna Wasilko",
                            YearInProgram = "Sophomore"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
