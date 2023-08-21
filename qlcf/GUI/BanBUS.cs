using System.Data;
using System.Data.SqlClient;

namespace qlcf.GUI
{
    class BanBUS
    {
        // Chuỗi kết nối đến CSDL, thay đổi nó để phù hợp với CSDL của bạn.
        private string connectionString = "Data Source=DESKTOP-UUUE2ME;Initial Catalog=qlcf;Integrated Security=True";

        // Lấy danh sách các bàn từ CSDL và trả về DataTable
        internal DataTable LayDanhSachBan()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Ban"; // Thay thế "Ban" bằng tên bảng tương ứng trong CSDL của bạn.
                SqlCommand command = new SqlCommand(query, connection);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                return dt;
            }
        }

        // Sửa thông tin bàn trong CSDL
        internal void SuaBan(string banID, string maBan, string tenBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Ban SET MaBan = @maBan, TenBan = @tenBan WHERE BanID = @banID"; // Thay thế "Ban" bằng tên bảng tương ứng và cột tương ứng trong CSDL của bạn.

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maBan", maBan);
                command.Parameters.AddWithValue("@tenBan", tenBan);
                command.Parameters.AddWithValue("@banID", banID);

                command.ExecuteNonQuery();
            }
        }
    }
}
