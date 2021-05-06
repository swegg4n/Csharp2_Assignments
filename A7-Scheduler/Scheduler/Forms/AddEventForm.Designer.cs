
namespace Scheduler
{
    partial class AddEventForm
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
            this.InfoInput_AddEvent = new System.Windows.Forms.TextBox();
            this.EventTypeInput_AddEvent = new System.Windows.Forms.ComboBox();
            this.DayPart_fm_AddEvent = new System.Windows.Forms.RadioButton();
            this.DayPart_am_AddEvent = new System.Windows.Forms.RadioButton();
            this.DateToInput_AddEvent = new System.Windows.Forms.DateTimePicker();
            this.DateFromInput_AddEvent = new System.Windows.Forms.DateTimePicker();
            this.SignInput_AddEvent = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Sign_addEvent = new System.Windows.Forms.Label();
            this.DateFrom_AddEvent = new System.Windows.Forms.Label();
            this.DateTo_AddEvent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventType_AddEvent = new System.Windows.Forms.Label();
            this.Info_AddEvent = new System.Windows.Forms.Label();
            this.DayPart_amfm_AddEvent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_AddEvent = new System.Windows.Forms.Button();
            this.Cancel_AddEvent = new System.Windows.Forms.Button();
            this.MultipleDays_AddEvent = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoInput_AddEvent
            // 
            this.InfoInput_AddEvent.BackColor = System.Drawing.Color.White;
            this.InfoInput_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoInput_AddEvent.Location = new System.Drawing.Point(219, 232);
            this.InfoInput_AddEvent.Name = "InfoInput_AddEvent";
            this.InfoInput_AddEvent.Size = new System.Drawing.Size(286, 29);
            this.InfoInput_AddEvent.TabIndex = 8;
            // 
            // EventTypeInput_AddEvent
            // 
            this.EventTypeInput_AddEvent.BackColor = System.Drawing.Color.White;
            this.EventTypeInput_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTypeInput_AddEvent.FormattingEnabled = true;
            this.EventTypeInput_AddEvent.ItemHeight = 24;
            this.EventTypeInput_AddEvent.Location = new System.Drawing.Point(219, 188);
            this.EventTypeInput_AddEvent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.EventTypeInput_AddEvent.Name = "EventTypeInput_AddEvent";
            this.EventTypeInput_AddEvent.Size = new System.Drawing.Size(286, 32);
            this.EventTypeInput_AddEvent.TabIndex = 7;
            // 
            // DayPart_fm_AddEvent
            // 
            this.DayPart_fm_AddEvent.AutoSize = true;
            this.DayPart_fm_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayPart_fm_AddEvent.Location = new System.Drawing.Point(400, 149);
            this.DayPart_fm_AddEvent.Name = "DayPart_fm_AddEvent";
            this.DayPart_fm_AddEvent.Size = new System.Drawing.Size(105, 22);
            this.DayPart_fm_AddEvent.TabIndex = 6;
            this.DayPart_fm_AddEvent.TabStop = true;
            this.DayPart_fm_AddEvent.Text = "Eftermiddag";
            this.DayPart_fm_AddEvent.UseVisualStyleBackColor = true;
            // 
            // DayPart_am_AddEvent
            // 
            this.DayPart_am_AddEvent.AutoSize = true;
            this.DayPart_am_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayPart_am_AddEvent.Location = new System.Drawing.Point(297, 149);
            this.DayPart_am_AddEvent.Name = "DayPart_am_AddEvent";
            this.DayPart_am_AddEvent.Size = new System.Drawing.Size(97, 22);
            this.DayPart_am_AddEvent.TabIndex = 5;
            this.DayPart_am_AddEvent.TabStop = true;
            this.DayPart_am_AddEvent.Text = "Förmiddag";
            this.DayPart_am_AddEvent.UseVisualStyleBackColor = true;
            // 
            // DateToInput_AddEvent
            // 
            this.DateToInput_AddEvent.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateToInput_AddEvent.CustomFormat = "yyyy-MM-dd";
            this.DateToInput_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToInput_AddEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateToInput_AddEvent.Location = new System.Drawing.Point(219, 99);
            this.DateToInput_AddEvent.Name = "DateToInput_AddEvent";
            this.DateToInput_AddEvent.Size = new System.Drawing.Size(176, 29);
            this.DateToInput_AddEvent.TabIndex = 3;
            this.DateToInput_AddEvent.Tag = "";
            // 
            // DateFromInput_AddEvent
            // 
            this.DateFromInput_AddEvent.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateFromInput_AddEvent.CustomFormat = "yyyy-MM-dd";
            this.DateFromInput_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFromInput_AddEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFromInput_AddEvent.Location = new System.Drawing.Point(219, 55);
            this.DateFromInput_AddEvent.Name = "DateFromInput_AddEvent";
            this.DateFromInput_AddEvent.Size = new System.Drawing.Size(176, 29);
            this.DateFromInput_AddEvent.TabIndex = 1;
            this.DateFromInput_AddEvent.Tag = "";
            this.DateFromInput_AddEvent.ValueChanged += new System.EventHandler(this.DateFromInput_AddEvent_ValueChanged);
            // 
            // SignInput_AddEvent
            // 
            this.SignInput_AddEvent.BackColor = System.Drawing.Color.White;
            this.SignInput_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInput_AddEvent.FormattingEnabled = true;
            this.SignInput_AddEvent.ItemHeight = 24;
            this.SignInput_AddEvent.Location = new System.Drawing.Point(219, 12);
            this.SignInput_AddEvent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.SignInput_AddEvent.Name = "SignInput_AddEvent";
            this.SignInput_AddEvent.Size = new System.Drawing.Size(176, 32);
            this.SignInput_AddEvent.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Sign_addEvent);
            this.flowLayoutPanel1.Controls.Add(this.DateFrom_AddEvent);
            this.flowLayoutPanel1.Controls.Add(this.DateTo_AddEvent);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.EventType_AddEvent);
            this.flowLayoutPanel1.Controls.Add(this.Info_AddEvent);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 269);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Sign_addEvent
            // 
            this.Sign_addEvent.AutoSize = true;
            this.Sign_addEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_addEvent.Location = new System.Drawing.Point(0, 0);
            this.Sign_addEvent.Margin = new System.Windows.Forms.Padding(0);
            this.Sign_addEvent.Name = "Sign_addEvent";
            this.Sign_addEvent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Sign_addEvent.Size = new System.Drawing.Size(75, 44);
            this.Sign_addEvent.TabIndex = 3;
            this.Sign_addEvent.Text = "Initialer*";
            // 
            // DateFrom_AddEvent
            // 
            this.DateFrom_AddEvent.AutoSize = true;
            this.DateFrom_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrom_AddEvent.Location = new System.Drawing.Point(0, 44);
            this.DateFrom_AddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.DateFrom_AddEvent.Name = "DateFrom_AddEvent";
            this.DateFrom_AddEvent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.DateFrom_AddEvent.Size = new System.Drawing.Size(118, 44);
            this.DateFrom_AddEvent.TabIndex = 4;
            this.DateFrom_AddEvent.Text = "Datum - från*";
            // 
            // DateTo_AddEvent
            // 
            this.DateTo_AddEvent.AutoSize = true;
            this.DateTo_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTo_AddEvent.Location = new System.Drawing.Point(0, 88);
            this.DateTo_AddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.DateTo_AddEvent.Name = "DateTo_AddEvent";
            this.DateTo_AddEvent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.DateTo_AddEvent.Size = new System.Drawing.Size(126, 44);
            this.DateTo_AddEvent.TabIndex = 5;
            this.DateTo_AddEvent.Text = "Datum - t.o.m.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label2.Size = new System.Drawing.Size(106, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Del av dag*";
            // 
            // EventType_AddEvent
            // 
            this.EventType_AddEvent.AutoSize = true;
            this.EventType_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventType_AddEvent.Location = new System.Drawing.Point(0, 176);
            this.EventType_AddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.EventType_AddEvent.Name = "EventType_AddEvent";
            this.EventType_AddEvent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.EventType_AddEvent.Size = new System.Drawing.Size(156, 44);
            this.EventType_AddEvent.TabIndex = 6;
            this.EventType_AddEvent.Text = "Typ av händelse*";
            // 
            // Info_AddEvent
            // 
            this.Info_AddEvent.AutoSize = true;
            this.Info_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_AddEvent.Location = new System.Drawing.Point(0, 220);
            this.Info_AddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.Info_AddEvent.Name = "Info_AddEvent";
            this.Info_AddEvent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Info_AddEvent.Size = new System.Drawing.Size(90, 44);
            this.Info_AddEvent.TabIndex = 7;
            this.Info_AddEvent.Text = "Övrig info";
            // 
            // DayPart_amfm_AddEvent
            // 
            this.DayPart_amfm_AddEvent.AutoSize = true;
            this.DayPart_amfm_AddEvent.Checked = true;
            this.DayPart_amfm_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayPart_amfm_AddEvent.Location = new System.Drawing.Point(219, 149);
            this.DayPart_amfm_AddEvent.Name = "DayPart_amfm_AddEvent";
            this.DayPart_amfm_AddEvent.Size = new System.Drawing.Size(72, 22);
            this.DayPart_amfm_AddEvent.TabIndex = 4;
            this.DayPart_amfm_AddEvent.TabStop = true;
            this.DayPart_amfm_AddEvent.Text = "Heldag";
            this.DayPart_amfm_AddEvent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, -66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lägg till händelse";
            // 
            // Add_AddEvent
            // 
            this.Add_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_AddEvent.Location = new System.Drawing.Point(219, 282);
            this.Add_AddEvent.Name = "Add_AddEvent";
            this.Add_AddEvent.Size = new System.Drawing.Size(235, 47);
            this.Add_AddEvent.TabIndex = 9;
            this.Add_AddEvent.Text = "Lägg till händelse";
            this.Add_AddEvent.UseVisualStyleBackColor = true;
            this.Add_AddEvent.Click += new System.EventHandler(this.Add_AddEvent_Click);
            // 
            // Cancel_AddEvent
            // 
            this.Cancel_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_AddEvent.Location = new System.Drawing.Point(85, 282);
            this.Cancel_AddEvent.Name = "Cancel_AddEvent";
            this.Cancel_AddEvent.Size = new System.Drawing.Size(125, 47);
            this.Cancel_AddEvent.TabIndex = 10;
            this.Cancel_AddEvent.Text = "Stäng";
            this.Cancel_AddEvent.UseVisualStyleBackColor = true;
            this.Cancel_AddEvent.Click += new System.EventHandler(this.Cancel_AddEvent_Click);
            // 
            // MultipleDays_AddEvent
            // 
            this.MultipleDays_AddEvent.BackColor = System.Drawing.Color.Transparent;
            this.MultipleDays_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleDays_AddEvent.Location = new System.Drawing.Point(199, 99);
            this.MultipleDays_AddEvent.Name = "MultipleDays_AddEvent";
            this.MultipleDays_AddEvent.Size = new System.Drawing.Size(20, 35);
            this.MultipleDays_AddEvent.TabIndex = 2;
            this.MultipleDays_AddEvent.UseVisualStyleBackColor = false;
            this.MultipleDays_AddEvent.CheckedChanged += new System.EventHandler(this.MultipleDays_AddEvent_CheckedChanged);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 336);
            this.Controls.Add(this.MultipleDays_AddEvent);
            this.Controls.Add(this.Cancel_AddEvent);
            this.Controls.Add(this.Add_AddEvent);
            this.Controls.Add(this.InfoInput_AddEvent);
            this.Controls.Add(this.EventTypeInput_AddEvent);
            this.Controls.Add(this.DayPart_fm_AddEvent);
            this.Controls.Add(this.DayPart_am_AddEvent);
            this.Controls.Add(this.DateToInput_AddEvent);
            this.Controls.Add(this.DateFromInput_AddEvent);
            this.Controls.Add(this.SignInput_AddEvent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DayPart_amfm_AddEvent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEventForm";
            this.Text = "Lägg till händelse";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoInput_AddEvent;
        private System.Windows.Forms.ComboBox EventTypeInput_AddEvent;
        private System.Windows.Forms.RadioButton DayPart_fm_AddEvent;
        private System.Windows.Forms.RadioButton DayPart_am_AddEvent;
        private System.Windows.Forms.DateTimePicker DateToInput_AddEvent;
        private System.Windows.Forms.DateTimePicker DateFromInput_AddEvent;
        private System.Windows.Forms.ComboBox SignInput_AddEvent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Sign_addEvent;
        private System.Windows.Forms.Label DateFrom_AddEvent;
        private System.Windows.Forms.Label DateTo_AddEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EventType_AddEvent;
        private System.Windows.Forms.Label Info_AddEvent;
        private System.Windows.Forms.RadioButton DayPart_amfm_AddEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_AddEvent;
        private System.Windows.Forms.Button Cancel_AddEvent;
        private System.Windows.Forms.CheckBox MultipleDays_AddEvent;
    }
}