using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
        class Yandex : MailService
        {
                private const string smtp = "smtp.yandex.ru";
                private const int socket = 465;

                public override string Smtp
                {
                        get { return smtp; }
                }

                public override int Socket
                {
                        get { return socket; }
                }
        }
}
