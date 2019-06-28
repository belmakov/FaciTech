using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaciTech.Apartment.Database.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunityLocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BuilderName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CountryId = table.Column<Guid>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StateId = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    CityId = table.Column<Guid>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    AreaId = table.Column<Guid>(nullable: false),
                    SubArea = table.Column<string>(nullable: true),
                    SubAreaId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    LocationLink = table.Column<string>(nullable: true),
                    AssociationName = table.Column<string>(nullable: true),
                    AssociationNumber = table.Column<string>(nullable: true),
                    AssociationBankName = table.Column<string>(nullable: true),
                    AssociationBankAccountNumber = table.Column<string>(nullable: true),
                    AssociationBankBranchAddress = table.Column<string>(nullable: true),
                    AssociationBankIFSC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ContactId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CountryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupRole",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRole", x => new { x.GroupId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_GroupRole_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleFeature",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleFeature", x => new { x.RoleId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_RoleFeature_Feature_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleFeature_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_UserGroup_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroup_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubArea",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AreaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubArea_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    BuilderName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    LocationLink = table.Column<string>(nullable: true),
                    AssociationName = table.Column<string>(nullable: true),
                    AssociationNumber = table.Column<string>(nullable: true),
                    AssociationBankName = table.Column<string>(nullable: true),
                    AssociationBankAccountNumber = table.Column<string>(nullable: true),
                    AssociationBankBranchAddress = table.Column<string>(nullable: true),
                    AssociationBankIFSC = table.Column<string>(nullable: true),
                    AmenityIds = table.Column<string>(nullable: true),
                    SubAreaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Community_SubArea_SubAreaId",
                        column: x => x.SubAreaId,
                        principalTable: "SubArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    NoOfFloors = table.Column<int>(nullable: false),
                    CommunityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_Community_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Community",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    FloorNumber = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    Specification = table.Column<string>(nullable: true),
                    SectionId = table.Column<Guid>(nullable: false),
                    OwnerContactId = table.Column<Guid>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Contact_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    ContactId = table.Column<Guid>(nullable: false),
                    Primary = table.Column<bool>(nullable: false),
                    UnitId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenant_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tenant_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Comments", "Created", "CreatedBy", "Inactive", "Name", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("bc389b83-ded4-406a-a318-0616b7973734"), null, new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(4799), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "India", new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(5172), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Comments", "ContactId", "Created", "CreatedBy", "Inactive", "Password", "Salt", "Updated", "UpdatedBy", "Username" },
                values: new object[] { new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), "sys user record", null, new DateTime(2019, 6, 28, 18, 39, 1, 24, DateTimeKind.Utc).AddTicks(9396), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "Bi4Fi6tHEiF+Cv3Jh0V0MA==", "123", new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(54), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), "system" });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Comments", "CountryId", "Created", "CreatedBy", "Inactive", "Name", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("29d44de8-9138-4295-ad1d-486a92eb74a4"), null, new Guid("bc389b83-ded4-406a-a318-0616b7973734"), new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(6697), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "Karnataka", new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(7035), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Comments", "Created", "CreatedBy", "Inactive", "Name", "StateId", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("bce5ac11-1af6-4301-86ac-83c97c218f7c"), null, new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(8691), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "Bangalore", new Guid("29d44de8-9138-4295-ad1d-486a92eb74a4"), new DateTime(2019, 6, 28, 18, 39, 1, 25, DateTimeKind.Utc).AddTicks(9019), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "Id", "CityId", "Comments", "Created", "CreatedBy", "Inactive", "Name", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("538a9be1-25c0-4a26-a8dd-93e32937faa2"), new Guid("bce5ac11-1af6-4301-86ac-83c97c218f7c"), null, new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(532), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "North", new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(886), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "Id", "CityId", "Comments", "Created", "CreatedBy", "Inactive", "Name", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("f314122a-e758-4c11-a48e-198ef276874e"), new Guid("bce5ac11-1af6-4301-86ac-83c97c218f7c"), null, new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(1537), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "South", new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(1542), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.InsertData(
                table: "SubArea",
                columns: new[] { "Id", "AreaId", "Comments", "Created", "CreatedBy", "Inactive", "Name", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("ddbdf5e0-f83f-4d72-af2a-1a64e6d0f338"), new Guid("538a9be1-25c0-4a26-a8dd-93e32937faa2"), null, new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(3356), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "Hebbal", new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(3361), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.InsertData(
                table: "SubArea",
                columns: new[] { "Id", "AreaId", "Comments", "Created", "CreatedBy", "Inactive", "Name", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("ea0cdc88-7fbd-4306-9bdf-a62d82a42d56"), new Guid("f314122a-e758-4c11-a48e-198ef276874e"), null, new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(2379), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0"), false, "Jayanagar", new DateTime(2019, 6, 28, 18, 39, 1, 26, DateTimeKind.Utc).AddTicks(2709), new Guid("fc3f9472-69c9-4dd3-8fab-8ba2639812f0") });

            migrationBuilder.CreateIndex(
                name: "IX_Area_CityId",
                table: "Area",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Community_SubAreaId",
                table: "Community",
                column: "SubAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRole_RoleId",
                table: "GroupRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleFeature_FeatureId",
                table: "RoleFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Section_CommunityId",
                table: "Section",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubArea_AreaId",
                table: "SubArea",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenant_ContactId",
                table: "Tenant",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenant_UnitId",
                table: "Tenant",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_OwnerId",
                table: "Unit",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_SectionId",
                table: "Unit",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ContactId",
                table: "User",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_GroupId",
                table: "UserGroup",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenity");

            migrationBuilder.DropTable(
                name: "CommunityLocation");

            migrationBuilder.DropTable(
                name: "GroupRole");

            migrationBuilder.DropTable(
                name: "RoleFeature");

            migrationBuilder.DropTable(
                name: "Tenant");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "SubArea");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
