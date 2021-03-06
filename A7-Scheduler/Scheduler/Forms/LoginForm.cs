﻿using System.Windows.Forms;

namespace Scheduler
{
    public partial class LoginForm : Form
    {
        private string password = "1234";

        private CalendarForm calForm;
        private AdminForm adminForm;
        

        public LoginForm()
        {
            InitializeComponent();
        }

        public void Open(CalendarForm calForm)
        {
            this.calForm = calForm;

            this.Show();
            PasswordInput_Login.Focus();
        }

        /// <summary>
        /// Validates if the inputted password is correct or not
        /// If correct: open a new admin form. Else: do nothing
        /// </summary>
        private void Login_Login_Click(object sender, System.EventArgs e)
        {
            if (PasswordInput_Login.Text == password)
            {
                if (adminForm != null)
                    adminForm.Close();

                adminForm = new AdminForm();
                adminForm.Open(calForm);

                this.Close();
            }
            else
            {
                PasswordInput_Login.Text = "";
                PasswordStatus_Login.Visible = true;
            }
        }
    }
}
