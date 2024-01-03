using Azure.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Server.Entities;

namespace TestTask.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserLogin = LoginTxtBox.Text,
                UserPassword = PasswordTxtBox.Text,
            };

            bool isSuccessfullyLoggedIn = await this.VerifyLogin($"https://localhost:4444/Api/UserController/login", user);

            if (isSuccessfullyLoggedIn)
            {
                CRUDForm cRUDForm = new CRUDForm();
                cRUDForm.Show();
            }
            else
            {
                MessageBox.Show("User with such credentials does not exist");
            }
        }

        public async Task<bool> VerifyLogin(string request, User user)
        {
            HttpClient client = new HttpClient();

            var json = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(request, json);

            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException();
            }
            return await response.Content.ReadAsAsync<bool>();
        }
    }
}
