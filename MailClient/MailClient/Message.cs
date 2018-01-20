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

	}
}
