using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(textBox2.Text);
            s2 = Convert.ToInt16(textBox3.Text);
            s3 = Convert.ToInt16(textBox4.Text);
            ort = (s1 + s2 + s3) / 3;
            textBox5.Text = ort.ToString();

            if (ort >= 50)
            {
                durum = "Geçti";
            }

            else
            {
                durum = "Kaldı";
            }
            textBox6.Text = durum;
            


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(textBox5.Text!="" && textBox6.Text!="")
            {

            
            string adsoyad, ders, numara;
            adsoyad = TxtAdSoyad.Text;
            ders = comboBox1.Text;
            numara = maskedTextBox1.Text;
            listBox1.Items.Add("Adı Soyad:"+ " "+ adsoyad + "/" + "Ders:"+ " "+ ders + "/"+ "Numara:" + numara + "/" + "Ortalama:" + textBox5.Text + "/"+ "Durum:"+ textBox6.Text);

                sayac++;
                label3.Text = "Kaydedilen Öğrenci Sayısı:" + sayac;
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durum hesabını yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSatirEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("-------------------------------------------------");
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            //listBox1.Items.Clear();
            maskedTextBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            TxtAdSoyad.Focus();
            

        }

        private void BtnMesajKutusu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya Derslerimiz Devam Ediyor", "Mesaj Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        int sayac=0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            sayac++;
            label3.Text = sayac.ToString();
        }

        private void BtnForDongusu_Click(object sender, EventArgs e)
        {
            for (int i = 1; i<= 10; i++)
            {
                listBox2.Items.Add(i +"-Galatasaray");
            }
        }

        private void BtnForDongusu2_Click(object sender, EventArgs e)
        {
            for(int i=1; i<=20; i++)

                if(i%3==0)
            {
                listBox2.Items.Add(i);
            }
        }

        private void BtnListboxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void BtnWhileDongusu_Click(object sender, EventArgs e)
        {
            int x = 1;
            while (x <= 10)
            {
                listBox2.Items.Add(x+ "-While Döngüsü");
                x++;
            }

        }

        private void BtnDizi1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Elazığ", "İstanbul", "Sivas", "Ankara", "Tunceli", "Malatya" };
            TxtAdSoyad.Text = sehirler[4];
        }

        private void BtnDizi2_Click(object sender, EventArgs e)
        {
            int [] sayilar ={23,34,62,44,58,123,1358,2022 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    listBox2.Items.Add(sayilar[i]);
            //}
          foreach(int k in sayilar)
            {
                listBox2.Items.Add(k);
            }
        }
    }
}
