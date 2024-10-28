using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchManageStore.Migrations
{
    public partial class CreateDBNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Watchs",
                columns: table => new
                {
                    WatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsuranceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchs", x => x.WatchId);
                    table.ForeignKey(
                        name: "FK_Watchs_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watchs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watchs_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    WatchId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Publish = table.Column<bool>(type: "bit", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Watchs_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watchs",
                        principalColumn: "WatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailWatchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchID = table.Column<int>(type: "int", nullable: false),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    Waterproof = table.Column<bool>(type: "bit", nullable: false),
                    Facematerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WireMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailWatchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailWatchs_Watchs_WatchID",
                        column: x => x.WatchID,
                        principalTable: "Watchs",
                        principalColumn: "WatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RateAccounts",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    WatchId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateAccounts", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_RateAccounts_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RateAccounts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RateAccounts_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RateAccounts_Watchs_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watchs",
                        principalColumn: "WatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Image" },
                values: new object[,]
                {
                    { 1, "Đồng hồ Philippe Auguste", "thuong-hieu2.png" },
                    { 2, "Đồng hồ Diamond D", "thuong-hieu3.png" },
                    { 3, "Thương hiệu Bovet", "thuong-hieu4.png" },
                    { 4, "Thương hiệu Jacques Lemans", "thuong-hieu5.png" },
                    { 5, "Thương hiệu Aries Gold", "thuong-hieu6.png" },
                    { 6, "Thương hiệu Q&Q", "thuong-hieu6.png" },
                    { 7, "Thương hiệu Atlantic Swiss", "thuong-hieu7.png" },
                    { 8, "Thương hiệu Hublot", "thuong-hieu8.png" },
                    { 9, "Thương hiệu Epos Swiss", "thuong-hieu9.png" },
                    { 10, "Thương hiệu Bruno Sohnle Glashutte", "thuong-hieu4.png" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 3, "Đồng hồ đôi" },
                    { 1, "Đồng hồ nam" },
                    { 2, "Đồng hồ nữ" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreateOn", "Id", "Image1", "Image2", "ModifyDate", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Nhân ngày Quốc tế phụ nũ 08/03 Đăng Quang Watch đã cập nhật hàng ngàn mẫu đồng hồ mới nhất, trend nhất dành riêng cho phái đẹp cùng chương trình khuyến mại đặc biệt: Giảm giá lên tới 30% và hoàn tiền 100% giá trị hóa đơn mua hàngĐồng hồ đeo tay chính là món phụ kiện giúp chị em phụ nữ hiện đại thể hiện phong cách thời trang và vẻ ngoài thanh lịch của mình, hơn nữa còn là vật dụng vô cùng hữu ích và cần thiết trong đời sống hàng ngày.Đồng hồ là biểu trưng cho thời gian. Khi làm quà tặng cho người mà mình trân quý, đồng hồ mang thông điệp tình cảm người tặng dành cho họ là bất diệt, không phai tàn theo thời gian.Nhiều mẫu đồng hồ đẹp có thể làm quà tặng 08/03 ý nghĩa đang có sẵn tại hệ thống gần 100 showroom Đăng Quang Watch.Trong đó, một số thương hiệu đang được nhiều người yêu thích như Diamond D, Aries Gold, Epos, Atlantic, Bruno Sohnle Glashutte, Citizen, Q&Q... Với chế độ bảo hành quốc tế, xuất hoá đơn đỏ, giấy tờ hải quan chứng minh nguồn gốc xuất xứ sản phẩm, khách hàng hoàn toàn có thể yên tâm sử dụng cũng như tin tưởng lựa chọn làm món quà tặng ý nghĩa cho người thân yêu.Ngoài các sản phẩm đồng hồ với thiết kế sang trọng, tinh tế, trẻ trung khách hàng có thể lựa chọn quà tặng là những sản phẩm kính mắt đến từ Kính Mắt Đăng Quang với thiết kế vô cùng năng động và cá tính.Kể từ ngày 01/03 đến 15/03/2022 Đăng Quang Watch tặng ngay ưu đãi giảm giá lên tới 30% cùng cơ hội quay số may mắn hoàn tiền 100% giá trị hóa đơn khi mua sắm đồng hồ trong dịp này. Để tham gia chương trình, khi mua hàng khách hàng chỉ cần điền đầy đủ thông tin vào hóa đơn. Trong đó, mã số tham dự quay giải chính là 4 số cuối số điện thoại của khách hàng. Chương trình sẽ dùng kết quả xổ số miền Bắc quay thưởng ngày 16/03/2022 làm căn cứ trao giải. Khách hàng may mắn 4 số cuối điện thoại cuối trùng với giải đặc biệt sẽ trở thành khách hàng may mắn nhất được hoàn lại 100% giá trị hóa đơn.", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "noi-bat-movado.png", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bùng nổ ưu đãi 08/03 : Giảm giá lên tới 30% và hoàn tiền 100% giá trị hóa đơn tại Đăng Quang Watch", "408aa945-3d84-4421-8342-7269ec64d949" },
                    { 2, "Mãnh Hổ được xem là biểu tượng của sức mạnh, quyền uy, sự thăng tiến trong học hành và kinh doanh. Trong dân gian con Hổ còn được coi là linh vật giám hộ hướng Tây, đầy uy lực, linh thiêng và được thờ phụng rất nhiều, bảo vệ cho gia chủ, đảm bảo tiền tài, sức khoẻ cho các thành viên trong gia đình.Đồng hồ Mãnh Hổ PA2022 phiên bản giới hạn chỉ 100 chiếc trên toàn cầu. Với mặt số được trang trí nổi bật biểu tượng con Hổ dũng mãnh - linh vật của năm. Thiết kế bộ kim màu vàng sang đẹp mắt và phần vò gắn kim cương nhân tạo tăng lên sự quyền lực, phú quý cho sản phẩm này.Đồng hồ Philippe Auguste là thương hiệu xuất xứ Châu Âu và được Đăng Quang Watch phân phối độc quyền tại Việt Nam. Với mã sản phẩm PA2022 phiên bản giới hạn toàn cầu chỉ có 100 chiếc là một thiết kế đặc biệt dành riêng cho năm 2022. Được trang bị mặt kính Saphire với khả năng chống xước tốt kết hợp chất liệu vỏ thép không gỉ được mạ công nghệ PVD tiên tiến.", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "noi-bat-versace.png", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ĐỒNG HỒ MÃNH HỔPHIÊN BẢN GIỚI HẠN - CHÀO ĐÓN NHÂM DẦN", "408aa945-3d84-4421-8342-7269ec64d949" },
                    { 3, "Bắt nguồn từ câu chuyện về hoàng đế Philippe Auguste (Philipe II) - Quốc vương đầu tiên của nước Pháp với tham vọng gây dựng đế chế cho riêng mình. Ông đã trải qua hơn hai thập kỷ chiến đấu, mở rộng lãnh thổ nhằm củng cố vương vị, quyền lực và sức mạnh. Nhờ tài trí, mưu lược, Philippe Auguste đã biến Pháp từ một đất nước phong kiến nhỏ bé trở thành quốc gia thịnh vượng và hùng mạnh ở châu Âu.Đồng hồ Philippe Auguste là biểu tượng của tham vọng, bản lĩnh, sức mạnh và khát khao thành công, khẳng định giá trị bản thân, những yếu tố không thể thiếu của người đàn ông trong cuộc sống hiện đại.Dòng sản phẩm Philippe Auguste định hướng dành riêng cho khách hàng nam giới yêu thích đồng hồ với phân khúc giá trung bình từ 4 - 20 triệu đồng. Với những thiết kế hợp “gu” khách hàng, Philippe Auguste ngày càng khẳng định vị trí thương hiệu của mình.Mùa đông năm nay, Philippe Auguste đã cho ra mắt BST mới với sự mới mẻ hơn về thiết kế.Không chỉ giữ nguyên những nét đẹp cổ điển tinh tế, với BST lần này Philippe Auguste đã ra mắt rất nhiều mẫu sản phẩm đồng hồ pin với phong cách năng động hơn,thể thao hơn cho các anh trai.", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "noi-bat-zenith.png", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Phillipe Auguste – Đẳng cấp quý ông Châu Âu", "408aa945-3d84-4421-8342-7269ec64d949" },
                    { 4, "Epos nằm trong trong top 10 hãng đồng hồ độc lập uy tín nhất trong ngành đồng hồ Thụy Sĩ. Những chiếc đồng hồ được sản xuất thủ công với bí quyết lâu đời đã tạo ra những chiếc đồng hồ tuyệt vời.Trong những năm 80 của thế kỷ trước, khi mà ngành công nghiệp đồng hồ Thụy Sĩ truyền thống trở nên bế tắc vì không thể cạnh tranh nổi với những đồng hồ Quartz đang làm mưa làm gió trên thị trường. Peter Hofer - một chuyên gia đầy kinh nghiệm trong sản xuất đồng hồ Thụy Sĩ, ông và vợ ông Erna quyết định thành lập công ty của riêng mình năm 1983: Montres EPOS SA. Tài sản chính của họ là một niềm đam mê đối với đồng hồ cơ khí và một bí quyết kỹ thuật trong lĩnh vực này.Ngay từ đầu, EPOS đã là một thương hiệu cơ khí với những đổi mới thú vị. Trong những năm qua, EPOS vẫn trung thành với lựa chọn của mình, phát triển bộ sưu tập đồng hồ tuyệt đẹp kết hợp các cơ hấp dẫn.Đạt được danh tiếng trên toàn thế giới qua nhiều thế kỷ,nhờ tinh thần tiên phong và ý nghĩ độc đáo trong sự gia công hoàn hảo của đồng hồ.Đồng hồ Thụy Sỹ EPOS đã trở thành một người giám hộ,là thước đo của các giá trị truyền thống và các tiêu chuẩn cao.", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "onghokimnguu2.jpg", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "EPOS - Tinh hoa nghệ thuật của đồng hồ Thụy Sỹ", "408aa945-3d84-4421-8342-7269ec64d949" },
                    { 5, "Thông thường các dòng đồng hồ Automatic vẫn được tích hợp thêm chức năng Handwinding vì thế những thông tin dưới đây sẽ là tổng hợp cả hai dòng đồng hồ trên. Có khá nhiều cách để lên dây cót cho đồng hồ Automatic từ đơn giản đến phức tạp. Không để anh em phải chờ lâu thêm nữa, dưới đây sẽ là những thông tin hướng dẫn lên dây cót đồng hồ.Chuyển động cánh tay đeo đồng hồ Khá đơn giản đúng không nào. Tuy nhiên, nhiều anh em lại nghĩ cánh tay phải chuyển động liên tục thì mới có thể lên dây cót đồng hồ nhưng không, sự tinh xảo trong thiết kế sẽ giúp đồng hồ lên dây cót khi anh em hoạt động thương ngày. Khi anh em đeo đồng hồ và hoạt động bình thường thì chiếc đồng hồ của anh em đã được nạp năng lượng và cho sự hoạt động ổn định nhất. Còn một lời khuyên nữa cho anh em đó chính là không nên vận động quá mạnh ví dụ khi chơi bóng đá, cầu lông, tenis,… vì những va đập có thể ảnh hưởng đến khả năng lên dây cót của đồng hồ.Để đảm bảo chiếc đồng hồ Automatic hoạt động bình thường ( ngay cả vào ban đêm khi không sử dụng ) thì anh em nên đeo ít nhất 8 tiếng 1 ngày.Lên dây cót đồng hồ bằng núm vặn Như đã nói,đồng hồ cơ Automatic hiện nay còn được tích hợp thêm chức năng lên dây cót bằng tay.Đối với những dòng đồng hồ như thế này,anh em chỉ việc tác động một lực vừa để vặn núm điều chỉnh(không nên vặn quá căng).Nếu tỉ mỉ thì anh em có thể vặn từ 15 đến 20 vòng là đẹp nhất.", new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "noi-bat-versace.png", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Hướng dẫn cách chỉnh dây cót đồng hồ automatic", "408aa945-3d84-4421-8342-7269ec64d949" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Address", "CreateOn", "Description", "Image", "ModifyDate", "Phone", "Status", "StoreName" },
                values: new object[,]
                {
                    { 2, "Ho Chi Minh", new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đồng Hồ Hải Triều, hệ thống đồng hồ chính hãng tại Việt Nam. Nơi phân phối 15.000+ mẫu đồng hồ mới nhất từ hơn 22 thương hiệu nổi tiếng thế giới. Trải nghiệm mua sắm ngay hôm nay", "haitrieu.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19006777", true, "Hai Trieu Watch" },
                    { 1, "Tran Dang Ninh, Cau Giay, HN", new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhà phân phối độc quyền các thương hiệu đồng hồ, kính mắt, bút ký nổi tiếng thế giới: Epos Swiss, Atlantic Swiss, Diamond D, Philippe Auguste, Jacques Lemans, Citizen, Aries Gold, dây da đồng hồ, dây đồng hồ đeo tay....", "Dangquang.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18006005", true, "Dang Quang Watch" },
                    { 3, "Ha Noi", new DateTime(2018, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khởi đầu với một cửa hàng nằm trên phố Tuệ Tĩnh, Hà Nội từ năm 2003, vượt qua nhiều thách thức gian nan, đến nay Galle Watch đã có thể hoàn toàn tự hào khi trở thành hệ thống phân phối đồng hồ hàng đầu Việt Nam. Với mong muốn mang lại cho khách hàng những sản phẩm chính hãng cùng dịch vụ sau bán hàng đạt tiêu chuẩn 4 sao, Galle Watch đang ngày càng nỗ lực để hoàn thiện và nâng cao chất lượng dịch vụ của mình.", "gallewatch.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19006000", true, "Galle Watch" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreateOn", "Id", "ModifyDate", "PostId", "Publish", "UserId", "WatchId" },
                values: new object[,]
                {
                    { 2, "Nhưng bạn cần viết nhiều hơn về lợi ích, ví dụ như nó giúp người dùng tự tin hơn trong giao tiếp, nâng cao chất lượng sống, giảm nguy cơ mắc bệnh tim mạch, tiểu đường… Lợi ích của sản phẩm sẽ có hiệu quả tốt hơn khi bạn muốn thuyết phục khách hàng!", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 1, "Tất cả các sản phẩm trên thị trường đều có điểm tốt và hạn chế. Do đó để viết bài review hiệu quả bạn cần nhớ KHÔNG CÓ GÌ LÀ HOÀN HẢO!", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "408aa945-3d84-4421-8342-7269ec64d949", null }
                });

            migrationBuilder.InsertData(
                table: "RateAccounts",
                columns: new[] { "RateId", "CreateOn", "Id", "ModifyDate", "PostId", "Rate", "StoreId", "UserId", "WatchId" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3.0, null, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 7, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2.0, null, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 8, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3.0, null, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 9, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3.0, null, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 12, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2.0, null, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.0, 1, "408aa945-3d84-4421-8342-7269ec64d949", null },
                    { 2, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5.0, 2, "408aa945-3d84-4421-8342-7269ec64d949", null }
                });

            migrationBuilder.InsertData(
                table: "Watchs",
                columns: new[] { "WatchId", "BrandId", "CategoryId", "CreateOn", "Description", "Image", "InsuranceDate", "ModifyDate", "Price", "Status", "StoreId", "WatchName" },
                values: new object[,]
                {
                    { 4, 4, 3, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "dong-ho-nam3.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300000000.0, true, 3, "Đồng Hồ Hublot Classic Fusion Chronograph Titanium Automatic Black Dial Men's Watch" },
                    { 8, 8, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "dong-ho-nam6.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65000000.0, true, 2, "Đồng hồ Jacques Lemans JL - 1 - 1830A" },
                    { 6, 6, 3, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "QQdoi.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40000000.0, true, 2, "Đồng hồ Q&Q QQ-S278J102Y + QQ-S279J102Y" },
                    { 1, 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "bovet6.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 450000000.0, true, 1, "Đồng hồ cao cấp Bovet AS36001SD12" },
                    { 2, 2, 1, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "dong-ho-nam1.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50000000.0, true, 1, "ĐỒNG HỒ PHILIPPE AUGUSTE PA2022" },
                    { 5, 5, 1, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "dong-ho-nam4.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000000.0, true, 3, "Đồng hồ Bruno sohnle 17-13153-241" },
                    { 3, 3, 1, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "dong-ho-nam2.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23000000.0, true, 2, "Đồng hồ Aries Gold AG-L5033Z G-W" },
                    { 7, 7, 1, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "dong-ho-nam5.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000000.0, true, 3, "ĐỒNG HỒ PHILIPPE AUGUSTE PA-555.2" }
                });

            migrationBuilder.InsertData(
                table: "DetailWatchs",
                columns: new[] { "Id", "Diameter", "Facematerial", "Style", "Warranty", "WatchID", "Waterproof", "WireMaterial" },
                values: new object[,]
                {
                    { 1, 36, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nữ", null, 1, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 2, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 2, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 3, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 3, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 6, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 6, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 8, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 8, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 4, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 4, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 5, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 5, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" },
                    { 7, 40, "Sapphire mặt trong đính 4 viên kim cương cọc số", "Đồng hồ nam", null, 7, true, "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )" }
                });

            migrationBuilder.InsertData(
                table: "RateAccounts",
                columns: new[] { "RateId", "CreateOn", "Id", "ModifyDate", "PostId", "Rate", "StoreId", "UserId", "WatchId" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3.0, null, "408aa945-3d84-4421-8342-7269ec64d949", 1 },
                    { 4, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.0, null, "408aa945-3d84-4421-8342-7269ec64d949", 2 },
                    { 5, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.0, null, "408aa945-3d84-4421-8342-7269ec64d949", 3 },
                    { 10, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.0, null, "408aa945-3d84-4421-8342-7269ec64d949", 4 },
                    { 11, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4.0, null, "408aa945-3d84-4421-8342-7269ec64d949", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Id",
                table: "Comments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WatchId",
                table: "Comments",
                column: "WatchId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailWatchs_WatchID",
                table: "DetailWatchs",
                column: "WatchID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Id",
                table: "Posts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RateAccounts_Id",
                table: "RateAccounts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RateAccounts_PostId",
                table: "RateAccounts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_RateAccounts_StoreId",
                table: "RateAccounts",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_RateAccounts_WatchId",
                table: "RateAccounts",
                column: "WatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchs_BrandId",
                table: "Watchs",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchs_CategoryId",
                table: "Watchs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchs_StoreId",
                table: "Watchs",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DetailWatchs");

            migrationBuilder.DropTable(
                name: "RateAccounts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Watchs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
