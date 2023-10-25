using System.Data;
using System.Data.SqlClient;

namespace BikeStoreManagement
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void createConnection()
        {
            // thong tin ket noi
            try
            {
                /** 
                 * tao chuoi ket noi 
                 * Server={Ten server may cua minh};Database={Ten CSDL su dung};Integrated Security = true
                 * 
                 */
                String stringConnection = "Server=HANGOCLINH45AC;Database=BikeStores;Integrated Security = true";
                // tao ket noi 
                conn = new SqlConnection(stringConnection);
                // khoi tao command
                cmd = new SqlCommand();
                // set Connection cho command
                cmd.Connection = conn;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra trong qua trinh ket noi " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            createConnection();
            displayData();
        }

        private void displayData()
        {
            // Mo ket noi
            conn.Open();
            // khoi tao command tu SQL Server connection 
            SqlCommand cmd = conn.CreateCommand();
            // Khai bao loai command
            cmd.CommandType = System.Data.CommandType.Text;
            // khai bao cau query 
            String sql = "SELECT * FROM customers";
            // Gan query cho command
            cmd.CommandText = sql;
            // chay command
            cmd.ExecuteNonQuery();
            // Khoi tao datatable de hien thi du lieu
            DataTable dt = new DataTable();
            // gan data vao sql Adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // day du lieu vao data grid view
            dgv.DataSource = dt;
            conn.Close();
        }

    }
}