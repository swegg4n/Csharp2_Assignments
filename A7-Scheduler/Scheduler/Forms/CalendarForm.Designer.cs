
namespace Scheduler
{
    partial class CalendarForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.NewEvent_Cal = new System.Windows.Forms.Button();
            this.Admin_Cal = new System.Windows.Forms.Button();
            this.prevMonth_Cal = new System.Windows.Forms.Button();
            this.nextMonth_Cal = new System.Windows.Forms.Button();
            this.Today_Cal = new System.Windows.Forms.Button();
            this.TodayIndicator_Cal = new System.Windows.Forms.PictureBox();
            this.CalGrid_Cal = new System.Windows.Forms.DataGridView();
            this.ToolTip_Cal = new System.Windows.Forms.ToolTip(this.components);
            this.Header_Cal = new System.Windows.Forms.DataGridView();
            this.MonthYear_Cal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TodayIndicator_Cal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalGrid_Cal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_Cal)).BeginInit();
            this.SuspendLayout();
            // 
            // NewEvent_Cal
            // 
            this.NewEvent_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEvent_Cal.Location = new System.Drawing.Point(12, 12);
            this.NewEvent_Cal.Name = "NewEvent_Cal";
            this.NewEvent_Cal.Size = new System.Drawing.Size(37, 37);
            this.NewEvent_Cal.TabIndex = 0;
            this.NewEvent_Cal.Text = "+";
            this.NewEvent_Cal.UseVisualStyleBackColor = true;
            this.NewEvent_Cal.Click += new System.EventHandler(this.NewEvent_Cal_Click);
            // 
            // Admin_Cal
            // 
            this.Admin_Cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Admin_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Cal.Location = new System.Drawing.Point(1167, 12);
            this.Admin_Cal.Name = "Admin_Cal";
            this.Admin_Cal.Size = new System.Drawing.Size(85, 37);
            this.Admin_Cal.TabIndex = 5;
            this.Admin_Cal.Text = "Admin";
            this.Admin_Cal.UseVisualStyleBackColor = true;
            this.Admin_Cal.Click += new System.EventHandler(this.Admin_Cal_Click);
            // 
            // prevMonth_Cal
            // 
            this.prevMonth_Cal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevMonth_Cal.Location = new System.Drawing.Point(279, 12);
            this.prevMonth_Cal.Name = "prevMonth_Cal";
            this.prevMonth_Cal.Size = new System.Drawing.Size(37, 37);
            this.prevMonth_Cal.TabIndex = 2;
            this.prevMonth_Cal.Text = "<";
            this.prevMonth_Cal.UseVisualStyleBackColor = true;
            this.prevMonth_Cal.Click += new System.EventHandler(this.prevMonth_Cal_Click);
            // 
            // nextMonth_Cal
            // 
            this.nextMonth_Cal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMonth_Cal.Location = new System.Drawing.Point(316, 12);
            this.nextMonth_Cal.Name = "nextMonth_Cal";
            this.nextMonth_Cal.Size = new System.Drawing.Size(37, 37);
            this.nextMonth_Cal.TabIndex = 3;
            this.nextMonth_Cal.Text = ">";
            this.nextMonth_Cal.UseVisualStyleBackColor = true;
            this.nextMonth_Cal.Click += new System.EventHandler(this.nextMonth_Cal_Click);
            // 
            // Today_Cal
            // 
            this.Today_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today_Cal.Location = new System.Drawing.Point(191, 12);
            this.Today_Cal.Name = "Today_Cal";
            this.Today_Cal.Size = new System.Drawing.Size(66, 37);
            this.Today_Cal.TabIndex = 1;
            this.Today_Cal.Text = "Idag";
            this.Today_Cal.UseVisualStyleBackColor = true;
            this.Today_Cal.Click += new System.EventHandler(this.Today_Cal_Click);
            // 
            // TodayIndicator_Cal
            // 
            this.TodayIndicator_Cal.BackColor = System.Drawing.Color.Red;
            this.TodayIndicator_Cal.InitialImage = null;
            this.TodayIndicator_Cal.Location = new System.Drawing.Point(607, -1);
            this.TodayIndicator_Cal.Name = "TodayIndicator_Cal";
            this.TodayIndicator_Cal.Size = new System.Drawing.Size(1, 713);
            this.TodayIndicator_Cal.TabIndex = 10;
            this.TodayIndicator_Cal.TabStop = false;
            // 
            // CalGrid_Cal
            // 
            this.CalGrid_Cal.AllowUserToAddRows = false;
            this.CalGrid_Cal.AllowUserToDeleteRows = false;
            this.CalGrid_Cal.AllowUserToResizeColumns = false;
            this.CalGrid_Cal.AllowUserToResizeRows = false;
            this.CalGrid_Cal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalGrid_Cal.BackgroundColor = System.Drawing.Color.White;
            this.CalGrid_Cal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalGrid_Cal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalGrid_Cal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CalGrid_Cal.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CalGrid_Cal.DefaultCellStyle = dataGridViewCellStyle2;
            this.CalGrid_Cal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CalGrid_Cal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.CalGrid_Cal.Location = new System.Drawing.Point(12, 130);
            this.CalGrid_Cal.MultiSelect = false;
            this.CalGrid_Cal.Name = "CalGrid_Cal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalGrid_Cal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CalGrid_Cal.RowHeadersVisible = false;
            this.CalGrid_Cal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CalGrid_Cal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CalGrid_Cal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CalGrid_Cal.ShowCellErrors = false;
            this.CalGrid_Cal.ShowCellToolTips = false;
            this.CalGrid_Cal.ShowEditingIcon = false;
            this.CalGrid_Cal.ShowRowErrors = false;
            this.CalGrid_Cal.Size = new System.Drawing.Size(1248, 539);
            this.CalGrid_Cal.TabIndex = 4;
            // 
            // Header_Cal
            // 
            this.Header_Cal.AllowUserToAddRows = false;
            this.Header_Cal.AllowUserToDeleteRows = false;
            this.Header_Cal.AllowUserToResizeColumns = false;
            this.Header_Cal.AllowUserToResizeRows = false;
            this.Header_Cal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Cal.BackgroundColor = System.Drawing.Color.White;
            this.Header_Cal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header_Cal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Header_Cal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Header_Cal.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Header_Cal.DefaultCellStyle = dataGridViewCellStyle5;
            this.Header_Cal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Header_Cal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Header_Cal.Location = new System.Drawing.Point(191, 55);
            this.Header_Cal.MultiSelect = false;
            this.Header_Cal.Name = "Header_Cal";
            this.Header_Cal.RowHeadersVisible = false;
            this.Header_Cal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Header_Cal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Header_Cal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Header_Cal.ShowCellErrors = false;
            this.Header_Cal.ShowCellToolTips = false;
            this.Header_Cal.ShowEditingIcon = false;
            this.Header_Cal.ShowRowErrors = false;
            this.Header_Cal.Size = new System.Drawing.Size(1069, 69);
            this.Header_Cal.TabIndex = 11;
            // 
            // MonthYear_Cal
            // 
            this.MonthYear_Cal.AutoSize = true;
            this.MonthYear_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYear_Cal.Location = new System.Drawing.Point(359, 18);
            this.MonthYear_Cal.Name = "MonthYear_Cal";
            this.MonthYear_Cal.Size = new System.Drawing.Size(155, 29);
            this.MonthYear_Cal.TabIndex = 6;
            this.MonthYear_Cal.Text = "Januari, 2020";
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TodayIndicator_Cal);
            this.Controls.Add(this.Header_Cal);
            this.Controls.Add(this.CalGrid_Cal);
            this.Controls.Add(this.Today_Cal);
            this.Controls.Add(this.MonthYear_Cal);
            this.Controls.Add(this.nextMonth_Cal);
            this.Controls.Add(this.prevMonth_Cal);
            this.Controls.Add(this.Admin_Cal);
            this.Controls.Add(this.NewEvent_Cal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarForm";
            this.Text = "Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.TodayIndicator_Cal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalGrid_Cal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header_Cal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewEvent_Cal;
        private System.Windows.Forms.Button Admin_Cal;
        private System.Windows.Forms.Button prevMonth_Cal;
        private System.Windows.Forms.Button nextMonth_Cal;
        private System.Windows.Forms.Button Today_Cal;
        private System.Windows.Forms.PictureBox TodayIndicator_Cal;
        private System.Windows.Forms.ToolTip ToolTip_Cal;
        public System.Windows.Forms.DataGridView CalGrid_Cal;
        public System.Windows.Forms.DataGridView Header_Cal;
        public System.Windows.Forms.Label MonthYear_Cal;
    }
}

