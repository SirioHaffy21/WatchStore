using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class StoreSeedData : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(
                new Store
                {
                    StoreId=1,
                    StoreName="Dang Quang Watch",
                    Status=true,
                    Address="Tran Dang Ninh, Cau Giay, HN",
                    Description= "Nhà phân phối độc quyền các thương hiệu đồng hồ, kính mắt, bút ký nổi tiếng thế giới: Epos Swiss, Atlantic Swiss, Diamond D, Philippe Auguste, Jacques Lemans, Citizen, Aries Gold, dây da đồng hồ, dây đồng hồ đeo tay....",
                    Image= "Dangquang.jpg",
                    CreateOn = new System.DateTime(2021, 12, 11),
                    Phone ="18006005",
                },
                   new Store
                   {
                       StoreId = 2,
                       StoreName = "Hai Trieu Watch",
                       Status = true,
                       Address = "Ho Chi Minh",
                       Description = "Đồng Hồ Hải Triều, hệ thống đồng hồ chính hãng tại Việt Nam. Nơi phân phối 15.000+ mẫu đồng hồ mới nhất từ hơn 22 thương hiệu nổi tiếng thế giới. Trải nghiệm mua sắm ngay hôm nay",
                       Image = "haitrieu.jpg",
                       Phone = "19006777",
                       CreateOn = new System.DateTime(2020, 02, 10)
                   },
                    new Store
                    {
                        StoreId = 3,
                        StoreName = "Galle Watch",
                        Status = true,
                        Address = "Ha Noi",
                        Description = "Khởi đầu với một cửa hàng nằm trên phố Tuệ Tĩnh, Hà Nội từ năm 2003, vượt qua nhiều thách thức gian nan, đến nay Galle Watch đã có thể hoàn toàn tự hào khi trở thành hệ thống phân phối đồng hồ hàng đầu Việt Nam. Với mong muốn mang lại cho khách hàng những sản phẩm chính hãng cùng dịch vụ sau bán hàng đạt tiêu chuẩn 4 sao, Galle Watch đang ngày càng nỗ lực để hoàn thiện và nâng cao chất lượng dịch vụ của mình.",
                        Image = "gallewatch.jpg",
                        Phone = "19006000",
                        CreateOn = new System.DateTime(2018, 02, 10)
                    }
                ); ;
        }
    }
}
