using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Mail;



namespace MailClient
{
	/// <summary>
	/// Логика взаимодействия для SendMailWindow.xaml
	/// </summary>
	public partial class SendMailWindow : Window
	{
		private User currentuser;
		private MailService mailservice;
		private List<Message> messagelist = new List<Message>();
		private List<String> attachmentlist = new List<String>();

		public SendMailWindow(User user, MailService selectedmailservice)
		{
			InitializeComponent();
			currentuser = user;
			mailservice = selectedmailservice;
		}

		private void AddAttachmentButton_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();

			var result = ofd.ShowDialog();

			if (result == true)
			{
				attachmentlist.Add(ofd.FileName);
			}
		}

		private void SendButton_Click(object sender, RoutedEventArgs e)
		{
			Message msg = new Message(currentuser.Email,ToBox.Text,BodyBox.Text,ThemeBox.Text);
			MailSender ms = new MailSender(mailservice, currentuser);
			ms.Send(msg);
		}
	}
}
