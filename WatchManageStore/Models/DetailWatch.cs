using System.ComponentModel.DataAnnotations.Schema;

namespace WatchManageStore.Models
{
    public class DetailWatch
    {
        public int Id { get; set; }
        public int WatchID { get; set; }

        [ForeignKey("WatchID")]
        public Watch Watch { get; set; }
        public int Diameter { get; set; }//đường kính
        public bool Waterproof { get; set; } //chống nước
        public string Facematerial{ get; set; } //chất liệu mặt
        public string WireMaterial { get; set; } //chất liệu dây
        public string Style { get; set; } //kiểu dáng .nam/nữ
        public string Warranty { get; set; } // chế độ bảo hành, mấy năm
    }
}
