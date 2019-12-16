using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Game game;
        int size = 3;
        Image[,] img;
        PictureBox[,] box;
        int k = 0;
        int tema = 1;
        public string asd;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
           
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            start_game();
            labelName.Text = "Player: " + asd;
        }

        
        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();        
        }

        private void start_game()
        {
            
            k = 0;
            game = new Game(size);
            crop_image();
            init_pictures();
            game.start();
            for (int j = 0; j < size * size * 30; j++)
            //for (int j = 0; j < 3; j++)
                game.shift_random();
            refresh();
            label1.Text = k.ToString();
        }

        private void crop_image()
        {
            img = new Image[size, size];
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    img[x, y] = get_image_part(x, y);
        }

        private Bitmap check_click()
        {
            Bitmap bitmap1;
            if (tema == 1)
            {
                bitmap1 = Properties.Resources.tusur;
            }
           
            else if (tema == 2) { bitmap1 = Properties.Resources.dekan; }
            else if (tema == 3) { bitmap1 = Properties.Resources.ram1; }
            else if (tema == 4) { bitmap1 = Properties.Resources.ram2; }
            else if (tema == 5) { bitmap1 = Properties.Resources.kot; }
            else if (tema == 6) { bitmap1 = Properties.Resources.cats; }
            else if (tema == 7) { bitmap1 = Properties.Resources.forest; }
            else { bitmap1 = Properties.Resources.horse; }
            return bitmap1;
        }

        private Bitmap get_image_part(int x, int y)
        {
                        
            int w, h;
            
            Bitmap bitmap = check_click();
            w = bitmap.Width / size;
            h = bitmap.Height / size;
            Rectangle crop_part = new Rectangle(x * w, y * h, w, h);
            Bitmap target = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(target);
            g.DrawImage(
                bitmap,
                new Rectangle(0, 0, target.Width, target.Height),
                crop_part,
                GraphicsUnit.Pixel);
            return target;
            
            
        }

        private void init_pictures()
        {
            int w, h;
            w = panel1.Width / size;
            h = panel1.Height / size;

            panel1.Controls.Clear();
            box = new PictureBox[size, size];
            for(int x=0; x<size;x++)
                for(int y=0; y< size; y++)
                {
                    PictureBox pb = new PictureBox();

                    pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pb.Location = new System.Drawing.Point(x*w, y*h);
                    
                    pb.Size = new System.Drawing.Size(w, h);
                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pb.Tag = y * size + x;
                    pb.Click += new System.EventHandler(this.pictureBox1_Click);

                    panel1.Controls.Add(pb);
                    box[x, y] = pb;
                }
        }

        private void refresh()
        {
            for (int position = 0; position < size*size; position++)
            {
                int nr = game.get_number(position);
                box[position % size, position / size].Visible = (nr >= 0);
                if (nr >= 0)
                    box[position % size, position / size].Image = img[nr % size, nr / size];
                                
            }
        }

        private void menu_level_3_Click(object sender, EventArgs e)
        {
            size = 3;
            start_game();
        }

        private void menu_level_4_Click(object sender, EventArgs e)
        {
            size = 4;
            start_game();
        }

        private void menu_level_5_Click(object sender, EventArgs e)
        {
            size = 5;
            start_game();
        }

        private void menu_level_6_Click(object sender, EventArgs e)
        {
            size = 6;
            start_game();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            int position = Convert.ToInt16(((PictureBox)sender).Tag);
            game.shift(position);
            if(game.check == true)
            {
                k++;
            }
            
            refresh();
            if (game.check_numbers())
            {
                MessageBox.Show("Вы победили!", "Поздравление");
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://aleksax0.beget.tech/theend.php");
                request.UserAgent = "Mozila/5.0";
                request.Method = "POST";
                string login = asd.ToString();
                string points = k.ToString();
                string query = "login=" + login + "&points=" + points;
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
                start_game();
            }
            label1.Text = k.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_help_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"Цель игры – собрать картинку, 
перемещая квадратики с частью изображения, 
сделав как можно меньше перемещений.

Щелчок мышкой по квадратику с картинкой 
переместит его на пустое поле,
если оно находится рядом. 
Необходимо получить картинку.", "Правила игры");
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Игровая программа «Пятнашки с изображениями» 

©ТУСУР Факультет безопасности Жаргалова Александра Булатовна группа 717-2", "Об авторе");
        }

        private void tema1_Click(object sender, EventArgs e)
        {
            tema = 1;
            check_click();
            start_game();

        }

        private void tema2_Click(object sender, EventArgs e)
        {
            tema = 2;
            check_click();
            start_game();

        }

        private void tema3_Click(object sender, EventArgs e)
        {
            tema = 3;
            check_click();
            start_game();
        }

        private void tema4_Click(object sender, EventArgs e)
        {
            tema = 4;
            check_click();
            start_game();
        }

        private void tema5_Click(object sender, EventArgs e)
        {
            tema = 5;
            check_click();
            start_game();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tema = 6;
            check_click();
            start_game();
        }

        private void tema7_Click(object sender, EventArgs e)
        {
            tema = 7;
            check_click();
            start_game();
        }

        private void tema8_Click(object sender, EventArgs e)
        {
            tema = 8;
            check_click();
            start_game();
        }

        private void рейтингToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://aleksax0.beget.tech/rating.php");
            request.UserAgent = "Mozila/5.0";
            request.Method = "POST";
                       
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

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }

   
}
