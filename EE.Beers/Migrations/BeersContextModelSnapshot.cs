﻿// <auto-generated />
using EE.Beers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EE.Beers.Migrations
{
    [DbContext(typeof(BeersContext))]
    partial class BeersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EE.Beers.Entities.Beer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AlcoholByVolume");

                    b.Property<byte>("BitteringIndex");

                    b.Property<long?>("BrouwerijId");

                    b.Property<bool>("IsActivelyBrewed");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BrouwerijId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("EE.Beers.Entities.BeerFlavor", b =>
                {
                    b.Property<long>("BeerId");

                    b.Property<long>("FlavorId");

                    b.HasKey("BeerId", "FlavorId");

                    b.HasIndex("FlavorId");

                    b.ToTable("BeerFlavor");
                });

            modelBuilder.Entity("EE.Beers.Entities.Brouwerij", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Brouwerijen");
                });

            modelBuilder.Entity("EE.Beers.Entities.Flavor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("EE.Beers.Entities.Beer", b =>
                {
                    b.HasOne("EE.Beers.Entities.Brouwerij", "Brouwerij")
                        .WithMany("BierenVanBrouwerij")
                        .HasForeignKey("BrouwerijId");
                });

            modelBuilder.Entity("EE.Beers.Entities.BeerFlavor", b =>
                {
                    b.HasOne("EE.Beers.Entities.Beer", "Beer")
                        .WithMany("Flavors")
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EE.Beers.Entities.Flavor", "Flavor")
                        .WithMany("BeersWithFlavor")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
