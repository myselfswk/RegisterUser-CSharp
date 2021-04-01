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
    public partial class RegisterUser : Form
    {
        SqlConnection conn;
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=RegisterUser;Integrated Security=True");
                SqlCommand command = new SqlCommand();

                command.CommandText = "Insert into [User](username, password) Values('" + txtUsername.Text +"', '"+ txtPassword.Text +"')";
                command.Connection = conn;

                conn.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Entered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
