using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
        public abstract class MailService
        {

                public virtual string Smtp { get; set; }
                public virtual int Socket { get; set; }
		public virtual string Name { get; }

		public override string ToString()
		{
			return Name;
		}
	}
}
