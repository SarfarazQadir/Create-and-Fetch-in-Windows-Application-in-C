using System.Data;
using System.Data.SqlClient;

namespace Create_and_Fetch
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;User=sa;Password=123456789;Database=CRUD_Operations_in_Windows");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student_Details Values ('" + id.Text + "','" + name.Text + "','" + age.Text + "','" + email.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.BeginExecuteNonQuery();
            conn.Close();
            ShowData();
            cleardata();
            MessageBox.Show("Data Inserted Successfully");
        }

        public void ShowData()
        {
            string query = "SELECT * FROM Student_Details ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
            cleardata();
        }
        public void cleardata()
        {
            id.Text = "";
            name.Text = "";
            age.Text = "";
            email.Text = "";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
