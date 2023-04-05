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
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

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
