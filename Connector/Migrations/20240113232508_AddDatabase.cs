using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Connector.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnershipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompaniesHouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddressTownCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uprn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnspdLatitude = table.Column<double>(type: "float", nullable: false),
                    OnspdLongitude = table.Column<double>(type: "float", nullable: false),
                    MainPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InspectionDirectorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Constituency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastInspection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CachedOnDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.ProviderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provider");
        }
    }
}
