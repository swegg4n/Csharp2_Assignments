using Scheduler.Source;
using System;
using System.Windows.Forms;

namespace Scheduler
{
    public enum PartOfDay { Heldag, Förmiddag, Eftermiddag }

    /// <summary>
    /// Form used to create and add new events
    /// </summary>
    public partial class AddEventForm : Form
    {
        CalendarForm calendarForm;

        private EventType[] eventTypes;


        public AddEventForm()
        {
            InitializeComponent();

            InitializeEventTypes();

            DateToInput_AddEvent.Enabled = false;
        }

        private void InitializeEventTypes()
        {
            string nry = "nry@coh.se";
            string ok = "ok@coh.se";
            string ds = "ds@coh.se";
            string utskick = "utskick@coh.se";


            string tempMail = "filip.moreau@hotmail.com";
            string tempMail2 = "filip.moreau@gmail.com";        
            eventTypes = new EventType[]
            {
                new EventType("Semester", "Sem.", true),
                new EventType("Föräldraledig", "Förä.", true),
                new EventType("Tjänstledigt", "Tjän.", true),

                new EventType("Jobbar hemifrån", "Job.h.", true),
                new EventType("Studiebesök/Platskontor", "Stu./Pl.", false),

                new EventType("Sjuk", "Sjuk", false),
                new EventType("VAB", "VAB", false),
            };

#if true
            eventTypes[0].SetEmail_Bro(tempMail, tempMail2);       //Semester
            eventTypes[0].SetEmail_Koord(tempMail, tempMail2);     //Semester
            eventTypes[0].SetEmail_Industri(tempMail, tempMail2);  //Semester

            eventTypes[1].SetEmail_Bro(tempMail);       //Föräldraledig
            eventTypes[1].SetEmail_Koord(tempMail);     //Föräldraledig
            eventTypes[1].SetEmail_Industri(tempMail);  //Föräldraledig

            eventTypes[2].SetEmail_Bro(tempMail);       //Tjänstledigt
            eventTypes[2].SetEmail_Koord(tempMail);     //Tjänstledigt
            eventTypes[2].SetEmail_Industri(tempMail);  //Tjänstledigt

            eventTypes[3].SetEmail_Bro(tempMail);       //Jobbar hemifrån
            eventTypes[3].SetEmail_Koord(tempMail);     //Jobbar hemifrån
            eventTypes[3].SetEmail_Industri(tempMail);  //Jobbar hemifrån

            eventTypes[4].SetEmail_Bro(tempMail);       //Studiebesök/Platskontor
            eventTypes[4].SetEmail_Koord(tempMail);     //Studiebesök/Platskontor
            eventTypes[4].SetEmail_Industri(tempMail);  //Studiebesök/Platskontor

            eventTypes[5].SetEmail_Bro(tempMail);       //Sjuk
            eventTypes[5].SetEmail_Koord(tempMail);     //Sjuk
            eventTypes[5].SetEmail_Industri(tempMail);  //Sjuk

            eventTypes[6].SetEmail_Bro(tempMail);       //VAB
            eventTypes[6].SetEmail_Koord(tempMail);     //VAB
            eventTypes[6].SetEmail_Industri(tempMail);  //VAB
#else
            eventTypes[0].SetEmail_Bro(nry, ok);       //Semester
            eventTypes[0].SetEmail_Koord(nry, ok);     //Semester
            eventTypes[0].SetEmail_Industri(nry, ds);  //Semester

            eventTypes[1].SetEmail_Bro(nry, ok);       //Föräldraledig
            eventTypes[1].SetEmail_Koord(nry, ok);     //Föräldraledig
            eventTypes[1].SetEmail_Industri(nry, ds);  //Föräldraledig

            eventTypes[2].SetEmail_Bro(nry, ok);       //Tjänstledigt
            eventTypes[2].SetEmail_Koord(nry, ok);     //Tjänstledigt
            eventTypes[2].SetEmail_Industri(nry, ds);  //Tjänstledigt

            eventTypes[3].SetEmail_Bro(utskick);       //Jobbar hemifrån
            eventTypes[3].SetEmail_Koord(utskick);     //Jobbar hemifrån
            eventTypes[3].SetEmail_Industri(utskick);  //Jobbar hemifrån

            eventTypes[4].SetEmail_Bro(utskick);       //Studiebesök/Platskontor
            eventTypes[4].SetEmail_Koord(utskick);     //Studiebesök/Platskontor
            eventTypes[4].SetEmail_Industri(utskick);  //Studiebesök/Platskontor

            eventTypes[5].SetEmail_Bro(utskick);       //Sjuk
            eventTypes[5].SetEmail_Koord(utskick);     //Sjuk
            eventTypes[5].SetEmail_Industri(utskick, ds);  //Sjuk

            eventTypes[6].SetEmail_Bro(utskick);       //VAB
            eventTypes[6].SetEmail_Koord(utskick);     //VAB
            eventTypes[6].SetEmail_Industri(utskick, ds);  //VAB
#endif
        }


