using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace infiniteworlds_fronted.Migrations
{
    /// <inheritdoc />
    public partial class AddTablePurchaseGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-admin-id", "user-admin-id" });

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

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-admin-id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-admin-id");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Games",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "PurchasedGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedGames_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasedGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedGames_GameId",
                table: "PurchasedGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedGames_UserId",
                table: "PurchasedGames",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchasedGames");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Games");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "role-admin-id", null, "Admin", "ADMIN" });

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
                    { "f07f192f-d7d4-4e12-afa5-0e6f4efcb640", 0, "cb6281e5-823a-403f-856f-0c4b726b887f", "Reggie.Hahn@gmail.com", false, false, null, null, null, "veeaoeia", null, false, "77a31518-9f91-4023-a8b0-fedee53f5c28", false, "Shanie30" },
                    { "user-admin-id", 0, "86eafb0a-cb62-492e-9db2-c90d3627001a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEO9CV/VdEGnBWamqVmQt7j9ZO84lGXrQ0C+JzopvqiBWhTmjaWG5ARRAd1tgkShwHQ==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Descripcion", "Genero", "ImageFilePath", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Et inventore aliquam quos eum voluptas est aut. Quas repellat quo. Necessitatibus cumque qui libero amet est voluptas maxime. Est quod consequatur molestiae delectus quia omnis impedit aut. Quia necessitatibus debitis quaerat. Rem dignissimos voluptatem error eveniet eum neque ratione quos laboriosam.", "RPG", "https://picsum.photos/200/300", "Practical Cotton Cheese", new DateTime(2016, 10, 16, 10, 13, 14, 542, DateTimeKind.Local).AddTicks(5873) },
                    { 2, "Sit aut voluptate consectetur aut sit dolorum esse nam maiores. Suscipit quos nulla nesciunt fuga accusantium rerum animi. Accusamus non aut praesentium et aut sint animi. Nemo fugiat saepe est natus corporis.", "RPG", "https://picsum.photos/200/300", "Intelligent Frozen Table", new DateTime(2021, 10, 6, 13, 29, 0, 242, DateTimeKind.Local).AddTicks(2247) },
                    { 3, "Repellat cumque aliquid rerum. Et dolores velit aut laboriosam aperiam. Sint reiciendis voluptas nulla harum sed eveniet voluptatum nobis autem.", "Action", "https://picsum.photos/200/300", "Small Cotton Bike", new DateTime(2020, 5, 26, 4, 51, 38, 641, DateTimeKind.Local).AddTicks(449) },
                    { 4, "Explicabo repudiandae voluptates. Enim corrupti aut. Ex et modi et.", "Shooter", "https://picsum.photos/200/300", "Unbranded Fresh Ball", new DateTime(2023, 10, 17, 9, 34, 5, 280, DateTimeKind.Local).AddTicks(2403) },
                    { 5, "Et sint dolore dolorem iure veritatis. Adipisci deleniti et quam consectetur inventore dolores maxime dolorem. Repellat cumque saepe. Commodi debitis id eaque.", "Shooter", "https://picsum.photos/200/300", "Generic Wooden Hat", new DateTime(2021, 6, 15, 3, 30, 10, 605, DateTimeKind.Local).AddTicks(1889) },
                    { 6, "Animi molestiae sint beatae cupiditate adipisci aspernatur consectetur ullam. Quia accusamus dolores. Cum necessitatibus dolores accusamus ducimus aut. Ut sunt est ad aut nulla pariatur tenetur. Pariatur culpa nemo eveniet a incidunt asperiores.", "RPG", "https://picsum.photos/200/300", "Gorgeous Metal Car", new DateTime(2022, 7, 4, 11, 19, 13, 713, DateTimeKind.Local).AddTicks(7918) },
                    { 7, "Facere voluptas error unde et nesciunt molestias provident nihil magnam. Quia rerum rerum necessitatibus facilis quas. Hic aperiam corrupti.", "Shooter", "https://picsum.photos/200/300", "Refined Rubber Mouse", new DateTime(2015, 11, 5, 16, 49, 42, 534, DateTimeKind.Local).AddTicks(5349) },
                    { 8, "Necessitatibus vero soluta vel excepturi. Molestiae nihil voluptas ut quia aut qui et. Enim suscipit magni rerum minus nemo sed deleniti quo.", "Strategy", "https://picsum.photos/200/300", "Rustic Steel Shoes", new DateTime(2022, 2, 20, 23, 20, 22, 342, DateTimeKind.Local).AddTicks(5628) },
                    { 9, "Perspiciatis harum quia quaerat facilis. Reiciendis vitae dicta. Earum cumque cumque autem ab est. Tempore ut distinctio dignissimos quisquam. Ducimus omnis non. Aperiam reiciendis doloremque repellat perspiciatis.", "RPG", "https://picsum.photos/200/300", "Gorgeous Steel Towels", new DateTime(2022, 1, 4, 18, 40, 18, 263, DateTimeKind.Local).AddTicks(1778) },
                    { 10, "Aut odit at enim. Delectus repudiandae qui minus mollitia et aut. Veniam enim assumenda saepe. Blanditiis eius illo eveniet assumenda non provident neque explicabo voluptas.", "Puzzle", "https://picsum.photos/200/300", "Practical Frozen Fish", new DateTime(2016, 10, 30, 13, 32, 39, 329, DateTimeKind.Local).AddTicks(6415) },
                    { 11, "Accusamus eligendi qui est quisquam sed facilis est. Sed earum sed consequatur consectetur rem. Et accusantium magni fugit enim illum repudiandae vel.", "Strategy", "https://picsum.photos/200/300", "Tasty Fresh Chair", new DateTime(2018, 10, 8, 19, 43, 18, 911, DateTimeKind.Local).AddTicks(1677) },
                    { 12, "Beatae necessitatibus iusto ut. Asperiores reprehenderit accusamus distinctio voluptatum ullam possimus dolore consectetur commodi. Saepe voluptates molestias ullam nemo. Ut atque quod animi enim magni sunt. Et eaque enim autem ratione doloremque eaque hic inventore. Velit perspiciatis et perspiciatis voluptate eveniet est quae repellendus.", "Strategy", "https://picsum.photos/200/300", "Unbranded Concrete Pants", new DateTime(2023, 10, 28, 19, 23, 12, 100, DateTimeKind.Local).AddTicks(4067) },
                    { 13, "Quam explicabo aut dolorem accusantium excepturi nihil adipisci. Veniam rerum voluptatem eaque aspernatur dolore rerum sed eum. Qui et iste error asperiores non placeat. Tenetur dolorem consectetur aperiam molestias ea iusto a ipsum voluptates. Dolor odit maiores et at velit id quae. Rem ipsa sed eligendi ut minima ea reprehenderit tempore laborum.", "Strategy", "https://picsum.photos/200/300", "Awesome Steel Fish", new DateTime(2023, 2, 6, 14, 50, 6, 723, DateTimeKind.Local).AddTicks(5511) },
                    { 14, "Ipsa tempore delectus et natus. Provident itaque cum ea natus. Commodi cum corrupti illo dolore dolore odio.", "Puzzle", "https://picsum.photos/200/300", "Handmade Concrete Soap", new DateTime(2020, 3, 26, 2, 54, 3, 286, DateTimeKind.Local).AddTicks(5316) },
                    { 15, "Aut corporis a repellat non sequi. Possimus et eaque assumenda. Minima nemo nisi laborum deserunt.", "Action", "https://picsum.photos/200/300", "Tasty Plastic Bike", new DateTime(2015, 12, 26, 23, 8, 5, 786, DateTimeKind.Local).AddTicks(6896) },
                    { 16, "Ipsa distinctio est odit quisquam expedita optio omnis. Et autem et accusamus. Voluptatibus odit praesentium nobis. Amet sapiente soluta aut praesentium iusto nihil accusamus saepe dolorem. Dolore quam saepe cum vero. Ea occaecati dolore fugit accusantium.", "Action", "https://picsum.photos/200/300", "Incredible Granite Ball", new DateTime(2015, 3, 29, 20, 14, 24, 581, DateTimeKind.Local).AddTicks(2125) },
                    { 17, "Vel quod assumenda cupiditate est dolorem iure. Et et dolorem. Numquam distinctio voluptatem alias consequatur odit qui nihil est minima. Voluptatum voluptas nihil. Ut consequatur accusantium provident.", "Adventure", "https://picsum.photos/200/300", "Tasty Metal Sausages", new DateTime(2024, 2, 6, 19, 49, 25, 949, DateTimeKind.Local).AddTicks(6745) },
                    { 18, "Sit in quibusdam. Facere non eos voluptate eveniet ut vel ut reiciendis. Vel et molestiae rerum cum totam esse.", "Action", "https://picsum.photos/200/300", "Tasty Cotton Soap", new DateTime(2021, 1, 9, 20, 58, 32, 743, DateTimeKind.Local).AddTicks(8124) },
                    { 19, "Non et eius quaerat neque harum sint explicabo. Voluptas architecto et facere voluptate suscipit nihil. Nisi commodi fuga et incidunt explicabo nulla voluptate.", "Adventure", "https://picsum.photos/200/300", "Ergonomic Granite Gloves", new DateTime(2018, 7, 11, 20, 27, 50, 371, DateTimeKind.Local).AddTicks(3294) },
                    { 20, "Et possimus nobis similique ea dolores. Eaque et quo deserunt ea fugit id. Ipsum inventore accusantium ea. Facilis adipisci minus. Pariatur sequi vel sed eveniet et nam autem.", "RPG", "https://picsum.photos/200/300", "Rustic Granite Soap", new DateTime(2019, 6, 11, 12, 36, 59, 117, DateTimeKind.Local).AddTicks(6720) },
                    { 21, "Nulla aliquid facilis officiis consequatur quia. Voluptatem molestias minima. Ratione tempore quisquam. Ratione veniam consequatur. Quia laudantium harum sunt nam sequi exercitationem hic nostrum laboriosam. Enim et similique.", "Shooter", "https://picsum.photos/200/300", "Ergonomic Steel Tuna", new DateTime(2016, 6, 1, 5, 49, 42, 678, DateTimeKind.Local).AddTicks(9157) },
                    { 22, "Qui numquam vel quis voluptatem quidem. In facere nulla quos rerum labore quod voluptas vitae. Incidunt voluptas distinctio praesentium voluptatum. Odit facilis cum rerum.", "Shooter", "https://picsum.photos/200/300", "Licensed Metal Fish", new DateTime(2015, 8, 16, 10, 28, 11, 434, DateTimeKind.Local).AddTicks(2563) },
                    { 23, "Eveniet et sed ut et nihil molestiae. Dolores magnam officiis magni rerum provident consectetur aut. Voluptatem qui incidunt in cupiditate.", "Action", "https://picsum.photos/200/300", "Generic Wooden Tuna", new DateTime(2016, 9, 16, 13, 28, 50, 125, DateTimeKind.Local).AddTicks(65) },
                    { 24, "Sint debitis sint iusto ut in. Consequuntur ipsum ea unde. Aut soluta accusantium nisi sit et dolorem. Officia iusto id unde velit quod excepturi. Aspernatur occaecati aut cupiditate. Voluptas itaque repellat vel omnis quis earum animi dolorum.", "Strategy", "https://picsum.photos/200/300", "Small Wooden Table", new DateTime(2023, 11, 2, 20, 12, 40, 428, DateTimeKind.Local).AddTicks(6727) },
                    { 25, "Libero harum rerum dolores voluptatem ut id expedita et aut. Repellendus aliquid laborum doloribus expedita. Voluptatem doloribus sed accusantium omnis. Eveniet et quaerat tempore sed nobis.", "Strategy", "https://picsum.photos/200/300", "Fantastic Concrete Pizza", new DateTime(2024, 3, 17, 19, 13, 43, 554, DateTimeKind.Local).AddTicks(264) },
                    { 26, "Perspiciatis est magni et corrupti culpa. Voluptatem veniam et. Hic omnis deserunt esse fuga sint autem. Voluptate explicabo molestias et quos. Harum molestiae numquam nihil facilis nihil magni cupiditate non. Nobis molestias aut fugiat omnis dolorem.", "RPG", "https://picsum.photos/200/300", "Handcrafted Granite Hat", new DateTime(2024, 3, 5, 15, 38, 14, 140, DateTimeKind.Local).AddTicks(684) },
                    { 27, "Voluptas velit praesentium quam ut qui dolorem debitis. Soluta adipisci mollitia id magni. Debitis sint quis sit.", "Puzzle", "https://picsum.photos/200/300", "Handmade Frozen Towels", new DateTime(2018, 9, 19, 22, 16, 37, 410, DateTimeKind.Local).AddTicks(6670) },
                    { 28, "Occaecati odit enim. Repellat temporibus quidem magni. Quia quod explicabo quia dolores quam. Et quo dolor quis nihil consequatur.", "RPG", "https://picsum.photos/200/300", "Handmade Frozen Chair", new DateTime(2016, 12, 14, 19, 0, 7, 580, DateTimeKind.Local).AddTicks(145) },
                    { 29, "Et dicta illum non quia mollitia. Officiis quas aliquam consequuntur mollitia corrupti sapiente omnis a. Voluptates fuga adipisci numquam animi magnam quia natus. Quia fugit et consequatur voluptate aspernatur commodi possimus et rerum.", "Action", "https://picsum.photos/200/300", "Sleek Cotton Table", new DateTime(2020, 2, 12, 4, 4, 14, 573, DateTimeKind.Local).AddTicks(6066) },
                    { 30, "Non autem consequatur totam ut nemo. Molestias qui id aut quo porro voluptas et. Quod impedit mollitia ducimus iure voluptatem.", "Action", "https://picsum.photos/200/300", "Gorgeous Wooden Soap", new DateTime(2022, 1, 10, 13, 20, 50, 625, DateTimeKind.Local).AddTicks(539) },
                    { 31, "Consequuntur nisi placeat excepturi doloribus eos ut. Porro excepturi velit consequatur officia architecto fuga est minima. Aut quas porro consequatur magnam atque vero delectus et eos. Architecto autem voluptas commodi et. Omnis maxime natus earum.", "Adventure", "https://picsum.photos/200/300", "Sleek Rubber Mouse", new DateTime(2023, 10, 28, 15, 6, 34, 394, DateTimeKind.Local).AddTicks(2325) },
                    { 32, "Non rerum neque sit qui voluptas. Dolorem maiores qui eum aut. Repudiandae est autem numquam quia est veniam. Est sit distinctio totam.", "Puzzle", "https://picsum.photos/200/300", "Practical Frozen Cheese", new DateTime(2022, 10, 25, 8, 55, 35, 412, DateTimeKind.Local).AddTicks(9573) },
                    { 33, "Expedita consequuntur repellat labore harum dolorem quibusdam maxime. Et consequatur necessitatibus corporis veniam facere et rerum. Molestias sunt quisquam blanditiis est beatae ut aspernatur. Provident laudantium enim molestiae ullam vel illum. Voluptas nihil nisi totam exercitationem occaecati. Sit sunt maxime eum quod facere consequatur quia.", "Adventure", "https://picsum.photos/200/300", "Refined Metal Mouse", new DateTime(2023, 3, 28, 16, 35, 49, 544, DateTimeKind.Local).AddTicks(4406) },
                    { 34, "Nostrum rerum corporis et molestiae eos et magnam et. Saepe illum natus neque incidunt sunt. Molestiae eveniet a aut aliquam labore. Veniam voluptas nesciunt fuga quas similique incidunt autem ut et. Asperiores quis incidunt aliquam sequi recusandae eos doloribus ut assumenda. Molestiae qui in.", "Shooter", "https://picsum.photos/200/300", "Refined Metal Sausages", new DateTime(2020, 10, 31, 0, 12, 37, 856, DateTimeKind.Local).AddTicks(3830) },
                    { 35, "Sit nihil quam. Voluptas ut beatae et minus et amet ab deleniti beatae. Molestiae similique at sunt et blanditiis soluta omnis amet consequatur. Sed rerum adipisci doloremque omnis suscipit. Voluptatibus debitis corrupti corrupti dolorem rerum expedita.", "Strategy", "https://picsum.photos/200/300", "Handcrafted Wooden Chicken", new DateTime(2020, 12, 17, 0, 57, 30, 933, DateTimeKind.Local).AddTicks(9370) },
                    { 36, "Amet totam corrupti rerum consectetur eos. Nisi velit vitae. Quaerat nihil libero libero non maxime qui ullam dolores. Delectus dignissimos assumenda fuga dolor. Ratione temporibus amet unde enim inventore ratione aliquid suscipit ut. Ut dolore sit perferendis nesciunt.", "Puzzle", "https://picsum.photos/200/300", "Handcrafted Frozen Pizza", new DateTime(2018, 4, 27, 21, 5, 16, 292, DateTimeKind.Local).AddTicks(2168) },
                    { 37, "Quis voluptatem tempore odit cumque. Neque consequatur esse quia aut rerum et quae sed voluptatem. Atque nihil qui aliquid aperiam quaerat tenetur laborum. Fugiat eveniet deserunt consectetur voluptas minus aliquid deleniti et.", "Adventure", "https://picsum.photos/200/300", "Generic Cotton Chicken", new DateTime(2020, 8, 2, 22, 38, 17, 568, DateTimeKind.Local).AddTicks(3647) },
                    { 38, "Sunt voluptas suscipit pariatur alias est. Deserunt maiores nesciunt esse unde et. Officia nostrum cum et unde a placeat minima.", "Puzzle", "https://picsum.photos/200/300", "Practical Rubber Computer", new DateTime(2019, 10, 27, 20, 42, 55, 195, DateTimeKind.Local).AddTicks(9996) },
                    { 39, "Non tempore mollitia repudiandae et officia in. Dolore facere magnam enim quidem ducimus. Non et blanditiis quae repellendus. Voluptatum dolor ipsum sit.", "RPG", "https://picsum.photos/200/300", "Gorgeous Frozen Fish", new DateTime(2024, 2, 23, 8, 15, 58, 503, DateTimeKind.Local).AddTicks(3856) },
                    { 40, "Sit aut dolore est earum assumenda soluta pariatur. Laudantium quo qui et nemo distinctio vel. Reiciendis aliquid et. Magnam alias quaerat perferendis voluptatem architecto. Unde explicabo sed et modi non tempora dignissimos quaerat.", "Adventure", "https://picsum.photos/200/300", "Handcrafted Wooden Pizza", new DateTime(2015, 11, 16, 17, 5, 14, 387, DateTimeKind.Local).AddTicks(6171) },
                    { 41, "Nesciunt cumque rerum qui. Consequatur animi quas consequuntur aut dolores minima aperiam et. Vel aut harum iusto culpa cupiditate fuga. Accusantium repudiandae aut omnis tenetur odio iste odit non.", "Adventure", "https://picsum.photos/200/300", "Generic Fresh Computer", new DateTime(2016, 11, 10, 4, 38, 48, 146, DateTimeKind.Local).AddTicks(2844) },
                    { 42, "Facere labore et enim occaecati. Consequatur eos placeat. Rem ratione molestiae vitae dolores est. Possimus debitis laudantium perferendis tenetur vel quis possimus quos. Enim vel sit. Omnis consequuntur ullam possimus ut iste est similique consequatur.", "Adventure", "https://picsum.photos/200/300", "Rustic Granite Pizza", new DateTime(2017, 3, 9, 16, 19, 36, 715, DateTimeKind.Local).AddTicks(8024) },
                    { 43, "Et ad explicabo amet voluptatem dolores voluptatem omnis recusandae. Officiis dolore repellat pariatur et animi maiores. Corporis quibusdam rem neque consectetur.", "Strategy", "https://picsum.photos/200/300", "Unbranded Steel Keyboard", new DateTime(2019, 6, 3, 17, 11, 21, 107, DateTimeKind.Local).AddTicks(9633) },
                    { 44, "Quia rem voluptatem. Adipisci sunt mollitia amet nemo quia placeat qui non. Occaecati aut delectus. Non possimus reprehenderit voluptatem.", "RPG", "https://picsum.photos/200/300", "Handcrafted Plastic Pizza", new DateTime(2024, 7, 4, 16, 50, 30, 138, DateTimeKind.Local).AddTicks(9405) },
                    { 45, "Voluptates fuga autem quis. Consequatur dicta incidunt praesentium voluptas repellat nostrum cumque nihil delectus. Ea aspernatur quis et eos libero deserunt voluptatem. Quod dolorum quidem sed est maiores similique aperiam. Quis asperiores ea corrupti maxime omnis odio.", "RPG", "https://picsum.photos/200/300", "Sleek Metal Car", new DateTime(2017, 11, 18, 6, 3, 53, 97, DateTimeKind.Local).AddTicks(5107) },
                    { 46, "In mollitia natus maiores eligendi. Sit officia ut numquam adipisci ut sit. Consequatur eius illo vel vero ullam sapiente sed ut quidem. Ratione sint voluptatem sit atque non adipisci.", "Puzzle", "https://picsum.photos/200/300", "Refined Fresh Hat", new DateTime(2016, 9, 21, 21, 59, 24, 798, DateTimeKind.Local).AddTicks(6339) },
                    { 47, "Nulla similique fugit nihil laboriosam deserunt. Et maxime est numquam. Sequi ullam ea ipsa et dolorum voluptatem minus repellendus eum. Magni nemo aliquid voluptas aut officiis eaque blanditiis aspernatur id. Et ut placeat quas dignissimos aut omnis delectus aut est. Saepe aut rem animi suscipit voluptas voluptate est qui debitis.", "RPG", "https://picsum.photos/200/300", "Ergonomic Fresh Ball", new DateTime(2023, 12, 9, 19, 29, 30, 131, DateTimeKind.Local).AddTicks(3948) },
                    { 48, "Quo nihil laudantium culpa ex quidem. Iure dolorum ut et qui harum illum. Dolor voluptas voluptas. Eveniet mollitia consequatur iusto cum possimus itaque. Eaque quod vel molestias voluptas necessitatibus occaecati eum. Velit ut sint provident et sit nulla.", "Puzzle", "https://picsum.photos/200/300", "Tasty Plastic Shirt", new DateTime(2023, 7, 21, 14, 8, 51, 254, DateTimeKind.Local).AddTicks(6451) },
                    { 49, "Explicabo quam recusandae eos at qui aliquam. Non aliquid qui fugit enim illum. Ducimus tenetur voluptatibus et sit quis provident.", "Puzzle", "https://picsum.photos/200/300", "Practical Plastic Soap", new DateTime(2020, 3, 23, 10, 19, 14, 82, DateTimeKind.Local).AddTicks(669) },
                    { 50, "Dolorum rem adipisci sint. Officiis sunt facere quasi aliquid accusamus. Error eum omnis est neque rerum. Dolores quis recusandae dolorem consequatur.", "Adventure", "https://picsum.photos/200/300", "Awesome Soft Gloves", new DateTime(2023, 9, 18, 22, 25, 10, 225, DateTimeKind.Local).AddTicks(3799) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-admin-id", "user-admin-id" });
        }
    }
}
