using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Scheduler.Source
{
    /// <summary>
    /// Class used for printing PDF-documents to files
    /// </summary>
    static class PrinterHelper
    {

        /// <summary>
        /// Prints listView: <paramref name="listView"/> to a PDF saved as <paramref name="fileName"/>
        /// </summary>
        public static void Print_ListView(ListView listView, string fileName)
        {
            Font pdfFont = new Font(Font.FontFamily.HELVETICA, 7.0f, Font.NORMAL);

            //Creating iTextSharp Table from the DataTable data
            PdfPTable headers = new PdfPTable(8);
            headers.DefaultCell.Padding = 5;
            headers.WidthPercentage = 100;
            headers.HorizontalAlignment = Element.ALIGN_LEFT;
            headers.DefaultCell.BorderWidth = 0.1f;
            headers.SetWidths(new int[] { 35, 60, 100, 100, 95, 125, 120, 70 });
            headers.SpacingAfter = 10.0f;

            PdfPTable items = new PdfPTable(8);
            items.DefaultCell.Padding = 5;
            items.WidthPercentage = 100;
            items.HorizontalAlignment = Element.ALIGN_LEFT;
            items.DefaultCell.BorderWidth = 0.1f;
            items.SetWidths(new int[] { 35, 60, 100, 100, 95, 125, 120, 70 });

            //Adding Header row
            foreach (ColumnHeader header in listView.Columns)
            {
                headers.AddCell(new Phrase(header.Text, pdfFont));
            }

            //Adding DataRow
            foreach (ListViewItem itemRow in listView.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    items.AddCell(new Phrase(itemRow.SubItems[i].Text, pdfFont));
                }
            }

            //Exporting to PDF
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            folderPath.Replace(@"\\", "/");


            try
            {
                using (FileStream stream = new FileStream(folderPath + "/" + fileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(headers);
                    pdfDoc.Add(items);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show($"PDF sparad till \"{folderPath}\\{fileName}.pdf\"", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TryOpenPDF($"{folderPath}/{fileName}.pdf");

            }
            catch (Exception)
            {
                MessageBox.Show($"Kan inte spara PDF - filen används av en annan process", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prints the calendar: <paramref name="calForm"/> to a PDF, from date: <paramref name="date"/>
        /// </summary>
        public static void Print_Calendar(CalendarForm calForm, DateTime date)
        {
            Font pdfFont = new Font(Font.FontFamily.HELVETICA, 6.0f, Font.NORMAL);

            //Creating iTextSharp Tables from the DataTable data
            PdfPTable headers = new PdfPTable(32);
            headers.DefaultCell.Padding = 2;
            headers.WidthPercentage = 100;
            headers.HorizontalAlignment = Element.ALIGN_LEFT;
            headers.DefaultCell.BorderWidth = 0.1f;
            headers.DefaultCell.BorderColor = BaseColor.LIGHT_GRAY;
            headers.SpacingAfter = 10.0f;

            PdfPTable items = new PdfPTable(32);
            items.DefaultCell.Padding = 2;
            items.WidthPercentage = 100;
            items.HorizontalAlignment = Element.ALIGN_LEFT;
            items.DefaultCell.BorderWidth = 0.1f;
            items.DefaultCell.BorderColor = BaseColor.LIGHT_GRAY;

            int[] widths = new int[32];
            widths[0] = 15;
            for (int i = 1; i < widths.Length; i++)
                widths[i] = 7;

            items.SetWidths(widths);
            headers.SetWidths(widths);

            DateTime originalDate = calForm.viewDate;
            calForm.RefreshCal(date);
            DataGridView header = calForm.Header_Cal;
            DataGridView data = calForm.CalGrid_Cal;

            //Adding Header row
            for (int row = 0; row < header.RowCount; row++)
            {
                headers.AddCell("");
                for (int col = 0; col < header.ColumnCount; col++)
                {
                    PdfPCell cell;

                    if (header[col, row].Value != null)
                        cell = new PdfPCell(new Phrase(header[col, row].Value.ToString(), pdfFont));
                    else
                        cell = new PdfPCell(new Phrase("", pdfFont));

                    System.Drawing.Color color = header[col, row].Style.BackColor;
                    if (!(color.R == 0 && color.G == 0 && color.B == 0))
                        cell.BackgroundColor = ColorToBase(header[col, row].Style.BackColor);
                    cell.BorderColor = BaseColor.LIGHT_GRAY;

                    headers.AddCell(cell);
                }
            }

            //Adding DataRow
            for (int row = 0; row < data.RowCount; row++)
            {
                for (int col = 0; col < data.ColumnCount; col++)
                {
                    PdfPCell cell;

                    if (data[col, row].Value != null)
                    {
                        System.Drawing.Color c = data[col, row].Style.ForeColor;
                        Font font = new Font(pdfFont.BaseFont, pdfFont.Size, pdfFont.Style, new BaseColor(c.R, c.G, c.B));

                        cell = new PdfPCell(new Phrase(data[col, row].Value.ToString(), font));
                    }
                    else
                    {
                        cell = new PdfPCell(new Phrase("", pdfFont));
                    }

                    System.Drawing.Color color = data[col, row].Style.BackColor;
                    if (!(color.R == 0 && color.G == 0 && color.B == 0))
                        cell.BackgroundColor = ColorToBase(data[col, row].Style.BackColor);
                    cell.BorderColor = BaseColor.LIGHT_GRAY;

                    items.AddCell(cell);
                }
            }

            calForm.RefreshCal(originalDate);

            //Exporting to PDF
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            folderPath.Replace(@"\\", "/");

            try
            {
                string month = calForm.monthNames[date.Date.Month - 1];
                string year = date.Date.Year.ToString();
                string fileName = "Kalender_" + month + "_" + year;
                using (FileStream stream = new FileStream(folderPath + "/" + fileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 25f, 20f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    iTextSharp.text.Paragraph p = new Paragraph($"{month}, {year}\n");
                    p.SpacingAfter = 10;
                    pdfDoc.Add(p);
                    pdfDoc.Add(headers);
                    pdfDoc.Add(items);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show($"PDF sparad till \"{folderPath}\\{fileName}.pdf\"", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TryOpenPDF($"{folderPath}/{fileName}.pdf");

            }
            catch (Exception)
            {
                MessageBox.Show($"Kan inte spara PDF - filen används av en annan process", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Prints charts over a specified month and year
        /// </summary>
        public static void Print_Chart(CalendarForm calForm, int _month, int _year)
        {
            //Exporting to PDF
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            folderPath.Replace(@"\\", "/");

            try
            {
                string month = calForm.monthNames[_month];
                string year = _year.ToString();
                string fileName = "Summering_" + month + "_" + year;
                using (FileStream stream = new FileStream(folderPath + "/" + fileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 25f, 20f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    iTextSharp.text.Paragraph p = new Paragraph($"Frånvarosummering - {month}, {year}\n");
                    p.SpacingAfter = 60;
                    pdfDoc.Add(p);

                    var img = Image.GetInstance(GetChartImage(_month, _year));
                    img.ScaleAbsolute(765, 500);
                    img.SetAbsolutePosition(0, 0);
                    pdfDoc.Add(img);

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show($"PDF sparad till \"{folderPath}\\{fileName}.pdf\"", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TryOpenPDF($"{folderPath}/{fileName}.pdf");

            }
            catch (Exception)
            {
                MessageBox.Show($"Kan inte spara PDF - filen används av en annan process", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Function used to start a process which tries to open a file at path: <paramref name="path"/>
        /// </summary>
        private static void TryOpenPDF(string path)
        {
            try
            {
                Process fileopener = new Process();
                fileopener.StartInfo.FileName = path;
                fileopener.Start();
            }
            catch (Exception) { }
        }


        /// <summary>
        /// Helper function for converting a value of type Color to type BaseColor (, via html hex)
        /// </summary>
        private static BaseColor ColorToBase(System.Drawing.Color color)
        {
            string hex = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            return new BaseColor(System.Drawing.ColorTranslator.FromHtml(hex));
        }


        /// <summary>
        /// Creates a chart from saved data displaying absence during a specified month
        /// </summary>
        /// <returns>A stream of bytes representing the chart, used for printing to PDF</returns>
        private static byte[] GetChartImage(int month, int year)
        {
            DateTime firstDate = new DateTime(year, month + 1, 1);

            int daysInMonth = DateTime.DaysInMonth(year, month + 1);

            System.Collections.Generic.List<EventData> events = SaveLoad.events.eventsData;
            string[] eventNames = new string[8] { "Semester", "Föräldraledig", "Tjänstledigt", "Jobbar hemifrån", "Studiebesök/Platskontor", "Sjuk", "VAB", "Sammanlagt" };

            float[,] absenceCounts = new float[daysInMonth, eventNames.Length - 1];

            for (int i = 0; i < daysInMonth; i++)
            {
                foreach (EventData e in events)
                {
                    if (e.Status != "Nekad")
                    {
                        DateTime loopDate = firstDate.AddDays(i).Date;
                        if (loopDate >= e.DateFrom.ToDateTime() && loopDate <= e.DateTo.ToDateTime())
                        {
                            float value = e.PartOfDay == "Heldag" ? 1 : 0.5f;

                            for (int j = 0; j < absenceCounts.GetLength(1); j++)
                            {
                                if (e.EventType.EventName == eventNames[j])
                                {
                                    absenceCounts[i, j] += value;
                                }
                            }
                        }
                    }
                }
            }

            float[] total = new float[daysInMonth];
            for (int i = 0; i < absenceCounts.GetLength(0); i++)
            {
                for (int j = 0; j < absenceCounts.GetLength(1); j++)
                {
                    total[i] += absenceCounts[i, j];
                }
            }


            System.Drawing.Font font = new System.Drawing.Font("Microsoft Sans Serif", 28);

            int width = 3060; //765
            int height = 2000; //500

            int[] points = new int[daysInMonth];

            using (var stream = new MemoryStream())
            {
                using (var chart = new Chart())
                {
                    ChartArea cA = new ChartArea();

                    cA.AxisX.Interval = 1;
                    cA.AxisX.MajorTickMark.Interval = 1;

                    cA.AxisY.Interval = 5;

                    cA.AxisY.MinorGrid.Interval = 1;
                    cA.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
                    cA.AxisY.MajorGrid.Interval = 1;
                    cA.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                    cA.AxisY.MinorTickMark.Interval = 5;
                    cA.AxisY.MinorTickMark.LineColor = System.Drawing.Color.LightGray;

                    cA.AxisX.MinorGrid.Enabled = false;
                    cA.AxisX.MajorGrid.Enabled = false;
                    cA.AxisX.MajorTickMark.Enabled = true;

                    cA.AxisY.MinorGrid.Enabled = true;
                    cA.AxisY.MajorGrid.Enabled = true;

                    cA.AxisX.Title = "Dag";
                    cA.AxisX.TitleFont = font;
                    cA.AxisY.Title = "Antal frånvarande";
                    cA.AxisY.TitleFont = font;

                    cA.AxisX.LabelAutoFitMinFontSize = 20;
                    cA.AxisY.LabelAutoFitMinFontSize = 20;
                    cA.AxisX.Minimum = 1;
                    cA.AxisX.Maximum = points.Length;

                    cA.AxisY.Minimum = 0;

                    float max = float.MinValue;
                    foreach (var a in absenceCounts)
                        if (a > max)
                            max = a;

                    cA.AxisY.Maximum = Math.Max(SaveLoad.users.usersData.Count / 3, (int)max);

                    cA.AxisX.LineWidth = 2;
                    cA.AxisY.LineWidth = 2;
                    cA.AxisY.MinorGrid.LineWidth = 2;


                    chart.ChartAreas.Add(cA);
                    chart.Size = new System.Drawing.Size(width, height);

                    Series[] series = new Series[8];

                    System.Drawing.Color[] seriesColors = new System.Drawing.Color[8] {
                        Settings.tonedGreen,
                        Settings.tonedGreen,
                        Settings.tonedGreen,
                        Settings.tonedBlue,
                        Settings.tonedBlue,
                        Settings.tonedYellow,
                        Settings.tonedYellow,
                        System.Drawing.Color.Gray,
                    };

                    LegendItem legendItem = new LegendItem();

                    for (int s = 0; s < series.Length; s++)
                    {
                        series[s] = new Series(eventNames[s]);
                        series[s].ChartType = SeriesChartType.Line;
                        series[s].MarkerSize = 5;
                        series[s].BorderWidth = 5;

                        for (int i = 0; i < points.Length; i++)
                        {
                            if (s == 7)
                            {
                                series[s].Points.AddXY(i + 1, total[i]);
                                series[s].Points[i].Font = new System.Drawing.Font(font.FontFamily.Name, 16.0f);
                            }
                            else
                                series[s].Points.AddXY(i + 1, absenceCounts[i, s]);
                        }


                        Legend legend = new Legend(series[s].Name);
                        //legend.DockedToChartArea = cA.Name;
                        legend.Docking = Docking.Top;
                        legend.Alignment = System.Drawing.StringAlignment.Far;
                        legend.Position.Auto = true;
                        legend.LegendStyle = LegendStyle.Table;
                        legend.Font = new System.Drawing.Font(font.FontFamily.Name, 22.0f);
                        //legend.BorderDashStyle = ChartDashStyle.Dash;
                        legend.IsDockedInsideChartArea = false;

                        series[s].IsVisibleInLegend = true;
                        series[s].Color = seriesColors[s];
                        chart.Series.Add(series[s]);
                    }
                    chart.Series[7].IsValueShownAsLabel = true;

                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(width, height);
                    chart.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, width, height));
                    bmp.Save(stream, ImageFormat.Png);
                }
                return stream.ToArray();
            }
        }
    }
}
