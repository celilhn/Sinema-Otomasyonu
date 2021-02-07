using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_05_2020
{

    public partial class Form1 : Form
    {
        public string sinema, tarih, seans, ad, soyad, cinsiyet, butonIsmi;
        public int ucret = 0,sinemaUcret=0,butonSay=0;
        bool sec, butonsecildimi;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (radioButtonErkek.Checked)
                cinsiyet = "Erkek";
            if (radioButtonKadın.Checked)
                cinsiyet = "Kadın";

            if (cinsiyet=="Erkek" || cinsiyet=="Kadın")
            {
                if (butonSay == 0)
                {
                    Button button = (sender as Button); // Basılan butonun indexi bulunuyor

                    if (cinsiyet == "Erkek")
                        button.BackColor = Color.Blue;
                    if (cinsiyet == "Kadın")
                        button.BackColor = Color.DeepPink;
                    butonSay++;
                    butonsecildimi = true;
                    butonIsmi = button.Name;
                }
            }
            
            
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            ad = txtAd.Text;
            soyad = txtSoyad.Text;

            if (sec == true && butonsecildimi==true && ad != "" && soyad != "")
            {
                if (checkBoxCekirdek.Checked)
                    ucret += 4;
                if (checkBoxCips.Checked)
                    ucret += 7;
                if (checkBoxkola.Checked)
                    ucret += 8;
                if (checkBoxMisir.Checked)
                    ucret += 10;

                label7.Text = (ucret + sinemaUcret).ToString();
            }
            else
                MessageBox.Show("Lütfen bilgileri eksizsiz girin.", "Bilgilendirme Penceresi");

            KoltukSecimi listele = new KoltukSecimi();
            listele.ad = ad;
            listele.soyad = soyad;
            listele.sinema = sinema;
            listele.seans = seans;
            listele.tarih = tarih;
            listele.butonIsmi = butonIsmi;
            listele.Show();
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            sinema = comboBoxSinema.SelectedItem.ToString();
            seans = comboBoxSeans.SelectedItem.ToString();
            tarih = dateTimePicker1.Value.ToString();

            if (comboBoxSinema.SelectedItem.ToString() == "Durdurulamaz Güç")
                sinemaUcret += 13;
            if (comboBoxSinema.SelectedItem.ToString() == "Gölgelerin Aşkı")
                sinemaUcret += 10;
            if (comboBoxSinema.SelectedItem.ToString() == "İlk Aşk")
                sinemaUcret += 25;
            if (comboBoxSinema.SelectedItem.ToString() == "Kadın")
                sinemaUcret += 18;
            if (comboBoxSinema.SelectedItem.ToString() == "Meryem")
                sinemaUcret += 12;

            label6.Text = sinemaUcret.ToString();

            sec = true;
        }
    }
}