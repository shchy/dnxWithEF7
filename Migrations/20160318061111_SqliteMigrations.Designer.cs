using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using sqlite.Models;

namespace sqlite.Migrations
{
    [DbContext(typeof(DataEventRecordContext))]
    [Migration("20160318061111_SqliteMigrations")]
    partial class SqliteMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("sqlite.Models.DataEventRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");
                });
        }
    }
}
