using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Mayın_Tarlası_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MayinTarlasi mayinTarlamiz;

        Image mayinResmi = Image.FromFile(@"mayin.png");

        List<Mayın> mayinlarimiz;

        int zorluk;
        string seviye;

        KullanıcıAdı KullaniciA = new KullanıcıAdı();


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void mayinEkle()
        {
            for (int x = 0; x < panel1.Width; x = x + 20)
            {
                for (int y = 0; y < panel1.Height; y = y + 20)
                {
                    buttonEkle(new Point(x, y));
                }
            }
        }

        public void buttonEkle(Point loc)
        {
            Button btn = new Button();

            btn.Name = loc.X + " " + loc.Y;
            btn.Text = " ";
            btn.Size = new Size(20, 20);
            btn.Location = loc;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
            btn.Click += new EventHandler(btn_Click);

            panel1.Controls.Add(btn);
        }

        public void btn_Click(object sender, EventArgs e)
        {
            

            timer1.Start();
            Button btn = (sender as Button);
            Mayın myn = mayinTarlamiz.mayinAlLoc(btn.Location);
            mayinlarimiz = new List<Mayın>();

            if (myn.mayinVarMi)
            {               
                mayinlariGoster();
                timer1.Stop();

                OyunSonu oyunsonu = new OyunSonu();

                (oyunsonu.Controls["txtOyunSonu"]).Text = (KullaniciA.Controls["txtKullaniciAdi"]).Text + " kaybettin.";
                (oyunsonu.Controls["txtSeviye"]).Text = seviye;
                (oyunsonu.Controls["txtSkor"]).Text = "0";

                oyunsonu.ShowDialog();

            }
            else
            {
                int say = etraftaKacMayinVar(myn);
                if (say == 0)
                {
                    mayinlarimiz.Add(myn);

                    for (int i = 0; i < mayinlarimiz.Count; i++)
                    {
                        if (mayinlarimiz[i] != null)
                        {

                            if (mayinlarimiz[i].bakildi_ == false && mayinlarimiz[i].mayinVarMi == false)
                            {
                                Button btn2 = (Button)panel1.Controls.Find(mayinlarimiz[i].konumAl.X + " " + mayinlarimiz[i].konumAl.Y, false)[0];

                                if (etraftaKacMayinVar(mayinlarimiz[i]) == 0)
                                {
                                    btn2.Enabled = false;
                                    btn2.BackColor = Color.DarkGray;
                                    cevresindekileriEkle(mayinlarimiz[i]);
                                }
                                else
                                {
                                    btn2.Text = etraftaKacMayinVar(mayinlarimiz[i]).ToString();
                                }
                                mayinlarimiz[i].bakildi_ = true;
                            }
                        }
                    }
                }
                else
                {
                    btn.Text = say.ToString();
                }
            }
            int say2 = 0;
            string s1=null;
            for (int x = 0; x < panel1.Width; x = x + 20)
            {
                for (int y = 0; y < panel1.Height; y = y + 20)
                {
                    s1 = panel1.Controls[x.ToString() + " " + y.ToString()].Text;
                    if (s1 == " "&& panel1.Controls[x.ToString() + " " + y.ToString()].Enabled)
                    {
                        say2++;
                    }
                }
            }
            if (say2<=zorluk)
            {
                mayinlariGoster();
                timer1.Stop();

                OyunSonu oyunsonu = new OyunSonu();

                (oyunsonu.Controls["txtOyunSonu"]).Text ="Tebrikler " +(KullaniciA.Controls["txtKullaniciAdi"]).Text + " kazandın.";
                (oyunsonu.Controls["txtSeviye"]).Text = seviye;
                (oyunsonu.Controls["txtSkor"]).Text = lblTimer.Text+" Saniye";

                oyunsonu.ShowDialog();
            }
        }

        public int etraftaKacMayinVar(Mayın m)
        {
            int say = 0;

            if (m.konumAl.X > 0)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X - 20, m.konumAl.Y)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.X < panel1.Width - 20)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X + 20, m.konumAl.Y)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.Y > 0)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X, m.konumAl.Y - 20)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.Y < panel1.Height - 20)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X, m.konumAl.Y + 20)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.X > 0 && m.konumAl.Y > 0)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X - 20, m.konumAl.Y - 20)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.X > 0 && m.konumAl.Y < panel1.Height - 20)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X - 20, m.konumAl.Y + 20)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.X < panel1.Width - 20 && m.konumAl.Y > 0)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X + 20, m.konumAl.Y - 20)).mayinVarMi)
                {
                    say++;
                }
            }
            if (m.konumAl.X < panel1.Width - 20 && m.konumAl.Y < panel1.Height - 20)
            {
                if (mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X + 20, m.konumAl.Y + 20)).mayinVarMi)
                {
                    say++;
                }
            }


            return say;
        }

        public void cevresindekileriEkle(Mayın m)
        {
            bool b1 = false, b2 = false, b3 = false, b4 = false;

            if (m.konumAl.X > 0)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X - 20, m.konumAl.Y)));
                b1 = true;
            }
            if (m.konumAl.Y > 0)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X, m.konumAl.Y - 20)));
                b2 = true;
            }
            if (m.konumAl.X < panel1.Width)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X + 20, m.konumAl.Y)));
                b3 = true;
            }
            if (m.konumAl.Y < panel1.Height)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X, m.konumAl.Y + 20)));
                b4 = true;
            }
            if (b1 && b2)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X - 20, m.konumAl.Y - 20)));

            }
            if (b1 && b4)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X - 20, m.konumAl.Y + 20)));

            }
            if (b3 && b2)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X + 20, m.konumAl.Y - 20)));

            }
            if (b3 && b4)
            {
                mayinlarimiz.Add(mayinTarlamiz.mayinAlLoc(new Point(m.konumAl.X + 20, m.konumAl.Y + 20)));

            }
        }


        public void mayinlariGoster()
        {
            foreach (Mayın item in mayinTarlamiz.GetAllMayin)
            {
                if (item.mayinVarMi)
                {
                    Button btn = (Button)panel1.Controls.Find(item.konumAl.X + " " + item.konumAl.Y, false)[0];
                    btn.BackgroundImage = mayinResmi;                   
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = sayac.ToString();
            sayac++;
        }

        private void btnKolay_Click(object sender, EventArgs e)
        {
            seviye = "Kolay";

            KullaniciA.ShowDialog();
            zorluk = 20;

            mayinTarlamiz = new MayinTarlasi(new Size(400, 400), zorluk);
            panel1.Size = mayinTarlamiz.buyuklugu;
            mayinEkle();
        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            seviye = "Orta";

            KullaniciA.ShowDialog();
            zorluk = 40;

            mayinTarlamiz = new MayinTarlasi(new Size(400, 400), zorluk);
            panel1.Size = mayinTarlamiz.buyuklugu;
            mayinEkle();
        }

        private void btnZor_Click(object sender, EventArgs e)
        {
            seviye = "Zor";
            KullaniciA.ShowDialog();
            zorluk = 80;

            mayinTarlamiz = new MayinTarlasi(new Size(400, 400), zorluk);
            panel1.Size = mayinTarlamiz.buyuklugu;
            mayinEkle();
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
