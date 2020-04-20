﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YumiAPI.Models;

namespace YumiAPI.Migrations
{
    [DbContext(typeof(YumiContext))]
    partial class YumiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("YumiAPI.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Allergens")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSpicy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("YumiAPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsFinished")
                        .HasColumnType("TEXT");

                    b.Property<string>("Items")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("YumiAPI.Models.PageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutPageText")
                        .HasColumnType("TEXT");

                    b.Property<int>("CarouselItems")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarouselVisible")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactHours")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPageText")
                        .HasColumnType("TEXT");

                    b.Property<string>("PageLogo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PageTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialFacebook")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialInstagram")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialTwitter")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PageContent");
                });

            modelBuilder.Entity("YumiAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateRegistered")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsAdmin")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoggedIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderCount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserImg")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
