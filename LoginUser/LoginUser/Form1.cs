using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LoginUser
{
    public partial class Form1 : Form
    {
        private User userManager;

        public Form1()
        {
            InitializeComponent();
            userManager = new User();
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\Brave\\source\\repos\\LoginUser\\LoginUser\\users.json");
            userManager.LoadUsersFromJson(jsonFilePath);
            LogInButton.Click += new EventHandler(btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = User.Text;
            string password = password1.Text;

            if (userManager.IsValid(username, password))
            {
                label4.Text = "Login successful! Welcome!!!!";
            }
            else
            {
                label4.Text = "Invalid username or password.";
            }
        }
    }
}
