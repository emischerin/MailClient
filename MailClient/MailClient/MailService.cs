using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
        abstract class MailService
        {

                public virtual string Smtp { get; }
                public virtual int Socket { get; }

        }
}
