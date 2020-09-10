﻿// <auto-generated />
using System;
using AccountingWeb.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountingWeb.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    partial class AccountingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountingWeb.Models.firm", b =>
                {
                    b.Property<int>("FirmID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Add1");

                    b.Property<string>("Add2");

                    b.Property<string>("Add3");

                    b.Property<string>("CINNO");

                    b.Property<int?>("CityID");

                    b.Property<string>("Commisionerate");

                    b.Property<string>("CommodityNo");

                    b.Property<string>("CstNo");

                    b.Property<string>("DirectorName1");

                    b.Property<string>("DirectorName2");

                    b.Property<string>("DivisionNo");

                    b.Property<string>("EccNo");

                    b.Property<string>("Email");

                    b.Property<string>("FBankAcNo");

                    b.Property<string>("FBankName");

                    b.Property<string>("FIfscode");

                    b.Property<string>("FaxNo");

                    b.Property<string>("FirmGSTNO");

                    b.Property<string>("FirmID4Stock");

                    b.Property<string>("FirmName");

                    b.Property<string>("FirmNameGuj");

                    b.Property<int?>("FirmOpenDate");

                    b.Property<int?>("FirmStateID");

                    b.Property<string>("GstNo");

                    b.Property<string>("InvGstRule1");

                    b.Property<string>("ItNo");

                    b.Property<string>("MobileNo");

                    b.Property<string>("PartnerName1");

                    b.Property<string>("PartnerName2");

                    b.Property<byte[]>("PartnerName3");

                    b.Property<string>("PhoneNo1");

                    b.Property<string>("PhoneNo2");

                    b.Property<string>("PhoneNo3");

                    b.Property<string>("Pincode");

                    b.Property<string>("RangeNo");

                    b.Property<string>("RegistrationNo");

                    b.Property<string>("ShortFirmName");

                    b.Property<string>("Signature");

                    b.Property<int?>("Status");

                    b.Property<DateTime?>("TRDTTIME");

                    b.Property<string>("TdaNo");

                    b.Property<int?>("USERID");

                    b.Property<string>("UlNo");

                    b.Property<string>("add1Guj");

                    b.Property<string>("add2Guj");

                    b.HasKey("FirmID");

                    b.ToTable("firm");
                });
#pragma warning restore 612, 618
        }
    }
}
