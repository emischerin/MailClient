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
		private List<String> attachments = new List<String>();

		public SendMailWindow(User user, MailService selectedmailservice)
		{
			InitializeComponent();
			currentuser = user;
			mailservice = selectedmailservice;
		}

		
		private void IncludeAttachments(Message a)
		{
			// Метод добавляет вложения из списка. Используется в SendButton_Click.
			for(int i = 0; i < attachments.Count;i++)
			{
				a.AddAttachement(attachments[i]);
			}
		}

		private void AddAttachmentButton_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();

			var result = ofd.ShowDialog();

			if (result == true)
			{
				attachments.Add(ofd.FileName);
			}
		}

		private void SendButton_Click(object sender, RoutedEventArgs e)
		{
			Message msg = new Message(currentuser.Email,ToBox.Text,BodyBox.Text,ThemeBox.Text);
			MailSender ms = new MailSender(mailservice, currentuser);
			IncludeAttachments(msg);
			messagelist.Add(msg);

			Task send = new Task(() => ms.Send(msg));

			try
			{
				send.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
						
		}
	}
}
