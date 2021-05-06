
namespace Scheduler
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password_Login = new System.Windows.Forms.Label();
            this.Login_Login = new System.Windows.Forms.Button();
            this.PasswordInput_Login = new System.Windows.Forms.TextBox();
            this.PasswordStatus_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password_Login
            // 
            this.Password_Login.AutoSize = true;
            this.Password_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Login.Location = new System.Drawing.Point(8, 5);
            this.Password_Login.Name = "Password_Login";
            this.Password_Login.Size = new System.Drawing.Size(90, 24);
            this.Password_Login.TabIndex = 0;
            this.Password_Login.Text = "Lösenord";
            // 
            // Login_Login
            // 
            this.Login_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Login.Location = new System.Drawing.Point(176, 32);
            this.Login_Login.Name = "Login_Login";
            this.Login_Login.Size = new System.Drawing.Size(92, 29);
            this.Login_Login.TabIndex = 1;
            this.Login_Login.Text = "Logga in";
            this.Login_Login.UseVisualStyleBackColor = true;
            this.Login_Login.Click += new System.EventHandler(this.Login_Login_Click);
            // 
            // PasswordInput_Login
            // 
            this.PasswordInput_Login.BackColor = System.Drawing.Color.White;
            this.PasswordInput_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordInput_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput_Login.Location = new System.Drawing.Point(12, 32);
            this.PasswordInput_Login.MaxLength = 16;
            this.PasswordInput_Login.Name = "PasswordInput_Login";
            this.PasswordInput_Login.PasswordChar = '*';
            this.PasswordInput_Login.Size = new System.Drawing.Size(158, 29);
            this.PasswordInput_Login.TabIndex = 9;
            // 
            // PasswordStatus_Login
            // 
            this.PasswordStatus_Login.AutoSize = true;
            this.PasswordStatus_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStatus_Login.ForeColor = System.Drawing.Color.Red;
            this.PasswordStatus_Login.Location = new System.Drawing.Point(72, 66);
            this.PasswordStatus_Login.Name = "PasswordStatus_Login";
            this.PasswordStatus_Login.Size = new System.Drawing.Size(118, 16);
            this.PasswordStatus_Login.TabIndex = 10;
            this.PasswordStatus_Login.Text = "Inkorrekt lösenord!";
            this.PasswordStatus_Login.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 85);
            this.Controls.Add(this.PasswordStatus_Login);
            this.Controls.Add(this.PasswordInput_Login);
            this.Controls.Add(this.Login_Login);
            this.Controls.Add(this.Password_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password_Login;
        private System.Windows.Forms.Button Login_Login;
        private System.Windows.Forms.TextBox PasswordInput_Login;
        private System.Windows.Forms.Label PasswordStatus_Login;
    }
}