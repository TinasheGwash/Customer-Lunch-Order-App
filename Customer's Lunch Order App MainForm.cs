// Name: Tinashe Gwashavanhu 
// Customer Lunch Order App
// Date: 09/05/18


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Lunch_Order_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            //When clear button is hit the appetizer text boxes are cleared
            bowlOfSoupTextBox.Clear();
            CeasarSaladTextBox.Clear();
            calamariTextBox.Clear();

            //when clear button is hit the sandwiches text boxes are cleared
            italianSubTextBox.Clear();
            meatballTextBox.Clear();
            sausageTextBox.Clear();

            //when clear button is hit the plates text boxes are cleared
            ravioliTextBox.Clear();
            lasagnaTextBox.Clear();

            //When clear button is hit the desserts text boxes are cleared
            spumoniTextBox.Clear();
            cheesecakeTextBox.Clear();

            //when clear button is hit the other text boxes are cleared 
            chickenFingersTextBox.Clear();
            pizzaSliceTextBox.Clear();

            subtotalLabel.Text = null;
            salesTaxLabel.Text = null;
            totalPriceLabel.Text = null; 

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo,// when the user hits exit display warning message and ask a yes or no question if they are sure.
               MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes) // if user chose yes, close program
                this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int bowlOfSoup, ceasarSalad, Calamari, italianSub, meatball, sausage, ravioli, lasagna, spumoni, cheesecake, chickenFingers, pizzaSlice;
            const double tax = 0.08;
            double subtotal, salesTax, totalPrice; 

            try
            {
                //crab the information from the form
                int.TryParse(bowlOfSoupTextBox.Text, out bowlOfSoup);
                int.TryParse(CeasarSaladTextBox.Text, out ceasarSalad);
                int.TryParse(calamariTextBox.Text, out Calamari);
                int.TryParse(italianSubTextBox.Text, out italianSub);
                int.TryParse(meatballTextBox.Text, out meatball);
                int.TryParse(sausageTextBox.Text, out sausage);
                int.TryParse(ravioliTextBox.Text, out ravioli);
                int.TryParse(lasagnaTextBox.Text, out lasagna);
                int.TryParse(spumoniTextBox.Text, out spumoni);
                int.TryParse(cheesecakeTextBox.Text, out cheesecake);
                int.TryParse(chickenFingersTextBox.Text, out chickenFingers);
                int.TryParse(pizzaSliceTextBox.Text, out pizzaSlice);

                //calaculate subtotal 
                subtotal = (bowlOfSoup * 5) + (ceasarSalad * 5) + (Calamari * 5) + (italianSub * 6) + (meatball * 6) + (sausage * 6) + (ravioli * 7) + (lasagna * 7) + (spumoni * 4) + (cheesecake * 4) + (chickenFingers * 5) + (pizzaSlice * 5);

                salesTax = subtotal * tax;

                totalPrice = salesTax + subtotal;

                subtotalLabel.Text = subtotal.ToString("C2");
                salesTaxLabel.Text = salesTax.ToString("C2");
                totalPriceLabel.Text = totalPrice.ToString("C2"); 
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                    throw;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
