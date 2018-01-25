using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace MailClient
{
	[Serializable]
	class Message
	{
		private MailMessage mailmessage = new MailMessage();
		
		public Message(String sender, string to, string body, string subject)
		{
			MailAddress ma = new MailAddress(sender);
			mailmessage.From = ma;
			mailmessage.To.Add(to);
			mailmessage.Body = body;
			mailmessage.Subject = subject;
		}

		public MailMessage MailMessage
		{
			get { return mailmessage; }
		}

		public MailAddress Sender
		{
			get { return mailmessage.From; }
			set { mailmessage.From = value; }
		}

		public MailAddressCollection Destination
		{
			get { return mailmessage.To; }
			set { mailmessage.To.Add(value.ToString()); }
		}

		public string Body
		{
			get { return mailmessage.Body; }
			set { mailmessage.Body = value; }
		}

		public string Subject
		{
			get { return mailmessage.Subject; }
			set { mailmessage.Subject = value; }
		}

		public bool SetHtml
		{
			get { return mailmessage.IsBodyHtml; }
			set { mailmessage.IsBodyHtml = value; }
		}

		public void AddAttachement(string path)
		{
			Attachment at = new Attachment(path);
			mailmessage.Attachments.Add(at);
		}
	}
}
