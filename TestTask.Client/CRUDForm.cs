using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using TestTask.Server.Entities;

namespace TestTask.Client
{
    public partial class CRUDForm : Form
    {
        private HttpClient _httpClient;
        private ObservableCollection<Student> _students;

        public CRUDForm()
        {
            InitializeComponent();
            this._httpClient = new HttpClient();
            this._students = new ObservableCollection<Student>();
        }

        //methods
        public async Task<ObservableCollection<Student>> GetAllStudents(string request)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(request);
            ObservableCollection<Student> res = null;
            if (response.IsSuccessStatusCode)
            {
                res = await response.Content.ReadAsAsync<ObservableCollection<Student>>();
            }
            return res;
        }
        public async Task<Student> GetOneStudent(string request)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(request);
            Student student = null;
            if (response.IsSuccessStatusCode)
            {
                student = await response.Content.ReadAsAsync<Student>();
            }
            return student;
        }
        public async Task CreateStudent(string request, Student student)
        {
            var json = new StringContent(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(request, json);
            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException();
            }
            return;
        }
        public async Task UpdateStudent(string request, Student student)
        {
            var json = new StringContent(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PatchAsync(request, json);
            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException();
            }
            return;
        }
        public async Task DeleteStudent(string request)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException();
            }
            return;
        }
        public async Task UpdateDataGridView()
        {
            this._students = await this.GetAllStudents("https://localhost:4444/Api/StudentController");
            this.dataGridView.DataSource = this._students;
            return;
        }

        //buttons
        private async void CreateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StudentFirstName = FirstNameTxtBox.Text,
                StudentLastName = LatTxtBox.Text,
            };

            await this.CreateStudent("https://localhost:4444/Api/StudentController", student);
            await UpdateDataGridView();
        }
        private async void ReadButton_Click(object sender, EventArgs e)
        {
            await this.GetOneStudent($"https://localhost:4444/Api/StudentController/{int.Parse(IdTxtBox.Text)}");
            await UpdateDataGridView();
        }
        private async void GetAllButton_Click(object sender, EventArgs e)
        {
            await UpdateDataGridView();
        }
        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Id = int.Parse(IdTxtBox.Text),
                StudentFirstName = FirstNameTxtBox.Text,
                StudentLastName = LatTxtBox.Text,
            };
            await this.UpdateStudent($"https://localhost:4444/Api/StudentController/{int.Parse(IdTxtBox.Text)}", student);
            await UpdateDataGridView();

        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await this.DeleteStudent($"https://localhost:4444/Api/StudentController/{int.Parse(IdTxtBox.Text)}");
            await UpdateDataGridView();
        }

    }
}
