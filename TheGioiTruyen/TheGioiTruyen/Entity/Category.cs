namespace TheGioiTruyen.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }//ten the loai
        public string Quantity { get; set; }//soluong
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
