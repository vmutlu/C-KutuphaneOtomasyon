using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.MdiParent = this;
            
            fr.Show();
            fr.Location = new Point(150, 113);
            
        }

        private void TarihveSaat()
        {
            textBox2.Text = DateTime.Now.ToLongTimeString(); // sadece saat 
            textBox1.Text = DateTime.Now.ToLongDateString(); // sadece tarih
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.MdiParent = this;

            fr.Show();
            fr.Location = new Point(150, 113);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.MdiParent = this;

            fr.Show();
            fr.Location = new Point(150, 113);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if (sonuc == DialogResult.No)
            {
                
                return;
            }
            Application.Exit();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            TarihveSaat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//
