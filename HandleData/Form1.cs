using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandleData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_loaidulieu.DropDownHeight = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setValueToCombobox();

        }
        private void setValueToCombobox()
        {

            cb_loaidulieu.Items.Add("Student");
            cb_loaidulieu.Items.Add("Subject");
            cb_loaidulieu.SelectedIndex = 0;
            cb_url.Items.Add("https://pttkpm-cntn16-portal.herokuapp.com/");
            cb_url.SelectedIndex = 0;

        }

        private void Bt_findUrl_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_url.Text = openFileDialog1.FileName;
            }
        }

        private void  Bt_sendData_Click(object sender, EventArgs e)
        {

            String direct = getUrl();
            string serverUrl = getUrlOfServer();
            if(direct == "")
            {
                MessageBox.Show("Bạn chưa chọn file dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            String type = getTypeObject();
            ConnectServer.SendDataToServer(direct,type,serverUrl);
        }

        private string getUrlOfServer()
        {
            return cb_url.Text;
        }

        private String getUrl()
        {
            return tb_url.Text;
        }
        private String getTypeObject()
        {
            return cb_loaidulieu.Text;
        }

    }
}
