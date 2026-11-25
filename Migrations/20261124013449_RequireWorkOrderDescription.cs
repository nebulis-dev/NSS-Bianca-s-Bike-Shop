using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiancasBikes.Migrations
{
    /// <inheritdoc />
    public partial class RequireWorkOrderDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkOrders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOFc6qkTgl1dLgp8VIk2J1/MdmhNHqbBvlqTb21bro4lCtXrcu9kgt14uoNGO/hmcw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkOrders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM4F/n5KZvgCOHguQYDT4HsF9CORE95LIu+x1+B81zKND2OVn13IF1JnevouZ6pINQ==");
        }
    }
}
