namespace TheGioiTruyen.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Status { get; set; }//mota ngan
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
        public string Author {  get; set; }//tac gia
        public DateTime PublishDate { get; set; }//xuat ban ngay
        public int CategoryId { get; set; }// the loai
        public int View { get; set; } = 0;
        public string Avatar {  get; set; }
        public DateTime CreatedTime { get; set; }//ngay tao
        public DateTime UpdatedTime { get; set; }// ngay cai tien
        public bool Follow {  get; set; }
        public int FollowedBy { get; set; }
    }
}
