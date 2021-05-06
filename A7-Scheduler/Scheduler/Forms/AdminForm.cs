using Scheduler.Source;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class AdminForm : Form
    {
        public CalendarForm calForm;


        public AdminForm()
        {
            InitializeComponent();

            //init();

            //Adds 100 years to the year drop-down lists, to choose from
            for (int i = 0; i < DateTime.Today.Year - 2020 + 100; i++)  
            {
                YearInput_AbsenceM.Items.Add($"{i + 2020}");
                YearInput_AbsenceY.Items.Add($"{i + 2020}");
                YearInput_AbsenceC.Items.Add($"{i + 2020}");
            }
            int index_y = DateTime.Today.Year - 2020;
            int index_m = DateTime.Today.Month - 1;
            YearInput_AbsenceM.SelectedIndex = index_y;
            YearInput_AbsenceY.SelectedIndex = index_y;
            YearInput_AbsenceC.SelectedIndex = index_y;
            MonthInput_AbsenceM.SelectedIndex = index_m;
            MonthInput_AbsenceC.SelectedIndex = index_m;
        }

        public void Open(CalendarForm calForm)
        {
            this.calForm = calForm;

            RefreshUsers();
            RefreshEvents();

            RefreshOneDayReport();

            this.Show();
        }


        /// <summary>
        /// Loads all users and presents them to the UsersList
        /// </summary>
        public void RefreshUsers()
        {
            UsersList_users.Items.Clear();
            DeleteUser_Users.Enabled = false;

            UsersData users = SaveLoad.users;
            foreach (UserData u in users.usersData)
            {
                string[] row = new string[] { u.Sign, u.EmployeeNumber.ToString(), u.FirstName, u.LastName, u.Domain };
                UsersList_users.Items.Add(new ListViewItem(row));
            }
        }

        /// <summary>
        /// Loads all events and presents them to the EventsList
        /// </summary>
        private void RefreshEvents()
        {
            EventsList_events.Items.Clear();

            foreach (EventData e in SaveLoad.events.eventsData)
            {
                string[] row = new string[] { e.EventId.ToString(), e.Sign, e.DateFrom.ToString(), e.DateTo.ToString(), e.PartOfDay, e.EventType.EventName, e.AdditionalInfo, e.Status };
                EventsList_events.Items.Add(new ListViewItem(row));
            }

            Approve_event.Enabled = false;
            Disapprove_event.Enabled = false;
            Delete_event.Enabled = false;
        }


        private void EventsList_events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventsList_events.SelectedItems.Count != 0)
            {
                string status = EventsList_events.SelectedItems[0].SubItems[7].Text;

                Approve_event.Enabled = (status != "Godkänd");
                Disapprove_event.Enabled = (status != "Nekad");
                Delete_event.Enabled = true;
            }
            else
            {
                Approve_event.Enabled = false;
                Disapprove_event.Enabled = false;
                Delete_event.Enabled = false;
            }
        }

        /// <summary>
        /// Changes selected event's status to "Godkänd"
        /// </summary>
        private void Approve_event_Click(object sender, EventArgs e)
        {
            EventData selectedEntry = SaveLoad.events.eventsData[EventsList_events.SelectedItems[0].Index];
            selectedEntry.Status = "Godkänd";
            SaveLoad.AppendData(selectedEntry);

            RefreshEvents();
            calForm.RefreshCal(null);
        }

        /// <summary>
        /// Changes selected event's status to "Nekad"
        /// </summary>
        private void Disapprove_event_Click(object sender, EventArgs e)
        {
            EventData selectedEntry = SaveLoad.events.eventsData[EventsList_events.SelectedItems[0].Index];
            selectedEntry.Status = "Nekad";
            SaveLoad.AppendData(selectedEntry);

            RefreshEvents();
            calForm.RefreshCal(null);
        }

        /// <summary>
        /// Deletes the selected event
        /// </summary>
        private void Delete_event_Click(object sender, EventArgs e)
        {
            EventData selectedEntry = SaveLoad.events.eventsData[EventsList_events.SelectedItems[0].Index];
            SaveLoad.RemoveData(selectedEntry);

            RefreshEvents();
            calForm.RefreshCal(null);
        }


        /// <summary>
        /// Calls to print a PDF of the EventsList
        /// </summary>
        private void Print_event_Click(object sender, EventArgs e)
        {
            PrinterHelper.Print_ListView(EventsList_events, $"Händelser_{new EventDate(DateTime.Today).ToString()}");
        }

        /// <summary>
        /// Option to add a new user to the system
        /// </summary>
        private void AddUser_Users_Click(object sender, EventArgs e)
        {
            new AddUserForm().Open(this);
        }

        /// <summary>
        /// Option to delete selected user from the system
        /// </summary>
        private void DeleteUser_Users_Click(object sender, EventArgs e)
        {
            SaveLoad.RemoveData(UsersList_users.SelectedItems[0].SubItems[0].Text);
            RefreshUsers();
            calForm.AddUsers();
        }

        private void UsersList_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteUser_Users.Enabled = (UsersList_users.SelectedItems.Count != 0);
        }


        private void RefreshOneDayReport()
        {
            PartOfDay partOfDay = PartOfDay.Heldag;
            if (am_Absence1.Checked)
                partOfDay = PartOfDay.Förmiddag;
            else if (pm_Absence1.Checked)
                partOfDay = PartOfDay.Eftermiddag;

            ReportHelper.CreateOneDayReport(DateInput_Absence1.Value.Date, partOfDay, Panel_Absence1);
        }



        private void ampm_Absence1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOneDayReport();
        }
        private void am_Absence1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOneDayReport();
        }
        private void pm_Absence1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOneDayReport();
        }
        private void DateInput_Absence1_ValueChanged(object sender, EventArgs e)
        {
            RefreshOneDayReport();
        }

        /// <summary>
        /// Calls to print a PDF of the absence each day during the specified month & year
        /// </summary>
        private void Print_AbsenceM_Click(object sender, EventArgs e)
        {
            int month = MonthInput_AbsenceM.SelectedIndex;
            int year = YearInput_AbsenceM.SelectedIndex + 2020;

            PrinterHelper.Print_Chart(calForm, month, year);
        }
        //[Obsolete]
        //private void Print_AbsenceY_Click(object sender, EventArgs e)
        //{
        //    //graf som visar månadsvis frånvaro? 1 serie per eventyp + total frånvaro
        //}

        /// <summary>
        /// Calls to print a PDF of the calendar for the specified month & year
        /// </summary>
        private void Print_AbsenceC_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(YearInput_AbsenceC.SelectedIndex + 2020, MonthInput_AbsenceC.SelectedIndex + 1, 1);
            PrinterHelper.Print_Calendar(calForm, date);
        }



        // For testing
