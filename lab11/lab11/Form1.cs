using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace lab11
{
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxsurname_TextChanged(object sender, EventArgs e)
        {
            user.surname = textBoxsurname.Text;
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {
            user.name = textBoxname.Text;
        }

        private void textBoxlastname_TextChanged(object sender, EventArgs e)
        {
            user.lastname = textBoxlastname.Text;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            user.sex = "Мужской";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            user.sex = "Женский";
        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {
            user.Birthday = birthday.Text;
        }

        private void comboBoxAdres_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.adress = comboBoxAdres.Text;
        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBoxemail.Text))
            {
                labelemail.ForeColor = Color.Red;
            }
            else
            {
                labelemail.ForeColor = Color.Black;
                user.email = textBoxemail.Text;
            }
        }

        private void comboBoxOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.phoneoperator = comboBoxOperator.Text;
        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\+375(29|33|24|25)\d{7}$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(textBoxphone.Text))
            {
                labelphone.ForeColor = Color.Red;
            }
            else
            {
                labelphone.ForeColor = Color.Black;
                user.phonenumber = textBoxphone.Text;
            }
        }

        private void experience0_CheckedChanged(object sender, EventArgs e)
        {
            user.stage = "Прежде не работал";
        }

        private void experience1_5_CheckedChanged(object sender, EventArgs e)
        {
            user.stage = "От 1 года до 5";
        }

        private void experience10_CheckedChanged(object sender, EventArgs e)
        {
            user.stage = "Более 10 лет";
        }

        private void experience1_CheckedChanged(object sender, EventArgs e)
        {
            user.stage = "Менее 1 года";
        }

        private void experience5_9_CheckedChanged(object sender, EventArgs e)
        {
            user.stage = "От 5 лет до 9";
        }

        private void checkBoxCar_CheckedChanged(object sender, EventArgs e)
        {
            user.car = "Имеется авто";
        }

        private void CategoryA_CheckedChanged(object sender, EventArgs e)
        {
            user.DriverCategory.Add("A");
        }

        private void CategoryB_CheckedChanged(object sender, EventArgs e)
        {
            user.DriverCategory.Add("B");
        }

        private void CategoryC_CheckedChanged(object sender, EventArgs e)
        {
            user.DriverCategory.Add("C");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            user.DriverCategory.Add("D");
        }

        private void listBoxMinzp_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.minzp = Convert.ToInt32(listBoxMinzp.Text);
        }

        private void listBoxMaxZP_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.maxzp = Convert.ToInt32(listBoxMaxZP.Text);
        }
        

        private void CV_TextChanged(object sender, EventArgs e)
        {
            user.CV = CV.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (user.surname == null || user.name == null || user.lastname == null || user.Birthday == null || user.email == null || labelemail.ForeColor == Color.Red || labelphone.ForeColor == Color.Red || labelmaxzp.ForeColor == Color.Red)
            {
                if (user.maxzp < user.minzp)
                {
                    labelmaxzp.ForeColor = Color.Red;
                }
                else
                {
                    labelmaxzp.ForeColor = Color.Black;
                }
                MessageBox.Show("Проверьте корректность ввода полей");
            }
            else
            {
                if (user.maxzp < user.minzp)
                {
                    labelmaxzp.ForeColor = Color.Red;
                    MessageBox.Show("Проверьте корректность ввода полей");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\labC#\\lab11\\lab11\\user.txt"))
                    {
                        sw.WriteLine("\t\t\tДанные сотрудника");
                        sw.WriteLine($"Фамилия Имя отчество: {user.surname} {user.name} {user.lastname}");
                        sw.WriteLine($"Пол: {user.sex}");
                        sw.WriteLine($"Дата рождения: {user.Birthday}");
                        sw.WriteLine($"Опыт работы: {user.stage}");
                        sw.WriteLine(user.car);
                        if (user.DriverCategory.Count == 0)
                        {
                            sw.WriteLine("Нету водительского удостоверения");
                        }
                        else
                        {
                            sw.Write("Имеется водительское удостоверение на категории : ");
                            for (int i = 0; i < user.DriverCategory.Count; i++)
                            {
                                sw.Write("{0} ", user.DriverCategory[i]);
                            }
                        }
                        sw.WriteLine($"\nОбъём зарработной платы: от {user.minzp} до {user.maxzp}");
                        sw.WriteLine("Краткое резюме: \n{0}", user.CV);
                    }
                    MessageBox.Show("Данные сохранены");
                }
            }
        }
        


        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите очистить форму?","Подтверждение", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Controls.Clear();
                InitializeComponent();
                MessageBox.Show("Форма очищена");
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
