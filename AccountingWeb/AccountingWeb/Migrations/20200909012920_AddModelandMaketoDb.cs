using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountingWeb.Migrations
{
    public partial class AddModelandMaketoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "firm",
                columns: table => new
                {
                    FirmID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirmName = table.Column<string>(nullable: true),
                    ShortFirmName = table.Column<string>(nullable: true),
                    Add1 = table.Column<string>(nullable: true),
                    Add2 = table.Column<string>(nullable: true),
                    Add3 = table.Column<string>(nullable: true),
                    CityID = table.Column<int>(nullable: true),
                    Pincode = table.Column<string>(nullable: true),
                    PhoneNo1 = table.Column<string>(nullable: true),
                    PhoneNo2 = table.Column<string>(nullable: true),
                    PhoneNo3 = table.Column<string>(nullable: true),
                    FaxNo = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RegistrationNo = table.Column<string>(nullable: true),
                    CstNo = table.Column<string>(nullable: true),
                    GstNo = table.Column<string>(nullable: true),
                    EccNo = table.Column<string>(nullable: true),
                    RangeNo = table.Column<string>(nullable: true),
                    DivisionNo = table.Column<string>(nullable: true),
                    ItNo = table.Column<string>(nullable: true),
                    CommodityNo = table.Column<string>(nullable: true),
                    TdaNo = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true),
                    Commisionerate = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    UlNo = table.Column<string>(nullable: true),
                    PartnerName1 = table.Column<string>(nullable: true),
                    PartnerName2 = table.Column<string>(nullable: true),
                    PartnerName3 = table.Column<byte[]>(nullable: true),
                    DirectorName1 = table.Column<string>(nullable: true),
                    DirectorName2 = table.Column<string>(nullable: true),
                    FirmNameGuj = table.Column<string>(nullable: true),
                    add1Guj = table.Column<string>(nullable: true),
                    add2Guj = table.Column<string>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    TRDTTIME = table.Column<DateTime>(nullable: true),
                    FBankName = table.Column<string>(nullable: true),
                    FIfscode = table.Column<string>(nullable: true),
                    FBankAcNo = table.Column<string>(nullable: true),
                    FirmOpenDate = table.Column<int>(nullable: true),
                    FirmID4Stock = table.Column<string>(nullable: true),
                    FirmGSTNO = table.Column<string>(nullable: true),
                    FirmStateID = table.Column<int>(nullable: true),
                    CINNO = table.Column<string>(nullable: true),
                    InvGstRule1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firm", x => x.FirmID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "firm");
        }
    }
}
