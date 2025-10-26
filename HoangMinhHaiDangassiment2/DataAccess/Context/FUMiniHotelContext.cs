using Microsoft.EntityFrameworkCore;
using BusinessObject;

namespace DataAccess.Context
{
    public class FUMiniHotelContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // ⚙️ Chuỗi kết nối - đổi "localhost" nếu bạn dùng tên SQL khác
                optionsBuilder.UseSqlServer("Server=localhost;Database=FUMiniHotelManagement;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
