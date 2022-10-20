using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobileshopmanagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MOBILE mob=new MOBILE()
            mob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accesories acc = new Accesories()
            acc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selling sel = new selling()
            sel.Show();
            this.Hide();
        }
    }
}
