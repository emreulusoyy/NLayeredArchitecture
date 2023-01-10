﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.AltSlider", b =>
                {
                    b.Property<int>("AltSliderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SliderBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AltSliderID");

                    b.ToTable("AltSliders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Belgeler", b =>
                {
                    b.Property<int>("BelgeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BelgeAcilirImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BelgeImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BelgeID");

                    b.ToTable("Belgelers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTarih")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hakkında", b =>
                {
                    b.Property<int>("HakkındaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HakkındaAcıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkındaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkındaImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkındaID");

                    b.ToTable("Hakkındas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hizmetler", b =>
                {
                    b.Property<int>("HizmetlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HizmetlerBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetlerImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HizmetlerID");

                    b.ToTable("Hizmetlers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Iletisim", b =>
                {
                    b.Property<int>("IletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Harita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IletisimID");

                    b.ToTable("Iletisims");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Slider", b =>
                {
                    b.Property<int>("SliderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SliderAltBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SliderID");

                    b.ToTable("Sliders");
                });
#pragma warning restore 612, 618
        }
    }
}
