
using static TheGioiTruyen.Config.Extensions;

namespace TheGioiTruyen.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Username { get; set; }
        public string Contact { get; set; }
        public Role Role { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
