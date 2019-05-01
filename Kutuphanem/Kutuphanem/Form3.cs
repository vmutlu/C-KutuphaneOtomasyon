using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphanem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-PTBFBBJ;Initial Catalog=Kütüphanedb;Integrated Security=True");
        private void verigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Kişiler ", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kisiid"].ToString();
                ekle.SubItems.Add(oku["Kisiad"].ToString());
                ekle.SubItems.Add(oku["Kisisoyad"].ToString());
                ekle.SubItems.Add(oku["Kisitc"].ToString());
                ekle.SubItems.Add(oku["Kisitel"].ToString());
                ekle.SubItems.Add(oku["KisiAdres"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Kişiler(Kisiid,Kisiad,Kisisoyad,Kisitc,Kisitel,KisiAdres) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + richTextBox1.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoster();
            MessageBox.Show("...Bilgiler Veritabanınıza Basarılı Şekilde Kaydedildi...");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verigoster();
        }
        int Kisiid = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from Kişiler where Kisiad like '%" + textBox11.Text + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kisiid"].ToString();
                ekle.SubItems.Add(oku["Kisiad"].ToString());
                ekle.SubItems.Add(oku["Kisisoyad"].ToString());
                ekle.SubItems.Add(oku["Kisitc"].ToString());
                ekle.SubItems.Add(oku["Kisitel"].ToString());
                ekle.SubItems.Add(oku["KisiAdres"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();




            /*baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Kişiler where Kisiid=(" + Kisiid + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoster();
            MessageBox.Show("...Bilgiler Veritabanınızdan Silindi...");
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();
            richTextBox2.Clear();*/
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Kisiid = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox10.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[4].Text;
            richTextBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update Kişiler set Kisiid='" + textBox10.Text.ToString() + "',Kisiad= '" + textBox9.Text.ToString() + "',Kisisoyad='" + textBox8.Text.ToString() + "',Kisitc='" + textBox7.Text.ToString() + "',Kisitel='" + textBox6.Text.ToString() + "',KisiAdres='" + richTextBox2.Text.ToString() + "' where Kisiid=" + Kisiid + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoster();
            MessageBox.Show("...Bilgiler Veritabanınıza Basarılı Şekilde Güncelleştirildi...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
