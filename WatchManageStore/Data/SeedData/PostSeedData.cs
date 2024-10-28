using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class PostSeedData : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post
                {
                    PostId=1,
                    UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                    Title = "Bùng nổ ưu đãi 08/03 : Giảm giá lên tới 30% và hoàn tiền 100% giá trị hóa đơn tại Đăng Quang Watch",
                    Content= "Nhân ngày Quốc tế phụ nũ 08/03 Đăng Quang Watch đã cập nhật hàng ngàn mẫu đồng hồ mới nhất, trend nhất dành riêng cho phái đẹp cùng chương trình khuyến mại đặc biệt: Giảm giá lên tới 30% và hoàn tiền 100% giá trị hóa đơn mua hàng"+
                    "Đồng hồ đeo tay chính là món phụ kiện giúp chị em phụ nữ hiện đại thể hiện phong cách thời trang và vẻ ngoài thanh lịch của mình, hơn nữa còn là vật dụng vô cùng hữu ích và cần thiết trong đời sống hàng ngày."+
                    "Đồng hồ là biểu trưng cho thời gian. Khi làm quà tặng cho người mà mình trân quý, đồng hồ mang thông điệp tình cảm người tặng dành cho họ là bất diệt, không phai tàn theo thời gian."  +"Nhiều mẫu đồng hồ đẹp có thể làm quà tặng 08/03 ý nghĩa đang có sẵn tại hệ thống gần 100 showroom Đăng Quang Watch.Trong đó, một số thương hiệu đang được nhiều người yêu thích như Diamond D, Aries Gold, Epos, Atlantic, Bruno Sohnle Glashutte, Citizen, Q&Q... Với chế độ bảo hành quốc tế, xuất hoá đơn đỏ, giấy tờ hải quan chứng minh nguồn gốc xuất xứ sản phẩm, khách hàng hoàn toàn có thể yên tâm sử dụng cũng như tin tưởng lựa chọn làm món quà tặng ý nghĩa cho người thân yêu."
                    + "Ngoài các sản phẩm đồng hồ với thiết kế sang trọng, tinh tế, trẻ trung khách hàng có thể lựa chọn quà tặng là những sản phẩm kính mắt đến từ Kính Mắt Đăng Quang với thiết kế vô cùng năng động và cá tính."
                    + "Kể từ ngày 01/03 đến 15/03/2022 Đăng Quang Watch tặng ngay ưu đãi giảm giá lên tới 30% cùng cơ hội quay số may mắn hoàn tiền 100% giá trị hóa đơn khi mua sắm đồng hồ trong dịp này. Để tham gia chương trình, khi mua hàng khách hàng chỉ cần điền đầy đủ thông tin vào hóa đơn. Trong đó, mã số tham dự quay giải chính là 4 số cuối số điện thoại của khách hàng. Chương trình sẽ dùng kết quả xổ số miền Bắc quay thưởng ngày 16/03/2022 làm căn cứ trao giải. Khách hàng may mắn 4 số cuối điện thoại cuối trùng với giải đặc biệt sẽ trở thành khách hàng may mắn nhất được hoàn lại 100% giá trị hóa đơn."
                    ,
                    Status =true,
                    CreateOn= new System.DateTime(2022, 02, 01),
                    Image1= "noi-bat-movado.png",
       
                },
                   new Post
                   {
                       PostId = 2,
                       UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                       Title = "ĐỒNG HỒ "+"MÃNH HỔ"+"PHIÊN BẢN GIỚI HẠN - CHÀO ĐÓN NHÂM DẦN",
                       Content = "Mãnh Hổ được xem là biểu tượng của sức mạnh, quyền uy, sự thăng tiến trong học hành và kinh doanh. Trong dân gian con Hổ còn được coi là linh vật giám hộ hướng Tây, đầy uy lực, linh thiêng và được thờ phụng rất nhiều, bảo vệ cho gia chủ, đảm bảo tiền tài, sức khoẻ cho các thành viên trong gia đình."
                       + "Đồng hồ Mãnh Hổ PA2022 phiên bản giới hạn chỉ 100 chiếc trên toàn cầu. Với mặt số được trang trí nổi bật biểu tượng con Hổ dũng mãnh - linh vật của năm. Thiết kế bộ kim màu vàng sang đẹp mắt và phần vò gắn kim cương nhân tạo tăng lên sự quyền lực, phú quý cho sản phẩm này."
                       + "Đồng hồ Philippe Auguste là thương hiệu xuất xứ Châu Âu và được Đăng Quang Watch phân phối độc quyền tại Việt Nam. Với mã sản phẩm PA2022 phiên bản giới hạn toàn cầu chỉ có 100 chiếc là một thiết kế đặc biệt dành riêng cho năm 2022. Được trang bị mặt kính Saphire với khả năng chống xước tốt kết hợp chất liệu vỏ thép không gỉ được mạ công nghệ PVD tiên tiến." ,
                      
                       Status = true,
                       CreateOn = new System.DateTime(2022, 01, 01),
                       Image1 = "noi-bat-versace.png",

                   },
                    new Post
                    {
                        PostId = 3,
                        UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                        Title = "Phillipe Auguste – Đẳng cấp quý ông Châu Âu",
                        Content = "Bắt nguồn từ câu chuyện về hoàng đế Philippe Auguste (Philipe II) - Quốc vương đầu tiên của nước Pháp với tham vọng gây dựng đế chế cho riêng mình. Ông đã trải qua hơn hai thập kỷ chiến đấu, mở rộng lãnh thổ nhằm củng cố vương vị, quyền lực và sức mạnh. Nhờ tài trí, mưu lược, Philippe Auguste đã biến Pháp từ một đất nước phong kiến nhỏ bé trở thành quốc gia thịnh vượng và hùng mạnh ở châu Âu."
                        + "Đồng hồ Philippe Auguste là biểu tượng của tham vọng, bản lĩnh, sức mạnh và khát khao thành công, khẳng định giá trị bản thân, những yếu tố không thể thiếu của người đàn ông trong cuộc sống hiện đại."
                        + "Dòng sản phẩm Philippe Auguste định hướng dành riêng cho khách hàng nam giới yêu thích đồng hồ với phân khúc giá trung bình từ 4 - 20 triệu đồng. Với những thiết kế hợp “gu” khách hàng, Philippe Auguste ngày càng khẳng định vị trí thương hiệu của mình.Mùa đông năm nay,"
                       +" Philippe Auguste đã cho ra mắt BST mới với sự mới mẻ hơn về thiết kế.Không chỉ giữ nguyên những nét đẹp cổ điển tinh tế,"
                       +" với BST lần này Philippe Auguste đã ra mắt rất nhiều mẫu sản phẩm đồng hồ pin với phong cách năng động hơn,"
                        +"thể thao hơn cho các anh trai.",
                       
                        Status = true,
                        CreateOn = new System.DateTime(2021, 10, 01),
                        Image1 = "noi-bat-zenith.png",
                    },
                    new Post
                    {
                        PostId = 4,
                        UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                        Title = "EPOS - Tinh hoa nghệ thuật của đồng hồ Thụy Sỹ",
                        Content = "Epos nằm trong trong top 10 hãng đồng hồ độc lập uy tín nhất trong ngành đồng hồ Thụy Sĩ. Những chiếc đồng hồ được sản xuất thủ công với bí quyết lâu đời đã tạo ra những chiếc đồng hồ tuyệt vời."
                        + "Trong những năm 80 của thế kỷ trước, khi mà ngành công nghiệp đồng hồ Thụy Sĩ truyền thống trở nên bế tắc vì không thể cạnh tranh nổi với những đồng hồ Quartz đang làm mưa làm gió trên thị trường. Peter Hofer - một chuyên gia đầy kinh nghiệm trong sản xuất đồng hồ Thụy Sĩ, ông và vợ ông Erna quyết định thành lập công ty của riêng mình năm 1983: Montres EPOS SA. Tài sản chính của họ là một niềm đam mê đối với đồng hồ cơ khí và một bí quyết kỹ thuật trong lĩnh vực này."
                        + "Ngay từ đầu, EPOS đã là một thương hiệu cơ khí với những đổi mới thú vị. Trong những năm qua, EPOS vẫn trung thành với lựa chọn của mình, phát triển bộ sưu tập đồng hồ tuyệt đẹp kết hợp các cơ hấp dẫn."
                        +"Đạt được danh tiếng trên toàn thế giới qua nhiều thế kỷ,nhờ tinh thần tiên phong và ý nghĩ độc đáo trong sự gia công hoàn hảo của đồng hồ.Đồng hồ Thụy Sỹ EPOS đã trở thành một người giám hộ,là thước đo của các giá trị truyền thống và các tiêu chuẩn cao."
                        ,
                        Status = true,
                        CreateOn = new System.DateTime(2021, 10, 01),
                        Image1 = "onghokimnguu2.jpg",
                    },
                    new Post
                    {
                        PostId = 5,
                        UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                        Title = "Hướng dẫn cách chỉnh dây cót đồng hồ automatic",
                        Content = "Thông thường các dòng đồng hồ Automatic vẫn được tích hợp thêm chức năng Handwinding vì thế những thông tin dưới đây sẽ là tổng hợp cả hai dòng đồng hồ trên. Có khá nhiều cách để lên dây cót cho đồng hồ Automatic từ đơn giản đến phức tạp. Không để anh em phải chờ lâu thêm nữa, dưới đây sẽ là những thông tin hướng dẫn lên dây cót đồng hồ."
                       + "Chuyển động cánh tay đeo đồng hồ Khá đơn giản đúng không nào. Tuy nhiên, nhiều anh em lại nghĩ cánh tay phải chuyển động liên tục thì mới có thể lên dây cót đồng hồ nhưng không, sự tinh xảo trong thiết kế sẽ giúp đồng hồ lên dây cót khi anh em hoạt động thương ngày. Khi anh em đeo đồng hồ và hoạt động bình thường thì chiếc đồng hồ của anh em đã được nạp năng lượng và cho sự hoạt động ổn định nhất. Còn một lời khuyên nữa cho anh em đó chính là không nên vận động quá mạnh ví dụ khi chơi bóng đá, cầu lông, tenis,… vì những va đập có thể ảnh hưởng đến khả năng lên dây cót của đồng hồ."
                       + "Để đảm bảo chiếc đồng hồ Automatic hoạt động bình thường ( ngay cả vào ban đêm khi không sử dụng ) thì anh em nên đeo ít nhất 8 tiếng 1 ngày.Lên dây cót đồng hồ bằng núm vặn Như đã nói,đồng hồ cơ Automatic hiện nay còn được tích hợp thêm chức năng lên dây cót bằng tay.Đối với những dòng đồng hồ như thế này,anh em chỉ việc tác động một lực vừa để vặn núm điều chỉnh(không nên vặn quá căng).Nếu tỉ mỉ thì anh em có thể vặn từ 15 đến 20 vòng là đẹp nhất."
                        ,
                        Status = true,
                        CreateOn = new System.DateTime(2021, 10, 10),
                        Image1 = "noi-bat-versace.png",
               
                    }
                ); 
        }
    }
}

