using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{

    public class CommentSeedData : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment
                {

                   CommentId=1,
                    UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                    PostId=3,
                    Publish =true,
                    CreateOn = new System.DateTime(2022, 01, 01),
                    Content= "Tất cả các sản phẩm trên thị trường đều có điểm tốt và hạn chế. Do đó để viết bài review hiệu quả bạn cần nhớ KHÔNG CÓ GÌ LÀ HOÀN HẢO!",
                    
                },
                   new Comment
                   {
                       CommentId = 2,
                       UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                       PostId = 2,
                       Publish = true,
                       CreateOn = new System.DateTime(2022, 01, 01),
                       Content = "Nhưng bạn cần viết nhiều hơn về lợi ích, ví dụ như nó giúp người dùng tự tin hơn trong giao tiếp, nâng cao chất lượng sống, giảm nguy cơ mắc bệnh tim mạch, tiểu đường… Lợi ích của sản phẩm sẽ có hiệu quả tốt hơn khi bạn muốn thuyết phục khách hàng!"
                   }
                ); ;
        }
    }
}
