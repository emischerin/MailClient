using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
        class Gmail : MailService
        {
                private const string smtp = "smtp.gmail.com";
                private const int socket = 587;
		private const string name = "Google";


                public override string Smtp
                {
                        get { return smtp; }
                }

                public override int Socket
                {
                        get { return socket; }
                }

		public override string Name
		{
			get { return name; }
		}
        }
}
