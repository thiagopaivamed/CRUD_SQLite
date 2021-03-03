﻿// <auto-generated />
using CRUD_SQLite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_SQLite.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("CRUD_SQLite.Models.Aviao", b =>
                {
                    b.Property<int>("AviaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fabricante")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantidadePassageiros")
                        .HasColumnType("INTEGER");

                    b.HasKey("AviaoId");

                    b.ToTable("Avioes");
                });
#pragma warning restore 612, 618
        }
    }
}
