﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Ideas : Form
    {
        //
        //Fields
        //
        private Button CurrentButton;
        private Panel ButtonPanel;
        public Ideas()
        {
            InitializeComponent();
            ButtonPanel = new Panel();
            ButtonPanel.Size = new Size(5, 60);
            LeftPanel.Controls.Add(ButtonPanel);
            ideaButton();
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

        private void IdeasButton_Click(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
        }

        private void ideaButton()
        {
            //Button
            CurrentButton = IdeasButton;
            CurrentButton.TextAlign = ContentAlignment.MiddleRight;
            //Border
            ButtonPanel.BackColor = Color.AliceBlue;
            ButtonPanel.Location = new Point(0, CurrentButton.Location.Y);
            ButtonPanel.Visible = true;
            ButtonPanel.BringToFront();
        }

        private void AccountButton_Click_1(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Account().Show();
            this.Hide();
        }

        private void ClientListButton_Click_1(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new ClientList().Show();
            this.Hide();
        }

        private void RegistrationButton_Click_1(object sender, EventArgs e)
        {
            ButtonActivated(sender, Color.AliceBlue);
            new Registration().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Ideas";
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet dsIdea= dbConn.getDataSet(query);
            dgvIdeas.DataSource = dsIdea.Tables[0];
        }

        private void dgvIdeas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
