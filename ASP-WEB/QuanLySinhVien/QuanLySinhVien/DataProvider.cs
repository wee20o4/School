using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public class DataProvider
    {
        const string connstring = "Data Source=CUONGKUTE\\SQLEXPRESS;Initial Catalog=BT_Tuan7_QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static List<DangNhap> dangNhaps = new List<DangNhap>();

        public static void OpenConnection()
        {
            connection = new SqlConnection(connstring);
            connection.Open();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static void GetAllDangNhap()
        {
            try
            {
                OpenConnection();
                string sql = "select * from DangNhap";
                SqlCommand command = new SqlCommand(sql,connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.TenDangNhap = reader["TenDangNhap"].ToString();
                    dangNhap.MatKhau = reader["MatKhau"].ToString();
                    dangNhap.HoTen = reader["HoTen"].ToString();
                    dangNhap.Quyen = reader["Quyen"].ToString();
                    dangNhaps.Add(dangNhap);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            
        }

        public static DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public static int ThaoTacCSDL(string sql)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                kq= sqlCommand.ExecuteNonQuery();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                CloseConnection();
            }

            return kq;
        }
    }
}
