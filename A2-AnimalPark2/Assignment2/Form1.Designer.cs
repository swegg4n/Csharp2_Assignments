
namespace Assignment2
{
    partial class Form1
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
            this.Animal_name_label = new System.Windows.Forms.Label();
            this.Animal_age_label = new System.Windows.Forms.Label();
            this.Animal_gender_label = new System.Windows.Forms.Label();
            this.Animal_image_label = new System.Windows.Forms.Label();
            this.Animal_group = new System.Windows.Forms.GroupBox();
            this.Animal_name_input = new System.Windows.Forms.TextBox();
            this.Animal_image_input = new System.Windows.Forms.Button();
            this.Animal_age_input = new System.Windows.Forms.TextBox();
            this.Animal_gender_input = new System.Windows.Forms.ComboBox();
            this.Category_group = new System.Windows.Forms.GroupBox();
            this.Category_furColor_input = new System.Windows.Forms.Button();
            this.Category_furColor_label = new System.Windows.Forms.Label();
            this.Category_noteeth_label = new System.Windows.Forms.Label();
            this.Category_noteeth_input = new System.Windows.Forms.TextBox();
            this.Category_canFly_input = new System.Windows.Forms.CheckBox();
            this.Categoty_canFly_label = new System.Windows.Forms.Label();
            this.Category_noLegs_label = new System.Windows.Forms.Label();
            this.Category_noLegs_input = new System.Windows.Forms.TextBox();
            this.Category_input = new System.Windows.Forms.ComboBox();
            this.Category_label = new System.Windows.Forms.Label();
            this.Species_input = new System.Windows.Forms.ComboBox();
            this.Species_group = new System.Windows.Forms.GroupBox();
            this.Species_tailLength_label = new System.Windows.Forms.Label();
            this.Species_tailLength_input = new System.Windows.Forms.TextBox();
            this.Species_isQueen_label = new System.Windows.Forms.Label();
            this.Species_isQueen_input = new System.Windows.Forms.CheckBox();
            this.Species_breed_label = new System.Windows.Forms.Label();
            this.Species_breed_input = new System.Windows.Forms.TextBox();
            this.Species_wingColor_label = new System.Windows.Forms.Label();
            this.Species_wingColor_input = new System.Windows.Forms.Button();
            this.Species_label = new System.Windows.Forms.Label();
            this.Animal_add_input = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Animals_list = new System.Windows.Forms.ListView();
            this.AnimalImage = new System.Windows.Forms.PictureBox();
            this.ListAllAnimals_input = new System.Windows.Forms.CheckBox();
            this.AnimalSpecs = new System.Windows.Forms.GroupBox();
            this.Animal_addRandom_input = new System.Windows.Forms.Button();
            this.FeedingSchedule = new System.Windows.Forms.GroupBox();
            this.Animal_dietinfo_input = new System.Windows.Forms.TextBox();
            this.Animal_dietType_input = new System.Windows.Forms.TextBox();
            this.Animal_dietType_label = new System.Windows.Forms.Label();
            this.List_sort_label = new System.Windows.Forms.Label();
            this.List_sort_input = new System.Windows.Forms.ComboBox();
            this.Animal_group.SuspendLayout();
            this.Category_group.SuspendLayout();
            this.Species_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalImage)).BeginInit();
            this.AnimalSpecs.SuspendLayout();
            this.FeedingSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // Animal_name_label
            // 
            this.Animal_name_label.AutoSize = true;
            this.Animal_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_name_label.Location = new System.Drawing.Point(6, 13);
            this.Animal_name_label.Name = "Animal_name_label";
            this.Animal_name_label.Size = new System.Drawing.Size(74, 25);
            this.Animal_name_label.TabIndex = 0;
            this.Animal_name_label.Text = "Name:";
            // 
            // Animal_age_label
            // 
            this.Animal_age_label.AutoSize = true;
            this.Animal_age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_age_label.Location = new System.Drawing.Point(6, 48);
            this.Animal_age_label.Name = "Animal_age_label";
            this.Animal_age_label.Size = new System.Drawing.Size(56, 25);
            this.Animal_age_label.TabIndex = 1;
            this.Animal_age_label.Text = "Age:";
            // 
            // Animal_gender_label
            // 
            this.Animal_gender_label.AutoSize = true;
            this.Animal_gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_gender_label.Location = new System.Drawing.Point(6, 83);
            this.Animal_gender_label.Name = "Animal_gender_label";
            this.Animal_gender_label.Size = new System.Drawing.Size(89, 25);
            this.Animal_gender_label.TabIndex = 2;
            this.Animal_gender_label.Text = "Gender:";
            // 
            // Animal_image_label
            // 
            this.Animal_image_label.AutoSize = true;
            this.Animal_image_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_image_label.Location = new System.Drawing.Point(6, 123);
            this.Animal_image_label.Name = "Animal_image_label";
            this.Animal_image_label.Size = new System.Drawing.Size(76, 25);
            this.Animal_image_label.TabIndex = 3;
            this.Animal_image_label.Text = "Image:";
            // 
            // Animal_group
            // 
            this.Animal_group.Controls.Add(this.Animal_name_label);
            this.Animal_group.Controls.Add(this.Animal_name_input);
            this.Animal_group.Controls.Add(this.Animal_image_input);
            this.Animal_group.Controls.Add(this.Animal_age_label);
            this.Animal_group.Controls.Add(this.Animal_image_label);
            this.Animal_group.Controls.Add(this.Animal_age_input);
            this.Animal_group.Controls.Add(this.Animal_gender_input);
            this.Animal_group.Controls.Add(this.Animal_gender_label);
            this.Animal_group.Location = new System.Drawing.Point(7, 58);
            this.Animal_group.Name = "Animal_group";
            this.Animal_group.Size = new System.Drawing.Size(279, 161);
            this.Animal_group.TabIndex = 1;
            this.Animal_group.TabStop = false;
            // 
            // Animal_name_input
            // 
            this.Animal_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_name_input.Location = new System.Drawing.Point(135, 14);
            this.Animal_name_input.Name = "Animal_name_input";
            this.Animal_name_input.Size = new System.Drawing.Size(138, 26);
            this.Animal_name_input.TabIndex = 4;
            // 
            // Animal_image_input
            // 
            this.Animal_image_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_image_input.Location = new System.Drawing.Point(135, 119);
            this.Animal_image_input.Name = "Animal_image_input";
            this.Animal_image_input.Size = new System.Drawing.Size(138, 29);
            this.Animal_image_input.TabIndex = 7;
            this.Animal_image_input.Text = "choose image";
            this.Animal_image_input.UseVisualStyleBackColor = true;
            this.Animal_image_input.Click += new System.EventHandler(this.Animal_image_input_Click);
            // 
            // Animal_age_input
            // 
            this.Animal_age_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_age_input.Location = new System.Drawing.Point(135, 49);
            this.Animal_age_input.Name = "Animal_age_input";
            this.Animal_age_input.Size = new System.Drawing.Size(138, 26);
            this.Animal_age_input.TabIndex = 5;
            // 
            // Animal_gender_input
            // 
            this.Animal_gender_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Animal_gender_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_gender_input.FormattingEnabled = true;
            this.Animal_gender_input.Location = new System.Drawing.Point(135, 83);
            this.Animal_gender_input.Name = "Animal_gender_input";
            this.Animal_gender_input.Size = new System.Drawing.Size(138, 28);
            this.Animal_gender_input.TabIndex = 6;
            // 
            // Category_group
            // 
            this.Category_group.Controls.Add(this.Category_furColor_input);
            this.Category_group.Controls.Add(this.Category_furColor_label);
            this.Category_group.Controls.Add(this.Category_noteeth_label);
            this.Category_group.Controls.Add(this.Category_noteeth_input);
            this.Category_group.Controls.Add(this.Category_canFly_input);
            this.Category_group.Controls.Add(this.Categoty_canFly_label);
            this.Category_group.Controls.Add(this.Category_noLegs_label);
            this.Category_group.Controls.Add(this.Category_noLegs_input);
            this.Category_group.Location = new System.Drawing.Point(292, 58);
            this.Category_group.Name = "Category_group";
            this.Category_group.Size = new System.Drawing.Size(279, 161);
            this.Category_group.TabIndex = 8;
            this.Category_group.TabStop = false;
            // 
            // Category_furColor_input
            // 
            this.Category_furColor_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Category_furColor_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_furColor_input.Location = new System.Drawing.Point(188, 45);
            this.Category_furColor_input.Name = "Category_furColor_input";
            this.Category_furColor_input.Size = new System.Drawing.Size(85, 35);
            this.Category_furColor_input.TabIndex = 15;
            this.Category_furColor_input.Text = "pick color";
            this.Category_furColor_input.UseVisualStyleBackColor = false;
            this.Category_furColor_input.Click += new System.EventHandler(this.Category_furColor_input_Click);
            // 
            // Category_furColor_label
            // 
            this.Category_furColor_label.AutoSize = true;
            this.Category_furColor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_furColor_label.Location = new System.Drawing.Point(6, 48);
            this.Category_furColor_label.Name = "Category_furColor_label";
            this.Category_furColor_label.Size = new System.Drawing.Size(103, 25);
            this.Category_furColor_label.TabIndex = 14;
            this.Category_furColor_label.Text = "Fur color:";
            // 
            // Category_noteeth_label
            // 
            this.Category_noteeth_label.AutoSize = true;
            this.Category_noteeth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_noteeth_label.Location = new System.Drawing.Point(6, 13);
            this.Category_noteeth_label.Name = "Category_noteeth_label";
            this.Category_noteeth_label.Size = new System.Drawing.Size(105, 25);
            this.Category_noteeth_label.TabIndex = 12;
            this.Category_noteeth_label.Text = "No. teeth:";
            // 
            // Category_noteeth_input
            // 
            this.Category_noteeth_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_noteeth_input.Location = new System.Drawing.Point(135, 14);
            this.Category_noteeth_input.Name = "Category_noteeth_input";
            this.Category_noteeth_input.Size = new System.Drawing.Size(138, 26);
            this.Category_noteeth_input.TabIndex = 13;
            // 
            // Category_canFly_input
            // 
            this.Category_canFly_input.AutoSize = true;
            this.Category_canFly_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_canFly_input.Location = new System.Drawing.Point(258, 55);
            this.Category_canFly_input.Name = "Category_canFly_input";
            this.Category_canFly_input.Size = new System.Drawing.Size(15, 14);
            this.Category_canFly_input.TabIndex = 11;
            this.Category_canFly_input.UseVisualStyleBackColor = true;
            // 
            // Categoty_canFly_label
            // 
            this.Categoty_canFly_label.AutoSize = true;
            this.Categoty_canFly_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoty_canFly_label.Location = new System.Drawing.Point(6, 48);
            this.Categoty_canFly_label.Name = "Categoty_canFly_label";
            this.Categoty_canFly_label.Size = new System.Drawing.Size(91, 25);
            this.Categoty_canFly_label.TabIndex = 10;
            this.Categoty_canFly_label.Text = "Can fly?";
            // 
            // Category_noLegs_label
            // 
            this.Category_noLegs_label.AutoSize = true;
            this.Category_noLegs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_noLegs_label.Location = new System.Drawing.Point(6, 13);
            this.Category_noLegs_label.Name = "Category_noLegs_label";
            this.Category_noLegs_label.Size = new System.Drawing.Size(97, 25);
            this.Category_noLegs_label.TabIndex = 8;
            this.Category_noLegs_label.Text = "No. legs:";
            // 
            // Category_noLegs_input
            // 
            this.Category_noLegs_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_noLegs_input.Location = new System.Drawing.Point(135, 14);
            this.Category_noLegs_input.Name = "Category_noLegs_input";
            this.Category_noLegs_input.Size = new System.Drawing.Size(138, 26);
            this.Category_noLegs_input.TabIndex = 9;
            // 
            // Category_input
            // 
            this.Category_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_input.FormattingEnabled = true;
            this.Category_input.Location = new System.Drawing.Point(403, 25);
            this.Category_input.Name = "Category_input";
            this.Category_input.Size = new System.Drawing.Size(138, 28);
            this.Category_input.TabIndex = 9;
            this.Category_input.SelectedIndexChanged += new System.EventHandler(this.Category_input_SelectedIndexChanged);
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_label.Location = new System.Drawing.Point(292, 24);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(105, 25);
            this.Category_label.TabIndex = 8;
            this.Category_label.Text = "Category:";
            // 
            // Species_input
            // 
            this.Species_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Species_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_input.Location = new System.Drawing.Point(673, 25);
            this.Species_input.Name = "Species_input";
            this.Species_input.Size = new System.Drawing.Size(138, 28);
            this.Species_input.TabIndex = 12;
            this.Species_input.SelectedIndexChanged += new System.EventHandler(this.Species_input_SelectedIndexChanged);
            // 
            // Species_group
            // 
            this.Species_group.Controls.Add(this.Species_tailLength_label);
            this.Species_group.Controls.Add(this.Species_tailLength_input);
            this.Species_group.Controls.Add(this.Species_isQueen_label);
            this.Species_group.Controls.Add(this.Species_isQueen_input);
            this.Species_group.Controls.Add(this.Species_breed_label);
            this.Species_group.Controls.Add(this.Species_breed_input);
            this.Species_group.Controls.Add(this.Species_wingColor_label);
            this.Species_group.Controls.Add(this.Species_wingColor_input);
            this.Species_group.Location = new System.Drawing.Point(577, 58);
            this.Species_group.Name = "Species_group";
            this.Species_group.Size = new System.Drawing.Size(279, 161);
            this.Species_group.TabIndex = 10;
            this.Species_group.TabStop = false;
            // 
            // Species_tailLength_label
            // 
            this.Species_tailLength_label.AutoSize = true;
            this.Species_tailLength_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_tailLength_label.Location = new System.Drawing.Point(6, 13);
            this.Species_tailLength_label.Name = "Species_tailLength_label";
            this.Species_tailLength_label.Size = new System.Drawing.Size(118, 25);
            this.Species_tailLength_label.TabIndex = 18;
            this.Species_tailLength_label.Text = "Tail length:";
            // 
            // Species_tailLength_input
            // 
            this.Species_tailLength_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_tailLength_input.Location = new System.Drawing.Point(135, 14);
            this.Species_tailLength_input.Name = "Species_tailLength_input";
            this.Species_tailLength_input.Size = new System.Drawing.Size(138, 26);
            this.Species_tailLength_input.TabIndex = 19;
            // 
            // Species_isQueen_label
            // 
            this.Species_isQueen_label.AutoSize = true;
            this.Species_isQueen_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_isQueen_label.Location = new System.Drawing.Point(6, 13);
            this.Species_isQueen_label.Name = "Species_isQueen_label";
            this.Species_isQueen_label.Size = new System.Drawing.Size(142, 25);
            this.Species_isQueen_label.TabIndex = 16;
            this.Species_isQueen_label.Text = "Is queen ant?";
            // 
            // Species_isQueen_input
            // 
            this.Species_isQueen_input.AutoSize = true;
            this.Species_isQueen_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_isQueen_input.Location = new System.Drawing.Point(258, 20);
            this.Species_isQueen_input.Name = "Species_isQueen_input";
            this.Species_isQueen_input.Size = new System.Drawing.Size(15, 14);
            this.Species_isQueen_input.TabIndex = 17;
            this.Species_isQueen_input.UseVisualStyleBackColor = true;
            // 
            // Species_breed_label
            // 
            this.Species_breed_label.AutoSize = true;
            this.Species_breed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_breed_label.Location = new System.Drawing.Point(6, 13);
            this.Species_breed_label.Name = "Species_breed_label";
            this.Species_breed_label.Size = new System.Drawing.Size(75, 25);
            this.Species_breed_label.TabIndex = 16;
            this.Species_breed_label.Text = "Breed:";
            // 
            // Species_breed_input
            // 
            this.Species_breed_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_breed_input.Location = new System.Drawing.Point(135, 14);
            this.Species_breed_input.Name = "Species_breed_input";
            this.Species_breed_input.Size = new System.Drawing.Size(138, 26);
            this.Species_breed_input.TabIndex = 17;
            // 
            // Species_wingColor_label
            // 
            this.Species_wingColor_label.AutoSize = true;
            this.Species_wingColor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_wingColor_label.Location = new System.Drawing.Point(6, 13);
            this.Species_wingColor_label.Name = "Species_wingColor_label";
            this.Species_wingColor_label.Size = new System.Drawing.Size(168, 25);
            this.Species_wingColor_label.TabIndex = 16;
            this.Species_wingColor_label.Text = "Main wing color:";
            // 
            // Species_wingColor_input
            // 
            this.Species_wingColor_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Species_wingColor_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_wingColor_input.Location = new System.Drawing.Point(188, 10);
            this.Species_wingColor_input.Name = "Species_wingColor_input";
            this.Species_wingColor_input.Size = new System.Drawing.Size(85, 35);
            this.Species_wingColor_input.TabIndex = 17;
            this.Species_wingColor_input.Text = "pick color";
            this.Species_wingColor_input.UseVisualStyleBackColor = false;
            this.Species_wingColor_input.Click += new System.EventHandler(this.Species_wingColor_input_Click);
            // 
            // Species_label
            // 
            this.Species_label.AutoSize = true;
            this.Species_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_label.Location = new System.Drawing.Point(572, 24);
            this.Species_label.Name = "Species_label";
            this.Species_label.Size = new System.Drawing.Size(95, 25);
            this.Species_label.TabIndex = 11;
            this.Species_label.Text = "Species:";
            // 
            // Animal_add_input
            // 
            this.Animal_add_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_add_input.Location = new System.Drawing.Point(862, 163);
            this.Animal_add_input.Name = "Animal_add_input";
            this.Animal_add_input.Size = new System.Drawing.Size(118, 56);
            this.Animal_add_input.TabIndex = 13;
            this.Animal_add_input.Text = "Add animal";
            this.Animal_add_input.UseVisualStyleBackColor = true;
            this.Animal_add_input.Click += new System.EventHandler(this.Animal_add_input_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.Filter = "jpg|*.jpg";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Animals";
            // 
            // Animals_list
            // 
            this.Animals_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Animals_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Animals_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animals_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_list.FullRowSelect = true;
            this.Animals_list.GridLines = true;
            this.Animals_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Animals_list.HideSelection = false;
            this.Animals_list.HoverSelection = true;
            this.Animals_list.Location = new System.Drawing.Point(12, 294);
            this.Animals_list.MultiSelect = false;
            this.Animals_list.Name = "Animals_list";
            this.Animals_list.ShowGroups = false;
            this.Animals_list.Size = new System.Drawing.Size(1128, 512);
            this.Animals_list.TabIndex = 17;
            this.Animals_list.UseCompatibleStateImageBehavior = false;
            this.Animals_list.View = System.Windows.Forms.View.Details;
            this.Animals_list.SelectedIndexChanged += new System.EventHandler(this.Animals_list_SelectedIndexChanged);
            // 
            // AnimalImage
            // 
            this.AnimalImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimalImage.Location = new System.Drawing.Point(1149, 384);
            this.AnimalImage.Name = "AnimalImage";
            this.AnimalImage.Size = new System.Drawing.Size(368, 422);
            this.AnimalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimalImage.TabIndex = 18;
            this.AnimalImage.TabStop = false;
            // 
            // ListAllAnimals_input
            // 
            this.ListAllAnimals_input.AutoSize = true;
            this.ListAllAnimals_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAllAnimals_input.Location = new System.Drawing.Point(835, 29);
            this.ListAllAnimals_input.Name = "ListAllAnimals_input";
            this.ListAllAnimals_input.Size = new System.Drawing.Size(130, 24);
            this.ListAllAnimals_input.TabIndex = 19;
            this.ListAllAnimals_input.Text = "List all animals";
            this.ListAllAnimals_input.UseVisualStyleBackColor = true;
            this.ListAllAnimals_input.CheckedChanged += new System.EventHandler(this.ListAllAnimals_input_CheckedChanged);
            // 
            // AnimalSpecs
            // 
            this.AnimalSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AnimalSpecs.Controls.Add(this.Animal_addRandom_input);
            this.AnimalSpecs.Controls.Add(this.ListAllAnimals_input);
            this.AnimalSpecs.Controls.Add(this.Animal_add_input);
            this.AnimalSpecs.Controls.Add(this.Species_input);
            this.AnimalSpecs.Controls.Add(this.Species_group);
            this.AnimalSpecs.Controls.Add(this.Species_label);
            this.AnimalSpecs.Controls.Add(this.Category_input);
            this.AnimalSpecs.Controls.Add(this.Category_group);
            this.AnimalSpecs.Controls.Add(this.Category_label);
            this.AnimalSpecs.Controls.Add(this.Animal_group);
            this.AnimalSpecs.Location = new System.Drawing.Point(5, 12);
            this.AnimalSpecs.Name = "AnimalSpecs";
            this.AnimalSpecs.Size = new System.Drawing.Size(989, 245);
            this.AnimalSpecs.TabIndex = 20;
            this.AnimalSpecs.TabStop = false;
            this.AnimalSpecs.Text = "Animal Specifications";
            // 
            // Animal_addRandom_input
            // 
            this.Animal_addRandom_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_addRandom_input.Location = new System.Drawing.Point(862, 103);
            this.Animal_addRandom_input.Name = "Animal_addRandom_input";
            this.Animal_addRandom_input.Size = new System.Drawing.Size(118, 56);
            this.Animal_addRandom_input.TabIndex = 20;
            this.Animal_addRandom_input.Text = "Add random animal";
            this.Animal_addRandom_input.UseVisualStyleBackColor = true;
            this.Animal_addRandom_input.Click += new System.EventHandler(this.Animal_addRandom_input_Click);
            // 
            // FeedingSchedule
            // 
            this.FeedingSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedingSchedule.Controls.Add(this.Animal_dietinfo_input);
            this.FeedingSchedule.Controls.Add(this.Animal_dietType_input);
            this.FeedingSchedule.Controls.Add(this.Animal_dietType_label);
            this.FeedingSchedule.Location = new System.Drawing.Point(1000, 12);
            this.FeedingSchedule.Name = "FeedingSchedule";
            this.FeedingSchedule.Size = new System.Drawing.Size(517, 245);
            this.FeedingSchedule.TabIndex = 21;
            this.FeedingSchedule.TabStop = false;
            this.FeedingSchedule.Text = "Feeding Schedule";
            // 
            // Animal_dietinfo_input
            // 
            this.Animal_dietinfo_input.AcceptsReturn = true;
            this.Animal_dietinfo_input.AcceptsTab = true;
            this.Animal_dietinfo_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Animal_dietinfo_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animal_dietinfo_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_dietinfo_input.Location = new System.Drawing.Point(6, 52);
            this.Animal_dietinfo_input.Multiline = true;
            this.Animal_dietinfo_input.Name = "Animal_dietinfo_input";
            this.Animal_dietinfo_input.ReadOnly = true;
            this.Animal_dietinfo_input.Size = new System.Drawing.Size(505, 187);
            this.Animal_dietinfo_input.TabIndex = 10;
            // 
            // Animal_dietType_input
            // 
            this.Animal_dietType_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Animal_dietType_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animal_dietType_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_dietType_input.Location = new System.Drawing.Point(149, 20);
            this.Animal_dietType_input.Name = "Animal_dietType_input";
            this.Animal_dietType_input.ReadOnly = true;
            this.Animal_dietType_input.Size = new System.Drawing.Size(362, 29);
            this.Animal_dietType_input.TabIndex = 9;
            this.Animal_dietType_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Animal_dietType_label
            // 
            this.Animal_dietType_label.AutoSize = true;
            this.Animal_dietType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_dietType_label.Location = new System.Drawing.Point(6, 24);
            this.Animal_dietType_label.Name = "Animal_dietType_label";
            this.Animal_dietType_label.Size = new System.Drawing.Size(124, 25);
            this.Animal_dietType_label.TabIndex = 8;
            this.Animal_dietType_label.Text = "Animal diet:";
            // 
            // List_sort_label
            // 
            this.List_sort_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.List_sort_label.AutoSize = true;
            this.List_sort_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_sort_label.Location = new System.Drawing.Point(1146, 294);
            this.List_sort_label.Name = "List_sort_label";
            this.List_sort_label.Size = new System.Drawing.Size(86, 25);
            this.List_sort_label.TabIndex = 8;
            this.List_sort_label.Text = "Sort by:";
            // 
            // List_sort_input
            // 
            this.List_sort_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.List_sort_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_sort_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_sort_input.FormattingEnabled = true;
            this.List_sort_input.Location = new System.Drawing.Point(1238, 295);
            this.List_sort_input.Name = "List_sort_input";
            this.List_sort_input.Size = new System.Drawing.Size(156, 28);
            this.List_sort_input.TabIndex = 8;
            this.List_sort_input.SelectedIndexChanged += new System.EventHandler(this.List_sort_input_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 818);
            this.Controls.Add(this.List_sort_input);
            this.Controls.Add(this.List_sort_label);
            this.Controls.Add(this.FeedingSchedule);
            this.Controls.Add(this.AnimalSpecs);
            this.Controls.Add(this.AnimalImage);
            this.Controls.Add(this.Animals_list);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Apu\'s Animal Park";
            this.Animal_group.ResumeLayout(false);
            this.Animal_group.PerformLayout();
            this.Category_group.ResumeLayout(false);
            this.Category_group.PerformLayout();
            this.Species_group.ResumeLayout(false);
            this.Species_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalImage)).EndInit();
            this.AnimalSpecs.ResumeLayout(false);
            this.AnimalSpecs.PerformLayout();
            this.FeedingSchedule.ResumeLayout(false);
            this.FeedingSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Animal_name_label;
        private System.Windows.Forms.Label Animal_age_label;
        private System.Windows.Forms.Label Animal_gender_label;
        private System.Windows.Forms.Label Animal_image_label;
        private System.Windows.Forms.GroupBox Animal_group;
        private System.Windows.Forms.Button Animal_image_input;
        private System.Windows.Forms.GroupBox Category_group;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.GroupBox Species_group;
        private System.Windows.Forms.Label Species_label;
        public System.Windows.Forms.TextBox Animal_name_input;
        public System.Windows.Forms.TextBox Animal_age_input;
        public System.Windows.Forms.ComboBox Animal_gender_input;
        public System.Windows.Forms.ComboBox Category_input;
        public System.Windows.Forms.ComboBox Species_input;
        private System.Windows.Forms.Button Animal_add_input;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox Category_noLegs_input;
        public System.Windows.Forms.CheckBox Category_canFly_input;
        public System.Windows.Forms.Label Category_noLegs_label;
        public System.Windows.Forms.Label Categoty_canFly_label;
        public System.Windows.Forms.Label Category_furColor_label;
        public System.Windows.Forms.Label Category_noteeth_label;
        public System.Windows.Forms.TextBox Category_noteeth_input;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button Category_furColor_input;
        public System.Windows.Forms.CheckBox Species_isQueen_input;
        public System.Windows.Forms.Label Species_isQueen_label;
        public System.Windows.Forms.Button Species_wingColor_input;
        public System.Windows.Forms.Label Species_wingColor_label;
        public System.Windows.Forms.Label Species_breed_label;
        public System.Windows.Forms.TextBox Species_breed_input;
        public System.Windows.Forms.Label Species_tailLength_label;
        public System.Windows.Forms.TextBox Species_tailLength_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Animals_list;
        private System.Windows.Forms.PictureBox AnimalImage;
        private System.Windows.Forms.CheckBox ListAllAnimals_input;
        private System.Windows.Forms.GroupBox AnimalSpecs;
        private System.Windows.Forms.GroupBox FeedingSchedule;
        private System.Windows.Forms.Label Animal_dietType_label;
        public System.Windows.Forms.TextBox Animal_dietType_input;
        public System.Windows.Forms.TextBox Animal_dietinfo_input;
        private System.Windows.Forms.Label List_sort_label;
        public System.Windows.Forms.ComboBox List_sort_input;
        private System.Windows.Forms.Button Animal_addRandom_input;
    }
}

