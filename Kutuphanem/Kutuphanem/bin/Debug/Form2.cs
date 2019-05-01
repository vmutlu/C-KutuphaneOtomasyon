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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-PTBFBBJ;Initial Catalog=Kütüphanedb;Integrated Security=True");
        private void  verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Kitaplar ", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["KitapYazari"].ToString());
                ekle.SubItems.Add(oku["KitapYayinevi"].ToString());
                ekle.SubItems.Add(oku["KitapAdet"].ToString());
                ekle.SubItems.Add(oku["KitapYili"].ToString());
                listView1.Items.Add(ekle);
             

            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Kitaplar(id,KitapAdi,KitapYazari,KitapYayinevi,KitapAdet,KitapYili) values ('"+textBox11.Text.ToString()+"','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" +textBox5.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("...Bilgiler Veritabanınıza Basarılı Şekilde Kaydedildi...");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox11.Clear();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ds.Tables[0];

        }
        int id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from Kitaplar where KitapAdi like '%" + textBox13.Text + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["KitapYazari"].ToString());
                ekle.SubItems.Add(oku["KitapYayinevi"].ToString());
                ekle.SubItems.Add(oku["KitapAdet"].ToString());
                ekle.SubItems.Add(oku["KitapYili"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
            
            
            
            
            
            
            
            /* SqlDataAdapter da = new SqlDataAdapter(komut);
            
            DataSet ds = new DataSet();
            da.Fill(ds);
            listView1.Items.Add(ds.Tables[0].ToString());
            baglan.Close();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Kitaplar where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("...Bilgiler Silindi...");
            textBox6.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox7.Clear();
            textBox9.Clear();
            textBox8.Clear();*/

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void textBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox10.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox12.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update Kitaplar set id='" + textBox6.Text.ToString() +"',KitapAdi= '"+textBox10.Text.ToString()+"',KitapYazari='"+textBox12.Text.ToString()+"',KitapYayinevi='"+textBox7.Text.ToString()+"',KitapAdet='"+textBox9.Text.ToString()+"',KitapYili='"+textBox8.Text.ToString()+"' where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("...Bilgiler Başarıyla Güncellendi...");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           /* SqlDataAdapter da = new SqlDataAdapter(komut);

            DataSet ds = new DataSet();
            da.Fill(ds);
            listView1.Items.Add(ds.Tables[0].ToString());
            baglan.Close();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Kitaplar where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("...Bilgiler Silindi...");
            textBox6.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox7.Clear();
            textBox9.Clear();
            textBox8.Clear(); */
        }
    }
}
