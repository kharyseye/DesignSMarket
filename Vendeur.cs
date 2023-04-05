using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMarket
{
    public partial class Vendeur : Form
    {
        public Vendeur()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            Article art = new Article();
            art.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Facture fact = new Facture();
            fact.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vendeur vend = new Vendeur();
            vend.Show();
            this.Hide();
        }
    }
}
