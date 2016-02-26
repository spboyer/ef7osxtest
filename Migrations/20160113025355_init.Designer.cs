using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EF7WebAPI.Data;

namespace EF7WebAPI.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20160113025355_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EF7WebAPI.WeatherEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Hooray");

                    b.Property<TimeSpan>("Time");

                    b.Property<int>("Type");

                    b.HasKey("Id");
                });
        }
    }
}
