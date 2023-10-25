using System.Data;
using System.Data.SqlClient;

namespace BikeStoreManagement
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        int choosenId;
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
            String sql = "SELECT * FROM customers ORDER BY customer_id DESC";
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

        private void createNewCustomer()
        {
            try
            {
                String sql = "INSERT INTO customers (first_name, last_name, phone, email, street, city, state, zip_code)"
                    + " VALUES (@first_name, @last_name, @phone, @email, @street, @city, @state, @zip_code)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar);
                cmd.Parameters["@first_name"].Value = tbFirstName.Text.ToString();

                cmd.Parameters.Add("@last_name", SqlDbType.VarChar);
                cmd.Parameters["@last_name"].Value = tbLastName.Text.ToString();

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = tbPhone.Text.ToString();

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbEmail.Text.ToString();

                cmd.Parameters.Add("@street", SqlDbType.VarChar);
                cmd.Parameters["@street"].Value = tbStreet.Text.ToString();

                cmd.Parameters.Add("@city", SqlDbType.VarChar);
                cmd.Parameters["@city"].Value = tbCity.Text.ToString();

                cmd.Parameters.Add("@state", SqlDbType.VarChar);
                cmd.Parameters["@state"].Value = tbState.Text.ToString();

                cmd.Parameters.Add("@zip_code", SqlDbType.VarChar);
                cmd.Parameters["@zip_code"].Value = tbZipCode.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them moi thanh cong!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi trong qua trinh tao " + ex.Message);
            }
        }

        private void deleteCustomer()
        {  
            try
            {
                // tao cau query voi param @choosenId
                String sql = "DELETE FROM customers WHERE customer_id = @choosenId";
                cmd.CommandText = sql;
                // khai bao params va gia tri trong command
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                // chay query
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Xoa Thanh Cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra " + ex.Message);
            }
                    
        }

        // xoa form thong tin
        private void clearForm()
        {
            tbCity.Text = "";
            tbStreet.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbState.Text = "";
            tbZipCode.Text = "";
        }

        // xoa form thong tin va get lai data
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
            displayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewCustomer();
        }

        /**
         * on click Cell
         * fdsf
         * @params
         */
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                tbFirstName.Text = row.Cells["first_name"].Value.ToString();
                tbLastName.Text = row.Cells["last_name"].Value.ToString();
                tbPhone.Text = row.Cells["phone"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
                tbStreet.Text = row.Cells["street"].Value.ToString();
                tbCity.Text = row.Cells["city"].Value.ToString();
                tbState.Text = row.Cells["state"].Value.ToString();
                tbZipCode.Text = row.Cells["zip_code"].Value.ToString();
                lbChoosenId.Text = "Ban da chon customer Id = " + choosenId;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (choosenId > 0)
            {
                DialogResult re = MessageBox.Show("Ban co muon xoa customer id = " + choosenId + "?", "Xac nhan", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    deleteCustomer();
                }
            }
        
            else
            {
                MessageBox.Show("Hay chon customer can xoa");
            }
        }
    }
}