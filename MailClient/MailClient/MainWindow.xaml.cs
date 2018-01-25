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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailClient
{
        /// <summary>
        /// Логика взаимодействия для MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
		MailService[] mailservicelist;

                public MainWindow()
                {
                        InitializeComponent();
			mailservicelist = new MailService[] {new Gmail(), new Yandex()};
			MailServiceListBox.ItemsSource = mailservicelist;
                }

		private bool AllowEnter()
		{
			if ((PasswordBox.Password != null) && (EmailBox.Text != "") && (MailServiceListBox.SelectedItem != null))
				return true;

			else return false;
		}

		private void OnEnterButtonClick(object sender, RoutedEventArgs e)
		{
			if (AllowEnter())
			{
				User user = new User(EmailBox.Text, PasswordBox.Password.ToString());
				SendMailWindow sm = new SendMailWindow(user, (MailService)MailServiceListBox.SelectedItem);
				sm.Show();
				this.Close();
			}

		}
	}
}
