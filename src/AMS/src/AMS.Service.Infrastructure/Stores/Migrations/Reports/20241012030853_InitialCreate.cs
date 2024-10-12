using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Undersoft.AMS.Service.Infrastructure.Stores.Migrations.Reports
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "domain");

            migrationBuilder.EnsureSchema(
                name: "relations");

            migrationBuilder.EnsureSchema(
                name: "identifiers");

            migrationBuilder.CreateTable(
                name: "Activities",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ParticipantType = table.Column<long>(type: "bigint", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    SocialMedia = table.Column<string>(type: "text", nullable: true),
                    Websites = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Member = table.Column<string>(type: "text", nullable: true),
                    MemberData = table.Column<byte[]>(type: "bytea", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsVariant = table.Column<bool>(type: "boolean", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityIdentifiers",
                schema: "identifiers",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ObjectId = table.Column<long>(type: "bigint", nullable: false),
                    Kind = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityIdentifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityIdentifiers_Activities_ObjectId",
                        column: x => x.ObjectId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityToActivity",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityToActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityToActivity_Activities_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityToActivity_Activities_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesToParticipants",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesToParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitiesToParticipants_Activities_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesToParticipants_Participants_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    PlaceId = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Postcode = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    Building = table.Column<string>(type: "text", nullable: true),
                    Apartment = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParticipantIdentifiers",
                schema: "identifiers",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ObjectId = table.Column<long>(type: "bigint", nullable: false),
                    Kind = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantIdentifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantIdentifiers_Participants_ObjectId",
                        column: x => x.ObjectId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantToParticipant",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantToParticipant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantToParticipant_Participants_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantToParticipant_Participants_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    PhoneType = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesToResources",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesToResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitiesToResources_Activities_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesToResources_Resources_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantsToResources",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantsToResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantsToResources_Participants_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantsToResources_Resources_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    SubjectId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectIdentifiers",
                schema: "identifiers",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ObjectId = table.Column<long>(type: "bigint", nullable: false),
                    Kind = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Key = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectIdentifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectIdentifiers_Subjects_ObjectId",
                        column: x => x.ObjectId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectsToResources",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsToResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectsToResources_Resources_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectsToResources_Subjects_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectToSubject",
                schema: "relations",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    RightEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LeftEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectToSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectToSubject_Subjects_LeftEntityId",
                        column: x => x.LeftEntityId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectToSubject_Subjects_RightEntityId",
                        column: x => x.RightEntityId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amounts",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Unit = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    UnitName = table.Column<string>(type: "text", nullable: true),
                    Prevalue = table.Column<double>(type: "double precision", nullable: true),
                    Factor = table.Column<double>(type: "double precision", nullable: true),
                    Value = table.Column<double>(type: "double precision", nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    SubjectId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amounts_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Amounts_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "domain",
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Amounts_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Amounts_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    SubjectId = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    ResourceId = table.Column<long>(type: "bigint", nullable: true),
                    Kind = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "domain",
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalSchema: "domain",
                        principalTable: "Resources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "domain",
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dates",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    AmountId = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dates_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalSchema: "domain",
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dates_Amounts_AmountId",
                        column: x => x.AmountId,
                        principalSchema: "domain",
                        principalTable: "Amounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dates_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "domain",
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dates_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "domain",
                        principalTable: "Participants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Endpoints",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    Host = table.Column<string>(type: "text", nullable: true),
                    IP = table.Column<string>(type: "text", nullable: true),
                    Port = table.Column<int>(type: "integer", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    BaseUrl = table.Column<string>(type: "text", nullable: true),
                    OS = table.Column<string>(type: "text", nullable: true),
                    Protocol = table.Column<string>(type: "text", nullable: true),
                    Method = table.Column<string>(type: "text", nullable: true),
                    Parameters = table.Column<string[]>(type: "text[]", nullable: true),
                    ReturnUrl = table.Column<string>(type: "text", nullable: true),
                    StateUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endpoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endpoints_Locations_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "domain",
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Places",
                schema: "domain",
                columns: table => new
                {
                    CodeNo = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    OriginId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "character varying(768)", maxLength: 768, nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Modifier = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Creator = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    Index = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    AddressId = table.Column<long>(type: "bigint", nullable: true),
                    Kind = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: true),
                    Width = table.Column<int>(type: "integer", nullable: true),
                    Length = table.Column<int>(type: "integer", nullable: true),
                    X = table.Column<int>(type: "integer", nullable: true),
                    Y = table.Column<int>(type: "integer", nullable: true),
                    Z = table.Column<int>(type: "integer", nullable: true),
                    Size = table.Column<int>(type: "integer", nullable: true),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Altitude = table.Column<double>(type: "double precision", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Block = table.Column<int>(type: "integer", nullable: false),
                    Sector = table.Column<int>(type: "integer", nullable: false),
                    Cluster = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "domain",
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Places_Locations_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "domain",
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Index",
                schema: "domain",
                table: "Activities",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesToParticipants_LeftEntityId",
                schema: "relations",
                table: "ActivitiesToParticipants",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesToParticipants_RightEntityId",
                schema: "relations",
                table: "ActivitiesToParticipants",
                column: "RightEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesToResources_LeftEntityId",
                schema: "relations",
                table: "ActivitiesToResources",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesToResources_RightEntityId",
                schema: "relations",
                table: "ActivitiesToResources",
                column: "RightEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityIdentifiers_Key",
                schema: "identifiers",
                table: "ActivityIdentifiers",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityIdentifiers_ObjectId",
                schema: "identifiers",
                table: "ActivityIdentifiers",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityToActivity_LeftEntityId",
                schema: "relations",
                table: "ActivityToActivity",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityToActivity_RightEntityId",
                schema: "relations",
                table: "ActivityToActivity",
                column: "RightEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Index",
                schema: "domain",
                table: "Addresses",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ParticipantId",
                schema: "domain",
                table: "Addresses",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Amounts_ActivityId",
                schema: "domain",
                table: "Amounts",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Amounts_Index",
                schema: "domain",
                table: "Amounts",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Amounts_ItemId",
                schema: "domain",
                table: "Amounts",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Amounts_ParticipantId",
                schema: "domain",
                table: "Amounts",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Amounts_SubjectId",
                schema: "domain",
                table: "Amounts",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ActivityId",
                schema: "domain",
                table: "Dates",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_AmountId",
                schema: "domain",
                table: "Dates",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_Index",
                schema: "domain",
                table: "Dates",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ItemId",
                schema: "domain",
                table: "Dates",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ParticipantId",
                schema: "domain",
                table: "Dates",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_Index",
                schema: "domain",
                table: "Emails",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ParticipantId",
                schema: "domain",
                table: "Emails",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Endpoints_Index",
                schema: "domain",
                table: "Endpoints",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Endpoints_LocationId",
                schema: "domain",
                table: "Endpoints",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ActivityId",
                schema: "domain",
                table: "Items",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Index",
                schema: "domain",
                table: "Items",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ParticipantId",
                schema: "domain",
                table: "Items",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SubjectId",
                schema: "domain",
                table: "Items",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ActivityId",
                schema: "domain",
                table: "Locations",
                column: "ActivityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Index",
                schema: "domain",
                table: "Locations",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ItemId",
                schema: "domain",
                table: "Locations",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ParticipantId",
                schema: "domain",
                table: "Locations",
                column: "ParticipantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ResourceId",
                schema: "domain",
                table: "Locations",
                column: "ResourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_SubjectId",
                schema: "domain",
                table: "Locations",
                column: "SubjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantIdentifiers_Key",
                schema: "identifiers",
                table: "ParticipantIdentifiers",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantIdentifiers_ObjectId",
                schema: "identifiers",
                table: "ParticipantIdentifiers",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_Index",
                schema: "domain",
                table: "Participants",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantsToResources_LeftEntityId",
                schema: "relations",
                table: "ParticipantsToResources",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantsToResources_RightEntityId",
                schema: "relations",
                table: "ParticipantsToResources",
                column: "RightEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantToParticipant_LeftEntityId",
                schema: "relations",
                table: "ParticipantToParticipant",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantToParticipant_RightEntityId",
                schema: "relations",
                table: "ParticipantToParticipant",
                column: "RightEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_Index",
                schema: "domain",
                table: "Phones",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ParticipantId",
                schema: "domain",
                table: "Phones",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_AddressId",
                schema: "domain",
                table: "Places",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_Index",
                schema: "domain",
                table: "Places",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_Places_LocationId",
                schema: "domain",
                table: "Places",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_Index",
                schema: "domain",
                table: "Resources",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectIdentifiers_Key",
                schema: "identifiers",
                table: "SubjectIdentifiers",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectIdentifiers_ObjectId",
                schema: "identifiers",
                table: "SubjectIdentifiers",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Index",
                schema: "domain",
                table: "Subjects",
                column: "Index");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsToResources_LeftEntityId",
                schema: "relations",
                table: "SubjectsToResources",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsToResources_RightEntityId",
                schema: "relations",
                table: "SubjectsToResources",
                column: "RightEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToSubject_LeftEntityId",
                schema: "relations",
                table: "SubjectToSubject",
                column: "LeftEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToSubject_RightEntityId",
                schema: "relations",
                table: "SubjectToSubject",
                column: "RightEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesToParticipants",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "ActivitiesToResources",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "ActivityIdentifiers",
                schema: "identifiers");

            migrationBuilder.DropTable(
                name: "ActivityToActivity",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "Dates",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Emails",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Endpoints",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "ParticipantIdentifiers",
                schema: "identifiers");

            migrationBuilder.DropTable(
                name: "ParticipantsToResources",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "ParticipantToParticipant",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "Phones",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Places",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "SubjectIdentifiers",
                schema: "identifiers");

            migrationBuilder.DropTable(
                name: "SubjectsToResources",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "SubjectToSubject",
                schema: "relations");

            migrationBuilder.DropTable(
                name: "Amounts",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Items",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Resources",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Activities",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Participants",
                schema: "domain");

            migrationBuilder.DropTable(
                name: "Subjects",
                schema: "domain");
        }
    }
}
