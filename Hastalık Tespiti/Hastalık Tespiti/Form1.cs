using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastalık_Tespiti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program sadece hastalığınızı tahmin ederek sizi bilgilendirmeyi amaçlamaktadır, çıkan sonuca göre ilaç kullanımına başlamamanız ve bir uzman görüşüne başvurmanız önemle rica edilir Sağlıklı Günler." );


                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false && checkBox8.Checked == false && checkBox9.Checked == false && checkBox10.Checked == false )
            { label1.Text = "Lütfen Belirti seçiniz"; }
            
            if (checkBox1.Checked == true)
            { label1.Text = "Reflü,Gastirt,Korner Kalp hastalğı"; }
             if (checkBox2.Checked == true)
            { label1.Text = "Reflü,Gastirt"; }
            if (checkBox1.Checked == true && checkBox2.Checked==true && checkBox3.Checked==true)
            {
                label1.Text = "Reflü";
            }
            
            else if (checkBox3.Checked == true)
            { label1.Text = "Başka belirtilerde seçiniz"; }
            
            if (checkBox3.Checked==true && checkBox4.Checked==true && checkBox5.Checked==true)
            {
                label1.Text = "Grip";
            }
            else if (checkBox4.Checked==true)
            { label1.Text = "Başka belirtilerde seçiniz"; }
            if (checkBox5.Checked == true && checkBox6.Checked == true && checkBox7.Checked == true)
            {
                label1.Text = "İdrar Yolu Enfeksiyonu";
            }
           if (checkBox5.Checked==true && checkBox7.Checked==true)
            {
                label1.Text = "İdrar Yolu Enfeksiyonu";}
            else if (checkBox5.Checked == true)
            { label1.Text = "Başka belirtilerde seçiniz"; }
            if (checkBox4.Checked == true && checkBox8.Checked == true)
            {
                label1.Text = "Beyin tümörü";
            }
            if (checkBox4.Checked == true && checkBox7.Checked == true && checkBox9.Checked==true )
            {
                label1.Text = "Böbrek enfeksiyonu";
            }
            if ( checkBox7.Checked == true && checkBox9.Checked == true)
            {
                label1.Text = "Böbrek enfeksiyonu";
            }

            else if (checkBox9.Checked==true)
            { label1.Text = "Başka belirtilerde seçiniz"; }
            else if (checkBox3.Checked==true && checkBox7.Checked ==true)
            { label1.Text = "Hastalık bulunamadı"; }
             if (checkBox2.Checked == true && checkBox8.Checked == true)
            { label1.Text = "Hastalık bulunamadı"; }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked==true  && checkBox4.Checked==true  )
            { label1.Text = "Hastalık bulunamadı"; }
            if (checkBox1.Checked == true && checkBox5.Checked == true)
            { label1.Text = "Hastalık bulunamadı"; }
            if (checkBox5.Checked == true && checkBox8.Checked == true)
            { label1.Text = "Hastalık bulunamadı"; }
            if (checkBox4.Checked == true && checkBox10.Checked == true)
            { label1.Text = "Tansiyon düşüklüğü"; }
            if (checkBox5.Checked == true && checkBox10.Checked == true)
            { label1.Text = "Hastalık bulunamadı"; }
            if (checkBox1.Checked == true && checkBox10.Checked == true)
            { label1.Text = "Hastalık bulunamadı"; }
            if (checkBox10.Checked == true )
            { label1.Text = "Oturup dinlendikten sonra en yakın sağlık kuruluşuna baş vurun"; }
            if (checkBox7.Checked == true && checkBox10.Checked == true)
            { label1.Text = "Hastalık bulunamadı"; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("184212046,184212047,184212021");
        }
    }
}