#if true
        string[] signs = new string[]{
            "AGN",
            "AJN",
            "ALR",
            "AMR",
            "AON",
            "BA",
            "BGA",
            "CMG",
            "CRN",
            "CSP",
            "DCN",
            "DS",
            "EEV",
            "EFI",
            "ETD",
            "FRD",
            "GBE",
            "GFN",
            "GMN",
            "GW",
            "HSN",
            "JAM",
            "JAR",
            "JEM",
            "JGI",
            "JHP",
            "JMN",
            "JMU",
            "JSH",
            "JSR",
            "JTT",
            "JYP",
            "KNH",
            "KPN",
            "LAE",
            "MFH",
            "MGI",
            "MHM",
            "MNN",
            "MP",
            "MRT",
            "MSS",
            "NRY",
            "OB",
            "OK",
            "PGN",
            "PJN",
            "PRX",
            "REK",
            "RW",
            "SFR",
            "SPG",
            "TKD",
            "TON",
            "VIN",
        };

        int[] id = new int[]
        {
            672,
            598,
            582,
            633,
            647,
            161,
            444,
            663,
            660,
            587,
            643,
            612,
            665,
            640,
            670,
            661,
            668,
            651,
            609,
            242,
            607,
            635,
            596,
            621,
            530,
            632,
            625,
            615,
            642,
            593,
            570,
            475,
            624,
            652,
            631,
            658,
            540,
            653,
            636,
            467,
            639,
            408,
            667,
            441,
            533,
            634,
            576,
            646,
            528,
            641,
            630,
            654,
            595,
            638,
            628,
        };

        string[] domains = new string[]
        {
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Industri",
            "Industri",
            "Industri",
            "Industri",
            "Industri",
            "Bro",
            "Bro",
            "Koordination",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Industri",
            "Bro",
            "Industri",
            "Bro",
            "Bro",
            "Industri",
            "Koordination",
            "Bro",
            "Bro",
            "Koordination",
            "Industri",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Koordination",
            "Industri",
            "Koordination",
            "Bro",
            "Bro",
            "Bro",
            "Bro",
            "Industri",
            "Bro",
            "Bro",
            "Bro",
            "Industri",
            "Bro",
            "Bro",
            "Bro",
        };

        private void init()
        {
            for (int i = 0; i < signs.Length; i++)
            {
                SaveLoad.AppendData(new UserData(signs[i], id[i].ToString(), "", "", domains[i]));
            }
        }
#endif

    }

}
