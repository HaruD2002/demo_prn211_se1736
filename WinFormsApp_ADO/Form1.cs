using System.Data;
using System.Data.SqlClient;
using WinForm_ADO;

namespace WinFormsApp_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataProvider DataProvider = new DataProvider();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            loadtCustomer1();

        }

        //su dung select with param
        private void loadtCustomer1()
        {
            string sql = "Select * from Customers";

            using (IDataReader reader = DataProvider.executeQuery2(sql))
            {
                List<Customer> c = new List<Customer>();

                while (reader.Read())
                {
                    string id = reader.GetInt32(0).ToString();
                    string name = reader.GetString(1);
                    string DOB = reader.GetDateTime(2).ToString();
                    string gender = reader.GetBoolean(3) ? "Male" : "Female";
                    string address = reader.GetString(4);
                    Customer customer = new Customer(id, name, DOB, gender, address);
                    c.Add(customer);
                }
                dgView.DataSource = c;
            }
        }

        private void LoadCustomer()
        {
            return;
            string sql = "Select * from Customers";
            DataTable dt = DataProvider.executeQuery(sql);
            dgView.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIds.Text = dgView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtAddress.Text = dgView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            if (dgView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("Male"))
            {
                rMale.Checked = true;
            }
            else
            {
                rFemale.Checked = true;
            }
            txtDOB.Text = dgView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from Customers where CustomerID=@id";

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@id",txtIds.Text)
            };

            if (DataProvider.executeNonQuery(sql, sp))
            {
                MessageBox.Show("delete success");
                LoadCustomer();
                ResetForm();
            }

        }

        private void ResetForm()
        {
            txtIds.Text = "";
            txtAddress.Text = "";
            txtName.Text = "";
            txtDOB.Text = "";
            rMale.Checked = false;
            rFemale.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO Customers(CustomerName,Birthdate,Gender,Address)VALUES(@name,@dob,@gender,@address)";
            string gender = "True";
            if (rFemale.Checked)
            {
                gender = "false";
            }
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@dob",txtDOB.Text),
                new SqlParameter("@gender",gender),
                new SqlParameter("@address",txtAddress.Text)
            };
            if (DataProvider.executeNonQuery(sql, sp))
            {
                MessageBox.Show("add successful");
                LoadCustomer();
                ResetForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"	UPDATE [Customers]
	                        SET [CustomerName] = @name
		                        ,[Birthdate] = @dob
		                        ,[Gender] = @gender
		                        ,[Address] = @addess
	                            WHERE @id";
            string gender = "True";
            if (rFemale.Checked)
            {
                gender = "false";
            }
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@dob",txtDOB.Text),
                new SqlParameter("@gender",gender),
                new SqlParameter("@addess",txtAddress.Text),
                new SqlParameter("@id",txtIds.Text),
            };

            if (DataProvider.executeNonQuery(sql, sp))
            {
                MessageBox.Show("update successful");
                LoadCustomer();
                ResetForm();
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //  khi delete check id co ton tai hay ko
        //  nhap random idM them nut search thi hien ra customer voi id o dgView\
        //  nhap vao name bat ki xong search hien thi ra o dgView
        //  
    }
}