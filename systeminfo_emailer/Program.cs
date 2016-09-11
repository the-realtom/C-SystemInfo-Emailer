using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using EASendMail;

namespace systeminfo_emailer {
    class Program {
        static string SystemInfoOutput() {

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = "/c systeminfo";
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            return p.StandardOutput.ReadToEnd();

        }

        static void Main(string[] args) {

            SmtpMail message = new SmtpMail("TryIt"); // License Code
            SmtpClient SMTP_client = new SmtpClient();

            // FROM email address
            message.From = "xxx@hotmail.com";

            // TO email address
            message.To = "xxxx@domain.com";

            // SUBJECT
            message.Subject = "test email";

            // BODY
            message.TextBody = SystemInfoOutput();

            // SMTP server 
            SmtpServer server = new SmtpServer("smtp.live.com");

            // AUTH
            server.User = "xxx0@hotmail.com";
            server.Password = "password";

            // PORT
            server.Port = 25;

            // SSL/TLS detection
            server.ConnectType = SmtpConnectType.ConnectSSLAuto;

            try {
                Console.WriteLine("Sending email ...");
                SMTP_client.SendMail(server, message);
                Console.WriteLine("email was sent successfully!");
            } catch (Exception ep) {
                Console.WriteLine("Email failed to send due to the following error: ");
                Console.WriteLine(ep.Message);
            }
        }
    }
}
