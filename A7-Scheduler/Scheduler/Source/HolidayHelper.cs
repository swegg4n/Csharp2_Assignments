using Nager.Date;
using Nager.Date.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Scheduler
{

    /// <summary>
    /// Class used to mange holidays, both national and customly created.
    /// </summary>
    static class HolidayHelper
    {
        private static Dictionary<string, HolidayData> holidays = new Dictionary<string, HolidayData>();

        private static DateTime lastDate;


        /// <summary>
        /// Refreshes the calendar-header with all holidays from date: <paramref name="startDate"/>
        /// </summary>
        public static void UpdateHolidays(DateTime startDate, DataGridView header, Dictionary<Point, string> cellToolTips)
        {
            if (lastDate == null || lastDate.Year != startDate.Year)
                AddHolidays(startDate.Year);

            lastDate = startDate;

            for (int col = 0; col < header.ColumnCount; col++)
            {
                if (DateSystem.IsWeekend(startDate.AddDays(col), CountryCode.SE))
                {
                    header[col, 1].Style.BackColor = Color.LightGray;
                }
                else
                    header[col, 1].Style.BackColor = Color.White;
            }

            DisplayHolidays(startDate, header, cellToolTips);
        }


        /// <summary>
        /// Adds all holidays to the "holdays" dictionary
        /// </summary>
        private static void AddHolidays(int year)
        {
            holidays.Clear();

            IEnumerable<PublicHoliday> publicHolidays = DateSystem.GetPublicHoliday(year, CountryCode.SE);

            string[] ignoredHolidays = new string[] { "Pingstdagen", "Midsommarafton" };
            foreach (var h in publicHolidays)
            {
                if (ignoredHolidays.Contains(h.LocalName))
                    continue;

                holidays.Add(h.LocalName, new HolidayData(h.Date, "Helgdag"));
            }

            holidays.Add("Trettondagsafton", new HolidayData(holidays["Trettondedag jul"].Date.AddDays(-1), "Halvdag"));
            holidays.Add("Skärtorsdagen", new HolidayData(holidays["Långfredagen"].Date.AddDays(-1), "Halvdag"));
            holidays.Add("Valborgmässoafton", new HolidayData(holidays["Första maj"].Date.AddDays(-1), "Halvdag"));
            holidays.Add("Allhelgonaafton", new HolidayData(holidays["Alla helgons dag"].Date.AddDays(-1), "Halvdag"));
            holidays.Add("Mårtensafton", new HolidayData(new DateTime(year, 11, 10), "Halvdag"));
            holidays.Add("Lille julafton", new HolidayData(holidays["Julafton"].Date.AddDays(-1), "Halvdag"));

            holidays.Add("Mellandag_1", new HolidayData(holidays["Annandag jul"].Date.AddDays(1), "Halvdag"));
            holidays.Add("Mellandag_2", new HolidayData(holidays["Annandag jul"].Date.AddDays(2), "Halvdag"));
            holidays.Add("Mellandag_3", new HolidayData(holidays["Annandag jul"].Date.AddDays(3), "Halvdag"));
            holidays.Add("Mellandag_4", new HolidayData(holidays["Annandag jul"].Date.AddDays(4), "Halvdag"));
        }


        /// <summary>
        /// Changes the headers color and tooltips based on holiday data
        /// </summary>
        private static void DisplayHolidays(DateTime startDate, DataGridView header, Dictionary<Point, string> cellToolTips)
        {
            cellToolTips.Clear();

            foreach (var h in holidays)
            {
                int dayDiff = (h.Value.Date - startDate).Days;

                if (dayDiff >= 0 && dayDiff <= 30)
                {
                    DataGridViewCell cell = header[dayDiff, 1];
                    cell.Style.BackColor = h.Value.Color;

                    string toolTipMsg = $"{h.Key.Split('_')[0]}\n" +
                                        $"({h.Value.AbsenceType})\n";

                    Point key = new Point(cell.ColumnIndex, cell.RowIndex);
                    if (cellToolTips.ContainsKey(key))
                        cellToolTips[key] = toolTipMsg;
                    else
                        cellToolTips.Add(key, toolTipMsg);
                }
            }
        }
    }


    /// <summary>
    /// Data structure for capturing all information about holidays
    /// </summary>
    class HolidayData
    {
        public HolidayData(DateTime date, string absenceType)
        {
            this.Date = date;
            this.AbsenceType = absenceType;
        }

        public DateTime Date { get; }
        public string AbsenceType { get; }


        public Color Color
        {
            get
            {
                switch (AbsenceType)
                {
                    case "Helgdag":
                        return Color.Red;
                    case "Halvdag":
                        return Color.LightSalmon;
                    case "Stängt":
                        return Color.Orange;

                    default:
                        return Color.White;
                }
            }
        }

    }
}
