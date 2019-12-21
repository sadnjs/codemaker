using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHttp;

namespace 코드발급기
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void 코드발급_Click(object sender, EventArgs e)
        {
            if (Code.Text != "")
            {
                var data = new Data
                {
                    Code1 = Code.Text
                };

                if (checkBox1.Checked)
                {
                    SetResponse response = await client.SetTaskAsync("1Day/" + Code.Text, data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("1일코드 발급 성공");
                    Clipboard.SetText(Code.Text);
                    Code.Text = "";
                }
                else if (checkBox2.Checked)
                {
                    SetResponse response = await client.SetTaskAsync("12Hour/" + Code.Text, data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("12시간코드 발급 성공");
                    Clipboard.SetText(Code.Text);
                    Code.Text = "";
                }
            }
            else
            {
                MessageBox.Show("코드칸을 비워둘수는 없습니다.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTempPassword();
        }

        public string CreateTempPassword()
        {
            string password = string.Empty;
            string[] alpabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            Random nalpabet = new Random();

            password = alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] +
                alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] +
                alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] +
                alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] +
                alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] +
                alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)] + alpabet[nalpabet.Next(0, 31)];

            Code.Text = password;
            return password;
        }
    }
}
