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

        static async Task<String> CreateProductAsync(Object obj,String type)
        {

            var response = await client.PostAsJsonAsync(type.ToLower(), obj);
            String statusRespone = response.Content.ReadAsStringAsync().Result;
            dynamic json = JObject.Parse(statusRespone);
            return json.status;
            // return URI of the created resource.
        }
        public static async Task SendDataToServer(String sourceDataUrl,String type,String serverUrl)
        {

            // Update port # in the following line.
            client.BaseAddress = new Uri(serverUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<String> status = new List<String>();
                List<Object> data = getListObjectFromName(type, sourceDataUrl);
                foreach (Object obj in data)
                {
                    String respone = await CreateProductAsync(obj, type);
                    status.Add(respone);
                }
                notifiResponeFromServer(status);
            }
            catch (Exception e)
            {

            }
        }
        private static List<Object> getListObjectFromName(String type, String url)
        {
            List<Object> list = new List<object>();
            List<String> infoSubject = ReadFile.readDataFromFile(url);
            if (type == "Subjects")
            {
                for(int i=0; i< infoSubject.Count; i++)
                {
                    list.Add(Subject.getSubjectFromString(infoSubject[i]));
                }
                if (list.Count <= 0)
                {
                    MessageBox.Show("Sai kiểu dữ liệu ở File!\n, vui lòng tùy chỉnh file theo đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            else if (type == "Students")
            {
                for (int i = 0; i < infoSubject.Count; i++)
                {
                    list.Add(Student.getStudentFromString(infoSubject[i]));
                }
                if (list.Count <= 0)
                {
                    MessageBox.Show("Sai kiểu dữ liệu ở File!\n, vui lòng tùy chỉnh file theo đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            return list;
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
