using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace infiniteworlds_fronted.Migrations
{
    /// <inheritdoc />
    public partial class Updateuserprofilegenerate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1436b133-2587-4052-892e-627596af9598");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a7a3e19-d306-451e-8184-b50533fa5546");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4cf03e-1c7d-45a7-9532-d3d7ac48e0c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55ab808a-0648-484e-88c9-f0fcc1047b72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f486c40-675b-4d8d-8293-5f3c10ee3531");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa979614-f233-4ef9-b15a-e05a5435667b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf9141f5-85cb-4425-8473-1ede382bbe94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d34edeaf-7708-4c1f-aeab-a2bf6bffed8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e279f093-acd5-4649-9cfb-0fca006e7fa6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e572547d-424d-43eb-9773-feb81c8adba2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86eafb0a-cb62-492e-9db2-c90d3627001a", "AQAAAAIAAYagAAAAEO9CV/VdEGnBWamqVmQt7j9ZO84lGXrQ0C+JzopvqiBWhTmjaWG5ARRAd1tgkShwHQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29fc2edf-dc5d-4e0f-aaf3-ebb8b5e72f96", 0, "fa41b197-ea22-4197-9118-f9d90efbae92", "Michaela25@hotmail.com", false, false, null, null, null, "dioiuiau", null, false, "1058bc2a-4828-4093-aff5-b91ebeab0489", false, "Kaelyn88" },
                    { "2a4603d7-1946-4c71-9994-46ba70f1d64a", 0, "1a39d709-ee1f-4c58-a250-ce57b4e995c0", "Sabrina57@yahoo.com", false, false, null, null, null, "yuiieaei", null, false, "0ddba573-c74e-429d-9062-f38b0ce24d4b", false, "Ulises.Labadie" },
                    { "7ad9cb22-f79f-4e95-982b-29279f0296d6", 0, "ea3acab9-2bee-4f89-92c8-0aae860885b3", "Dayna9@hotmail.com", false, false, null, null, null, "kuoeuioe", null, false, "c2533805-61e4-4ecc-bc2b-04d6b2e08a86", false, "Gordon_Gleichner" },
                    { "8e0905d9-106b-44a4-9ef9-526a32d3cfdf", 0, "e9857385-9f4f-4cb3-b99f-10e5c09e3e17", "Oswald_Sporer60@gmail.com", false, false, null, null, null, "voioeioo", null, false, "535b799d-4b3a-4725-ab01-87dbb1076d7b", false, "Rosalee.Koss" },
                    { "afd3af4b-7e26-4e7f-865c-56ce4e5c52d5", 0, "e06fef52-6af6-4211-805a-a2e6f420fd93", "Bruce.Upton99@yahoo.com", false, false, null, null, null, "nuoiaeoa", null, false, "0eadd52c-5621-457d-b4ee-8af49311dc02", false, "Dolores73" },
                    { "b8c57e6e-9a96-41f8-b45b-4dfaba5d3191", 0, "af0751fa-9b54-41e8-a4bd-7761be25e07e", "Helen6@yahoo.com", false, false, null, null, null, "qiiaouie", null, false, "dceeeaf4-7fdd-4de2-8886-17ca889b48a9", false, "Salma_Hoppe17" },
                    { "c47ac2e4-2218-498f-8b7f-5f1dd9d4755c", 0, "791a20a0-a415-4788-a75a-d8d66fd1263e", "Lucienne_Skiles8@hotmail.com", false, false, null, null, null, "pauuauao", null, false, "fc181bae-89b4-48c5-bc4e-ae7b7209ad72", false, "Chauncey_Dicki67" },
                    { "cabe5f4b-2b82-4d96-8455-7c3f7f656293", 0, "2dc1739a-c2bf-4d3f-b35f-77d35ed54925", "Keeley_Heathcote30@hotmail.com", false, false, null, null, null, "teiiaeuo", null, false, "f6278c27-d45c-4bb8-85a5-5f63570d76b9", false, "Eleazar.Gottlieb20" },
                    { "ce95e522-511b-4353-b697-3cf0f17392c5", 0, "cceef6f8-cc0b-402f-a589-3af5956143fb", "Priscilla.Sawayn14@gmail.com", false, false, null, null, null, "beaueiui", null, false, "26792993-5b05-44b0-9e6f-3736b5a17084", false, "Cicero45" },
                    { "f07f192f-d7d4-4e12-afa5-0e6f4efcb640", 0, "cb6281e5-823a-403f-856f-0c4b726b887f", "Reggie.Hahn@gmail.com", false, false, null, null, null, "veeaoeia", null, false, "77a31518-9f91-4023-a8b0-fedee53f5c28", false, "Shanie30" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Et inventore aliquam quos eum voluptas est aut. Quas repellat quo. Necessitatibus cumque qui libero amet est voluptas maxime. Est quod consequatur molestiae delectus quia omnis impedit aut. Quia necessitatibus debitis quaerat. Rem dignissimos voluptatem error eveniet eum neque ratione quos laboriosam.", "RPG", "Practical Cotton Cheese", new DateTime(2016, 10, 16, 10, 13, 14, 542, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sit aut voluptate consectetur aut sit dolorum esse nam maiores. Suscipit quos nulla nesciunt fuga accusantium rerum animi. Accusamus non aut praesentium et aut sint animi. Nemo fugiat saepe est natus corporis.", "RPG", "Intelligent Frozen Table", new DateTime(2021, 10, 6, 13, 29, 0, 242, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Repellat cumque aliquid rerum. Et dolores velit aut laboriosam aperiam. Sint reiciendis voluptas nulla harum sed eveniet voluptatum nobis autem.", "Action", "Small Cotton Bike", new DateTime(2020, 5, 26, 4, 51, 38, 641, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Explicabo repudiandae voluptates. Enim corrupti aut. Ex et modi et.", "Shooter", "Unbranded Fresh Ball", new DateTime(2023, 10, 17, 9, 34, 5, 280, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Et sint dolore dolorem iure veritatis. Adipisci deleniti et quam consectetur inventore dolores maxime dolorem. Repellat cumque saepe. Commodi debitis id eaque.", "Shooter", "Generic Wooden Hat", new DateTime(2021, 6, 15, 3, 30, 10, 605, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Animi molestiae sint beatae cupiditate adipisci aspernatur consectetur ullam. Quia accusamus dolores. Cum necessitatibus dolores accusamus ducimus aut. Ut sunt est ad aut nulla pariatur tenetur. Pariatur culpa nemo eveniet a incidunt asperiores.", "Gorgeous Metal Car", new DateTime(2022, 7, 4, 11, 19, 13, 713, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Facere voluptas error unde et nesciunt molestias provident nihil magnam. Quia rerum rerum necessitatibus facilis quas. Hic aperiam corrupti.", "Shooter", "Refined Rubber Mouse", new DateTime(2015, 11, 5, 16, 49, 42, 534, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Necessitatibus vero soluta vel excepturi. Molestiae nihil voluptas ut quia aut qui et. Enim suscipit magni rerum minus nemo sed deleniti quo.", "Strategy", "Rustic Steel Shoes", new DateTime(2022, 2, 20, 23, 20, 22, 342, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Perspiciatis harum quia quaerat facilis. Reiciendis vitae dicta. Earum cumque cumque autem ab est. Tempore ut distinctio dignissimos quisquam. Ducimus omnis non. Aperiam reiciendis doloremque repellat perspiciatis.", "Gorgeous Steel Towels", new DateTime(2022, 1, 4, 18, 40, 18, 263, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Aut odit at enim. Delectus repudiandae qui minus mollitia et aut. Veniam enim assumenda saepe. Blanditiis eius illo eveniet assumenda non provident neque explicabo voluptas.", "Puzzle", "Practical Frozen Fish", new DateTime(2016, 10, 30, 13, 32, 39, 329, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Accusamus eligendi qui est quisquam sed facilis est. Sed earum sed consequatur consectetur rem. Et accusantium magni fugit enim illum repudiandae vel.", "Strategy", "Tasty Fresh Chair", new DateTime(2018, 10, 8, 19, 43, 18, 911, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Beatae necessitatibus iusto ut. Asperiores reprehenderit accusamus distinctio voluptatum ullam possimus dolore consectetur commodi. Saepe voluptates molestias ullam nemo. Ut atque quod animi enim magni sunt. Et eaque enim autem ratione doloremque eaque hic inventore. Velit perspiciatis et perspiciatis voluptate eveniet est quae repellendus.", "Strategy", "Unbranded Concrete Pants", new DateTime(2023, 10, 28, 19, 23, 12, 100, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quam explicabo aut dolorem accusantium excepturi nihil adipisci. Veniam rerum voluptatem eaque aspernatur dolore rerum sed eum. Qui et iste error asperiores non placeat. Tenetur dolorem consectetur aperiam molestias ea iusto a ipsum voluptates. Dolor odit maiores et at velit id quae. Rem ipsa sed eligendi ut minima ea reprehenderit tempore laborum.", "Strategy", "Awesome Steel Fish", new DateTime(2023, 2, 6, 14, 50, 6, 723, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Ipsa tempore delectus et natus. Provident itaque cum ea natus. Commodi cum corrupti illo dolore dolore odio.", "Handmade Concrete Soap", new DateTime(2020, 3, 26, 2, 54, 3, 286, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Aut corporis a repellat non sequi. Possimus et eaque assumenda. Minima nemo nisi laborum deserunt.", "Action", "Tasty Plastic Bike", new DateTime(2015, 12, 26, 23, 8, 5, 786, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Ipsa distinctio est odit quisquam expedita optio omnis. Et autem et accusamus. Voluptatibus odit praesentium nobis. Amet sapiente soluta aut praesentium iusto nihil accusamus saepe dolorem. Dolore quam saepe cum vero. Ea occaecati dolore fugit accusantium.", "Incredible Granite Ball", new DateTime(2015, 3, 29, 20, 14, 24, 581, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Vel quod assumenda cupiditate est dolorem iure. Et et dolorem. Numquam distinctio voluptatem alias consequatur odit qui nihil est minima. Voluptatum voluptas nihil. Ut consequatur accusantium provident.", "Adventure", "Tasty Metal Sausages", new DateTime(2024, 2, 6, 19, 49, 25, 949, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 18,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sit in quibusdam. Facere non eos voluptate eveniet ut vel ut reiciendis. Vel et molestiae rerum cum totam esse.", "Action", "Tasty Cotton Soap", new DateTime(2021, 1, 9, 20, 58, 32, 743, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 19,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Non et eius quaerat neque harum sint explicabo. Voluptas architecto et facere voluptate suscipit nihil. Nisi commodi fuga et incidunt explicabo nulla voluptate.", "Adventure", "Ergonomic Granite Gloves", new DateTime(2018, 7, 11, 20, 27, 50, 371, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 20,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Et possimus nobis similique ea dolores. Eaque et quo deserunt ea fugit id. Ipsum inventore accusantium ea. Facilis adipisci minus. Pariatur sequi vel sed eveniet et nam autem.", "RPG", "Rustic Granite Soap", new DateTime(2019, 6, 11, 12, 36, 59, 117, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 21,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Nulla aliquid facilis officiis consequatur quia. Voluptatem molestias minima. Ratione tempore quisquam. Ratione veniam consequatur. Quia laudantium harum sunt nam sequi exercitationem hic nostrum laboriosam. Enim et similique.", "Shooter", "Ergonomic Steel Tuna", new DateTime(2016, 6, 1, 5, 49, 42, 678, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 22,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Qui numquam vel quis voluptatem quidem. In facere nulla quos rerum labore quod voluptas vitae. Incidunt voluptas distinctio praesentium voluptatum. Odit facilis cum rerum.", "Shooter", "Licensed Metal Fish", new DateTime(2015, 8, 16, 10, 28, 11, 434, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 23,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Eveniet et sed ut et nihil molestiae. Dolores magnam officiis magni rerum provident consectetur aut. Voluptatem qui incidunt in cupiditate.", "Action", "Generic Wooden Tuna", new DateTime(2016, 9, 16, 13, 28, 50, 125, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 24,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sint debitis sint iusto ut in. Consequuntur ipsum ea unde. Aut soluta accusantium nisi sit et dolorem. Officia iusto id unde velit quod excepturi. Aspernatur occaecati aut cupiditate. Voluptas itaque repellat vel omnis quis earum animi dolorum.", "Strategy", "Small Wooden Table", new DateTime(2023, 11, 2, 20, 12, 40, 428, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 25,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Libero harum rerum dolores voluptatem ut id expedita et aut. Repellendus aliquid laborum doloribus expedita. Voluptatem doloribus sed accusantium omnis. Eveniet et quaerat tempore sed nobis.", "Strategy", "Fantastic Concrete Pizza", new DateTime(2024, 3, 17, 19, 13, 43, 554, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 26,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Perspiciatis est magni et corrupti culpa. Voluptatem veniam et. Hic omnis deserunt esse fuga sint autem. Voluptate explicabo molestias et quos. Harum molestiae numquam nihil facilis nihil magni cupiditate non. Nobis molestias aut fugiat omnis dolorem.", "RPG", "Handcrafted Granite Hat", new DateTime(2024, 3, 5, 15, 38, 14, 140, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 27,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Voluptas velit praesentium quam ut qui dolorem debitis. Soluta adipisci mollitia id magni. Debitis sint quis sit.", "Puzzle", "Handmade Frozen Towels", new DateTime(2018, 9, 19, 22, 16, 37, 410, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 28,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Occaecati odit enim. Repellat temporibus quidem magni. Quia quod explicabo quia dolores quam. Et quo dolor quis nihil consequatur.", "Handmade Frozen Chair", new DateTime(2016, 12, 14, 19, 0, 7, 580, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 29,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Et dicta illum non quia mollitia. Officiis quas aliquam consequuntur mollitia corrupti sapiente omnis a. Voluptates fuga adipisci numquam animi magnam quia natus. Quia fugit et consequatur voluptate aspernatur commodi possimus et rerum.", "Action", "Sleek Cotton Table", new DateTime(2020, 2, 12, 4, 4, 14, 573, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 30,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Non autem consequatur totam ut nemo. Molestias qui id aut quo porro voluptas et. Quod impedit mollitia ducimus iure voluptatem.", "Action", "Gorgeous Wooden Soap", new DateTime(2022, 1, 10, 13, 20, 50, 625, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 31,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Consequuntur nisi placeat excepturi doloribus eos ut. Porro excepturi velit consequatur officia architecto fuga est minima. Aut quas porro consequatur magnam atque vero delectus et eos. Architecto autem voluptas commodi et. Omnis maxime natus earum.", "Adventure", "Sleek Rubber Mouse", new DateTime(2023, 10, 28, 15, 6, 34, 394, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 32,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Non rerum neque sit qui voluptas. Dolorem maiores qui eum aut. Repudiandae est autem numquam quia est veniam. Est sit distinctio totam.", "Practical Frozen Cheese", new DateTime(2022, 10, 25, 8, 55, 35, 412, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 33,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Expedita consequuntur repellat labore harum dolorem quibusdam maxime. Et consequatur necessitatibus corporis veniam facere et rerum. Molestias sunt quisquam blanditiis est beatae ut aspernatur. Provident laudantium enim molestiae ullam vel illum. Voluptas nihil nisi totam exercitationem occaecati. Sit sunt maxime eum quod facere consequatur quia.", "Adventure", "Refined Metal Mouse", new DateTime(2023, 3, 28, 16, 35, 49, 544, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 34,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Nostrum rerum corporis et molestiae eos et magnam et. Saepe illum natus neque incidunt sunt. Molestiae eveniet a aut aliquam labore. Veniam voluptas nesciunt fuga quas similique incidunt autem ut et. Asperiores quis incidunt aliquam sequi recusandae eos doloribus ut assumenda. Molestiae qui in.", "Shooter", "Refined Metal Sausages", new DateTime(2020, 10, 31, 0, 12, 37, 856, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 35,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sit nihil quam. Voluptas ut beatae et minus et amet ab deleniti beatae. Molestiae similique at sunt et blanditiis soluta omnis amet consequatur. Sed rerum adipisci doloremque omnis suscipit. Voluptatibus debitis corrupti corrupti dolorem rerum expedita.", "Strategy", "Handcrafted Wooden Chicken", new DateTime(2020, 12, 17, 0, 57, 30, 933, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 36,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Amet totam corrupti rerum consectetur eos. Nisi velit vitae. Quaerat nihil libero libero non maxime qui ullam dolores. Delectus dignissimos assumenda fuga dolor. Ratione temporibus amet unde enim inventore ratione aliquid suscipit ut. Ut dolore sit perferendis nesciunt.", "Puzzle", "Handcrafted Frozen Pizza", new DateTime(2018, 4, 27, 21, 5, 16, 292, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 37,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quis voluptatem tempore odit cumque. Neque consequatur esse quia aut rerum et quae sed voluptatem. Atque nihil qui aliquid aperiam quaerat tenetur laborum. Fugiat eveniet deserunt consectetur voluptas minus aliquid deleniti et.", "Adventure", "Generic Cotton Chicken", new DateTime(2020, 8, 2, 22, 38, 17, 568, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 38,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sunt voluptas suscipit pariatur alias est. Deserunt maiores nesciunt esse unde et. Officia nostrum cum et unde a placeat minima.", "Puzzle", "Practical Rubber Computer", new DateTime(2019, 10, 27, 20, 42, 55, 195, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 39,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Non tempore mollitia repudiandae et officia in. Dolore facere magnam enim quidem ducimus. Non et blanditiis quae repellendus. Voluptatum dolor ipsum sit.", "Gorgeous Frozen Fish", new DateTime(2024, 2, 23, 8, 15, 58, 503, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 40,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sit aut dolore est earum assumenda soluta pariatur. Laudantium quo qui et nemo distinctio vel. Reiciendis aliquid et. Magnam alias quaerat perferendis voluptatem architecto. Unde explicabo sed et modi non tempora dignissimos quaerat.", "Adventure", "Handcrafted Wooden Pizza", new DateTime(2015, 11, 16, 17, 5, 14, 387, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 41,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Nesciunt cumque rerum qui. Consequatur animi quas consequuntur aut dolores minima aperiam et. Vel aut harum iusto culpa cupiditate fuga. Accusantium repudiandae aut omnis tenetur odio iste odit non.", "Adventure", "Generic Fresh Computer", new DateTime(2016, 11, 10, 4, 38, 48, 146, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 42,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Facere labore et enim occaecati. Consequatur eos placeat. Rem ratione molestiae vitae dolores est. Possimus debitis laudantium perferendis tenetur vel quis possimus quos. Enim vel sit. Omnis consequuntur ullam possimus ut iste est similique consequatur.", "Rustic Granite Pizza", new DateTime(2017, 3, 9, 16, 19, 36, 715, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 43,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Et ad explicabo amet voluptatem dolores voluptatem omnis recusandae. Officiis dolore repellat pariatur et animi maiores. Corporis quibusdam rem neque consectetur.", "Unbranded Steel Keyboard", new DateTime(2019, 6, 3, 17, 11, 21, 107, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 44,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quia rem voluptatem. Adipisci sunt mollitia amet nemo quia placeat qui non. Occaecati aut delectus. Non possimus reprehenderit voluptatem.", "RPG", "Handcrafted Plastic Pizza", new DateTime(2024, 7, 4, 16, 50, 30, 138, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 45,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Voluptates fuga autem quis. Consequatur dicta incidunt praesentium voluptas repellat nostrum cumque nihil delectus. Ea aspernatur quis et eos libero deserunt voluptatem. Quod dolorum quidem sed est maiores similique aperiam. Quis asperiores ea corrupti maxime omnis odio.", "RPG", "Sleek Metal Car", new DateTime(2017, 11, 18, 6, 3, 53, 97, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 46,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "In mollitia natus maiores eligendi. Sit officia ut numquam adipisci ut sit. Consequatur eius illo vel vero ullam sapiente sed ut quidem. Ratione sint voluptatem sit atque non adipisci.", "Puzzle", "Refined Fresh Hat", new DateTime(2016, 9, 21, 21, 59, 24, 798, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 47,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Nulla similique fugit nihil laboriosam deserunt. Et maxime est numquam. Sequi ullam ea ipsa et dolorum voluptatem minus repellendus eum. Magni nemo aliquid voluptas aut officiis eaque blanditiis aspernatur id. Et ut placeat quas dignissimos aut omnis delectus aut est. Saepe aut rem animi suscipit voluptas voluptate est qui debitis.", "RPG", "Ergonomic Fresh Ball", new DateTime(2023, 12, 9, 19, 29, 30, 131, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 48,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Quo nihil laudantium culpa ex quidem. Iure dolorum ut et qui harum illum. Dolor voluptas voluptas. Eveniet mollitia consequatur iusto cum possimus itaque. Eaque quod vel molestias voluptas necessitatibus occaecati eum. Velit ut sint provident et sit nulla.", "Tasty Plastic Shirt", new DateTime(2023, 7, 21, 14, 8, 51, 254, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 49,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Explicabo quam recusandae eos at qui aliquam. Non aliquid qui fugit enim illum. Ducimus tenetur voluptatibus et sit quis provident.", "Practical Plastic Soap", new DateTime(2020, 3, 23, 10, 19, 14, 82, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 50,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Dolorum rem adipisci sint. Officiis sunt facere quasi aliquid accusamus. Error eum omnis est neque rerum. Dolores quis recusandae dolorem consequatur.", "Adventure", "Awesome Soft Gloves", new DateTime(2023, 9, 18, 22, 25, 10, 225, DateTimeKind.Local).AddTicks(3799) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29fc2edf-dc5d-4e0f-aaf3-ebb8b5e72f96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a4603d7-1946-4c71-9994-46ba70f1d64a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad9cb22-f79f-4e95-982b-29279f0296d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e0905d9-106b-44a4-9ef9-526a32d3cfdf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afd3af4b-7e26-4e7f-865c-56ce4e5c52d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c57e6e-9a96-41f8-b45b-4dfaba5d3191");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c47ac2e4-2218-498f-8b7f-5f1dd9d4755c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cabe5f4b-2b82-4d96-8455-7c3f7f656293");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce95e522-511b-4353-b697-3cf0f17392c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07f192f-d7d4-4e12-afa5-0e6f4efcb640");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b9b7e7a-8140-49d8-aae0-31b822c0df03", "AQAAAAIAAYagAAAAEEZlVMC9D6DjIa0wK80kB/myJnNhvq+FaFtPqbqTihiCC4NGBrqM6cT7KVNSr5WMLw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1436b133-2587-4052-892e-627596af9598", 0, "a723df39-d8a6-4e73-8ce6-80d30f1aea59", "Rocky_Daugherty@hotmail.com", false, false, null, null, null, "buioaiuu", null, false, "c5a8b12a-3933-4f96-9022-22cb5c277b77", false, "Emanuel.Yundt" },
                    { "2a7a3e19-d306-451e-8184-b50533fa5546", 0, "e63bff75-fac2-4006-8a75-ee2685ffb457", "Evie.Renner85@hotmail.com", false, false, null, null, null, "miueaaeu", null, false, "295cac92-7020-406f-a955-d74b300c52ef", false, "Norris_Effertz91" },
                    { "3f4cf03e-1c7d-45a7-9532-d3d7ac48e0c2", 0, "7c965762-b84b-4849-8e43-94db853d2fc1", "Remington_Altenwerth@gmail.com", false, false, null, null, null, "hoauueua", null, false, "a3432e2c-40df-4383-a26e-67e59c94d584", false, "Adelle.Treutel62" },
                    { "55ab808a-0648-484e-88c9-f0fcc1047b72", 0, "2212b134-74a7-4d5f-91a8-c5696b3309b1", "Winston13@hotmail.com", false, false, null, null, null, "diaiaaue", null, false, "739ae6f8-f1af-4059-84df-7d98c670be21", false, "Antwan.Hilpert36" },
                    { "7f486c40-675b-4d8d-8293-5f3c10ee3531", 0, "6624e317-19d7-4a86-a973-c51222bfc114", "Monique.Volkman7@yahoo.com", false, false, null, null, null, "cuuueeau", null, false, "76f16008-67e6-4496-8e75-06d5ddb718c9", false, "Johnny.Lockman" },
                    { "aa979614-f233-4ef9-b15a-e05a5435667b", 0, "dc3dfef8-e342-4266-9cae-95ff9728e4dc", "Ricardo.Towne@hotmail.com", false, false, null, null, null, "kaoouuee", null, false, "4aaa6b67-a2a7-49c0-a70b-85ada990fa25", false, "Lawrence_Gleichner" },
                    { "cf9141f5-85cb-4425-8473-1ede382bbe94", 0, "0443a87b-cef9-4c42-8205-5f91ad699fb5", "Enola_Schultz11@yahoo.com", false, false, null, null, null, "qiiuiuuo", null, false, "f4376b50-78cd-4a57-aaaa-f18922a5729e", false, "Ernie.Hermiston" },
                    { "d34edeaf-7708-4c1f-aeab-a2bf6bffed8c", 0, "27d0d24a-ea6f-49a0-923f-15019164ede4", "Mckenzie86@gmail.com", false, false, null, null, null, "wueiiooo", null, false, "46e1c0ed-c910-4a04-be64-9133b46333d7", false, "Julien44" },
                    { "e279f093-acd5-4649-9cfb-0fca006e7fa6", 0, "3602e177-005e-47c4-bbc3-afefe71474db", "Vinnie.Harris@yahoo.com", false, false, null, null, null, "coooeioi", null, false, "3c1427cc-f8a2-410a-8628-c8039c32ad1c", false, "Rosalinda.Kling" },
                    { "e572547d-424d-43eb-9773-feb81c8adba2", 0, "b7e82454-4957-4bf9-b328-f2d052fc8412", "Vivianne89@gmail.com", false, false, null, null, null, "beoeooeu", null, false, "3e991bb3-ee5b-4b4d-9451-05e89fd16b2c", false, "Maryse_Waters98" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Dolorem expedita fugit illo ut voluptates autem. Voluptas a quaerat voluptatem non dolorem inventore qui. Modi maiores similique vitae. Beatae corporis molestiae dolor asperiores enim sint fugit voluptatibus.", "Puzzle", "Practical Wooden Chicken", new DateTime(2019, 3, 10, 1, 18, 14, 443, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Harum ea sint dolore illo adipisci et. Et quibusdam quo placeat ad qui est cumque quibusdam rem. Quia ipsam vel eveniet. Dolores aut tempora molestiae. Officiis voluptatem voluptatem molestiae voluptatem fugiat velit. Rerum quia aut maxime ut sit expedita.", "Puzzle", "Awesome Concrete Keyboard", new DateTime(2023, 11, 15, 7, 34, 14, 802, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Similique et perferendis tempore id in sunt saepe quam. Excepturi et quia. Maiores voluptatum dolor voluptas sed pariatur eveniet nihil saepe ex. Autem ex fugiat nulla distinctio asperiores nihil natus. Et et impedit eos beatae rerum nihil.", "Puzzle", "Gorgeous Frozen Computer", new DateTime(2022, 11, 8, 2, 24, 22, 945, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Repellat est eum non repellendus laborum. Iure enim fugit quam debitis reiciendis harum sed. Quasi quis officiis nesciunt. Laboriosam quo beatae dolores cupiditate sint et quis aut.", "Adventure", "Generic Metal Chair", new DateTime(2015, 7, 30, 11, 37, 41, 264, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Sed quaerat sint velit sunt iusto. Omnis voluptatem et quisquam debitis omnis dolor omnis. Maiores laudantium qui commodi aliquid ut sed iste. Quo et et. Est nostrum omnis ea doloribus atque quo dolor laborum. Ut non quidem quidem a ad.", "Strategy", "Generic Wooden Chair", new DateTime(2018, 8, 3, 12, 20, 24, 7, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Ratione ea nihil quia similique qui nostrum. Saepe nisi perferendis blanditiis. Quod ut eligendi non. Magnam non temporibus consequuntur nemo corporis quo laudantium accusamus aut. Placeat ut animi maxime maxime repellendus.", "Practical Plastic Salad", new DateTime(2020, 5, 20, 17, 37, 16, 206, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Ut vitae temporibus. Officiis doloremque est tempore. Distinctio molestias blanditiis eos nisi voluptatum odit aut non.", "Strategy", "Ergonomic Fresh Car", new DateTime(2020, 9, 18, 23, 23, 18, 830, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Ipsa placeat esse. Exercitationem aliquam quam error voluptas ut. Occaecati accusantium fuga iste libero tenetur repudiandae eveniet. Et deserunt nostrum iste a occaecati id delectus dolores nobis.", "Shooter", "Rustic Frozen Fish", new DateTime(2018, 8, 3, 1, 21, 20, 268, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Dolor odit in officia ea sint quo facilis. Qui quod nulla quia. Cupiditate voluptas accusantium nostrum aliquid maxime nesciunt veritatis facilis. Atque eos assumenda dolores sunt tempora alias quia officiis et. Dolorem temporibus rerum. Dolore et velit aut eius voluptatum id ea praesentium.", "Small Metal Car", new DateTime(2021, 3, 13, 6, 53, 13, 285, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Similique soluta voluptatem sit a. Aut iste molestiae rerum et cumque autem et occaecati. Occaecati fugit velit explicabo. Velit dolores sapiente officiis aliquam quidem praesentium voluptatum quibusdam et. Est doloribus voluptas vitae omnis adipisci error quis aliquid ut.", "Strategy", "Licensed Concrete Shirt", new DateTime(2022, 11, 12, 8, 6, 37, 41, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Mollitia quaerat pariatur. Corporis asperiores ut accusantium quia. Eius deleniti omnis quibusdam voluptas nobis eos alias. Aut qui totam sed. Atque laborum est. Libero rerum nemo praesentium et quibusdam exercitationem.", "RPG", "Awesome Granite Hat", new DateTime(2023, 8, 5, 12, 57, 31, 858, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Repellendus odit consequuntur aut dolorem qui cumque error. Aspernatur et ad sit. Soluta nostrum sed. Nobis in repellendus alias quia temporibus ut. Voluptatem harum non est facere vitae.", "RPG", "Licensed Rubber Car", new DateTime(2019, 11, 22, 16, 28, 57, 936, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Dignissimos corporis minus officiis. Quibusdam sit debitis deserunt nisi et quo nulla. Blanditiis nihil dolor repudiandae eveniet assumenda error laboriosam. Ipsa nemo est nihil et sint sunt.", "RPG", "Tasty Metal Fish", new DateTime(2020, 2, 8, 6, 23, 31, 850, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Labore explicabo numquam consequatur sapiente. Qui provident mollitia modi quia maxime quasi. Voluptatum fugit aut et error corporis labore optio. Veritatis dolores nobis et voluptatem.", "Incredible Concrete Salad", new DateTime(2022, 2, 22, 12, 45, 10, 93, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Omnis odio libero in corrupti quo voluptas omnis. Sunt possimus ducimus. Explicabo nobis occaecati non aperiam veritatis non dolor vitae. Necessitatibus aut illum aliquid. Itaque qui quaerat libero laboriosam corrupti sequi eveniet.", "RPG", "Incredible Plastic Fish", new DateTime(2019, 7, 3, 21, 24, 49, 905, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Facilis vitae inventore quia tempore beatae. Ut soluta earum consequatur dolor et quia tempora et. Dolorem placeat iste. Mollitia quo enim. Minima in laudantium beatae et commodi nulla ex fuga et. Aspernatur rerum dolore dolorem enim eveniet doloremque.", "Sleek Cotton Mouse", new DateTime(2021, 7, 25, 16, 35, 44, 82, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Dolorem non illo nesciunt saepe. Architecto esse est illum fuga. Neque eum fugit debitis et quisquam ea enim vel. Assumenda sunt recusandae praesentium placeat quam rerum sed. Excepturi dolores numquam exercitationem illum non.", "RPG", "Gorgeous Concrete Ball", new DateTime(2020, 5, 15, 21, 33, 7, 985, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 18,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Error totam iure veniam fuga nostrum alias quia. Hic expedita eius. Est qui voluptas nulla non quo. Non commodi mollitia eaque provident quis.", "Adventure", "Licensed Frozen Hat", new DateTime(2023, 2, 8, 12, 39, 47, 840, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 19,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Fuga dolorem facere aut error est est dolor ut. Ducimus consequatur sint in facere fuga deserunt explicabo quidem. Exercitationem quibusdam molestias doloribus ipsam dolorem veritatis quo laborum. Laborum rerum voluptates ut. Amet sit sit et dolore quis repudiandae laudantium iure. Iusto velit voluptatem repellendus reprehenderit nihil.", "Puzzle", "Generic Metal Shoes", new DateTime(2023, 3, 17, 14, 24, 4, 392, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 20,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Vel illo ea et perspiciatis fugit. Voluptatum veritatis ad est voluptatem distinctio adipisci modi. Fuga rerum pariatur omnis eligendi accusamus ducimus et. Corporis dolor pariatur dolore voluptates. Voluptas et natus.", "Puzzle", "Practical Cotton Chips", new DateTime(2016, 8, 25, 5, 50, 2, 873, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 21,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Hic autem architecto. Enim modi voluptatem qui aspernatur. Voluptates minus esse explicabo ratione perspiciatis qui accusamus. Quis autem sed.", "RPG", "Handmade Granite Chips", new DateTime(2018, 8, 9, 8, 43, 9, 294, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 22,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quis esse asperiores ut aut fugiat laudantium mollitia. Possimus id assumenda voluptatem nemo voluptatem. Saepe ab dolorem et iste aliquid illo. At magnam quidem consequatur ipsum.", "Puzzle", "Generic Metal Gloves", new DateTime(2017, 9, 8, 1, 14, 35, 702, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 23,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Et voluptatem ullam. Maxime asperiores eos corrupti dolor consectetur aperiam dolorem neque. Eos nemo non quos qui dolor voluptatibus. Alias qui provident ipsa molestiae id ipsum illo odit. Dolorem saepe in temporibus nemo sit recusandae est alias. Ducimus deserunt inventore dignissimos consectetur.", "Strategy", "Practical Steel Cheese", new DateTime(2020, 3, 4, 18, 43, 19, 599, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 24,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quaerat perferendis hic atque. Tenetur nihil ad velit alias id facere tempora. Nihil iste voluptas vero minus fugit. Unde qui deserunt quis eligendi quia. Est rerum voluptatem blanditiis incidunt qui.", "Puzzle", "Rustic Rubber Chips", new DateTime(2022, 11, 14, 1, 18, 43, 307, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 25,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quis sed odit veniam dicta quia sit sed veritatis. At ipsa quia. Non laudantium culpa voluptatibus maiores non corporis et dolorem.", "Puzzle", "Handmade Frozen Bike", new DateTime(2016, 1, 7, 12, 47, 4, 149, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 26,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Vel itaque rerum. Libero optio aspernatur voluptatem. Voluptate dicta non quia sapiente id. Iure nostrum nihil sunt sed. Commodi est accusamus aut. Voluptates sequi magnam sit.", "Action", "Handcrafted Fresh Cheese", new DateTime(2018, 6, 30, 18, 38, 17, 323, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 27,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Ad asperiores quis explicabo doloremque. Placeat rerum voluptas cumque. Nihil ut aliquid quis cum. Iusto nam inventore dolorem dignissimos qui non odio. Velit vitae exercitationem molestiae sit repellendus sed deserunt aspernatur. Eveniet sit aut laborum enim rem veritatis deserunt.", "RPG", "Incredible Granite Pants", new DateTime(2018, 11, 15, 7, 7, 32, 798, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 28,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Et ut fugiat fugiat natus maxime natus architecto voluptate in. Veritatis nostrum modi aut facere enim consectetur nobis. Ducimus eum quia autem in voluptatem velit fuga iusto quibusdam. Quaerat vel officiis vitae vitae. Voluptatibus tempora et praesentium et. Vel eius recusandae.", "Generic Rubber Car", new DateTime(2021, 10, 26, 2, 27, 20, 919, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 29,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Exercitationem quae impedit minus non ducimus ducimus a commodi expedita. Sapiente nesciunt ullam. Porro assumenda vel distinctio. Tempora magni a veritatis mollitia beatae minima architecto.", "Puzzle", "Refined Cotton Mouse", new DateTime(2016, 10, 11, 9, 1, 3, 663, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 30,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Neque commodi illo sint sed. Iste inventore quos. Cumque necessitatibus ut quisquam. Et quia est ut mollitia. Nulla eos cum rem.", "Shooter", "Handcrafted Metal Bacon", new DateTime(2016, 2, 12, 21, 55, 40, 228, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 31,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Impedit unde fugiat porro quo. Harum sequi velit. Delectus odit aut eum vel. Aut eligendi ut consectetur eum dolorem error sed fugiat odit. Maxime iusto nihil voluptatibus.", "RPG", "Gorgeous Frozen Tuna", new DateTime(2021, 6, 4, 12, 31, 45, 20, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 32,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Rerum ipsa rerum est. Accusantium amet voluptatem est a. Distinctio voluptatem vel laborum necessitatibus. Perspiciatis architecto unde cumque et voluptas iusto reprehenderit.", "Incredible Steel Chips", new DateTime(2018, 6, 28, 18, 51, 23, 318, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 33,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Pariatur sequi rerum voluptatem aut sed blanditiis dolorum voluptatem voluptate. Aut consequatur animi aut est provident asperiores unde. Iste in distinctio quidem. Qui magni porro nobis optio qui voluptatum.", "Shooter", "Generic Steel Cheese", new DateTime(2022, 3, 2, 11, 30, 28, 68, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 34,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Eum sunt similique voluptatem. Rerum qui neque dolor quod minus. Ea provident velit quos ipsa qui commodi. Cum nulla recusandae at eligendi. Culpa debitis eum eaque iste.", "Action", "Generic Rubber Cheese", new DateTime(2016, 1, 12, 14, 57, 50, 192, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 35,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Nisi voluptates est. Dolorem id aliquam sed asperiores dolores rerum in. Eligendi quia iure itaque necessitatibus voluptatem et veritatis. Harum qui nemo qui harum delectus magnam harum velit laudantium. Eum tenetur odio saepe accusantium ut amet officiis et vel.", "Shooter", "Awesome Cotton Gloves", new DateTime(2017, 7, 24, 23, 57, 40, 282, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 36,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Id rerum eligendi sit deleniti aut. Ad ea voluptas omnis a exercitationem totam. Vitae temporibus laboriosam et et velit accusamus.", "RPG", "Refined Steel Pizza", new DateTime(2024, 7, 30, 13, 27, 44, 770, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 37,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Qui soluta temporibus voluptate error saepe voluptates sit. Maxime ipsum autem vel dicta dignissimos eaque atque. Dolor et ea alias iure sunt impedit assumenda. Minima quas nihil sit. Qui unde consequatur cupiditate delectus ipsam a esse animi sit.", "Strategy", "Small Soft Chicken", new DateTime(2022, 9, 28, 3, 16, 8, 770, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 38,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Architecto quidem qui non. Voluptatum aut vitae repellendus soluta temporibus eligendi ex. Tempore maxime ut odit.", "Strategy", "Incredible Wooden Shoes", new DateTime(2020, 4, 25, 8, 12, 2, 625, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 39,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Laborum quia similique nisi. Accusantium impedit dolores necessitatibus illum in voluptatem sunt voluptatum. Sit aut nulla repellendus beatae sit et.", "Handmade Steel Chair", new DateTime(2015, 5, 8, 20, 45, 56, 971, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 40,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Saepe iste soluta. Itaque incidunt ipsum maiores nesciunt quae ab quia dolore corrupti. Quia quisquam vitae. Reprehenderit error cum perferendis commodi quo sed eos. Sit aperiam in assumenda itaque. Et ut itaque eum voluptate qui temporibus atque.", "Strategy", "Tasty Steel Pants", new DateTime(2020, 3, 28, 18, 50, 34, 274, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 41,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Perspiciatis eius qui. Facilis id adipisci nihil voluptas magni nobis. Voluptatem enim in reprehenderit nesciunt accusamus adipisci facere aut. Repellendus perspiciatis et molestiae sit impedit excepturi velit. Id aperiam in dicta rerum quaerat nemo.", "Action", "Unbranded Concrete Computer", new DateTime(2016, 1, 31, 6, 19, 5, 847, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 42,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Eveniet harum totam vel impedit magnam ullam. Nihil fuga alias repudiandae saepe eius officiis quos dignissimos quis. Molestiae commodi voluptatum est. Sunt eligendi voluptatum. Pariatur placeat dolore rerum dolorem hic.", "Intelligent Fresh Ball", new DateTime(2021, 7, 18, 2, 49, 59, 231, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 43,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Expedita a sit sint. Explicabo minima molestias blanditiis deserunt eaque a rerum necessitatibus sit. Omnis aperiam tenetur saepe dignissimos commodi dolores magnam quidem. Et maxime quod modi eum dolore assumenda officiis numquam modi.", "Handmade Concrete Shirt", new DateTime(2018, 9, 24, 11, 42, 55, 322, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 44,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Aliquid quia ut ea quia totam. Voluptatem ullam nesciunt tenetur reprehenderit repudiandae. Explicabo placeat rem suscipit. Ut adipisci molestias esse quo eum. Reiciendis sint dolorum in praesentium. Eos ut ipsum accusantium quia et fuga nobis et.", "Shooter", "Rustic Soft Tuna", new DateTime(2023, 6, 17, 14, 23, 14, 425, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 45,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Qui quo accusantium et beatae maxime doloremque porro. Inventore quia accusantium doloremque enim aut. Harum animi et molestias blanditiis tempora eos. Eos repellat sit aut eaque modi cupiditate voluptatem quia.", "Strategy", "Small Fresh Gloves", new DateTime(2023, 3, 22, 9, 38, 3, 600, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 46,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Eos dolor aliquid aliquid a aut. Et qui error. A nulla et ipsam at.", "Shooter", "Gorgeous Cotton Car", new DateTime(2016, 7, 1, 4, 24, 43, 994, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 47,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Quisquam totam aperiam cumque magni dolorem. Quo ullam et id enim ab culpa quis. Voluptatum rerum iusto similique magnam quod. Autem in ducimus delectus quo pariatur quia quasi animi rem.", "Strategy", "Generic Fresh Shoes", new DateTime(2022, 6, 26, 19, 33, 3, 930, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 48,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Eos quasi molestiae amet. Laborum quisquam molestias quo. Cum labore libero.", "Intelligent Concrete Fish", new DateTime(2020, 1, 6, 11, 35, 42, 417, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 49,
                columns: new[] { "Descripcion", "Name", "ReleaseDate" },
                values: new object[] { "Voluptate dolore inventore optio reprehenderit. Voluptatem expedita consectetur odio ratione sequi. Aut autem earum dignissimos. Voluptatibus dolores dolore omnis pariatur voluptatem officiis.", "Incredible Fresh Sausages", new DateTime(2014, 12, 13, 12, 36, 49, 571, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 50,
                columns: new[] { "Descripcion", "Genero", "Name", "ReleaseDate" },
                values: new object[] { "Molestias vero qui perspiciatis. Et nam placeat aliquam perspiciatis ipsa molestias. Pariatur distinctio quas iure excepturi saepe. Ipsam voluptates rem mollitia et possimus laboriosam. Est facere corporis veritatis. Et voluptatem dolor aliquam repellat officiis.", "Shooter", "Handcrafted Cotton Tuna", new DateTime(2021, 11, 24, 3, 29, 52, 243, DateTimeKind.Local).AddTicks(2371) });
        }
    }
}
