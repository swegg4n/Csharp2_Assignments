using Scheduler.Source;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Scheduler
{
    /// <summary>
    /// Helper class for creating different absence reports
    /// </summary>
    public static class ReportHelper
    {

        /// <summary>
        /// Creates multiple bar graphs representing the absence on date: <paramref name="date"/>
        /// </summary>
        public static void CreateOneDayReport(DateTime date, PartOfDay partOfDay, Panel panel)
        {
            List<UserData> users = SaveLoad.users.usersData;
            EventsData events = SaveLoad.events;

            string[] names = new string[8]
            {
                "På kontoret",
                "Semester",
                "Föräldraledig",
                "Tjänstledig",
                "Jobbar hemifrån",
                "Studiebesök/Platskontor",
                "Sjuk",
                "VAB",
            };

            Color[] colors = new Color[8]
            {
                Color.Silver,
                Settings.tonedGreen,
                Settings.tonedGreen,
                Settings.tonedGreen,
                Settings.tonedBlue,
                Settings.tonedBlue,
                Settings.tonedYellow,
                Settings.tonedYellow,
            };

            int[] absenceCount = new int[7] { 0, 0, 0, 0, 0, 0, 0, };
            List<string> countedUsers = new List<string>();

            foreach (EventData e in events.eventsData)
            {
                if (!countedUsers.Contains(e.Sign))
                {
                    if (e.DateFrom.ToDateTime() <= date && e.DateTo.ToDateTime() >= date && e.Status != "Nekad")
                    {
                        if (partOfDay == PartOfDay.Heldag ||
                            ((e.PartOfDay == "Förmiddag" || e.PartOfDay == "Heldag") && partOfDay == PartOfDay.Förmiddag) ||
                            ((e.PartOfDay == "Eftermiddag" || e.PartOfDay == "Heldag") && partOfDay == PartOfDay.Eftermiddag))
                        {
                            for (int i = 1; i < names.Length; i++)
                            {
                                if (e.EventType.EventName == names[i])
                                {
                                    absenceCount[i - 1]++;
                                    countedUsers.Add(e.Sign);
                                }
                            }
                        }
                    }
                }
            }

            int totAbsence = 0;
            Array.ForEach(absenceCount, a => totAbsence += a);

            int xPos = 0;
            int yPos = -15;
            int spacingY_small = 15;
            int spacingY_large = 25;

            int maxVal = users.Count;
            int maxWidth = 200;

            panel.Controls.Clear();

            Font font = new Font("Microsoft Sans Serif", 10);

            panel.Controls.Add(new Label() { Location = new Point(xPos, yPos += spacingY_large), Width = 210, Text = $"{names[0]}: {users.Count - totAbsence}", Font = font, TextAlign = ContentAlignment.BottomLeft });
            panel.Controls.Add(new PictureBox() { Location = new Point(xPos, yPos += spacingY_small), Width = GetBarWidth(users.Count - totAbsence, maxVal, maxWidth), Height = 20, BackColor = colors[0] });
            for (int i = 0; i < absenceCount.Length; i++)
            {
                panel.Controls.Add(new Label() { Location = new Point(xPos, yPos += spacingY_large), Width = 210, Text = $"{names[i + 1]}: {absenceCount[i]}", Font = font, TextAlign = ContentAlignment.BottomLeft });
                panel.Controls.Add(new PictureBox() { Location = new Point(xPos, yPos += spacingY_small), Width = GetBarWidth(absenceCount[i], maxVal, maxWidth), Height = 20, BackColor = colors[i + 1] });
            }
        }

        private static int GetBarWidth(int yValue, int maxVal, int maxWidth)
        {
            return (int)((float)yValue / (float)maxVal * maxWidth);
        }

    }

}
