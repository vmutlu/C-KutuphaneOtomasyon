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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-PTBFBBJ;Initial Catalog=Kütüphanedb;Integrated Security=True");
        private void verigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Emanet ", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Kisiad"].ToString());
                ekle.SubItems.Add(oku["Kitapad"].ToString());
                ekle.SubItems.Add(oku["Aldigitarih"].ToString());
                ekle.SubItems.Add(oku["Teslimtarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Emanet(id,Kisiad,Kitapad,Aldigitarih,Teslimtarih) values('" + textBox5.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "')", baglan);
            
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoster();
            MessageBox.Show("...Bilgiler Veritabanınıza Basarılı Şekilde Kaydedildi...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verigoster();
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from Emanet where Kitapad like '%" + textBox7.Text + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Kisiad"].ToString());
                ekle.SubItems.Add(oku["Kitapad"].ToString());
                ekle.SubItems.Add(oku["Aldigitarih"].ToString());
                ekle.SubItems.Add(oku["Teslimtarih"].ToString());
                

                listView1.Items.Add(ekle);
            }
            baglan.Close();






            /*baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Emanet where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoster();
            MessageBox.Show("...Bilgileriniz Silindi...");
            */


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            dateTimePicker4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker3.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand komut = new SqlCommand("update Emanet set id= '"+textBox6.Text.ToString()+"',Kisiad='"+textBox4.Text.ToString()+"',Kitapad='"+textBox3.Text.ToString()+"',Aldigitarih='"+dateTimePicker4.Value.ToShortDateString()+"',Teslimtarih='"+dateTimePicker3.Value.ToShortDateString()+ "' where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigoster();
            MessageBox.Show("...Bilgileriniz Guncellendi...");


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
//                                                                                                                                                                                 