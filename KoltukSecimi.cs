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
    public partial class KoltukSecimi : Form
    {
        public string ad,soyad,sinema,seans,tarih,butonIsmi;
        public KoltukSecimi()
        {
            InitializeComponent();
        }

        private void KoltukSecimi_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("İsim: " + ad);
            listBox1.Items.Add("Soyisim: " + soyad);
            listBox1.Items.Add("Sinema: " + sinema);
            listBox1.Items.Add("Seans: " + seans);
            listBox1.Items.Add("Tarih: " + tarih);
            listBox1.Items.Add("Koltuk Numarası: " + butonIsmi);
        }
    }
}
