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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void hastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 fr = new Form2();
            fr.MdiParent = this;

            fr.Show();
            fr.Location = new Point(150, 113);
        }
    }
}
