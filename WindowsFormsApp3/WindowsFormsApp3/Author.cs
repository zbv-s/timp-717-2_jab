using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using xNet;


namespace WindowsFormsApp3
{
    public partial class Author : Form
    {
        string login;
        string pass;
        HttpRequest req = new HttpRequest();
        bool vis = true;
        public Author()
        {
            InitializeComponent();
            buttonAuth.Click += new EventHandler(buttonAuth_Click);
        }

        private void Author_Load(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {


            //req.Get("http://aleksax0.beget.tech/connection.php?login=" + login + "&pass=" + pass);
            //MessageBox.Show("send");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://aleksax0.beget.tech/connection.php");
            request.UserAgent = "Mozila/5.0";
            request.Method = "POST";
            login = textBoxLog.Text;
            pass = textBoxPass.Text;
            string query = "login=" + login + "&pass=" + pass;
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = request.GetResponse();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = sR.ReadToEnd();
                }
            }
            response.Close();
            MessageBox.Show(answer);



        }


        private void buttonAuth_Click(object sender, EventArgs e)
        {
            //const String CorrectAuthText = "Авторизация прошла успешно";
            //var request = (HttpWebRequest)WebRequest.Create("http://aleksax0.beget.tech/auth.php");
            //var postData = "buttonAuth = True";
            //postData += "&login =" +textBoxLog.Text;
            //postData += "&password =" +textBoxPass.Text;
            //var data = Encoding.ASCII.GetBytes(postData);
            //request.Method = "POST";
            //request.ContentType = "application / x - www - form - urlencoded";
            //request.ContentLength = data.Length;

            //using (var stream = request.GetRequestStream())
            //{ stream.Write(data, 0, data.Length); }
            //var response = (HttpWebResponse)request.GetResponse();
            //var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://aleksax0.beget.tech/auth.php");
            request.UserAgent = "Mozila/5.0";
            request.Method = "POST";
            login = textBoxLog.Text;
            pass = textBoxPass.Text;
            string query = "login=" + login + "&pass=" + pass;
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = request.GetResponse();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = sR.ReadToEnd();
                }
            }
            response.Close();
            if (answer == "")
            {
                //Form1 f = new Form1();
                //f.Show();
                //this.Close();
                this.Hide();
                var formMain = new Form1();
                formMain.asd = textBoxLog.Text;
                formMain.Closed += (s, args) => this.Close();
                formMain.Show();
                
            }

            else
            {
                MessageBox.Show(answer);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vis)
            {

                textBoxPass.UseSystemPasswordChar = false; vis = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true; vis = true;
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true; vis = true;
        }
        
    }
}
     
