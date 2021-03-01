
namespace Assignment3
{
    partial class FeedingScheduleForm
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
            this.AddSchedule_cancel = new System.Windows.Forms.Button();
            this.AddSchedule_ok = new System.Windows.Forms.Button();
            this.AddDescriptions = new System.Windows.Forms.GroupBox();
            this.AddSchedule_description_collection = new System.Windows.Forms.ListView();
            this.AddSchedule_delete_input = new System.Windows.Forms.Button();
            this.AddSchedule_change_input = new System.Windows.Forms.Button();
            this.AddSchedule_add_input = new System.Windows.Forms.Button();
            this.AddSchedule_description_label = new System.Windows.Forms.Label();
            this.AddSchedule_description_input = new System.Windows.Forms.TextBox();
            this.AddSchedule_diet_label = new System.Windows.Forms.Label();
            this.AddSchedule_diet_input = new System.Windows.Forms.TextBox();
            this.AddDescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSchedule_cancel
            // 
            this.AddSchedule_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSchedule_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_cancel.Location = new System.Drawing.Point(200, 319);
            this.AddSchedule_cancel.Name = "AddSchedule_cancel";
            this.AddSchedule_cancel.Size = new System.Drawing.Size(108, 34);
            this.AddSchedule_cancel.TabIndex = 35;
            this.AddSchedule_cancel.Text = "Cancel";
            this.AddSchedule_cancel.UseVisualStyleBackColor = true;
            this.AddSchedule_cancel.Click += new System.EventHandler(this.AddSchedule_cancel_Click);
            // 
            // AddSchedule_ok
            // 
            this.AddSchedule_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSchedule_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_ok.Location = new System.Drawing.Point(86, 319);
            this.AddSchedule_ok.Name = "AddSchedule_ok";
            this.AddSchedule_ok.Size = new System.Drawing.Size(108, 34);
            this.AddSchedule_ok.TabIndex = 34;
            this.AddSchedule_ok.Text = "OK";
            this.AddSchedule_ok.UseVisualStyleBackColor = true;
            this.AddSchedule_ok.Click += new System.EventHandler(this.AddSchedule_ok_Click);
            // 
            // AddDescriptions
            // 
            this.AddDescriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDescriptions.Controls.Add(this.AddSchedule_description_collection);
            this.AddDescriptions.Controls.Add(this.AddSchedule_delete_input);
            this.AddDescriptions.Controls.Add(this.AddSchedule_change_input);
            this.AddDescriptions.Controls.Add(this.AddSchedule_add_input);
            this.AddDescriptions.Controls.Add(this.AddSchedule_description_label);
            this.AddDescriptions.Controls.Add(this.AddSchedule_description_input);
            this.AddDescriptions.Location = new System.Drawing.Point(12, 54);
            this.AddDescriptions.Name = "AddDescriptions";
            this.AddDescriptions.Size = new System.Drawing.Size(377, 257);
            this.AddDescriptions.TabIndex = 33;
            this.AddDescriptions.TabStop = false;
            this.AddDescriptions.Text = "Add Descriptions";
            // 
            // AddSchedule_description_collection
            // 
            this.AddSchedule_description_collection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddSchedule_description_collection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_description_collection.FullRowSelect = true;
            this.AddSchedule_description_collection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AddSchedule_description_collection.HideSelection = false;
            this.AddSchedule_description_collection.Location = new System.Drawing.Point(120, 78);
            this.AddSchedule_description_collection.MultiSelect = false;
            this.AddSchedule_description_collection.Name = "AddSchedule_description_collection";
            this.AddSchedule_description_collection.Size = new System.Drawing.Size(251, 167);
            this.AddSchedule_description_collection.TabIndex = 30;
            this.AddSchedule_description_collection.UseCompatibleStateImageBehavior = false;
            this.AddSchedule_description_collection.View = System.Windows.Forms.View.List;
            this.AddSchedule_description_collection.SelectedIndexChanged += new System.EventHandler(this.AddSchedule_description_collection_SelectedIndexChanged);
            // 
            // AddSchedule_delete_input
            // 
            this.AddSchedule_delete_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddSchedule_delete_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_delete_input.Location = new System.Drawing.Point(6, 158);
            this.AddSchedule_delete_input.Name = "AddSchedule_delete_input";
            this.AddSchedule_delete_input.Size = new System.Drawing.Size(108, 34);
            this.AddSchedule_delete_input.TabIndex = 28;
            this.AddSchedule_delete_input.Text = "Delete";
            this.AddSchedule_delete_input.UseVisualStyleBackColor = false;
            this.AddSchedule_delete_input.Click += new System.EventHandler(this.AddSchedule_delete_input_Click);
            // 
            // AddSchedule_change_input
            // 
            this.AddSchedule_change_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddSchedule_change_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_change_input.Location = new System.Drawing.Point(6, 118);
            this.AddSchedule_change_input.Name = "AddSchedule_change_input";
            this.AddSchedule_change_input.Size = new System.Drawing.Size(108, 34);
            this.AddSchedule_change_input.TabIndex = 27;
            this.AddSchedule_change_input.Text = "Change";
            this.AddSchedule_change_input.UseVisualStyleBackColor = false;
            this.AddSchedule_change_input.Click += new System.EventHandler(this.AddSchedule_change_input_Click);
            // 
            // AddSchedule_add_input
            // 
            this.AddSchedule_add_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddSchedule_add_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_add_input.Location = new System.Drawing.Point(6, 78);
            this.AddSchedule_add_input.Name = "AddSchedule_add_input";
            this.AddSchedule_add_input.Size = new System.Drawing.Size(108, 34);
            this.AddSchedule_add_input.TabIndex = 26;
            this.AddSchedule_add_input.Text = "Add";
            this.AddSchedule_add_input.UseVisualStyleBackColor = false;
            this.AddSchedule_add_input.Click += new System.EventHandler(this.AddSchedule_add_input_Click);
            // 
            // AddSchedule_description_label
            // 
            this.AddSchedule_description_label.AutoSize = true;
            this.AddSchedule_description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_description_label.Location = new System.Drawing.Point(6, 29);
            this.AddSchedule_description_label.Name = "AddSchedule_description_label";
            this.AddSchedule_description_label.Size = new System.Drawing.Size(109, 24);
            this.AddSchedule_description_label.TabIndex = 23;
            this.AddSchedule_description_label.Text = "Description:";
            // 
            // AddSchedule_description_input
            // 
            this.AddSchedule_description_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSchedule_description_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_description_input.Location = new System.Drawing.Point(120, 29);
            this.AddSchedule_description_input.Name = "AddSchedule_description_input";
            this.AddSchedule_description_input.Size = new System.Drawing.Size(251, 26);
            this.AddSchedule_description_input.TabIndex = 24;
            this.AddSchedule_description_input.TextChanged += new System.EventHandler(this.AddSchedule_description_input_TextChanged);
            // 
            // AddSchedule_diet_label
            // 
            this.AddSchedule_diet_label.AutoSize = true;
            this.AddSchedule_diet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_diet_label.Location = new System.Drawing.Point(12, 9);
            this.AddSchedule_diet_label.Name = "AddSchedule_diet_label";
            this.AddSchedule_diet_label.Size = new System.Drawing.Size(56, 25);
            this.AddSchedule_diet_label.TabIndex = 31;
            this.AddSchedule_diet_label.Text = "Diet:";
            // 
            // AddSchedule_diet_input
            // 
            this.AddSchedule_diet_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSchedule_diet_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedule_diet_input.Location = new System.Drawing.Point(132, 10);
            this.AddSchedule_diet_input.Name = "AddSchedule_diet_input";
            this.AddSchedule_diet_input.Size = new System.Drawing.Size(251, 26);
            this.AddSchedule_diet_input.TabIndex = 32;
            this.AddSchedule_diet_input.TextChanged += new System.EventHandler(this.AddSchedule_diet_input_TextChanged);
            // 
            // FeedingScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 363);
            this.Controls.Add(this.AddSchedule_cancel);
            this.Controls.Add(this.AddSchedule_ok);
            this.Controls.Add(this.AddDescriptions);
            this.Controls.Add(this.AddSchedule_diet_label);
            this.Controls.Add(this.AddSchedule_diet_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FeedingScheduleForm";
            this.Text = "Add Feeding Schedule";
            this.AddDescriptions.ResumeLayout(false);
            this.AddDescriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSchedule_cancel;
        private System.Windows.Forms.Button AddSchedule_ok;
        private System.Windows.Forms.GroupBox AddDescriptions;
        private System.Windows.Forms.ListView AddSchedule_description_collection;
        private System.Windows.Forms.Button AddSchedule_delete_input;
        private System.Windows.Forms.Button AddSchedule_change_input;
        private System.Windows.Forms.Button AddSchedule_add_input;
        private System.Windows.Forms.Label AddSchedule_description_label;
        public System.Windows.Forms.TextBox AddSchedule_description_input;
        private System.Windows.Forms.Label AddSchedule_diet_label;
        private System.Windows.Forms.TextBox AddSchedule_diet_input;
    }
}