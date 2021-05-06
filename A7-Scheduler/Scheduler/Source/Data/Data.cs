using System;
using System.Collections.Generic;
using System.Drawing;

namespace Scheduler.Source
{

    /// <summary>
    /// Data structure for all users
    /// </summary>
    [System.Serializable]
    class UsersData
    {
        public List<UserData> usersData { get; set; } = new List<UserData>();

        public UserData FindUser(string sign)
        {
            foreach (UserData u in usersData)
            {
                if (u.Sign == sign)
                    return u;
            }
            return null;
        }
    }

    /// <summary>
    /// Data structure for all events
    /// </summary>
    [System.Serializable]
    class EventsData
    {
        public int Id
        {
            get
            {
                if (eventsData != null && eventsData.Count > 0)
                    return eventsData[eventsData.Count - 1].EventId + 1;
                else
                    return 0;
            }
        }

        public List<EventData> eventsData { get; set; } = new List<EventData>();

        public EventData FindEvent(int id)
        {
            foreach (EventData e in eventsData)
            {
                if (e.EventId == id)
                    return e;
            }
            return null;
        }
    }


    /// <summary>
    /// Data structure for users
    /// </summary>
    [System.Serializable]
    class UserData
    {
        public UserData(string sign, string employeeNumber, string firstName, string lastName, string domain)
        {
            this.Sign = sign;
            this.EmployeeNumber = employeeNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Domain = domain;
        }

        public string Sign { get; }
        public string EmployeeNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Domain { get; }
    }


    /// <summary>
    /// Data structure for events
    /// </summary>
    [System.Serializable]
    public class EventData
    {
        public EventData(string sign, DateTime dateFrom, DateTime dateTo, PartOfDay partOfDay, EventType eventType, string additionalInfo)
        {
            this.EventId = SaveLoad.events.Id;
            this.Sign = sign;
            this.DateFrom = new EventDate(dateFrom);
            this.DateTo = (dateTo == null) ? new EventDate(dateFrom) : new EventDate(dateTo);
            this.PartOfDay = partOfDay.ToString();
            this.EventType = eventType;
            this.AdditionalInfo = additionalInfo;
            this.Status = eventType.NeedsApproval ? "Ansökan" : "Godkänd";
        }


        public int EventId { get; set; }
        public string Sign { get; }
        public EventDate DateFrom { get; }
        public EventDate DateTo { get; }

        public string PartOfDay { get; }
        public EventType EventType { get; }

        public string AdditionalInfo { get; }
        public string Status { get; set; }
    }



    [System.Serializable]
    public class EventDate
    {
        public EventDate(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public EventDate(DateTime dateTime)
        {
            this.Year = dateTime.Year;
            this.Month = dateTime.Month;
            this.Day = dateTime.Day;
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }


        public new string ToString()
        {
            string year = string.Format("{0:00}", Year);
            string month = string.Format("{0:00}", Month);
            string day = string.Format("{0:00}", Day);

            return $"{year}-{month}-{day}";
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }

        public static bool operator ==(EventDate lhs, EventDate rhs)
        {
            return (lhs.Year == rhs.Year && lhs.Month == rhs.Month && lhs.Day == rhs.Day);
        }
        public static bool operator !=(EventDate lhs, EventDate rhs)
        {
            return !(lhs == rhs);
        }
    }


    [System.Serializable]
    public class EventType
    {
        public EventType(string eventName, string eventNameShort, bool needsApproval)
        {
            this.EventName = eventName;
            this.EventNameShort = eventNameShort;
            this.NeedsApproval = needsApproval;
        }


        public string EventName { get; }
        public string EventNameShort { get; }
        public bool NeedsApproval { get; }

        public string[] ConfirmEmails_Bro { get; private set; }
        public string[] ConfirmEmails_Industri { get; private set; }
        public string[] ConfirmEmails_Koord { get; private set; }


        public void SetEmail_Bro(params string[] addresses)
        {
            ConfirmEmails_Bro = addresses;
        }
        public void SetEmail_Industri(params string[] addresses)
        {
            ConfirmEmails_Industri = addresses;
        }
        public void SetEmail_Koord(params string[] addresses)
        {
            ConfirmEmails_Koord = addresses;
        }


        public Color GetColor()
        {
            switch (EventName)
            {
                case "Semester":
                case "Föräldraledig":
                case "Tjänstledigt":
                    return Settings.tonedGreen;

                case "Jobbar hemifrån":
                case "Studiebesök/Platskontor":
                    return Settings.tonedBlue;

                case "Sjuk":
                case "VAB":
                    return Settings.tonedYellow;

                default:
                    return Color.White;
            }
        }

    }

}
