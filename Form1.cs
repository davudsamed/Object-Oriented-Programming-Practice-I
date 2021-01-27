/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Davud Samed Tombul
**				ÖĞRENCİ NUMARASI.......:B171210007
**              DERSİN ALINDIĞI GRUP...:1D
****************************************************************************/

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

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] satirlar;
            string hepsi = richTextBox1.Text;
            satirlar = hepsi.Split('\n'); //dosya satırlara ayrılabilir
            foreach (string s in satirlar) // personel bilgileri(satırlar) ayrıştırılabilir.
            {
                string[] kelimeler = s.Split(' ');
                if (tcarama_text.Text == kelimeler[0])
                {
                    tc_text.Text = kelimeler[0];
                    adi_text.Text = kelimeler[1];
                    soyadi_text.Text = kelimeler[2];
                    yas_text.Text = kelimeler[3];
                    calismasure_text.Text = kelimeler[4];
                    evlilik_text.Text = kelimeler[5];
                    escalisma_text.Text = kelimeler[6];
                    cocuksayisi_text.Text = kelimeler[7];
                    tabanmaas_text.Text = kelimeler[8];
                    makamtazminat_text.Text = kelimeler[9];
                    fazla_mesai_text.Text = kelimeler[10];
                    fazla_mesai_ucret_text.Text = kelimeler[11];
                    idare_gorev_text.Text = kelimeler[12];
                    vergi_matrah_text.Text = kelimeler[13];
                    pictureBox1.Image = Image.FromFile(kelimeler[14]);

                    double taban_maas, makam_tazminatı, idari_gorev, cocuk_sayısı, fazla_mesaisaati, fazlamesai_ücreti,brut_sonuc=0;
                    taban_maas = Convert.ToDouble(kelimeler[8]);
                    makam_tazminatı = Convert.ToDouble(kelimeler[9]);
                    idari_gorev = Convert.ToDouble(kelimeler[12]);
                    cocuk_sayısı = Convert.ToDouble(kelimeler[7]);
                    fazla_mesaisaati = Convert.ToDouble(kelimeler[10]);
                    fazlamesai_ücreti = Convert.ToDouble(kelimeler[11]);


                    
                    if (kelimeler[5] == "B")
                       brut_sonuc= taban_maas + makam_tazminatı + idari_gorev + cocuk_sayısı * 30 + fazla_mesaisaati * fazlamesai_ücreti;
                     if(kelimeler[5] == "E" && kelimeler[6]=="E")
                        brut_sonuc = taban_maas + makam_tazminatı + idari_gorev + cocuk_sayısı * 30 + fazla_mesaisaati * fazlamesai_ücreti;
                     if(kelimeler[5] == "E" && kelimeler[6] != "E")
                        brut_sonuc = taban_maas + makam_tazminatı + idari_gorev + cocuk_sayısı * 30 + fazla_mesaisaati * fazlamesai_ücreti+200;

                    brut_text.Text = Convert.ToString(brut_sonuc);
                }   
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Dosyası |*.txt";
            openFileDialog.ShowDialog();

            richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);


            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
