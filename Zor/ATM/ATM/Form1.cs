using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Login_Button_8_Click(object sender, EventArgs e)
        {
            if (Account.check_Acc(Int32.Parse(textBox1.Text.ToString())))
            {
                Login_Panel.Visible = false;
                Select_Panel.Visible = true;
                Gun_Sonu.logger(textBox1.Text+" No lu hesaptan giriş yapıldı.");
            }
            else
            {
                Hatali_Islemler.Kalan_hak--;
                Kalan_Hak.Text = Hatali_Islemler.Kalan_hak.ToString();
                Gun_Sonu.logger("Tc kimlik Hatalı Girildi Kalan Hak sayısı "+ Hatali_Islemler.Kalan_hak);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gun_Sonu.logger("Program çalıştırıldı.");
            Account.AllAccount();
        }

        private void Para_Cekme_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = false;
            Para_Cekme_panel.Visible = true;


        }

        private void Para_Cekim_AnaSayfa_Click(object sender, EventArgs e)
        {
            Para_Cekme_panel.Visible = false;
            Select_Panel.Visible = true;
            listBox1.Items.Clear();
            textBox2.Text = "";
        }

        private void Para_Cekim_Exit_Click(object sender, EventArgs e)
        {
            Para_Cekme_panel.Visible = false;
            Login_Panel.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                var Bakiye = Account.accounts[Account.index].Bakiye;
                if (Bakiye < Int32.Parse(textBox2.Text))
                {
                    MessageBox.Show("Yetersiz Bakiye");
                    Gun_Sonu.logger(Account.accounts[Account.index].isim+" -Yetersiz Bakiye Sonucunu aldı.");
                }
                else
                {
                    Hesaplamalar.ParaBol(Int32.Parse(textBox2.Text));

                    listBox1.Items.Add(Hesaplamalar.banknots[0]._200 + " Adet 200TL lik Banknot");
                    listBox1.Items.Add(Hesaplamalar.banknots[0]._100 + " Adet 100TL lik Banknot");
                    listBox1.Items.Add(Hesaplamalar.banknots[0]._50 + " Adet 50TL lik Banknot");
                    listBox1.Items.Add(Hesaplamalar.banknots[0]._20 + " Adet 20TL lik Banknot");
                    listBox1.Items.Add(Hesaplamalar.banknots[0]._10 + " Adet 10TL lik Banknot");
                    listBox1.Items.Add(Hesaplamalar.banknots[0]._5 + " Adet 5TL lik Banknot");
                    listBox1.Items.Add(Hesaplamalar.banknots[0]._1 + " Adet 1TL lik Bozuk Para");
                    Gun_Sonu.logger(Account.accounts[Account.index].isim + " -Para çekimi Etti :" + textBox2.Text + " TL");
                }
               

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = false;
            Kredi_Ode_Panel.Visible = true;
            borc_label.Text = Account.accounts[Account.index].Borc.ToString();


        }

        private void Kredi_Onay_button_Click(object sender, EventArgs e)
        {
            var Borc = Account.accounts[Account.index].Borc;
            if (Borc < Int32.Parse(textBox3.Text))
            {
                MessageBox.Show("Borcunuzdan Daha Yüksek Bir Değer Girdiniz");
            }
            else
            {
                Hesaplamalar.KrediOde(Convert.ToSingle(textBox3.Text));
                Account.accounts[Account.index].Borc -= Convert.ToSingle(textBox3.Text);
                borc_label.Text = Account.accounts[Account.index].Borc.ToString();
                textBox3.Text = "";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Kredi_Ode_Panel.Visible = false;
            Select_Panel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = false;
            Bakiye_Bilgisi.Visible=true; 
            toplam_bakiye_label.Text= Account.accounts[Account.index].Bakiye.ToString();
            Gun_Sonu.logger(Account.accounts[Account.index].isim + " -Bakiye Kontrolü :");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = true;
            Bakiye_Bilgisi.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = false;
            Transfer_Panel.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int transferindex = 0;
            float transferpara = 0;
            float value = Convert.ToSingle(Tc_Text.Text);
            if (null != Account.accounts.Find(a => a.TC == value))
            {
                transferindex = Account.accounts.FindIndex(a => a.TC == value);
                transferpara = Convert.ToSingle(Visible_Transfer_Box.Text);
               

            }

            Hesaplamalar.Transfer(transferindex,transferpara);
            listBox2.Items.Add("Gönderilen Kişinin İsimi: " + Account.accounts[transferindex].isim);
            listBox2.Items.Add("Gönderilen Kişinin Soyisimi: " + Account.accounts[transferindex].Soyisim);
            listBox2.Items.Add("Gönderilen Kişinin Tc No'su " + Account.accounts[transferindex].TC);
            listBox2.Items.Add("Gönderilen Miktar " + transferpara);
            listBox2.Items.Add("Kalan Bakiyeniz " + Account.accounts[Account.index].Bakiye);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = true;
            Transfer_Panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_Panel.Visible = false;
            Login_Panel.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Gun_Sonu.extract();
        }
    }
}