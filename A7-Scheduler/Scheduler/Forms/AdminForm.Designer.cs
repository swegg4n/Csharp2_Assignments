
namespace Scheduler
{
    partial class AdminForm
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Events = new System.Windows.Forms.TabPage();
            this.Print_event = new System.Windows.Forms.Button();
            this.Disapprove_event = new System.Windows.Forms.Button();
            this.EventsList_events = new System.Windows.Forms.ListView();
            this.Id_events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sign_events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFrom_events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTo_events = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartOfDay_event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventType_event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info_event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delete_event = new System.Windows.Forms.Button();
            this.Approve_event = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.TabPage();
            this.UsersList_users = new System.Windows.Forms.ListView();
            this.Sign_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Domain_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteUser_Users = new System.Windows.Forms.Button();
            this.AddUser_Users = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.YearInput_AbsenceC = new System.Windows.Forms.ComboBox();
            this.MonthInput_AbsenceC = new System.Windows.Forms.ComboBox();
            this.Print_AbsenceC = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YearInput_AbsenceY = new System.Windows.Forms.ComboBox();
            this.Print_AbsenceY = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YearInput_AbsenceM = new System.Windows.Forms.ComboBox();
            this.MonthInput_AbsenceM = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Print_AbsenceM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel_Absence1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pm_Absence1 = new System.Windows.Forms.RadioButton();
            this.am_Absence1 = new System.Windows.Forms.RadioButton();
            this.ampm_Absence1 = new System.Windows.Forms.RadioButton();
            this.Sign_addEvent = new System.Windows.Forms.Label();
            this.DateInput_Absence1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.Events.SuspendLayout();
            this.Users.SuspendLayout();
            this.Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.Events);
            this.Tabs.Controls.Add(this.Users);
            this.Tabs.Controls.Add(this.Reports);
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(0, 0);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(888, 586);
            this.Tabs.TabIndex = 99;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.Print_event);
            this.Events.Controls.Add(this.Disapprove_event);
            this.Events.Controls.Add(this.EventsList_events);
            this.Events.Controls.Add(this.Delete_event);
            this.Events.Controls.Add(this.Approve_event);
            this.Events.Controls.Add(this.Event);
            this.Events.Location = new System.Drawing.Point(4, 4);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(880, 553);
            this.Events.TabIndex = 3;
            this.Events.Text = "Händelser";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // Print_event
            // 
            this.Print_event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_event.BackColor = System.Drawing.Color.Transparent;
            this.Print_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_event.Location = new System.Drawing.Point(750, 493);
            this.Print_event.Name = "Print_event";
            this.Print_event.Size = new System.Drawing.Size(120, 46);
            this.Print_event.TabIndex = 13;
            this.Print_event.Text = "Skriv ut";
            this.Print_event.UseVisualStyleBackColor = false;
            this.Print_event.Click += new System.EventHandler(this.Print_event_Click);
            // 
            // Disapprove_event
            // 
            this.Disapprove_event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Disapprove_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Disapprove_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disapprove_event.Location = new System.Drawing.Point(750, 106);
            this.Disapprove_event.Name = "Disapprove_event";
            this.Disapprove_event.Size = new System.Drawing.Size(120, 34);
            this.Disapprove_event.TabIndex = 1;
            this.Disapprove_event.Text = "Neka";
            this.Disapprove_event.UseVisualStyleBackColor = false;
            this.Disapprove_event.Click += new System.EventHandler(this.Disapprove_event_Click);
            // 
            // EventsList_events
            // 
            this.EventsList_events.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsList_events.AutoArrange = false;
            this.EventsList_events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventsList_events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_events,
            this.Sign_events,
            this.DateFrom_events,
            this.DateTo_events,
            this.PartOfDay_event,
            this.EventType_event,
            this.Info_event,
            this.Status});
            this.EventsList_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsList_events.FullRowSelect = true;
            this.EventsList_events.GridLines = true;
            this.EventsList_events.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EventsList_events.HideSelection = false;
            this.EventsList_events.Location = new System.Drawing.Point(10, 39);
            this.EventsList_events.MultiSelect = false;
            this.EventsList_events.Name = "EventsList_events";
            this.EventsList_events.Size = new System.Drawing.Size(734, 500);
            this.EventsList_events.TabIndex = 11;
            this.EventsList_events.UseCompatibleStateImageBehavior = false;
            this.EventsList_events.View = System.Windows.Forms.View.Details;
            this.EventsList_events.SelectedIndexChanged += new System.EventHandler(this.EventsList_events_SelectedIndexChanged);
            // 
            // Id_events
            // 
            this.Id_events.Tag = "1";
            this.Id_events.Text = "ID";
            this.Id_events.Width = 40;
            // 
            // Sign_events
            // 
            this.Sign_events.Tag = "1";
            this.Sign_events.Text = "Initialer";
            this.Sign_events.Width = 67;
            // 
            // DateFrom_events
            // 
            this.DateFrom_events.Tag = "1";
            this.DateFrom_events.Text = "Datum - från";
            this.DateFrom_events.Width = 110;
            // 
            // DateTo_events
            // 
            this.DateTo_events.Tag = "1";
            this.DateTo_events.Text = "Datum - t.o.m.";
            this.DateTo_events.Width = 110;
            // 
            // PartOfDay_event
            // 
            this.PartOfDay_event.Tag = "1";
            this.PartOfDay_event.Text = "Del av dag";
            this.PartOfDay_event.Width = 100;
            // 
            // EventType_event
            // 
            this.EventType_event.Tag = "1";
            this.EventType_event.Text = "Händelsetyp";
            this.EventType_event.Width = 110;
            // 
            // Info_event
            // 
            this.Info_event.Tag = "1";
            this.Info_event.Text = "Information";
            this.Info_event.Width = 115;
            // 
            // Status
            // 
            this.Status.Tag = "1";
            this.Status.Text = "Status";
            this.Status.Width = 80;
            // 
            // Delete_event
            // 
            this.Delete_event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_event.Location = new System.Drawing.Point(750, 163);
            this.Delete_event.Name = "Delete_event";
            this.Delete_event.Size = new System.Drawing.Size(120, 34);
            this.Delete_event.TabIndex = 2;
            this.Delete_event.Text = "Radera";
            this.Delete_event.UseVisualStyleBackColor = false;
            this.Delete_event.Click += new System.EventHandler(this.Delete_event_Click);
            // 
            // Approve_event
            // 
            this.Approve_event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Approve_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Approve_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approve_event.Location = new System.Drawing.Point(750, 39);
            this.Approve_event.Name = "Approve_event";
            this.Approve_event.Size = new System.Drawing.Size(120, 61);
            this.Approve_event.TabIndex = 0;
            this.Approve_event.Text = "Godkänn";
            this.Approve_event.UseVisualStyleBackColor = false;
            this.Approve_event.Click += new System.EventHandler(this.Approve_event_Click);
            // 
            // Event
            // 
            this.Event.AutoSize = true;
            this.Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.Location = new System.Drawing.Point(5, 11);
            this.Event.Margin = new System.Windows.Forms.Padding(0);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(110, 25);
            this.Event.TabIndex = 8;
            this.Event.Text = "Händelser";
            // 
            // Users
            // 
            this.Users.AutoScroll = true;
            this.Users.Controls.Add(this.UsersList_users);
            this.Users.Controls.Add(this.DeleteUser_Users);
            this.Users.Controls.Add(this.AddUser_Users);
            this.Users.Controls.Add(this.User);
            this.Users.Location = new System.Drawing.Point(4, 4);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(880, 553);
            this.Users.TabIndex = 2;
            this.Users.Text = "Användare";
            this.Users.UseVisualStyleBackColor = true;
            // 
            // UsersList_users
            // 
            this.UsersList_users.AutoArrange = false;
            this.UsersList_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsersList_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sign_user,
            this.Id_user,
            this.FirstName_user,
            this.LastName_user,
            this.Domain_user});
            this.UsersList_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersList_users.FullRowSelect = true;
            this.UsersList_users.GridLines = true;
            this.UsersList_users.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UsersList_users.HideSelection = false;
            this.UsersList_users.Location = new System.Drawing.Point(10, 39);
            this.UsersList_users.MultiSelect = false;
            this.UsersList_users.Name = "UsersList_users";
            this.UsersList_users.Size = new System.Drawing.Size(588, 500);
            this.UsersList_users.TabIndex = 0;
            this.UsersList_users.UseCompatibleStateImageBehavior = false;
            this.UsersList_users.View = System.Windows.Forms.View.Details;
            this.UsersList_users.SelectedIndexChanged += new System.EventHandler(this.UsersList_users_SelectedIndexChanged);
            // 
            // Sign_user
            // 
            this.Sign_user.Text = "Initialer";
            this.Sign_user.Width = 75;
            // 
            // Id_user
            // 
            this.Id_user.Text = "ID";
            this.Id_user.Width = 75;
            // 
            // FirstName_user
            // 
            this.FirstName_user.Text = "Förnamn";
            this.FirstName_user.Width = 130;
            // 
            // LastName_user
            // 
            this.LastName_user.Text = "Efternamn";
            this.LastName_user.Width = 130;
            // 
            // Domain_user
            // 
            this.Domain_user.Text = "Avdelning";
            this.Domain_user.Width = 155;
            // 
            // DeleteUser_Users
            // 
            this.DeleteUser_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUser_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteUser_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser_Users.Location = new System.Drawing.Point(604, 106);
            this.DeleteUser_Users.Name = "DeleteUser_Users";
            this.DeleteUser_Users.Size = new System.Drawing.Size(120, 34);
            this.DeleteUser_Users.TabIndex = 1;
            this.DeleteUser_Users.Text = "Radera";
            this.DeleteUser_Users.UseVisualStyleBackColor = false;
            this.DeleteUser_Users.Click += new System.EventHandler(this.DeleteUser_Users_Click);
            // 
            // AddUser_Users
            // 
            this.AddUser_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUser_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddUser_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_Users.Location = new System.Drawing.Point(604, 39);
            this.AddUser_Users.Name = "AddUser_Users";
            this.AddUser_Users.Size = new System.Drawing.Size(120, 61);
            this.AddUser_Users.TabIndex = 5;
            this.AddUser_Users.Text = "Lägg till";
            this.AddUser_Users.UseVisualStyleBackColor = false;
            this.AddUser_Users.Click += new System.EventHandler(this.AddUser_Users_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(5, 11);
            this.User.Margin = new System.Windows.Forms.Padding(0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(116, 25);
            this.User.TabIndex = 4;
            this.User.Text = "Användare";
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.label9);
            this.Reports.Controls.Add(this.YearInput_AbsenceC);
            this.Reports.Controls.Add(this.MonthInput_AbsenceC);
            this.Reports.Controls.Add(this.Print_AbsenceC);
            this.Reports.Controls.Add(this.label10);
            this.Reports.Controls.Add(this.label8);
            this.Reports.Controls.Add(this.pictureBox3);
            this.Reports.Controls.Add(this.label6);
            this.Reports.Controls.Add(this.YearInput_AbsenceY);
            this.Reports.Controls.Add(this.Print_AbsenceY);
            this.Reports.Controls.Add(this.label7);
            this.Reports.Controls.Add(this.label5);
            this.Reports.Controls.Add(this.YearInput_AbsenceM);
            this.Reports.Controls.Add(this.MonthInput_AbsenceM);
            this.Reports.Controls.Add(this.pictureBox2);
            this.Reports.Controls.Add(this.Print_AbsenceM);
            this.Reports.Controls.Add(this.label4);
            this.Reports.Controls.Add(this.label3);
            this.Reports.Controls.Add(this.Panel_Absence1);
            this.Reports.Controls.Add(this.pictureBox1);
            this.Reports.Controls.Add(this.label2);
            this.Reports.Controls.Add(this.pm_Absence1);
            this.Reports.Controls.Add(this.am_Absence1);
            this.Reports.Controls.Add(this.ampm_Absence1);
            this.Reports.Controls.Add(this.Sign_addEvent);
            this.Reports.Controls.Add(this.DateInput_Absence1);
            this.Reports.Controls.Add(this.label1);
            this.Reports.Location = new System.Drawing.Point(4, 4);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(880, 553);
            this.Reports.TabIndex = 4;
            this.Reports.Text = "Rapporter";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "År";
            // 
            // YearInput_AbsenceC
            // 
            this.YearInput_AbsenceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearInput_AbsenceC.FormattingEnabled = true;
            this.YearInput_AbsenceC.Location = new System.Drawing.Point(590, 72);
            this.YearInput_AbsenceC.Name = "YearInput_AbsenceC";
            this.YearInput_AbsenceC.Size = new System.Drawing.Size(74, 28);
            this.YearInput_AbsenceC.TabIndex = 32;
            // 
            // MonthInput_AbsenceC
            // 
            this.MonthInput_AbsenceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthInput_AbsenceC.FormattingEnabled = true;
            this.MonthInput_AbsenceC.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Mars",
            "April",
            "Maj",
            "Juni",
            "Juli",
            "Augusti",
            "September",
            "Oktober",
            "November",
            "December"});
            this.MonthInput_AbsenceC.Location = new System.Drawing.Point(466, 72);
            this.MonthInput_AbsenceC.Name = "MonthInput_AbsenceC";
            this.MonthInput_AbsenceC.Size = new System.Drawing.Size(118, 28);
            this.MonthInput_AbsenceC.TabIndex = 31;
            // 
            // Print_AbsenceC
            // 
            this.Print_AbsenceC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_AbsenceC.BackColor = System.Drawing.Color.Transparent;
            this.Print_AbsenceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_AbsenceC.Location = new System.Drawing.Point(466, 112);
            this.Print_AbsenceC.Name = "Print_AbsenceC";
            this.Print_AbsenceC.Size = new System.Drawing.Size(198, 35);
            this.Print_AbsenceC.TabIndex = 30;
            this.Print_AbsenceC.Text = "Skriv ut";
            this.Print_AbsenceC.UseVisualStyleBackColor = false;
            this.Print_AbsenceC.Click += new System.EventHandler(this.Print_AbsenceC_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Månad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Kalender";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Location = new System.Drawing.Point(211, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(236, 2);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "År";
            this.label6.Visible = false;
            // 
            // YearInput_AbsenceY
            // 
            this.YearInput_AbsenceY.Enabled = false;
            this.YearInput_AbsenceY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearInput_AbsenceY.FormattingEnabled = true;
            this.YearInput_AbsenceY.Location = new System.Drawing.Point(229, 323);
            this.YearInput_AbsenceY.Name = "YearInput_AbsenceY";
            this.YearInput_AbsenceY.Size = new System.Drawing.Size(74, 28);
            this.YearInput_AbsenceY.TabIndex = 25;
            this.YearInput_AbsenceY.Visible = false;
            // 
            // Print_AbsenceY
            // 
            this.Print_AbsenceY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_AbsenceY.BackColor = System.Drawing.Color.Transparent;
            this.Print_AbsenceY.Enabled = false;
            this.Print_AbsenceY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_AbsenceY.Location = new System.Drawing.Point(229, 363);
            this.Print_AbsenceY.Name = "Print_AbsenceY";
            this.Print_AbsenceY.Size = new System.Drawing.Size(198, 35);
            this.Print_AbsenceY.TabIndex = 24;
            this.Print_AbsenceY.Text = "Skriv ut";
            this.Print_AbsenceY.UseVisualStyleBackColor = false;
            this.Print_AbsenceY.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Frånvaro - År";
            this.label7.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "År";
            // 
            // YearInput_AbsenceM
            // 
            this.YearInput_AbsenceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearInput_AbsenceM.FormattingEnabled = true;
            this.YearInput_AbsenceM.Location = new System.Drawing.Point(353, 72);
            this.YearInput_AbsenceM.Name = "YearInput_AbsenceM";
            this.YearInput_AbsenceM.Size = new System.Drawing.Size(74, 28);
            this.YearInput_AbsenceM.TabIndex = 21;
            // 
            // MonthInput_AbsenceM
            // 
            this.MonthInput_AbsenceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthInput_AbsenceM.FormattingEnabled = true;
            this.MonthInput_AbsenceM.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Mars",
            "April",
            "Maj",
            "Juni",
            "Juli",
            "Augusti",
            "September",
            "Oktober",
            "November",
            "December"});
            this.MonthInput_AbsenceM.Location = new System.Drawing.Point(229, 72);
            this.MonthInput_AbsenceM.Name = "MonthInput_AbsenceM";
            this.MonthInput_AbsenceM.Size = new System.Drawing.Size(118, 28);
            this.MonthInput_AbsenceM.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(445, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 547);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Print_AbsenceM
            // 
            this.Print_AbsenceM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_AbsenceM.BackColor = System.Drawing.Color.Transparent;
            this.Print_AbsenceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_AbsenceM.Location = new System.Drawing.Point(229, 112);
            this.Print_AbsenceM.Name = "Print_AbsenceM";
            this.Print_AbsenceM.Size = new System.Drawing.Size(198, 35);
            this.Print_AbsenceM.TabIndex = 18;
            this.Print_AbsenceM.Text = "Skriv ut";
            this.Print_AbsenceM.UseVisualStyleBackColor = false;
            this.Print_AbsenceM.Click += new System.EventHandler(this.Print_AbsenceM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Månad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Frånvaro - Månad";
            // 
            // Panel_Absence1
            // 
            this.Panel_Absence1.Location = new System.Drawing.Point(3, 209);
            this.Panel_Absence1.Name = "Panel_Absence1";
            this.Panel_Absence1.Size = new System.Drawing.Size(206, 341);
            this.Panel_Absence1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(211, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 547);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Del av dag";
            // 
            // pm_Absence1
            // 
            this.pm_Absence1.AutoSize = true;
            this.pm_Absence1.Location = new System.Drawing.Point(10, 179);
            this.pm_Absence1.Name = "pm_Absence1";
            this.pm_Absence1.Size = new System.Drawing.Size(114, 24);
            this.pm_Absence1.TabIndex = 3;
            this.pm_Absence1.Text = "Eftermiddag";
            this.pm_Absence1.UseVisualStyleBackColor = true;
            this.pm_Absence1.CheckedChanged += new System.EventHandler(this.pm_Absence1_CheckedChanged);
            // 
            // am_Absence1
            // 
            this.am_Absence1.AutoSize = true;
            this.am_Absence1.Location = new System.Drawing.Point(10, 157);
            this.am_Absence1.Name = "am_Absence1";
            this.am_Absence1.Size = new System.Drawing.Size(103, 24);
            this.am_Absence1.TabIndex = 2;
            this.am_Absence1.Text = "Förmiddag";
            this.am_Absence1.UseVisualStyleBackColor = true;
            this.am_Absence1.CheckedChanged += new System.EventHandler(this.am_Absence1_CheckedChanged);
            // 
            // ampm_Absence1
            // 
            this.ampm_Absence1.AutoSize = true;
            this.ampm_Absence1.Checked = true;
            this.ampm_Absence1.Location = new System.Drawing.Point(10, 135);
            this.ampm_Absence1.Name = "ampm_Absence1";
            this.ampm_Absence1.Size = new System.Drawing.Size(78, 24);
            this.ampm_Absence1.TabIndex = 1;
            this.ampm_Absence1.TabStop = true;
            this.ampm_Absence1.Text = "Heldag";
            this.ampm_Absence1.UseVisualStyleBackColor = true;
            this.ampm_Absence1.CheckedChanged += new System.EventHandler(this.ampm_Absence1_CheckedChanged);
            // 
            // Sign_addEvent
            // 
            this.Sign_addEvent.AutoSize = true;
            this.Sign_addEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_addEvent.Location = new System.Drawing.Point(6, 47);
            this.Sign_addEvent.Margin = new System.Windows.Forms.Padding(0);
            this.Sign_addEvent.Name = "Sign_addEvent";
            this.Sign_addEvent.Size = new System.Drawing.Size(64, 24);
            this.Sign_addEvent.TabIndex = 7;
            this.Sign_addEvent.Text = "Datum";
            // 
            // DateInput_Absence1
            // 
            this.DateInput_Absence1.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateInput_Absence1.CustomFormat = "yyyy-MM-dd";
            this.DateInput_Absence1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInput_Absence1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateInput_Absence1.Location = new System.Drawing.Point(10, 71);
            this.DateInput_Absence1.Name = "DateInput_Absence1";
            this.DateInput_Absence1.Size = new System.Drawing.Size(161, 29);
            this.DateInput_Absence1.TabIndex = 0;
            this.DateInput_Absence1.Tag = "";
            this.DateInput_Absence1.ValueChanged += new System.EventHandler(this.DateInput_Absence1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Frånvaro - Dag";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 586);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.Text = "Administrering";
            this.Tabs.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            this.Events.PerformLayout();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            this.Reports.ResumeLayout(false);
            this.Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Button AddUser_Users;
        private System.Windows.Forms.Button DeleteUser_Users;
        private System.Windows.Forms.ListView UsersList_users;
        private System.Windows.Forms.ColumnHeader Sign_user;
        private System.Windows.Forms.ColumnHeader Id_user;
        private System.Windows.Forms.ColumnHeader FirstName_user;
        private System.Windows.Forms.ColumnHeader LastName_user;
        private System.Windows.Forms.ColumnHeader Domain_user;
        private System.Windows.Forms.ListView EventsList_events;
        private System.Windows.Forms.ColumnHeader Id_events;
        private System.Windows.Forms.ColumnHeader Sign_events;
        private System.Windows.Forms.ColumnHeader DateFrom_events;
        private System.Windows.Forms.ColumnHeader DateTo_events;
        private System.Windows.Forms.ColumnHeader PartOfDay_event;
        private System.Windows.Forms.Button Delete_event;
        private System.Windows.Forms.Button Approve_event;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.ColumnHeader EventType_event;
        private System.Windows.Forms.ColumnHeader Info_event;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button Disapprove_event;
        private System.Windows.Forms.Button Print_event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateInput_Absence1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton pm_Absence1;
        private System.Windows.Forms.RadioButton am_Absence1;
        private System.Windows.Forms.RadioButton ampm_Absence1;
        private System.Windows.Forms.Label Sign_addEvent;
        private System.Windows.Forms.Panel Panel_Absence1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Print_AbsenceM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox MonthInput_AbsenceM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YearInput_AbsenceM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox YearInput_AbsenceY;
        private System.Windows.Forms.Button Print_AbsenceY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox YearInput_AbsenceC;
        private System.Windows.Forms.ComboBox MonthInput_AbsenceC;
        private System.Windows.Forms.Button Print_AbsenceC;
        private System.Windows.Forms.Label label10;
    }
}