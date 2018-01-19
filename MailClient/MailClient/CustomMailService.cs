using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
	class CustomMailService:MailService
	{
		private string smtp;
		private int socket;

		public override string Smtp
		{
			get { return smtp; }
			set { smtp = value; }
		}

		public override int Socket
		{
			get { return socket; }
			set { socket = value; }
		}

		public CustomMailService(string smtp, int socket)
		{
			this.smtp = smtp;
			this.socket = socket;
		}
	}
}
