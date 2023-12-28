using System.Diagnostics.Eventing.Reader;

namespace LAB4_COFFEE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Make_Coffee taocoffee = new Make_Coffee();

        private void Blackcoffee_Click(object sender, EventArgs e)
        {
            if (taocoffee.markBlackCoffee())
            {
                coffeeDpic.Image = Properties.Resources.blackcoffee_1561170296;
            }
            else
            {
                MessageBox.Show("Out of stock");
                coffeeDpic.Visible = false;
            }
        }

        private void Mocha_Click(object sender, EventArgs e)
        {
            if (taocoffee.markMocha())
            {
                coffeeDpic.Image = Properties.Resources.Cover_Mocha_1080x675;
            }
            else
            {
                MessageBox.Show("Out of stock");
                coffeeDpic.Visible = false;

            }
        }

        private void Latte_Click(object sender, EventArgs e)
        {
            if (taocoffee.markLatte())
            {
                coffeeDpic.Image = Properties.Resources.latte;
            }
            else
            {
                MessageBox.Show("Out of stock");
                coffeeDpic.Visible = false;
            }
        }

        private void Chocolate_Click(object sender, EventArgs e)
        {
            if (taocoffee.markChocolate())
            {
                coffeeDpic.Image = Properties.Resources.chocolate;
            }
            else
            {
                MessageBox.Show("Out of stock");
                coffeeDpic.Visible = false;
            }
        }
        
    }
}
