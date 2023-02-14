﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    [Migration("20230213192002_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6.Models.TrackerEntry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntryID");

                    b.ToTable("entries");

                    b.HasData(
                        new
                        {
                            EntryID = 1,
                            Category = "Sci-Fi",
                            Director = "James Cameron",
                            Edited = false,
                            Notes = "Saw it twice in theaters",
                            Rating = "PG-13",
                            Title = "Avatar: Way of Water",
                            Year = 2022
                        },
                        new
                        {
                            EntryID = 2,
                            Category = "Historical",
                            Director = "Angelina Jolie",
                            Edited = false,
                            LentTo = "Mitchell",
                            Notes = "Very inspirational",
                            Rating = "PG-13",
                            Title = "Unbroken",
                            Year = 2014
                        },
                        new
                        {
                            EntryID = 3,
                            Category = "Action/Adventure",
                            Director = "Joseph Kosinski",
                            Edited = false,
                            LentTo = "Ryan",
                            Notes = "Almost made me join AF",
                            Rating = "PG-13",
                            Title = "Top Gun: Maverick",
                            Year = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
