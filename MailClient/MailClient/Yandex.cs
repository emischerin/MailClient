﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
        class Yandex : MailService
        {
		// Для простой отправки по SMTP нужен порт без шифрования. 465 - это порт с шифрованием.
		// Для его работы необходим другой код.

                private const  string smtp = "smtp.yandex.ru";
                private const int socket = 587;
		private const string name = "Yandex";

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
