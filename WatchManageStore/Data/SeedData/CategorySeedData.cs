using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {

                    CategoryId = 1,
                    CategoryName = "Đồng hồ nam"
                },
                   new Category
                   {

                       CategoryId = 2,
                       CategoryName = "Đồng hồ nữ"
                   },
                    new Category
                    {

                        CategoryId = 3,
                        CategoryName = "Đồng hồ đôi"
                    }
                ); ;
        }
    }
}
