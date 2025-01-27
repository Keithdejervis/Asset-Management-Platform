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

namespace GUI
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UserEmailTextBox.ForeColor = Color.Black;
            }
            catch { }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PasswordTextBox.ForeColor = Color.Black;
            }
            catch { }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            String email, password, role;

            email = UserEmailTextBox.Text;
            password = PasswordTextBox.Text;

            
                role = dbConn.validateLogin(email, password);
                DataSet account1 = dbConn.getDataSet("SELECT * from Account where email = '" + email + "'");

                string name = account1.Tables[0].Rows[0]["Name"].ToString();
                string emailRM = account1.Tables[0].Rows[0]["Email"].ToString();
                string roleRM = account1.Tables[0].Rows[0]["Role"].ToString();
                string phoneNum = account1.Tables[0].Rows[0]["Phone Number"].ToString();

                if (role == "RM")
                {
                    RM rm = new RM();
                    rm.Show();
                    this.Hide();
                    Account obj = new Account();
                    obj.loadRmData(name, emailRM, roleRM, phoneNum);
                }
                else if (role == "AI")
                {
                    AuthorIdea ai = new AuthorIdea();
                    ai.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your credentials don't match. \n Email or Password are wrong");
                }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       // private void ForgotPasswordButton_Click(object sender, EventArgs e)
       // {
       //     forgotPassword newForm = new forgotPassword();
       //     newForm.Show();
       //     this.Hide();
       // }
    }
}
