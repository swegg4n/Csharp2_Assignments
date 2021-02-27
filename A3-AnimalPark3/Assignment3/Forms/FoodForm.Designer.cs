
namespace Assignment3
{
    partial class FoodForm
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
            this.AddFood_name_label = new System.Windows.Forms.Label();
            this.AddFood_name_input = new System.Windows.Forms.TextBox();
            this.AddIngredients = new System.Windows.Forms.GroupBox();
            this.AddFood_ingredients_collection = new System.Windows.Forms.ListView();
            this.AddFood_delete_input = new System.Windows.Forms.Button();
            this.AddFood_change_input = new System.Windows.Forms.Button();
            this.AddFood_add_input = new System.Windows.Forms.Button();
            this.AddFood_ingredient_label = new System.Windows.Forms.Label();
            this.AddFood_ingredient_input = new System.Windows.Forms.TextBox();
            this.AddFood_ok = new System.Windows.Forms.Button();
            this.AddFood_cancel = new System.Windows.Forms.Button();
            this.AddIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFood_name_label
            // 
            this.AddFood_name_label.AutoSize = true;
            this.AddFood_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_name_label.Location = new System.Drawing.Point(12, 9);
            this.AddFood_name_label.Name = "AddFood_name_label";
            this.AddFood_name_label.Size = new System.Drawing.Size(74, 25);
            this.AddFood_name_label.TabIndex = 5;
            this.AddFood_name_label.Text = "Name:";
            // 
            // AddFood_name_input
            // 
            this.AddFood_name_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFood_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_name_input.Location = new System.Drawing.Point(132, 10);
            this.AddFood_name_input.Name = "AddFood_name_input";
            this.AddFood_name_input.Size = new System.Drawing.Size(251, 26);
            this.AddFood_name_input.TabIndex = 6;
            this.AddFood_name_input.TextChanged += new System.EventHandler(this.AddFood_name_input_TextChanged);
            // 
            // AddIngredients
            // 
            this.AddIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIngredients.Controls.Add(this.AddFood_ingredients_collection);
            this.AddIngredients.Controls.Add(this.AddFood_delete_input);
            this.AddIngredients.Controls.Add(this.AddFood_change_input);
            this.AddIngredients.Controls.Add(this.AddFood_add_input);
            this.AddIngredients.Controls.Add(this.AddFood_ingredient_label);
            this.AddIngredients.Controls.Add(this.AddFood_ingredient_input);
            this.AddIngredients.Location = new System.Drawing.Point(12, 54);
            this.AddIngredients.Name = "AddIngredients";
            this.AddIngredients.Size = new System.Drawing.Size(377, 257);
            this.AddIngredients.TabIndex = 22;
            this.AddIngredients.TabStop = false;
            this.AddIngredients.Text = "Add Ingredients";
            // 
            // AddFood_ingredients_collection
            // 
            this.AddFood_ingredients_collection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddFood_ingredients_collection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_ingredients_collection.FullRowSelect = true;
            this.AddFood_ingredients_collection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AddFood_ingredients_collection.HideSelection = false;
            this.AddFood_ingredients_collection.Location = new System.Drawing.Point(120, 78);
            this.AddFood_ingredients_collection.MultiSelect = false;
            this.AddFood_ingredients_collection.Name = "AddFood_ingredients_collection";
            this.AddFood_ingredients_collection.Size = new System.Drawing.Size(251, 167);
            this.AddFood_ingredients_collection.TabIndex = 30;
            this.AddFood_ingredients_collection.UseCompatibleStateImageBehavior = false;
            this.AddFood_ingredients_collection.View = System.Windows.Forms.View.List;
            this.AddFood_ingredients_collection.SelectedIndexChanged += new System.EventHandler(this.AddFood_ingredients_collection_SelectedIndexChanged);
            // 
            // AddFood_delete_input
            // 
            this.AddFood_delete_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddFood_delete_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_delete_input.Location = new System.Drawing.Point(6, 158);
            this.AddFood_delete_input.Name = "AddFood_delete_input";
            this.AddFood_delete_input.Size = new System.Drawing.Size(108, 34);
            this.AddFood_delete_input.TabIndex = 28;
            this.AddFood_delete_input.Text = "Delete";
            this.AddFood_delete_input.UseVisualStyleBackColor = false;
            this.AddFood_delete_input.Click += new System.EventHandler(this.AddFood_delete_input_Click);
            // 
            // AddFood_change_input
            // 
            this.AddFood_change_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddFood_change_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_change_input.Location = new System.Drawing.Point(6, 118);
            this.AddFood_change_input.Name = "AddFood_change_input";
            this.AddFood_change_input.Size = new System.Drawing.Size(108, 34);
            this.AddFood_change_input.TabIndex = 27;
            this.AddFood_change_input.Text = "Change";
            this.AddFood_change_input.UseVisualStyleBackColor = false;
            this.AddFood_change_input.Click += new System.EventHandler(this.AddFood_change_input_Click);
            // 
            // AddFood_add_input
            // 
            this.AddFood_add_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddFood_add_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_add_input.Location = new System.Drawing.Point(6, 78);
            this.AddFood_add_input.Name = "AddFood_add_input";
            this.AddFood_add_input.Size = new System.Drawing.Size(108, 34);
            this.AddFood_add_input.TabIndex = 26;
            this.AddFood_add_input.Text = "Add";
            this.AddFood_add_input.UseVisualStyleBackColor = false;
            this.AddFood_add_input.Click += new System.EventHandler(this.AddFood_add_input_Click);
            // 
            // AddFood_ingredient_label
            // 
            this.AddFood_ingredient_label.AutoSize = true;
            this.AddFood_ingredient_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_ingredient_label.Location = new System.Drawing.Point(6, 29);
            this.AddFood_ingredient_label.Name = "AddFood_ingredient_label";
            this.AddFood_ingredient_label.Size = new System.Drawing.Size(99, 24);
            this.AddFood_ingredient_label.TabIndex = 23;
            this.AddFood_ingredient_label.Text = "Ingredient:";
            // 
            // AddFood_ingredient_input
            // 
            this.AddFood_ingredient_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFood_ingredient_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_ingredient_input.Location = new System.Drawing.Point(120, 29);
            this.AddFood_ingredient_input.Name = "AddFood_ingredient_input";
            this.AddFood_ingredient_input.Size = new System.Drawing.Size(251, 26);
            this.AddFood_ingredient_input.TabIndex = 24;
            this.AddFood_ingredient_input.TextChanged += new System.EventHandler(this.AddFood_ingredient_input_TextChanged);
            // 
            // AddFood_ok
            // 
            this.AddFood_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFood_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_ok.Location = new System.Drawing.Point(86, 319);
            this.AddFood_ok.Name = "AddFood_ok";
            this.AddFood_ok.Size = new System.Drawing.Size(108, 34);
            this.AddFood_ok.TabIndex = 29;
            this.AddFood_ok.Text = "OK";
            this.AddFood_ok.UseVisualStyleBackColor = true;
            this.AddFood_ok.Click += new System.EventHandler(this.AddFood_ok_Click);
            // 
            // AddFood_cancel
            // 
            this.AddFood_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFood_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood_cancel.Location = new System.Drawing.Point(200, 319);
            this.AddFood_cancel.Name = "AddFood_cancel";
            this.AddFood_cancel.Size = new System.Drawing.Size(108, 34);
            this.AddFood_cancel.TabIndex = 30;
            this.AddFood_cancel.Text = "Cancel";
            this.AddFood_cancel.UseVisualStyleBackColor = true;
            this.AddFood_cancel.Click += new System.EventHandler(this.AddFood_cancel_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 363);
            this.Controls.Add(this.AddFood_cancel);
            this.Controls.Add(this.AddFood_ok);
            this.Controls.Add(this.AddIngredients);
            this.Controls.Add(this.AddFood_name_label);
            this.Controls.Add(this.AddFood_name_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FoodForm";
            this.Text = "Add Food";
            this.TopMost = true;
            this.AddIngredients.ResumeLayout(false);
            this.AddIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddFood_name_label;
        public System.Windows.Forms.TextBox AddFood_name_input;
        private System.Windows.Forms.GroupBox AddIngredients;
        private System.Windows.Forms.Label AddFood_ingredient_label;
        public System.Windows.Forms.TextBox AddFood_ingredient_input;
        private System.Windows.Forms.Button AddFood_delete_input;
        private System.Windows.Forms.Button AddFood_change_input;
        private System.Windows.Forms.Button AddFood_add_input;
        private System.Windows.Forms.Button AddFood_cancel;
        private System.Windows.Forms.Button AddFood_ok;
        private System.Windows.Forms.ListView AddFood_ingredients_collection;
    }
}