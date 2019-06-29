using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace HandleData
{
    public class ConnectServer
    {
        private static HttpClient client = new HttpClient();

        static async Task<String> CreateProductAsync(Object obj)
        {

            var response = await client.PostAsJsonAsync("api/students", obj);
            String statusRespone = response.Content.ReadAsStringAsync().Result;
            dynamic json = JObject.Parse(statusRespone);
            return json.status;
            // return URI of the created resource.
        }
        public static async Task SendDataToServer(String sourceDataUrl,String type,String serverUrl)
        {

            configConectToServer(serverUrl);
            try
            {
                List<String> status = new List<String>();
                if (type == "Subject")
                {
                    List<Subject> subjects = Subject.GetSubjectsFromFile(sourceDataUrl);
                    if(subjects.Count <= 0)
                    {
                        MessageBox.Show("Sai kiểu dữ liệu ở File!\n, vui lòng tùy chỉnh file theo đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    foreach (Subject subject in subjects)
                    {
                        String url = await CreateProductAsync(subject);
                        status.Add(url);
                    }
                }
                else if(type == "Student")
                {
                    List<Student> students = Student.getStudentsFromFile(sourceDataUrl);
                    if(students.Count <= 0)
                    {
                        MessageBox.Show("Sai kiểu dữ liệu ở File!\n, vui lòng tùy chỉnh file theo đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    foreach (Student student in students)
                    {
                        String url = await CreateProductAsync(student);
                        status.Add(url);
                    }
                }
                notifiResponeFromServer(status);
            }
            catch (Exception e)
            {

            }
        }

        private static void configConectToServer(string serverUrl)
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri(serverUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private static void  notifiResponeFromServer(List<String> noti)
        {
            if (noti.Contains("True"))
            {
                MessageBox.Show("Dữ liệu đã được thêm vào Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
     
    }

}
