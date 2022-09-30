using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Appetizer", "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует", "https://i.pinimg.com/originals/29/df/58/29df58cb2d677b950d073cf8cc21418b.jpg", "Samosa", 15m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "Appetizer", "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует", "https://eda.yandex/images/1380298/9057ba70a760213ab552e93eebc57969-450x300.jpg", "Paneer Tikka", 13.22m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "Dessert", "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1gRnMvOqlvbRBmVC1DnajLW4gSvtvK0jTVg&usqp=CAU", "Sweet Pie", 19.52m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
