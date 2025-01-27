using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Account : Form
    {
        //
        //Fields
        //
        private Button CurrentButton;
        private Panel ButtonPanel;
      //  private readonly object Connection_String;

        public Account()
        {
            InitializeComponent();
            ButtonPanel = new Panel();
            ButtonPanel.Size = new Size(5, 60);
            LeftPanel.Controls.Add(ButtonPanel);
            accountButton();
        }

        private void ButtonActivated(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                ButtonDisabled();
                //Button
                CurrentButton = (Button)senderBtn;
                CurrentButton.TextAlign = ContentAlignment.MiddleRight;
                //Border
                ButtonPanel.BackColor = color;
                ButtonPanel.Location = new Point(0, CurrentButton.Location.Y);
                ButtonPanel.Visible = true;
                ButtonPanel.BringToFront();
            }
        }

        private void ButtonDisabled()
        {
            if (CurrentButton != null)
            {
                CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
        }

        private void ClientListButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new ClientList().Show();
            this.Hide();
        }

        private void IdeasButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Ideas().Show();
            this.Hide();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Registration().Show();
            this.Hide();
        }

        private void accountButton()
        {
            //Button
            CurrentButton = AccountButton;
            CurrentButton.TextAlign = ContentAlignment.MiddleRight;
            //Border
            ButtonPanel.BackColor = Color.AliceBlue;
            ButtonPanel.Location = new Point(0, CurrentButton.Location.Y);
            ButtonPanel.Visible = true;
            ButtonPanel.BringToFront();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }



        private void textBoxRegName_TextChanged(object sender, EventArgs e)
        {

        }

        private class SqlConnection
        {
            private object connection_String;

            public SqlConnection()
            {
            }

            public SqlConnection(object connection_String)
            {
                this.connection_String = connection_String;
            }
        }

        //   private void label5_Click(object sender, EventArgs e)
        ///    {
        //       var st = from s in DBConnection select s;

        //   }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        public void loadRmData(string name, string email, string role,string phoneNum)
        {
            textboxEmail.Text = email;
            textBox1.Text = name;
            textboxNumber.Text = phoneNum;
            textboxRole.Text = role;

        }

        private void textboxRole_TextChanged(object sender, EventArgs e)//role
        {

        }

        private void textboxEmail_TextChanged(object sender, EventArgs e)//email
        {

        }

        private void textboxNumber_TextChanged(object sender, EventArgs e)//phone number
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//name
        {

        }
    }
}
