using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace infiniteworlds_fronted.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "role-admin-id", null, "Admin", "ADMIN" });

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
                    { "e572547d-424d-43eb-9773-feb81c8adba2", 0, "b7e82454-4957-4bf9-b328-f2d052fc8412", "Vivianne89@gmail.com", false, false, null, null, null, "beoeooeu", null, false, "3e991bb3-ee5b-4b4d-9451-05e89fd16b2c", false, "Maryse_Waters98" },
                    { "user-admin-id", 0, "1b9b7e7a-8140-49d8-aae0-31b822c0df03", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEEZlVMC9D6DjIa0wK80kB/myJnNhvq+FaFtPqbqTihiCC4NGBrqM6cT7KVNSr5WMLw==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Descripcion", "Genero", "ImageFilePath", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Dolorem expedita fugit illo ut voluptates autem. Voluptas a quaerat voluptatem non dolorem inventore qui. Modi maiores similique vitae. Beatae corporis molestiae dolor asperiores enim sint fugit voluptatibus.", "Puzzle", "https://picsum.photos/200/300", "Practical Wooden Chicken", new DateTime(2019, 3, 10, 1, 18, 14, 443, DateTimeKind.Local).AddTicks(5436) },
                    { 2, "Harum ea sint dolore illo adipisci et. Et quibusdam quo placeat ad qui est cumque quibusdam rem. Quia ipsam vel eveniet. Dolores aut tempora molestiae. Officiis voluptatem voluptatem molestiae voluptatem fugiat velit. Rerum quia aut maxime ut sit expedita.", "Puzzle", "https://picsum.photos/200/300", "Awesome Concrete Keyboard", new DateTime(2023, 11, 15, 7, 34, 14, 802, DateTimeKind.Local).AddTicks(5208) },
                    { 3, "Similique et perferendis tempore id in sunt saepe quam. Excepturi et quia. Maiores voluptatum dolor voluptas sed pariatur eveniet nihil saepe ex. Autem ex fugiat nulla distinctio asperiores nihil natus. Et et impedit eos beatae rerum nihil.", "Puzzle", "https://picsum.photos/200/300", "Gorgeous Frozen Computer", new DateTime(2022, 11, 8, 2, 24, 22, 945, DateTimeKind.Local).AddTicks(638) },
                    { 4, "Repellat est eum non repellendus laborum. Iure enim fugit quam debitis reiciendis harum sed. Quasi quis officiis nesciunt. Laboriosam quo beatae dolores cupiditate sint et quis aut.", "Adventure", "https://picsum.photos/200/300", "Generic Metal Chair", new DateTime(2015, 7, 30, 11, 37, 41, 264, DateTimeKind.Local).AddTicks(2392) },
                    { 5, "Sed quaerat sint velit sunt iusto. Omnis voluptatem et quisquam debitis omnis dolor omnis. Maiores laudantium qui commodi aliquid ut sed iste. Quo et et. Est nostrum omnis ea doloribus atque quo dolor laborum. Ut non quidem quidem a ad.", "Strategy", "https://picsum.photos/200/300", "Generic Wooden Chair", new DateTime(2018, 8, 3, 12, 20, 24, 7, DateTimeKind.Local).AddTicks(8658) },
                    { 6, "Ratione ea nihil quia similique qui nostrum. Saepe nisi perferendis blanditiis. Quod ut eligendi non. Magnam non temporibus consequuntur nemo corporis quo laudantium accusamus aut. Placeat ut animi maxime maxime repellendus.", "RPG", "https://picsum.photos/200/300", "Practical Plastic Salad", new DateTime(2020, 5, 20, 17, 37, 16, 206, DateTimeKind.Local).AddTicks(429) },
                    { 7, "Ut vitae temporibus. Officiis doloremque est tempore. Distinctio molestias blanditiis eos nisi voluptatum odit aut non.", "Strategy", "https://picsum.photos/200/300", "Ergonomic Fresh Car", new DateTime(2020, 9, 18, 23, 23, 18, 830, DateTimeKind.Local).AddTicks(2269) },
                    { 8, "Ipsa placeat esse. Exercitationem aliquam quam error voluptas ut. Occaecati accusantium fuga iste libero tenetur repudiandae eveniet. Et deserunt nostrum iste a occaecati id delectus dolores nobis.", "Shooter", "https://picsum.photos/200/300", "Rustic Frozen Fish", new DateTime(2018, 8, 3, 1, 21, 20, 268, DateTimeKind.Local).AddTicks(4841) },
                    { 9, "Dolor odit in officia ea sint quo facilis. Qui quod nulla quia. Cupiditate voluptas accusantium nostrum aliquid maxime nesciunt veritatis facilis. Atque eos assumenda dolores sunt tempora alias quia officiis et. Dolorem temporibus rerum. Dolore et velit aut eius voluptatum id ea praesentium.", "RPG", "https://picsum.photos/200/300", "Small Metal Car", new DateTime(2021, 3, 13, 6, 53, 13, 285, DateTimeKind.Local).AddTicks(4663) },
                    { 10, "Similique soluta voluptatem sit a. Aut iste molestiae rerum et cumque autem et occaecati. Occaecati fugit velit explicabo. Velit dolores sapiente officiis aliquam quidem praesentium voluptatum quibusdam et. Est doloribus voluptas vitae omnis adipisci error quis aliquid ut.", "Strategy", "https://picsum.photos/200/300", "Licensed Concrete Shirt", new DateTime(2022, 11, 12, 8, 6, 37, 41, DateTimeKind.Local).AddTicks(3322) },
                    { 11, "Mollitia quaerat pariatur. Corporis asperiores ut accusantium quia. Eius deleniti omnis quibusdam voluptas nobis eos alias. Aut qui totam sed. Atque laborum est. Libero rerum nemo praesentium et quibusdam exercitationem.", "RPG", "https://picsum.photos/200/300", "Awesome Granite Hat", new DateTime(2023, 8, 5, 12, 57, 31, 858, DateTimeKind.Local).AddTicks(1870) },
                    { 12, "Repellendus odit consequuntur aut dolorem qui cumque error. Aspernatur et ad sit. Soluta nostrum sed. Nobis in repellendus alias quia temporibus ut. Voluptatem harum non est facere vitae.", "RPG", "https://picsum.photos/200/300", "Licensed Rubber Car", new DateTime(2019, 11, 22, 16, 28, 57, 936, DateTimeKind.Local).AddTicks(1704) },
                    { 13, "Dignissimos corporis minus officiis. Quibusdam sit debitis deserunt nisi et quo nulla. Blanditiis nihil dolor repudiandae eveniet assumenda error laboriosam. Ipsa nemo est nihil et sint sunt.", "RPG", "https://picsum.photos/200/300", "Tasty Metal Fish", new DateTime(2020, 2, 8, 6, 23, 31, 850, DateTimeKind.Local).AddTicks(6444) },
                    { 14, "Labore explicabo numquam consequatur sapiente. Qui provident mollitia modi quia maxime quasi. Voluptatum fugit aut et error corporis labore optio. Veritatis dolores nobis et voluptatem.", "Puzzle", "https://picsum.photos/200/300", "Incredible Concrete Salad", new DateTime(2022, 2, 22, 12, 45, 10, 93, DateTimeKind.Local).AddTicks(3955) },
                    { 15, "Omnis odio libero in corrupti quo voluptas omnis. Sunt possimus ducimus. Explicabo nobis occaecati non aperiam veritatis non dolor vitae. Necessitatibus aut illum aliquid. Itaque qui quaerat libero laboriosam corrupti sequi eveniet.", "RPG", "https://picsum.photos/200/300", "Incredible Plastic Fish", new DateTime(2019, 7, 3, 21, 24, 49, 905, DateTimeKind.Local).AddTicks(8285) },
                    { 16, "Facilis vitae inventore quia tempore beatae. Ut soluta earum consequatur dolor et quia tempora et. Dolorem placeat iste. Mollitia quo enim. Minima in laudantium beatae et commodi nulla ex fuga et. Aspernatur rerum dolore dolorem enim eveniet doloremque.", "Action", "https://picsum.photos/200/300", "Sleek Cotton Mouse", new DateTime(2021, 7, 25, 16, 35, 44, 82, DateTimeKind.Local).AddTicks(4220) },
                    { 17, "Dolorem non illo nesciunt saepe. Architecto esse est illum fuga. Neque eum fugit debitis et quisquam ea enim vel. Assumenda sunt recusandae praesentium placeat quam rerum sed. Excepturi dolores numquam exercitationem illum non.", "RPG", "https://picsum.photos/200/300", "Gorgeous Concrete Ball", new DateTime(2020, 5, 15, 21, 33, 7, 985, DateTimeKind.Local).AddTicks(6919) },
                    { 18, "Error totam iure veniam fuga nostrum alias quia. Hic expedita eius. Est qui voluptas nulla non quo. Non commodi mollitia eaque provident quis.", "Adventure", "https://picsum.photos/200/300", "Licensed Frozen Hat", new DateTime(2023, 2, 8, 12, 39, 47, 840, DateTimeKind.Local).AddTicks(9845) },
                    { 19, "Fuga dolorem facere aut error est est dolor ut. Ducimus consequatur sint in facere fuga deserunt explicabo quidem. Exercitationem quibusdam molestias doloribus ipsam dolorem veritatis quo laborum. Laborum rerum voluptates ut. Amet sit sit et dolore quis repudiandae laudantium iure. Iusto velit voluptatem repellendus reprehenderit nihil.", "Puzzle", "https://picsum.photos/200/300", "Generic Metal Shoes", new DateTime(2023, 3, 17, 14, 24, 4, 392, DateTimeKind.Local).AddTicks(6199) },
                    { 20, "Vel illo ea et perspiciatis fugit. Voluptatum veritatis ad est voluptatem distinctio adipisci modi. Fuga rerum pariatur omnis eligendi accusamus ducimus et. Corporis dolor pariatur dolore voluptates. Voluptas et natus.", "Puzzle", "https://picsum.photos/200/300", "Practical Cotton Chips", new DateTime(2016, 8, 25, 5, 50, 2, 873, DateTimeKind.Local).AddTicks(4081) },
                    { 21, "Hic autem architecto. Enim modi voluptatem qui aspernatur. Voluptates minus esse explicabo ratione perspiciatis qui accusamus. Quis autem sed.", "RPG", "https://picsum.photos/200/300", "Handmade Granite Chips", new DateTime(2018, 8, 9, 8, 43, 9, 294, DateTimeKind.Local).AddTicks(2664) },
                    { 22, "Quis esse asperiores ut aut fugiat laudantium mollitia. Possimus id assumenda voluptatem nemo voluptatem. Saepe ab dolorem et iste aliquid illo. At magnam quidem consequatur ipsum.", "Puzzle", "https://picsum.photos/200/300", "Generic Metal Gloves", new DateTime(2017, 9, 8, 1, 14, 35, 702, DateTimeKind.Local).AddTicks(8042) },
                    { 23, "Et voluptatem ullam. Maxime asperiores eos corrupti dolor consectetur aperiam dolorem neque. Eos nemo non quos qui dolor voluptatibus. Alias qui provident ipsa molestiae id ipsum illo odit. Dolorem saepe in temporibus nemo sit recusandae est alias. Ducimus deserunt inventore dignissimos consectetur.", "Strategy", "https://picsum.photos/200/300", "Practical Steel Cheese", new DateTime(2020, 3, 4, 18, 43, 19, 599, DateTimeKind.Local).AddTicks(5612) },
                    { 24, "Quaerat perferendis hic atque. Tenetur nihil ad velit alias id facere tempora. Nihil iste voluptas vero minus fugit. Unde qui deserunt quis eligendi quia. Est rerum voluptatem blanditiis incidunt qui.", "Puzzle", "https://picsum.photos/200/300", "Rustic Rubber Chips", new DateTime(2022, 11, 14, 1, 18, 43, 307, DateTimeKind.Local).AddTicks(6173) },
                    { 25, "Quis sed odit veniam dicta quia sit sed veritatis. At ipsa quia. Non laudantium culpa voluptatibus maiores non corporis et dolorem.", "Puzzle", "https://picsum.photos/200/300", "Handmade Frozen Bike", new DateTime(2016, 1, 7, 12, 47, 4, 149, DateTimeKind.Local).AddTicks(7076) },
                    { 26, "Vel itaque rerum. Libero optio aspernatur voluptatem. Voluptate dicta non quia sapiente id. Iure nostrum nihil sunt sed. Commodi est accusamus aut. Voluptates sequi magnam sit.", "Action", "https://picsum.photos/200/300", "Handcrafted Fresh Cheese", new DateTime(2018, 6, 30, 18, 38, 17, 323, DateTimeKind.Local).AddTicks(4003) },
                    { 27, "Ad asperiores quis explicabo doloremque. Placeat rerum voluptas cumque. Nihil ut aliquid quis cum. Iusto nam inventore dolorem dignissimos qui non odio. Velit vitae exercitationem molestiae sit repellendus sed deserunt aspernatur. Eveniet sit aut laborum enim rem veritatis deserunt.", "RPG", "https://picsum.photos/200/300", "Incredible Granite Pants", new DateTime(2018, 11, 15, 7, 7, 32, 798, DateTimeKind.Local).AddTicks(7141) },
                    { 28, "Et ut fugiat fugiat natus maxime natus architecto voluptate in. Veritatis nostrum modi aut facere enim consectetur nobis. Ducimus eum quia autem in voluptatem velit fuga iusto quibusdam. Quaerat vel officiis vitae vitae. Voluptatibus tempora et praesentium et. Vel eius recusandae.", "RPG", "https://picsum.photos/200/300", "Generic Rubber Car", new DateTime(2021, 10, 26, 2, 27, 20, 919, DateTimeKind.Local).AddTicks(6201) },
                    { 29, "Exercitationem quae impedit minus non ducimus ducimus a commodi expedita. Sapiente nesciunt ullam. Porro assumenda vel distinctio. Tempora magni a veritatis mollitia beatae minima architecto.", "Puzzle", "https://picsum.photos/200/300", "Refined Cotton Mouse", new DateTime(2016, 10, 11, 9, 1, 3, 663, DateTimeKind.Local).AddTicks(5455) },
                    { 30, "Neque commodi illo sint sed. Iste inventore quos. Cumque necessitatibus ut quisquam. Et quia est ut mollitia. Nulla eos cum rem.", "Shooter", "https://picsum.photos/200/300", "Handcrafted Metal Bacon", new DateTime(2016, 2, 12, 21, 55, 40, 228, DateTimeKind.Local).AddTicks(5465) },
                    { 31, "Impedit unde fugiat porro quo. Harum sequi velit. Delectus odit aut eum vel. Aut eligendi ut consectetur eum dolorem error sed fugiat odit. Maxime iusto nihil voluptatibus.", "RPG", "https://picsum.photos/200/300", "Gorgeous Frozen Tuna", new DateTime(2021, 6, 4, 12, 31, 45, 20, DateTimeKind.Local).AddTicks(7209) },
                    { 32, "Rerum ipsa rerum est. Accusantium amet voluptatem est a. Distinctio voluptatem vel laborum necessitatibus. Perspiciatis architecto unde cumque et voluptas iusto reprehenderit.", "Puzzle", "https://picsum.photos/200/300", "Incredible Steel Chips", new DateTime(2018, 6, 28, 18, 51, 23, 318, DateTimeKind.Local).AddTicks(5816) },
                    { 33, "Pariatur sequi rerum voluptatem aut sed blanditiis dolorum voluptatem voluptate. Aut consequatur animi aut est provident asperiores unde. Iste in distinctio quidem. Qui magni porro nobis optio qui voluptatum.", "Shooter", "https://picsum.photos/200/300", "Generic Steel Cheese", new DateTime(2022, 3, 2, 11, 30, 28, 68, DateTimeKind.Local).AddTicks(5274) },
                    { 34, "Eum sunt similique voluptatem. Rerum qui neque dolor quod minus. Ea provident velit quos ipsa qui commodi. Cum nulla recusandae at eligendi. Culpa debitis eum eaque iste.", "Action", "https://picsum.photos/200/300", "Generic Rubber Cheese", new DateTime(2016, 1, 12, 14, 57, 50, 192, DateTimeKind.Local).AddTicks(6713) },
                    { 35, "Nisi voluptates est. Dolorem id aliquam sed asperiores dolores rerum in. Eligendi quia iure itaque necessitatibus voluptatem et veritatis. Harum qui nemo qui harum delectus magnam harum velit laudantium. Eum tenetur odio saepe accusantium ut amet officiis et vel.", "Shooter", "https://picsum.photos/200/300", "Awesome Cotton Gloves", new DateTime(2017, 7, 24, 23, 57, 40, 282, DateTimeKind.Local).AddTicks(9910) },
                    { 36, "Id rerum eligendi sit deleniti aut. Ad ea voluptas omnis a exercitationem totam. Vitae temporibus laboriosam et et velit accusamus.", "RPG", "https://picsum.photos/200/300", "Refined Steel Pizza", new DateTime(2024, 7, 30, 13, 27, 44, 770, DateTimeKind.Local).AddTicks(1374) },
                    { 37, "Qui soluta temporibus voluptate error saepe voluptates sit. Maxime ipsum autem vel dicta dignissimos eaque atque. Dolor et ea alias iure sunt impedit assumenda. Minima quas nihil sit. Qui unde consequatur cupiditate delectus ipsam a esse animi sit.", "Strategy", "https://picsum.photos/200/300", "Small Soft Chicken", new DateTime(2022, 9, 28, 3, 16, 8, 770, DateTimeKind.Local).AddTicks(5382) },
                    { 38, "Architecto quidem qui non. Voluptatum aut vitae repellendus soluta temporibus eligendi ex. Tempore maxime ut odit.", "Strategy", "https://picsum.photos/200/300", "Incredible Wooden Shoes", new DateTime(2020, 4, 25, 8, 12, 2, 625, DateTimeKind.Local).AddTicks(2865) },
                    { 39, "Laborum quia similique nisi. Accusantium impedit dolores necessitatibus illum in voluptatem sunt voluptatum. Sit aut nulla repellendus beatae sit et.", "RPG", "https://picsum.photos/200/300", "Handmade Steel Chair", new DateTime(2015, 5, 8, 20, 45, 56, 971, DateTimeKind.Local).AddTicks(2612) },
                    { 40, "Saepe iste soluta. Itaque incidunt ipsum maiores nesciunt quae ab quia dolore corrupti. Quia quisquam vitae. Reprehenderit error cum perferendis commodi quo sed eos. Sit aperiam in assumenda itaque. Et ut itaque eum voluptate qui temporibus atque.", "Strategy", "https://picsum.photos/200/300", "Tasty Steel Pants", new DateTime(2020, 3, 28, 18, 50, 34, 274, DateTimeKind.Local).AddTicks(3555) },
                    { 41, "Perspiciatis eius qui. Facilis id adipisci nihil voluptas magni nobis. Voluptatem enim in reprehenderit nesciunt accusamus adipisci facere aut. Repellendus perspiciatis et molestiae sit impedit excepturi velit. Id aperiam in dicta rerum quaerat nemo.", "Action", "https://picsum.photos/200/300", "Unbranded Concrete Computer", new DateTime(2016, 1, 31, 6, 19, 5, 847, DateTimeKind.Local).AddTicks(6417) },
                    { 42, "Eveniet harum totam vel impedit magnam ullam. Nihil fuga alias repudiandae saepe eius officiis quos dignissimos quis. Molestiae commodi voluptatum est. Sunt eligendi voluptatum. Pariatur placeat dolore rerum dolorem hic.", "Adventure", "https://picsum.photos/200/300", "Intelligent Fresh Ball", new DateTime(2021, 7, 18, 2, 49, 59, 231, DateTimeKind.Local).AddTicks(9414) },
                    { 43, "Expedita a sit sint. Explicabo minima molestias blanditiis deserunt eaque a rerum necessitatibus sit. Omnis aperiam tenetur saepe dignissimos commodi dolores magnam quidem. Et maxime quod modi eum dolore assumenda officiis numquam modi.", "Strategy", "https://picsum.photos/200/300", "Handmade Concrete Shirt", new DateTime(2018, 9, 24, 11, 42, 55, 322, DateTimeKind.Local).AddTicks(892) },
                    { 44, "Aliquid quia ut ea quia totam. Voluptatem ullam nesciunt tenetur reprehenderit repudiandae. Explicabo placeat rem suscipit. Ut adipisci molestias esse quo eum. Reiciendis sint dolorum in praesentium. Eos ut ipsum accusantium quia et fuga nobis et.", "Shooter", "https://picsum.photos/200/300", "Rustic Soft Tuna", new DateTime(2023, 6, 17, 14, 23, 14, 425, DateTimeKind.Local).AddTicks(2823) },
                    { 45, "Qui quo accusantium et beatae maxime doloremque porro. Inventore quia accusantium doloremque enim aut. Harum animi et molestias blanditiis tempora eos. Eos repellat sit aut eaque modi cupiditate voluptatem quia.", "Strategy", "https://picsum.photos/200/300", "Small Fresh Gloves", new DateTime(2023, 3, 22, 9, 38, 3, 600, DateTimeKind.Local).AddTicks(5897) },
                    { 46, "Eos dolor aliquid aliquid a aut. Et qui error. A nulla et ipsam at.", "Shooter", "https://picsum.photos/200/300", "Gorgeous Cotton Car", new DateTime(2016, 7, 1, 4, 24, 43, 994, DateTimeKind.Local).AddTicks(3340) },
                    { 47, "Quisquam totam aperiam cumque magni dolorem. Quo ullam et id enim ab culpa quis. Voluptatum rerum iusto similique magnam quod. Autem in ducimus delectus quo pariatur quia quasi animi rem.", "Strategy", "https://picsum.photos/200/300", "Generic Fresh Shoes", new DateTime(2022, 6, 26, 19, 33, 3, 930, DateTimeKind.Local).AddTicks(3297) },
                    { 48, "Eos quasi molestiae amet. Laborum quisquam molestias quo. Cum labore libero.", "Puzzle", "https://picsum.photos/200/300", "Intelligent Concrete Fish", new DateTime(2020, 1, 6, 11, 35, 42, 417, DateTimeKind.Local).AddTicks(4517) },
                    { 49, "Voluptate dolore inventore optio reprehenderit. Voluptatem expedita consectetur odio ratione sequi. Aut autem earum dignissimos. Voluptatibus dolores dolore omnis pariatur voluptatem officiis.", "Puzzle", "https://picsum.photos/200/300", "Incredible Fresh Sausages", new DateTime(2014, 12, 13, 12, 36, 49, 571, DateTimeKind.Local).AddTicks(1594) },
                    { 50, "Molestias vero qui perspiciatis. Et nam placeat aliquam perspiciatis ipsa molestias. Pariatur distinctio quas iure excepturi saepe. Ipsam voluptates rem mollitia et possimus laboriosam. Est facere corporis veritatis. Et voluptatem dolor aliquam repellat officiis.", "Shooter", "https://picsum.photos/200/300", "Handcrafted Cotton Tuna", new DateTime(2021, 11, 24, 3, 29, 52, 243, DateTimeKind.Local).AddTicks(2371) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-admin-id", "user-admin-id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-admin-id", "user-admin-id" });

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
        }
    }
}
