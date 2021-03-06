
namespace Assignment4
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
            this.FileDialog_image = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_open_text = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_open_binary = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_save_text = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_save_binary = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_saveAs_text = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_saveAs_binary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenu_xml = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_xml_import = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_xml_export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Animals_list = new System.Windows.Forms.ListView();
            this.AnimalImage = new System.Windows.Forms.PictureBox();
            this.AnimalSpecs = new System.Windows.Forms.GroupBox();
            this.Animal_group = new System.Windows.Forms.GroupBox();
            this.Animal_gender_label = new System.Windows.Forms.Label();
            this.Animal_gender_input = new System.Windows.Forms.ComboBox();
            this.Animal_age_input = new System.Windows.Forms.TextBox();
            this.Animal_image_label = new System.Windows.Forms.Label();
            this.Animal_age_label = new System.Windows.Forms.Label();
            this.Animal_image_input = new System.Windows.Forms.Button();
            this.Animal_name_input = new System.Windows.Forms.TextBox();
            this.Animal_name_label = new System.Windows.Forms.Label();
            this.Category_label = new System.Windows.Forms.Label();
            this.Category_group = new System.Windows.Forms.GroupBox();
            this.Category_noLegs_input = new System.Windows.Forms.TextBox();
            this.Category_noLegs_label = new System.Windows.Forms.Label();
            this.Categoty_canFly_label = new System.Windows.Forms.Label();
            this.Category_canFly_input = new System.Windows.Forms.CheckBox();
            this.Category_noteeth_input = new System.Windows.Forms.TextBox();
            this.Category_noteeth_label = new System.Windows.Forms.Label();
            this.Category_furColor_label = new System.Windows.Forms.Label();
            this.Category_furColor_input = new System.Windows.Forms.Button();
            this.Category_input = new System.Windows.Forms.ComboBox();
            this.Species_label = new System.Windows.Forms.Label();
            this.Species_group = new System.Windows.Forms.GroupBox();
            this.Species_wingColor_input = new System.Windows.Forms.Button();
            this.Species_wingColor_label = new System.Windows.Forms.Label();
            this.Species_breed_input = new System.Windows.Forms.TextBox();
            this.Species_breed_label = new System.Windows.Forms.Label();
            this.Species_isQueen_input = new System.Windows.Forms.CheckBox();
            this.Species_isQueen_label = new System.Windows.Forms.Label();
            this.Species_tailLength_input = new System.Windows.Forms.TextBox();
            this.Species_tailLength_label = new System.Windows.Forms.Label();
            this.Species_input = new System.Windows.Forms.ComboBox();
            this.Animal_add_input = new System.Windows.Forms.Button();
            this.ListAllAnimals_input = new System.Windows.Forms.CheckBox();
            this.Animal_addRandom_input = new System.Windows.Forms.Button();
            this.Animal_remove_input = new System.Windows.Forms.Button();
            this.Animal_change_input = new System.Windows.Forms.Button();
            this.List_sort_label = new System.Windows.Forms.Label();
            this.List_sort_input = new System.Windows.Forms.ComboBox();
            this.FoodItems = new System.Windows.Forms.GroupBox();
            this.FoodItems_NewFoodItem_input = new System.Windows.Forms.Button();
            this.FoodItems_list = new System.Windows.Forms.ListView();
            this.FoodItem_name_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodItem_ingredients_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodItem_animalID_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodItems_ConnectAnimal_input = new System.Windows.Forms.Button();
            this.FeedingSchedule = new System.Windows.Forms.GroupBox();
            this.FoodSchedule_NewSchedule_input = new System.Windows.Forms.Button();
            this.FeedingSchedule_list = new System.Windows.Forms.ListView();
            this.FeedingSchedule_diet_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FeedingSchedule_foodItems_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FeedingSchedule_animalID_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FeedingSchedule_ConnectAnimal_input = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalImage)).BeginInit();
            this.AnimalSpecs.SuspendLayout();
            this.Animal_group.SuspendLayout();
            this.Category_group.SuspendLayout();
            this.Species_group.SuspendLayout();
            this.FoodItems.SuspendLayout();
            this.FeedingSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileDialog_image
            // 
            this.FileDialog_image.DefaultExt = "jpg";
            this.FileDialog_image.Filter = "jpg|*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1505, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_new,
            this.toolStripMenuItem3,
            this.FileMenu_open,
            this.FileMenu_save,
            this.FileMenu_saveAs,
            this.toolStripMenuItem1,
            this.FileMenu_xml,
            this.toolStripMenuItem2,
            this.FileMenu_exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // FileMenu_new
            // 
            this.FileMenu_new.Name = "FileMenu_new";
            this.FileMenu_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileMenu_new.Size = new System.Drawing.Size(141, 22);
            this.FileMenu_new.Text = "New";
            this.FileMenu_new.Click += new System.EventHandler(this.FileMenu_new_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(138, 6);
            // 
            // FileMenu_open
            // 
            this.FileMenu_open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_open_text,
            this.FileMenu_open_binary});
            this.FileMenu_open.Name = "FileMenu_open";
            this.FileMenu_open.Size = new System.Drawing.Size(141, 22);
            this.FileMenu_open.Text = "Open...";
            // 
            // FileMenu_open_text
            // 
            this.FileMenu_open_text.Name = "FileMenu_open_text";
            this.FileMenu_open_text.Size = new System.Drawing.Size(128, 22);
            this.FileMenu_open_text.Text = "Text File";
            this.FileMenu_open_text.Click += new System.EventHandler(this.FileMenu_open_text_Click);
            // 
            // FileMenu_open_binary
            // 
            this.FileMenu_open_binary.Name = "FileMenu_open_binary";
            this.FileMenu_open_binary.Size = new System.Drawing.Size(128, 22);
            this.FileMenu_open_binary.Text = "Binary File";
            this.FileMenu_open_binary.Click += new System.EventHandler(this.FileMenu_open_binary_Click);
            // 
            // FileMenu_save
            // 
            this.FileMenu_save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_save_text,
            this.FileMenu_save_binary});
            this.FileMenu_save.Name = "FileMenu_save";
            this.FileMenu_save.Size = new System.Drawing.Size(141, 22);
            this.FileMenu_save.Text = "Save";
            // 
            // FileMenu_save_text
            // 
            this.FileMenu_save_text.Name = "FileMenu_save_text";
            this.FileMenu_save_text.Size = new System.Drawing.Size(128, 22);
            this.FileMenu_save_text.Text = "Text File";
            this.FileMenu_save_text.Click += new System.EventHandler(this.FileMenu_save_text_Click);
            // 
            // FileMenu_save_binary
            // 
            this.FileMenu_save_binary.Name = "FileMenu_save_binary";
            this.FileMenu_save_binary.Size = new System.Drawing.Size(128, 22);
            this.FileMenu_save_binary.Text = "Binary File";
            this.FileMenu_save_binary.Click += new System.EventHandler(this.FileMenu_save_binary_Click);
            // 
            // FileMenu_saveAs
            // 
            this.FileMenu_saveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_saveAs_text,
            this.FileMenu_saveAs_binary});
            this.FileMenu_saveAs.Name = "FileMenu_saveAs";
            this.FileMenu_saveAs.Size = new System.Drawing.Size(141, 22);
            this.FileMenu_saveAs.Text = "Save as...";
            // 
            // FileMenu_saveAs_text
            // 
            this.FileMenu_saveAs_text.Name = "FileMenu_saveAs_text";
            this.FileMenu_saveAs_text.Size = new System.Drawing.Size(128, 22);
            this.FileMenu_saveAs_text.Text = "Text File";
            this.FileMenu_saveAs_text.Click += new System.EventHandler(this.FileMenu_saveAs_text_Click);
            // 
            // FileMenu_saveAs_binary
            // 
            this.FileMenu_saveAs_binary.Name = "FileMenu_saveAs_binary";
            this.FileMenu_saveAs_binary.Size = new System.Drawing.Size(128, 22);
            this.FileMenu_saveAs_binary.Text = "Binary File";
            this.FileMenu_saveAs_binary.Click += new System.EventHandler(this.FileMenu_saveAs_binary_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // FileMenu_xml
            // 
            this.FileMenu_xml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_xml_import,
            this.FileMenu_xml_export});
            this.FileMenu_xml.Name = "FileMenu_xml";
            this.FileMenu_xml.Size = new System.Drawing.Size(141, 22);
            this.FileMenu_xml.Text = "XML";
            // 
            // FileMenu_xml_import
            // 
            this.FileMenu_xml_import.Name = "FileMenu_xml_import";
            this.FileMenu_xml_import.Size = new System.Drawing.Size(187, 22);
            this.FileMenu_xml_import.Text = "Import from XML File";
            this.FileMenu_xml_import.Click += new System.EventHandler(this.FileMenu_xml_import_Click);
            // 
            // FileMenu_xml_export
            // 
            this.FileMenu_xml_export.Name = "FileMenu_xml_export";
            this.FileMenu_xml_export.Size = new System.Drawing.Size(187, 22);
            this.FileMenu_xml_export.Text = "Export to XML File";
            this.FileMenu_xml_export.Click += new System.EventHandler(this.FileMenu_xml_export_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // FileMenu_exit
            // 
            this.FileMenu_exit.Name = "FileMenu_exit";
            this.FileMenu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.FileMenu_exit.Size = new System.Drawing.Size(141, 22);
            this.FileMenu_exit.Text = "Exit";
            this.FileMenu_exit.Click += new System.EventHandler(this.FileMenu_exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Animals";
            // 
            // Animals_list
            // 
            this.Animals_list.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Animals_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Animals_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animals_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animals_list.FullRowSelect = true;
            this.Animals_list.GridLines = true;
            this.Animals_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Animals_list.HideSelection = false;
            this.Animals_list.Location = new System.Drawing.Point(19, 315);
            this.Animals_list.MultiSelect = false;
            this.Animals_list.Name = "Animals_list";
            this.Animals_list.ShowGroups = false;
            this.Animals_list.Size = new System.Drawing.Size(982, 500);
            this.Animals_list.TabIndex = 29;
            this.Animals_list.UseCompatibleStateImageBehavior = false;
            this.Animals_list.View = System.Windows.Forms.View.Details;
            this.Animals_list.SelectedIndexChanged += new System.EventHandler(this.Animals_list_SelectedIndexChanged);
            // 
            // AnimalImage
            // 
            this.AnimalImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimalImage.Location = new System.Drawing.Point(1007, 535);
            this.AnimalImage.Name = "AnimalImage";
            this.AnimalImage.Size = new System.Drawing.Size(493, 280);
            this.AnimalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimalImage.TabIndex = 30;
            this.AnimalImage.TabStop = false;
            // 
            // AnimalSpecs
            // 
            this.AnimalSpecs.Controls.Add(this.Animal_change_input);
            this.AnimalSpecs.Controls.Add(this.Animal_remove_input);
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
            this.AnimalSpecs.Location = new System.Drawing.Point(12, 27);
            this.AnimalSpecs.Name = "AnimalSpecs";
            this.AnimalSpecs.Size = new System.Drawing.Size(989, 248);
            this.AnimalSpecs.TabIndex = 31;
            this.AnimalSpecs.TabStop = false;
            this.AnimalSpecs.Text = "Animal Specifications";
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
            // Animal_age_input
            // 
            this.Animal_age_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_age_input.Location = new System.Drawing.Point(135, 49);
            this.Animal_age_input.Name = "Animal_age_input";
            this.Animal_age_input.Size = new System.Drawing.Size(138, 26);
            this.Animal_age_input.TabIndex = 5;
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
            // Animal_name_input
            // 
            this.Animal_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_name_input.Location = new System.Drawing.Point(135, 14);
            this.Animal_name_input.Name = "Animal_name_input";
            this.Animal_name_input.Size = new System.Drawing.Size(138, 26);
            this.Animal_name_input.TabIndex = 4;
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
            // Category_noLegs_input
            // 
            this.Category_noLegs_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_noLegs_input.Location = new System.Drawing.Point(135, 14);
            this.Category_noLegs_input.Name = "Category_noLegs_input";
            this.Category_noLegs_input.Size = new System.Drawing.Size(138, 26);
            this.Category_noLegs_input.TabIndex = 9;
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
            // Category_noteeth_input
            // 
            this.Category_noteeth_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_noteeth_input.Location = new System.Drawing.Point(135, 14);
            this.Category_noteeth_input.Name = "Category_noteeth_input";
            this.Category_noteeth_input.Size = new System.Drawing.Size(138, 26);
            this.Category_noteeth_input.TabIndex = 13;
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
            // Species_breed_input
            // 
            this.Species_breed_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_breed_input.Location = new System.Drawing.Point(135, 14);
            this.Species_breed_input.Name = "Species_breed_input";
            this.Species_breed_input.Size = new System.Drawing.Size(138, 26);
            this.Species_breed_input.TabIndex = 17;
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
            // Species_tailLength_input
            // 
            this.Species_tailLength_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Species_tailLength_input.Location = new System.Drawing.Point(135, 14);
            this.Species_tailLength_input.Name = "Species_tailLength_input";
            this.Species_tailLength_input.Size = new System.Drawing.Size(138, 26);
            this.Species_tailLength_input.TabIndex = 19;
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
            // Animal_add_input
            // 
            this.Animal_add_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Animal_add_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_add_input.Location = new System.Drawing.Point(862, 116);
            this.Animal_add_input.Name = "Animal_add_input";
            this.Animal_add_input.Size = new System.Drawing.Size(118, 56);
            this.Animal_add_input.TabIndex = 13;
            this.Animal_add_input.Text = "Add animal";
            this.Animal_add_input.UseVisualStyleBackColor = false;
            this.Animal_add_input.Click += new System.EventHandler(this.Animal_add_input_Click);
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
            // Animal_addRandom_input
            // 
            this.Animal_addRandom_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Animal_addRandom_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_addRandom_input.Location = new System.Drawing.Point(862, 59);
            this.Animal_addRandom_input.Name = "Animal_addRandom_input";
            this.Animal_addRandom_input.Size = new System.Drawing.Size(118, 56);
            this.Animal_addRandom_input.TabIndex = 20;
            this.Animal_addRandom_input.Text = "Add random animal";
            this.Animal_addRandom_input.UseVisualStyleBackColor = false;
            this.Animal_addRandom_input.Click += new System.EventHandler(this.Animal_addRandom_input_Click);
            // 
            // Animal_remove_input
            // 
            this.Animal_remove_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Animal_remove_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_remove_input.Location = new System.Drawing.Point(862, 211);
            this.Animal_remove_input.Name = "Animal_remove_input";
            this.Animal_remove_input.Size = new System.Drawing.Size(118, 34);
            this.Animal_remove_input.TabIndex = 21;
            this.Animal_remove_input.Text = "Remove animal";
            this.Animal_remove_input.UseVisualStyleBackColor = false;
            this.Animal_remove_input.Click += new System.EventHandler(this.Animal_remove_input_Click);
            // 
            // Animal_change_input
            // 
            this.Animal_change_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Animal_change_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animal_change_input.Location = new System.Drawing.Point(862, 175);
            this.Animal_change_input.Name = "Animal_change_input";
            this.Animal_change_input.Size = new System.Drawing.Size(118, 34);
            this.Animal_change_input.TabIndex = 22;
            this.Animal_change_input.Text = "Change animal";
            this.Animal_change_input.UseVisualStyleBackColor = false;
            this.Animal_change_input.Click += new System.EventHandler(this.Animal_change_input_Click);
            // 
            // List_sort_label
            // 
            this.List_sort_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_sort_label.AutoSize = true;
            this.List_sort_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_sort_label.Location = new System.Drawing.Point(753, 284);
            this.List_sort_label.Name = "List_sort_label";
            this.List_sort_label.Size = new System.Drawing.Size(86, 25);
            this.List_sort_label.TabIndex = 27;
            this.List_sort_label.Text = "Sort by:";
            // 
            // List_sort_input
            // 
            this.List_sort_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_sort_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_sort_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_sort_input.FormattingEnabled = true;
            this.List_sort_input.Location = new System.Drawing.Point(845, 281);
            this.List_sort_input.Name = "List_sort_input";
            this.List_sort_input.Size = new System.Drawing.Size(156, 28);
            this.List_sort_input.TabIndex = 26;
            this.List_sort_input.SelectedIndexChanged += new System.EventHandler(this.List_sort_input_SelectedIndexChanged);
            // 
            // FoodItems
            // 
            this.FoodItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodItems.Controls.Add(this.FoodItems_ConnectAnimal_input);
            this.FoodItems.Controls.Add(this.FoodItems_list);
            this.FoodItems.Controls.Add(this.FoodItems_NewFoodItem_input);
            this.FoodItems.Location = new System.Drawing.Point(1007, 27);
            this.FoodItems.Name = "FoodItems";
            this.FoodItems.Size = new System.Drawing.Size(493, 248);
            this.FoodItems.TabIndex = 32;
            this.FoodItems.TabStop = false;
            this.FoodItems.Text = "Food Items";
            // 
            // FoodItems_NewFoodItem_input
            // 
            this.FoodItems_NewFoodItem_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItems_NewFoodItem_input.Location = new System.Drawing.Point(6, 207);
            this.FoodItems_NewFoodItem_input.Name = "FoodItems_NewFoodItem_input";
            this.FoodItems_NewFoodItem_input.Size = new System.Drawing.Size(128, 34);
            this.FoodItems_NewFoodItem_input.TabIndex = 21;
            this.FoodItems_NewFoodItem_input.Text = "New Food Item";
            this.FoodItems_NewFoodItem_input.UseVisualStyleBackColor = true;
            this.FoodItems_NewFoodItem_input.Click += new System.EventHandler(this.Animal_foodItems_input_Click);
            // 
            // FoodItems_list
            // 
            this.FoodItems_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodItems_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodItems_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FoodItem_name_header,
            this.FoodItem_ingredients_header,
            this.FoodItem_animalID_header});
            this.FoodItems_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItems_list.FullRowSelect = true;
            this.FoodItems_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FoodItems_list.HideSelection = false;
            this.FoodItems_list.Location = new System.Drawing.Point(6, 19);
            this.FoodItems_list.MultiSelect = false;
            this.FoodItems_list.Name = "FoodItems_list";
            this.FoodItems_list.Size = new System.Drawing.Size(481, 184);
            this.FoodItems_list.TabIndex = 23;
            this.FoodItems_list.UseCompatibleStateImageBehavior = false;
            this.FoodItems_list.View = System.Windows.Forms.View.Details;
            // 
            // FoodItem_name_header
            // 
            this.FoodItem_name_header.Text = "Name";
            this.FoodItem_name_header.Width = 112;
            // 
            // FoodItem_ingredients_header
            // 
            this.FoodItem_ingredients_header.Text = "Ingredients";
            this.FoodItem_ingredients_header.Width = 278;
            // 
            // FoodItem_animalID_header
            // 
            this.FoodItem_animalID_header.Text = "Animal ID";
            this.FoodItem_animalID_header.Width = 76;
            // 
            // FoodItems_ConnectAnimal_input
            // 
            this.FoodItems_ConnectAnimal_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItems_ConnectAnimal_input.Location = new System.Drawing.Point(341, 207);
            this.FoodItems_ConnectAnimal_input.Name = "FoodItems_ConnectAnimal_input";
            this.FoodItems_ConnectAnimal_input.Size = new System.Drawing.Size(146, 34);
            this.FoodItems_ConnectAnimal_input.TabIndex = 24;
            this.FoodItems_ConnectAnimal_input.Text = "Connect Animal";
            this.FoodItems_ConnectAnimal_input.UseVisualStyleBackColor = true;
            this.FoodItems_ConnectAnimal_input.Click += new System.EventHandler(this.FoodItems_ConnectAnimal_input_Click);
            // 
            // FeedingSchedule
            // 
            this.FeedingSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedingSchedule.Controls.Add(this.FeedingSchedule_ConnectAnimal_input);
            this.FeedingSchedule.Controls.Add(this.FeedingSchedule_list);
            this.FeedingSchedule.Controls.Add(this.FoodSchedule_NewSchedule_input);
            this.FeedingSchedule.Location = new System.Drawing.Point(1007, 281);
            this.FeedingSchedule.Name = "FeedingSchedule";
            this.FeedingSchedule.Size = new System.Drawing.Size(493, 248);
            this.FeedingSchedule.TabIndex = 33;
            this.FeedingSchedule.TabStop = false;
            this.FeedingSchedule.Text = "Feeding Schedule";
            // 
            // FoodSchedule_NewSchedule_input
            // 
            this.FoodSchedule_NewSchedule_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodSchedule_NewSchedule_input.Location = new System.Drawing.Point(6, 207);
            this.FoodSchedule_NewSchedule_input.Name = "FoodSchedule_NewSchedule_input";
            this.FoodSchedule_NewSchedule_input.Size = new System.Drawing.Size(128, 34);
            this.FoodSchedule_NewSchedule_input.TabIndex = 21;
            this.FoodSchedule_NewSchedule_input.Text = "New Schedule";
            this.FoodSchedule_NewSchedule_input.UseVisualStyleBackColor = true;
            this.FoodSchedule_NewSchedule_input.Click += new System.EventHandler(this.FoodSchedule_NewSchedule_input_Click);
            // 
            // FeedingSchedule_list
            // 
            this.FeedingSchedule_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedingSchedule_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FeedingSchedule_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FeedingSchedule_diet_header,
            this.FeedingSchedule_foodItems_header,
            this.FeedingSchedule_animalID_header});
            this.FeedingSchedule_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedingSchedule_list.FullRowSelect = true;
            this.FeedingSchedule_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FeedingSchedule_list.HideSelection = false;
            this.FeedingSchedule_list.Location = new System.Drawing.Point(6, 19);
            this.FeedingSchedule_list.MultiSelect = false;
            this.FeedingSchedule_list.Name = "FeedingSchedule_list";
            this.FeedingSchedule_list.Size = new System.Drawing.Size(481, 184);
            this.FeedingSchedule_list.TabIndex = 23;
            this.FeedingSchedule_list.UseCompatibleStateImageBehavior = false;
            this.FeedingSchedule_list.View = System.Windows.Forms.View.Details;
            // 
            // FeedingSchedule_diet_header
            // 
            this.FeedingSchedule_diet_header.Text = "Diet";
            this.FeedingSchedule_diet_header.Width = 112;
            // 
            // FeedingSchedule_foodItems_header
            // 
            this.FeedingSchedule_foodItems_header.Text = "To be fed as follows:";
            this.FeedingSchedule_foodItems_header.Width = 278;
            // 
            // FeedingSchedule_animalID_header
            // 
            this.FeedingSchedule_animalID_header.Text = "Animal ID";
            this.FeedingSchedule_animalID_header.Width = 76;
            // 
            // FeedingSchedule_ConnectAnimal_input
            // 
            this.FeedingSchedule_ConnectAnimal_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedingSchedule_ConnectAnimal_input.Location = new System.Drawing.Point(341, 207);
            this.FeedingSchedule_ConnectAnimal_input.Name = "FeedingSchedule_ConnectAnimal_input";
            this.FeedingSchedule_ConnectAnimal_input.Size = new System.Drawing.Size(146, 34);
            this.FeedingSchedule_ConnectAnimal_input.TabIndex = 24;
            this.FeedingSchedule_ConnectAnimal_input.Text = "Connect Animal";
            this.FeedingSchedule_ConnectAnimal_input.UseVisualStyleBackColor = true;
            this.FeedingSchedule_ConnectAnimal_input.Click += new System.EventHandler(this.FeedingSchedule_ConnectAnimal_input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 827);
            this.Controls.Add(this.FeedingSchedule);
            this.Controls.Add(this.FoodItems);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.List_sort_input);
            this.Controls.Add(this.AnimalSpecs);
            this.Controls.Add(this.List_sort_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Animals_list);
            this.Controls.Add(this.AnimalImage);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalImage)).EndInit();
            this.AnimalSpecs.ResumeLayout(false);
            this.AnimalSpecs.PerformLayout();
            this.Animal_group.ResumeLayout(false);
            this.Animal_group.PerformLayout();
            this.Category_group.ResumeLayout(false);
            this.Category_group.PerformLayout();
            this.Species_group.ResumeLayout(false);
            this.Species_group.PerformLayout();
            this.FoodItems.ResumeLayout(false);
            this.FeedingSchedule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.OpenFileDialog FileDialog_image;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_new;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_open;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_open_text;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_open_binary;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_save;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_saveAs;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_saveAs_text;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_saveAs_binary;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_xml;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_exit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_xml_import;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_xml_export;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_save_text;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_save_binary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Animals_list;
        private System.Windows.Forms.PictureBox AnimalImage;
        private System.Windows.Forms.GroupBox AnimalSpecs;
        private System.Windows.Forms.Button Animal_change_input;
        private System.Windows.Forms.Button Animal_remove_input;
        private System.Windows.Forms.Button Animal_addRandom_input;
        private System.Windows.Forms.CheckBox ListAllAnimals_input;
        private System.Windows.Forms.Button Animal_add_input;
        public System.Windows.Forms.ComboBox Species_input;
        private System.Windows.Forms.GroupBox Species_group;
        public System.Windows.Forms.Label Species_tailLength_label;
        public System.Windows.Forms.TextBox Species_tailLength_input;
        public System.Windows.Forms.Label Species_isQueen_label;
        public System.Windows.Forms.CheckBox Species_isQueen_input;
        public System.Windows.Forms.Label Species_breed_label;
        public System.Windows.Forms.TextBox Species_breed_input;
        public System.Windows.Forms.Label Species_wingColor_label;
        public System.Windows.Forms.Button Species_wingColor_input;
        private System.Windows.Forms.Label Species_label;
        public System.Windows.Forms.ComboBox Category_input;
        private System.Windows.Forms.GroupBox Category_group;
        public System.Windows.Forms.Button Category_furColor_input;
        public System.Windows.Forms.Label Category_furColor_label;
        public System.Windows.Forms.Label Category_noteeth_label;
        public System.Windows.Forms.TextBox Category_noteeth_input;
        public System.Windows.Forms.CheckBox Category_canFly_input;
        public System.Windows.Forms.Label Categoty_canFly_label;
        public System.Windows.Forms.Label Category_noLegs_label;
        public System.Windows.Forms.TextBox Category_noLegs_input;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.GroupBox Animal_group;
        private System.Windows.Forms.Label Animal_name_label;
        public System.Windows.Forms.TextBox Animal_name_input;
        private System.Windows.Forms.Button Animal_image_input;
        private System.Windows.Forms.Label Animal_age_label;
        private System.Windows.Forms.Label Animal_image_label;
        public System.Windows.Forms.TextBox Animal_age_input;
        public System.Windows.Forms.ComboBox Animal_gender_input;
        private System.Windows.Forms.Label Animal_gender_label;
        private System.Windows.Forms.Label List_sort_label;
        public System.Windows.Forms.ComboBox List_sort_input;
        private System.Windows.Forms.GroupBox FoodItems;
        private System.Windows.Forms.Button FoodItems_ConnectAnimal_input;
        private System.Windows.Forms.ListView FoodItems_list;
        private System.Windows.Forms.ColumnHeader FoodItem_name_header;
        private System.Windows.Forms.ColumnHeader FoodItem_ingredients_header;
        private System.Windows.Forms.ColumnHeader FoodItem_animalID_header;
        private System.Windows.Forms.Button FoodItems_NewFoodItem_input;
        private System.Windows.Forms.GroupBox FeedingSchedule;
        private System.Windows.Forms.Button FeedingSchedule_ConnectAnimal_input;
        private System.Windows.Forms.ListView FeedingSchedule_list;
        private System.Windows.Forms.ColumnHeader FeedingSchedule_diet_header;
        private System.Windows.Forms.ColumnHeader FeedingSchedule_foodItems_header;
        private System.Windows.Forms.ColumnHeader FeedingSchedule_animalID_header;
        private System.Windows.Forms.Button FoodSchedule_NewSchedule_input;
    }
}

