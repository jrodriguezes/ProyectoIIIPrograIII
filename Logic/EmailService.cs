using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Logic
{
    public class EmailService
    {
        public void sendPDFEmail(string emailDestination, byte[] pdfBytes)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage email = new MailMessage();

            email.From = new MailAddress("bluesketchinf@gmail.com");
            email.To.Add(emailDestination);
            email.Subject = "Reporte del sistema - Reportes";
            email.Body = "Adjunto resumen PDF generado por el sistema.";
            email.IsBodyHtml = false;

            MemoryStream adjuntoStream = new MemoryStream(pdfBytes);
            Attachment adjunto = new Attachment(adjuntoStream, "Reporte.pdf", "application/pdf");
            email.Attachments.Add(adjunto);

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("bluesketchinf@gmail.com", "znqu lobx cdfe urbv");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(email);
                MessageBox.Show("Correo correctamente enviado con el PDF adjunto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        public byte[] generateSimplePdfFromData(Dictionary<string, string> data)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                foreach (var item in data)
                {
                    Paragraph paragraph = new Paragraph($"{item.Key}: {item.Value}", new Font(Font.FontFamily.HELVETICA, 12));
                    doc.Add(paragraph);
                }

                doc.Close();
                return stream.ToArray();
            }
        }
    }
}
