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
using System.Data.Entity;
using System.Windows.Forms;
using LANguage.Forms;

namespace LANguage.Tables
{
    public partial class UserTable : Page
    {
        LangaugeDB db = new LangaugeDB();
        Client clientForDelite;
        public UserTable()
        {
            InitializeComponent();
            db.Client.Load();
            listBoxTableClient.ItemsSource = db.Client.Local.ToBindingList();
            
        }

        private void createTupleButton_Click(object sender, RoutedEventArgs e)
        {
            UserForm userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                Client client= new Client();
                Client client1 = new Client();
                client1 = db.Client.OrderByDescending(o => o.ID).FirstOrDefault();
                client.ID = client1.ID + 1;
                client.FirstName = userForm.firstNameBox.Text;
                client.LastName = userForm.LastNameBox.Text;
                client.Patronymic = userForm.patronymicBox.Text;
                client.Birthday = Convert.ToDateTime(userForm.birthdayBox.Text);
                client.RegistrationDate = DateTime.Today;
                client.Email = userForm.emailBox.Text;
                client.Phone = userForm.phoneBox.Text;
                if (userForm.genderComboBox.Text == "Мужской")
                {
                    client.GenderCode = "1";
                }
                else if (userForm.genderComboBox.Text == "Женский")
                {
                    client.GenderCode = "0";
                }
                db.Client.Add(client);
                db.SaveChanges();
                userForm.Dispose();
            }
            
        }

        private void deleteTupleButton_Click(object sender, RoutedEventArgs e)
        {
            Client client = db.Client.Where(o => o.ID == clientForDelite.ID).FirstOrDefault();
            db.Client.Remove(client);
            db.SaveChanges();

        }

        public void listBoxTableClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clientForDelite = listBoxTableClient.SelectedItem as Client;
        }
    }
}