        /// <summary>
        /// Initializes the form.
        /// Adds all users and event types to their respective drop-down list
        /// </summary>
        public void Open(CalendarForm calendarForm)
        {
            this.calendarForm = calendarForm;

            UsersData users = SaveLoad.users;

            foreach (UserData u in users.usersData)
            {
                SignInput_AddEvent.Items.Add($"{u.Sign}, {u.EmployeeNumber}");
            }
            foreach (EventType e in eventTypes)
            {
                EventTypeInput_AddEvent.Items.Add(e.EventName);
            }

            this.Show();
        }


        /// <summary>
        /// Makes sure the from is correctly filled
        /// Raises warning message boxes upon incorrect/missing field
        /// </summary>
        private bool ValidateAddEvent(string sign, DateTime dateFrom, DateTime dateTo, int eventTypeIndex)
        {
            bool valid = false;

            foreach (UserData u in SaveLoad.users.usersData)      //Validate Sign
            {
                if (u.Sign == sign)
                {
                    valid = true;
                    break;
                }
            }

            if (!valid)
            {
                if (sign == "")
                    MessageBox.Show($"\"Initialer\" får inte lämnas blank", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Användare med initialer \"{sign}\" kunde inte hittas", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (dateTo < dateFrom)      //Validate date-to
            {
                MessageBox.Show($"\"Datum - Till\" får inte ligga före \"Datum - Från\" i tid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (eventTypeIndex == -1)
            {
                MessageBox.Show($"\"Typ av händelse\" måste väljas från drop down-menyn", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return valid;
        }

        /// <summary>
        /// checkbox for selecting one day/multiple days
        /// </summary>
        private void MultipleDays_AddEvent_CheckedChanged(object sender, EventArgs e)
        {
            DateToInput_AddEvent.Enabled = MultipleDays_AddEvent.Checked;
        }

        /// <summary>
        /// Add button event
        /// Tries to create a new event from inputted data and writes it to the save file
        /// </summary>
        private void Add_AddEvent_Click(object sender, EventArgs e)
        {
            string sign = SignInput_AddEvent.Text.Split(',')[0];
            DateTime dateFrom = DateFromInput_AddEvent.Value.Date;
            DateTime dateTo = MultipleDays_AddEvent.Checked ? DateToInput_AddEvent.Value.Date : DateFromInput_AddEvent.Value.Date;
            PartOfDay partOfDay = DayPart_amfm_AddEvent.Checked ? PartOfDay.Heldag : DayPart_am_AddEvent.Checked ? PartOfDay.Förmiddag : PartOfDay.Eftermiddag;
            int eventTypeIndex = EventTypeInput_AddEvent.SelectedIndex;
            string additionalInfo = InfoInput_AddEvent.Text;

            if (ValidateAddEvent(sign, dateFrom, dateTo, eventTypeIndex))
            {
                EventType eventType = eventTypes[eventTypeIndex];
                EventData eventData = new EventData(sign, dateFrom, dateTo, partOfDay, eventType, additionalInfo);
                SaveLoad.AppendData(eventData);

                UsersData users = SaveLoad.users;
                UserData user = users.FindUser(sign);

                if (user != null)
                {
                    string[] mailAddresses = (user.Domain == "Bro") ? eventType.ConfirmEmails_Bro :
                        (user.Domain == "Industri") ? eventType.ConfirmEmails_Industri :
                        (user.Domain == "Koordination") ? eventType.ConfirmEmails_Koord : null;

                    MessageBox.Show($"Händelse tillagd!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

#if false
                    if (mailAddresses != null)
                        MailHelper.SendMail(mailAddresses, eventData);
#endif

                    ClearFields();
                }
            }

            calendarForm.RefreshCal(null);
        }

        private void ClearFields()
        {
            SignInput_AddEvent.Text = "";
            DateFromInput_AddEvent.Value = DateTime.Today;
            DateToInput_AddEvent.Value = DateTime.Today;
            MultipleDays_AddEvent.Checked = false;
            DayPart_amfm_AddEvent.Checked = true;
            EventTypeInput_AddEvent.Text = "";
            InfoInput_AddEvent.Text = "";
        }

        private void Cancel_AddEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DateFromInput_AddEvent_ValueChanged(object sender, EventArgs e)
        {
            if (MultipleDays_AddEvent.Checked == false)
                DateToInput_AddEvent.Value = DateFromInput_AddEvent.Value;
        }
    }
}
