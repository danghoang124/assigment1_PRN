using System;
using System.Linq;
using DataAccess.Context;

namespace DataAccess
{
    public class TestDb
    {
        public static void Check()
        {
            try
            {
                using var db = new FUMiniHotelContext();
                Console.WriteLine("✅ Số lượng khách hàng hiện có: " + db.Customers.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
