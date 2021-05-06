
namespace Scheduler
{
    partial class AddUserForm
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
            this.Cancel_AddUser = new System.Windows.Forms.Button();
            this.Add_AddUser = new System.Windows.Forms.Button();
            this.DomainInput_AddUser = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Sign_addUser = new System.Windows.Forms.Label();
            this.UserNr_AddUser = new System.Windows.Forms.Label();
            this.FirstName_AddUser = new System.Windows.Forms.Label();
            this.LastName_AddUser = new System.Windows.Forms.Label();
            this.Domain_AddUser = new System.Windows.Forms.Label();
            this.SignInput_AddUser = new System.Windows.Forms.TextBox();
            this.UserNrInput_AddUser = new System.Windows.Forms.TextBox();
            this.FirstNameInput_AddUser = new System.Windows.Forms.TextBox();
            this.LastNameInput_AddUser = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_AddUser
            // 
            this.Cancel_AddUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_AddUser.Location = new System.Drawing.Point(10, 226);
            this.Cancel_AddUser.Name = "Cancel_AddUser";
            this.Cancel_AddUser.Size = new System.Drawing.Size(125, 47);
            this.Cancel_AddUser.TabIndex = 6;
            this.Cancel_AddUser.Text = "Stäng";
            this.Cancel_AddUser.UseVisualStyleBackColor = false;
            this.Cancel_AddUser.Click += new System.EventHandler(this.Cancel_AddUser_Click);
            // 
            // Add_AddUser
            // 
            this.Add_AddUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Add_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_AddUser.Location = new System.Drawing.Point(141, 226);
            this.Add_AddUser.Name = "Add_AddUser";
            this.Add_AddUser.Size = new System.Drawing.Size(238, 47);
            this.Add_AddUser.TabIndex = 5;
            this.Add_AddUser.Text = "Lägg till användare";
            this.Add_AddUser.UseVisualStyleBackColor = false;
            this.Add_AddUser.Click += new System.EventHandler(this.Add_AddUser_Click);
            // 
            // DomainInput_AddUser
            // 
            this.DomainInput_AddUser.BackColor = System.Drawing.Color.White;
            this.DomainInput_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainInput_AddUser.FormattingEnabled = true;
            this.DomainInput_AddUser.ItemHeight = 24;
            this.DomainInput_AddUser.Items.AddRange(new object[] {
            "Bro",
            "Industri",
            "Koordination"});
            this.DomainInput_AddUser.Location = new System.Drawing.Point(205, 188);
            this.DomainInput_AddUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.DomainInput_AddUser.Name = "DomainInput_AddUser";
            this.DomainInput_AddUser.Size = new System.Drawing.Size(174, 32);
            this.DomainInput_AddUser.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Sign_addUser);
            this.flowLayoutPanel1.Controls.Add(this.UserNr_AddUser);
            this.flowLayoutPanel1.Controls.Add(this.FirstName_AddUser);
            this.flowLayoutPanel1.Controls.Add(this.LastName_AddUser);
            this.flowLayoutPanel1.Controls.Add(this.Domain_AddUser);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 205);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // Sign_addUser
            // 
            this.Sign_addUser.AutoSize = true;
            this.Sign_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_addUser.Location = new System.Drawing.Point(0, 0);
            this.Sign_addUser.Margin = new System.Windows.Forms.Padding(0);
            this.Sign_addUser.Name = "Sign_addUser";
            this.Sign_addUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Sign_addUser.Size = new System.Drawing.Size(75, 44);
            this.Sign_addUser.TabIndex = 3;
            this.Sign_addUser.Text = "Initialer*";
            // 
            // UserNr_AddUser
            // 
            this.UserNr_AddUser.AutoSize = true;
            this.UserNr_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNr_AddUser.Location = new System.Drawing.Point(0, 44);
            this.UserNr_AddUser.Margin = new System.Windows.Forms.Padding(0);
            this.UserNr_AddUser.Name = "UserNr_AddUser";
            this.UserNr_AddUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.UserNr_AddUser.Size = new System.Drawing.Size(140, 44);
            this.UserNr_AddUser.TabIndex = 4;
            this.UserNr_AddUser.Text = "Anställningsnr.*";
            // 
            // FirstName_AddUser
            // 
            this.FirstName_AddUser.AutoSize = true;
            this.FirstName_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_AddUser.Location = new System.Drawing.Point(0, 88);
            this.FirstName_AddUser.Margin = new System.Windows.Forms.Padding(0);
            this.FirstName_AddUser.Name = "FirstName_AddUser";
            this.FirstName_AddUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.FirstName_AddUser.Size = new System.Drawing.Size(87, 44);
            this.FirstName_AddUser.TabIndex = 5;
            this.FirstName_AddUser.Text = "Förnamn";
            // 
            // LastName_AddUser
            // 
            this.LastName_AddUser.AutoSize = true;
            this.LastName_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_AddUser.Location = new System.Drawing.Point(0, 132);
            this.LastName_AddUser.Margin = new System.Windows.Forms.Padding(0);
            this.LastName_AddUser.Name = "LastName_AddUser";
            this.LastName_AddUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.LastName_AddUser.Size = new System.Drawing.Size(96, 44);
            this.LastName_AddUser.TabIndex = 6;
            this.LastName_AddUser.Text = "Efternamn";
            // 
            // Domain_AddUser
            // 
            this.Domain_AddUser.AutoSize = true;
            this.Domain_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Domain_AddUser.Location = new System.Drawing.Point(0, 176);
            this.Domain_AddUser.Margin = new System.Windows.Forms.Padding(0);
            this.Domain_AddUser.Name = "Domain_AddUser";
            this.Domain_AddUser.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Domain_AddUser.Size = new System.Drawing.Size(102, 44);
            this.Domain_AddUser.TabIndex = 7;
            this.Domain_AddUser.Text = "Avdelning*";
            // 
            // SignInput_AddUser
            // 
            this.SignInput_AddUser.BackColor = System.Drawing.Color.White;
            this.SignInput_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInput_AddUser.Location = new System.Drawing.Point(205, 15);
            this.SignInput_AddUser.Name = "SignInput_AddUser";
            this.SignInput_AddUser.Size = new System.Drawing.Size(174, 29);
            this.SignInput_AddUser.TabIndex = 0;
            // 
            // UserNrInput_AddUser
            // 
            this.UserNrInput_AddUser.BackColor = System.Drawing.Color.White;
            this.UserNrInput_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNrInput_AddUser.Location = new System.Drawing.Point(205, 56);
            this.UserNrInput_AddUser.Name = "UserNrInput_AddUser";
            this.UserNrInput_AddUser.Size = new System.Drawing.Size(174, 29);
            this.UserNrInput_AddUser.TabIndex = 1;
            // 
            // FirstNameInput_AddUser
            // 
            this.FirstNameInput_AddUser.BackColor = System.Drawing.Color.White;
            this.FirstNameInput_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameInput_AddUser.Location = new System.Drawing.Point(205, 100);
            this.FirstNameInput_AddUser.Name = "FirstNameInput_AddUser";
            this.FirstNameInput_AddUser.Size = new System.Drawing.Size(174, 29);
            this.FirstNameInput_AddUser.TabIndex = 2;
            // 
            // LastNameInput_AddUser
            // 
            this.LastNameInput_AddUser.BackColor = System.Drawing.Color.White;
            this.LastNameInput_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameInput_AddUser.Location = new System.Drawing.Point(205, 144);
            this.LastNameInput_AddUser.Name = "LastNameInput_AddUser";
            this.LastNameInput_AddUser.Size = new System.Drawing.Size(174, 29);
            this.LastNameInput_AddUser.TabIndex = 3;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 281);
            this.Controls.Add(this.LastNameInput_AddUser);
            this.Controls.Add(this.FirstNameInput_AddUser);
            this.Controls.Add(this.UserNrInput_AddUser);
            this.Controls.Add(this.SignInput_AddUser);
            this.Controls.Add(this.Cancel_AddUser);
            this.Controls.Add(this.Add_AddUser);
            this.Controls.Add(this.DomainInput_AddUser);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUserForm";
            this.Text = "Lägg till användare";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel_AddUser;
        private System.Windows.Forms.Button Add_AddUser;
        private System.Windows.Forms.ComboBox DomainInput_AddUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Sign_addUser;
        private System.Windows.Forms.Label UserNr_AddUser;
        private System.Windows.Forms.Label FirstName_AddUser;
        private System.Windows.Forms.Label LastName_AddUser;
        private System.Windows.Forms.Label Domain_AddUser;
        private System.Windows.Forms.TextBox SignInput_AddUser;
        private System.Windows.Forms.TextBox UserNrInput_AddUser;
        private System.Windows.Forms.TextBox FirstNameInput_AddUser;
        private System.Windows.Forms.TextBox LastNameInput_AddUser;
    }
}