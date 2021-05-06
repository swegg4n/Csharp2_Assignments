using Scheduler.Source;
using System.Net;
using System.Net.Mail;

namespace Scheduler
{
    /// <summary>
    /// Class used for sending emails using google's smtp server
    /// Currently not used for security reasons
    /// </summary>
    public static class MailHelper
    {
        public static string SendMail(string[] mailAddresses, EventData eventData)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("", ""),
                EnableSsl = true,
            };

            string dateText = "";
            if (eventData.DateFrom.ToString() == eventData.DateTo.ToString())
                dateText = eventData.DateFrom.ToString();
            else
                dateText = $"{eventData.DateFrom.ToString()}  -  {eventData.DateTo.ToString()}";

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(""),
                Subject = $"Kalenderhändelse [{eventData.EventId}] skapad  ({eventData.Status})",
                Body = $"<h3>En ny kalenderhändelse har skapats</h3>\n\n" +
                       $"<p>ID: [{eventData.EventId}]</p>\n" +
                       $"<p>Status: {eventData.Status}</p>\n" +
                       $"<p>Användare: {eventData.Sign}</p>\n" +
                       $"<p>Händelsetyp: {eventData.EventType.EventName}</p>\n" +
                       $"<p>Datum: {dateText}   ({eventData.PartOfDay})</p>\n" +
                       $"<p>Övrig information: {eventData.AdditionalInfo}</p>\n\n" +
                       $"<h4>Logga in i kalendern för att hantera händelsen</h4>"
                       ,
                IsBodyHtml = true,
            };

            foreach (string m in mailAddresses)
                mailMessage.To.Add(m);
            mailMessage.CC.Add($"{eventData.Sign.ToLower()}@coh.se");

            smtpClient.Send(mailMessage);

            return "";
        }
    }
}
