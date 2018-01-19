using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
	class User
	{
		private string email;
		private string password;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public User(string email,string password)
		{
			this.email = email;
			this.password = password;
		}

	}
}
