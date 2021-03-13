using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LANguage.Forms
{
    public partial class UserForm : Form
    {
        
        public UserForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (LastNameBox.Text == "")
            {
                MessageBox.Show("Введите Фамилию", "Поле Фамилия обазятальна для заполнения");
                goto Decline;
            }
            if (firstNameBox.Text == "")
            {
                MessageBox.Show("Введите имя", "Поле Имя обазятальна для заполнения");
                goto Decline;
            }
            if (phoneBox.Text == "")
            {
                MessageBox.Show("Введите Телефон", "Поле Телефон обазятальна для заполнения");
                goto Decline;
            }
            if (genderComboBox.Text == "")
            {
                MessageBox.Show("Выберите пол", "Поле Пол обазятально для выбора");
                goto Decline;
            }
            createButton.DialogResult = DialogResult.OK;
            Decline:
            { }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
