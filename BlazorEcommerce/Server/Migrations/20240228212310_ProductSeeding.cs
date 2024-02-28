using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Rather than look at Muhammad's traits or his moral character for the explanation — in other words, at how Muhammad was — Hayward focused on what Muhammad thought and did while leading in order to ascertain whether his concepts, actions and habits reveal substantial and meaningful insights into the effectiveness of his leadership. Hayward investigated what the earliest extant Arabic sources reveal about Muhammad's capacity and aptitude for leadership in order to make a determination as to whether, and to what degree, Muhammad consciously acted in ways that produced positive results, especially the results he actually sought, during his twenty-three years as a leader.", "https://www.ijtihad.org/wp-content/uploads/2019/06/Screen-Shot-2019-06-01-at-4.20.19-PM.png", 9.99m, "The Leadership of Muhammad" },
                    { 2, "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance, and repressive regimentation of people and behaviours within society.", "https://booktriggerwarnings.com/images/1/13/1984.jpg", 7.99m, "Nineteen Eighty-Four" },
                    { 3, "Tafsīr al-Qurʾān al-ʿAẓīm better known as Tafsir Ibn Kathir is the tafsir by Ibn Kathir (died 774 AH/1372 CE). It is one of the most famous Islamic books concerned with the science of interpretation of the Quran.[1] It also includes jurisprudential rulings, and takes care of the hadiths and is famous for being almost devoid of Israʼiliyyat.[1] It is the most followed tafsir by salafist muslims.", "https://umdatalsalik.files.wordpress.com/2010/12/ibnkathirjuz10.jpg", 11.99m, "Tafsir Ibn Kathir" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
