using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace LoginForm
{
    public partial class SignUpForm : Form
    {
        List<UserData> AccountsManager;
        public SignUpForm()
        {
            InitializeComponent();
            CheckUsers();
        }
        private void CheckUsers()
        {
            string filePath = "D:\\WORK\\2 КУРС\\ТиМП ЛР 2 курс 4 СЕМЕСТР\\Forms\\FormLogin\\LoginForm\\userInfo.json";

            var userDataJson = File.ReadAllText(filePath);
            AccountsManager = JsonConvert.DeserializeObject<List<UserData>>(userDataJson);

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            foreach (var item in AccountsManager)
            {
                if (textBoxLogin.Text == XORDecode(item.Login, "mysecretkey")
                && textBoxPassword.Text == XORDecode(item.Password, "mysecretkey"))
                {
                    MessageBox.Show("Авторизация прошла успешно!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show(
                    "Ошибка! Неверный логин или пароль.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }
        private void SaveNewUser()
        {
            string filePath = "D:\\WORK\\2 КУРС\\ТиМП ЛР 2 курс 4 СЕМЕСТР\\Forms\\FormLogin\\LoginForm\\userInfo.json";
            string fileContent = JsonConvert.SerializeObject(AccountsManager);
            File.WriteAllText(filePath, fileContent);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string login = XOREncode(textBoxLogin.Text, "mysecretkey");
            string password = XOREncode(textBoxPassword.Text, "mysecretkey");

            if (!AccountsManager.Any(u => u.Login == login)) 
            {
                var newUser = new UserData(login, password);
                AccountsManager.Add(newUser);
                SaveNewUser();
                CheckUsers();

                MessageBox.Show("Регистрация прошла успешно!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка! Такой пользователь уже зарегистрирован!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Шифрование на основе XOR
        public static string XOREncode(string text, string key)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] encodedBytes = new byte[textBytes.Length];

            for (int i = 0; i < textBytes.Length; i++)
            {
                encodedBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Convert.ToBase64String(encodedBytes);
        }

        public static string XORDecode(string encodedText, string key)
        {
            byte[] encodedBytes = Convert.FromBase64String(encodedText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] decodedBytes = new byte[encodedBytes.Length];

            for (int i = 0; i < encodedBytes.Length; i++)
            {
                decodedBytes[i] = (byte)(encodedBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Encoding.UTF8.GetString(decodedBytes);
        }

    }
}
