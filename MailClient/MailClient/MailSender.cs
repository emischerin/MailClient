using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;



namespace MailClient
{
	class MailSender
	{
		SmtpClient sc = new SmtpClient();
		
		public MailSender()
		{
			sc.EnableSsl = true;
			sc.UseDefaultCredentials = false;

		}

		public MailSender(MailService service, User currentuser)
		{
			sc.EnableSsl = true;
			sc.UseDefaultCredentials = false;
			sc.Host = service.Smtp;
			sc.Port = service.Socket;
			sc.Credentials = new NetworkCredential(currentuser.Email, currentuser.Password);

		}

		public void Send(Message msg)
		{
			
				sc.Send(msg.MailMessage);		
						
		}
	}
}
