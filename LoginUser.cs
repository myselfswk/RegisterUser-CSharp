using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegisterUser_CSharp
{
    public partial class LoginUser : Form
    {
        SqlConnection conn;
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=RegisterUser;Integrated Security=True");

                string credentials = "select * from [RegisterUser].[dbo].[User] where [username] = '"+ txtUsername.Text +"' and [password] = '"+ txtPassword.Text +"'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(credentials, conn);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Check Your Username and password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
