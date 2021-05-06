using Scheduler.Source;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class CalendarForm : Form
    {
        private AddEventForm newEventForm;

        private LoginForm loginForm;

        public DateTime viewDate;

        private Dictionary<string, int> userIndex = new Dictionary<string, int>();

        public Dictionary<Point, string> headerToolTips = new Dictionary<Point, string>();
        public Dictionary<Point, string> cellToolTips = new Dictionary<Point, string>();



        public CalendarForm()
        {
            InitializeComponent();

            //SaveLoad.CreateEmptyUserFile();       //for testing
            //SaveLoad.CreateEmptyEventsFile();

            try { SaveLoad.RenewUsersData(); }
            catch (Exception e) { System.Diagnostics.Debug.WriteLine(e.ToString()); }

            try { SaveLoad.RenewEventsData(); }
            catch (Exception e) { System.Diagnostics.Debug.WriteLine(e.ToString()); }

            Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            this.Size = new Size((int)(screenSize.Width * 0.8f), (int)(screenSize.Height * 0.8f));

            ResizeEnd += new EventHandler(CalendarForm_ResizeEnd);
            Resize += new EventHandler(CalendarForm_Resize);
            CalGrid_Cal.CellEnter += new DataGridViewCellEventHandler(CalGrid_Cal_CellEnter);
            Header_Cal.CellEnter += new DataGridViewCellEventHandler(Header_Cal_CellEnter);

            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            viewDate = startDate;

            InitHeader(startDate);

            SetTodayIndicator();
            AddUsers();
            AddEvents();
            HolidayHelper.UpdateHolidays(viewDate, Header_Cal, headerToolTips);

            ResizeDaysHeader();
            ResizeUsersList();
        }

        /// <summary>
        /// Completely redraws the calendar
        /// </summary>
        public void RefreshCal(DateTime? date)
        {
            if (date == null)
                date = viewDate;

            DateTime newDate = (DateTime)date;
            DateTime startDate = new DateTime(newDate.Year, newDate.Month, 1);
            viewDate = startDate;

            SetDaysNumbering(startDate);
            SetWeekdayNames(startDate);
            SetWeekNumbers(startDate);
            FormatHeaderText(startDate);

            SetTodayIndicator();
            AddEvents();
            HolidayHelper.UpdateHolidays(startDate, Header_Cal, headerToolTips);
        }


        #region Headers
        public string[] monthNames = new string[] { "Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December" };
        string[] wdayNames = new string[] { "Sön.", "Mån.", "Tis.", "Ons.", "Tor.", "Fre.", "Lör." };

        private void InitHeader(DateTime startDate)
        {
            Header_Cal.RowCount = 3;
            Header_Cal.ColumnCount = 31;

            SetDaysNumbering(startDate);
            SetWeekdayNames(startDate);
            SetWeekNumbers(startDate);
        }

        /// <summary>
        /// Writes the day numbers to the header
        /// </summary>
        private void SetDaysNumbering(DateTime startDate)
        {
            int month = startDate.Month;
            int year = startDate.Year;

            MonthYear_Cal.Text = $"{monthNames[month - 1]}, {year}";

            for (int col = 0; col < Header_Cal.ColumnCount; col++)
                Header_Cal[col, 0].Value = startDate.AddDays(col).Day;
        }


        /// <summary>
        /// Writes the weekday names to the header
        /// </summary>
        private void SetWeekdayNames(DateTime startDate)
        {
            int month = startDate.Month;
            int year = startDate.Year;

            for (int col = 0; col < Header_Cal.ColumnCount; col++)
            {
                int weekdayIndex = (int)startDate.AddDays(col).DayOfWeek;
                Header_Cal[col, 1].Value = wdayNames[weekdayIndex];
            }
        }

        /// <summary>
        /// Writes the week numbers to the header
        /// </summary>
        private void SetWeekNumbers(DateTime startDate)
        {
            for (int col = 0; col < Header_Cal.ColumnCount; col++)
            {
                DateTime loopDate = startDate.AddDays(col);

                DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(loopDate);
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                {
                    loopDate = loopDate.AddDays(3);
                }

                if (day == DayOfWeek.Monday || col == 0)
                {
                    int weekNumber = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(loopDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                    Header_Cal[col, 2].Value = $"v.{weekNumber}";
                }
                else
                {
                    Header_Cal[col, 2].Value = "";
                }
            }
        }

        /// <summary>
        /// Colors the header text based on if the date is part of the next month or not. 
        /// Helps identifying when the month ends 
        /// </summary>
        /// <param name="startDate"></param>
        private void FormatHeaderText(DateTime startDate)
        {
            for (int row = 0; row < Header_Cal.RowCount; row++)
            {
                for (int col = 0; col < Header_Cal.ColumnCount; col++)
                {
                    if (col >= DateTime.DaysInMonth(startDate.Year, startDate.Month))
                        Header_Cal[col, row].Style.ForeColor = Color.Gray;
                    else
                        Header_Cal[col, row].Style.ForeColor = Color.Black;
                }
            }
        }
        #endregion


        /// <summary>
        /// Adds all saved users to the calendar categorized after which department they work in
        /// </summary>
        public void AddUsers()
        {
            for (int row = 0; row < CalGrid_Cal.RowCount; row++)
                CalGrid_Cal[0, row].Value = "";

            userIndex.Clear();

            List<string> users_bro = new List<string>();
            List<string> users_industri = new List<string>();
            List<string> users_koord = new List<string>();

            foreach (UserData u in SaveLoad.users.usersData)
            {
                switch (u.Domain)
                {
                    case "Bro":
                        users_bro.Add($"  {u.Sign}, {u.EmployeeNumber}");
                        break;

                    case "Industri":
                        users_industri.Add($"  {u.Sign}, {u.EmployeeNumber}");
                        break;

                    case "Koordination":
                        users_koord.Add($"  {u.Sign}, {u.EmployeeNumber}");
                        break;
                }
            }

            users_bro.Sort();
            users_industri.Sort();
            users_koord.Sort();

            CalGrid_Cal.ColumnCount = 32;   //31 days + users column
            CalGrid_Cal.RowCount = users_bro.Count + users_industri.Count + users_koord.Count + 6;

            int a = 0;
            CalGrid_Cal.Rows[a++].Cells[0].Value = "Bro";
            for (int i = 0; i < users_bro.Count; i++, a++)
            {
                CalGrid_Cal.Rows[a].Cells[0].Value = users_bro[i];
                userIndex.Add(users_bro[i].Split(',')[0].Trim(' '), a);
            }
            CalGrid_Cal.Rows[a++].Cells[0].Value = "";
            CalGrid_Cal.Rows[a++].Cells[0].Value = "Industri";
            for (int i = 0; i < users_industri.Count; i++, a++)
            {
                CalGrid_Cal.Rows[a].Cells[0].Value = users_industri[i];
                userIndex.Add(users_industri[i].Split(',')[0].Trim(' '), a);
            }
            CalGrid_Cal.Rows[a++].Cells[0].Value = "";
            CalGrid_Cal.Rows[a++].Cells[0].Value = "Koordination";
            for (int i = 0; i < users_koord.Count; i++, a++)
            {
                CalGrid_Cal.Rows[a].Cells[0].Value = users_koord[i];
                userIndex.Add(users_koord[i].Split(',')[0].Trim(' '), a);
            }
        }

        /// <summary>
        /// Clears the calendar to prepare for redrawal
        /// </summary>
        private void ClearEvents()
        {
            cellToolTips.Clear();

            for (int y = 1; y < CalGrid_Cal.RowCount; y++)
            {
                for (int x = 1; x < CalGrid_Cal.ColumnCount; x++)
                {
                    if (CalGrid_Cal[x, y].Value != null)
                    {
                        CalGrid_Cal[x, y].Value = null;
                        CalGrid_Cal[x, y].Style.BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Adds all the saved events to the calendar
        /// </summary>
        private void AddEvents()
        {
            ClearEvents();

            List<EventData> events = SaveLoad.events.eventsData;

            foreach (EventData e in events)
            {
                if (e.Status == "Nekad")
                    continue;

                int row = userIndex[e.Sign];
                int fromCol = Math.Min(Math.Max((e.DateFrom.ToDateTime().AddDays(1) - viewDate).Days, 1), 32);
                int toCol = Math.Min(Math.Max((e.DateTo.ToDateTime().AddDays(2) - viewDate).Days, 1), 32);

                for (int col = fromCol; col < toCol; col++)
                {
                    AddEvent(CalGrid_Cal[col, row], e);
                }
            }
        }
        private void AddEvent(DataGridViewCell cell, EventData e)
        {
            cell.Value = e.EventType.EventNameShort;
            cell.Style.ForeColor = (e.Status == "Godkänd") ? Color.Black : Color.Red;
            cell.Style.BackColor = e.EventType.GetColor();

            string dateText = (e.DateFrom == e.DateTo) ? $"{e.DateFrom.ToString()}" : $"{e.DateFrom.ToString()} - {e.DateTo.ToString()}";

            string toolTipMsg = $"{e.EventType.EventName}\n" +
                                $"{e.Sign}\n" +
                                $"{dateText} ({e.PartOfDay})\n" +
                                $"[{e.Status}]\n" +
                                $"info: {e.AdditionalInfo}\n";

            Point key = new Point(cell.ColumnIndex, cell.RowIndex);
            if (cellToolTips.ContainsKey(key))
                cellToolTips[key] += ("----------\n" + toolTipMsg);
            else
                cellToolTips.Add(key, toolTipMsg);
        }


        private void CalGrid_Cal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Header_Cal.ClearSelection();
            var cell = CalGrid_Cal.CurrentCell;
            var cellDisplayRect = CalGrid_Cal.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            string toolTipMsg;
            if (cellToolTips.TryGetValue(new Point(e.ColumnIndex, e.RowIndex), out toolTipMsg))
            {
                ToolTip_Cal.Show(toolTipMsg,
                    CalGrid_Cal,
                    cellDisplayRect.X + cell.Size.Width / 2,
                    cellDisplayRect.Y + cell.Size.Height,
                    60000);
            }
            else
            {
                ToolTip_Cal.Show("",
                    CalGrid_Cal,
                    cellDisplayRect.X + cell.Size.Width,
                    cellDisplayRect.Y + cell.Size.Height,
                    1);
            }
        }
        private void Header_Cal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CalGrid_Cal.ClearSelection();
            var cell = Header_Cal.CurrentCell;
            var cellDisplayRect = Header_Cal.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            string toolTipMsg;
            if (headerToolTips.TryGetValue(new Point(e.ColumnIndex, e.RowIndex), out toolTipMsg))
            {
                ToolTip_Cal.Show(toolTipMsg,
                    Header_Cal,
                    cellDisplayRect.X + cell.Size.Width / 2,
                    cellDisplayRect.Y + cell.Size.Height,
                    60000);
            }
            else
            {
                ToolTip_Cal.Show("",
                    Header_Cal,
                    cellDisplayRect.X + cell.Size.Width,
                    cellDisplayRect.Y + cell.Size.Height,
                    1);
            }
        }


        #region Resize

        private void ResizeDaysHeader()
        {
            int colWidth = (Header_Cal.Width - SystemInformation.VerticalScrollBarWidth) / 31;
            for (int i = 0; i < 31; i++)
            {
                Header_Cal.Columns[i].Width = colWidth;
            }
        }
        private void ResizeUsersList()
        {
            int col0Width = 179;
            int colWidth = (CalGrid_Cal.Width - col0Width - SystemInformation.VerticalScrollBarWidth) / 31;

            CalGrid_Cal.Columns[0].Width = col0Width;
            for (int i = 1; i < 32; i++)
            {
                CalGrid_Cal.Columns[i].Width = colWidth;
            }
        }

        private void CalendarForm_ResizeEnd(object sender, EventArgs e)
        {
            ResizeDaysHeader();
            ResizeUsersList();
            SetTodayIndicator();
        }

        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void CalendarForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
                {
                    ResizeDaysHeader();
                    ResizeUsersList();
                    SetTodayIndicator();
                }
            }
        }
        #endregion


        #region StaticButtons
        private void NewEvent_Cal_Click(object sender, EventArgs e)
        {
            if (newEventForm != null)
                newEventForm.Close();

            newEventForm = new AddEventForm();
            newEventForm.Open(this);
        }

        private void Admin_Cal_Click(object sender, EventArgs e)
        {
            if (loginForm != null)
                loginForm.Close();

            loginForm = new LoginForm();
            loginForm.Open(this);
        }

        private void Today_Cal_Click(object sender, EventArgs e)
        {
            RefreshCal(DateTime.Today);
        }
        private void prevMonth_Cal_Click(object sender, EventArgs e)
        {
            RefreshCal(viewDate.AddMonths(-1));
        }
        private void nextMonth_Cal_Click(object sender, EventArgs e)
        {
            RefreshCal(viewDate.AddMonths(1));
        }
        #endregion


        private void SetTodayIndicator()
        {
            int colWidth = (Header_Cal.Width - SystemInformation.VerticalScrollBarWidth) / 31;
            int xOffset = (DateTime.Today - viewDate).Days * colWidth + colWidth / 2;

            TodayIndicator_Cal.Location = new Point(Header_Cal.Location.X + xOffset, Header_Cal.Location.Y);
            TodayIndicator_Cal.Size = new Size(1, Size.Height);
        }
    }
}
