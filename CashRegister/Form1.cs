//Author: James Hopper
//Purpose: A cash register able to calculate price with tax of three items, and able to calculate change and print a receipt

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //These are all my variables
        int mild = 6;
        int hot = 6;
        int dog = 5;
        int mildBox;
        int hotBox;
        int dogBox;
        int mildPrice;
        int hotPrice;
        int dogPrice;
        double totalCost;
        double finalCost;
        double tax = 0.13;
        double finalTax;
        double change;
        int payment;
        
       

        public Form1()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This makes sure the catch label is blank
                receitLabel.Text = $"";

                //This converts the text boxes to intigers
                mildBox = Convert.ToInt32(mildSausagebox.Text);
                hotBox = Convert.ToInt32(hotSausagebox.Text);
                dogBox = Convert.ToInt32(hotdogBox.Text);

                //setting what the price variables equal
                mildPrice = mildBox * mild;
                hotPrice = hotBox * hot;
                dogPrice = dogBox * dog;
                
                //calculaing the total price, tax, and the final price with tax included
                totalCost = mildPrice + hotPrice + dogPrice;
                finalTax = totalCost * tax;
                finalCost = totalCost + tax;

                //Tells the cost, tax, and total price label what to say
                costLabel.Text = $"Cost: {totalCost.ToString("C")}";
                taxLabel.Text = $"Tax: {finalTax.ToString("C")}";
                totalPriceLabel.Text = $"Total price: {finalCost.ToString("c")}";
            }
            catch
            {
                //If someone puts a letter or decimal in the text box this will display
                receitLabel.Text = $"We sell food here not portions or letters.";
            }
            
        }

        private void mildSausageLabel_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //reset in case the typed a letter or decimal 
                receitLabel.Text = $"";
                totalPriceLabel.Text = $"Total price: {finalCost.ToString("c")}";
                
                //setting payment textbox to an intager
                payment = Convert.ToInt32(paymentBox.Text);

                //setting what the variables equal
                change = payment - finalCost;

                //telling what the change label to say
                changeLabel.Text = $"Change: {change.ToString("c")}";
            }
            catch
            {
                //if someone puts letters or decimals in the text box display this
                receitLabel.Text = $"We only accept full bills here";
            }
        }

        private void changeLabel_Click(object sender, EventArgs e)
        {

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //reset receipt label in case som typed a letter or decimal in the text box
            receitLabel.Text = $"";

            //setting the payment box to a intager
            payment = Convert.ToInt32(paymentBox.Text);

            //playing the receipt sound
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.reccepit);
            soundPlayer.Play();

            //printing the receipt
            receitLabel.Text += $"\n\nHot Diggity Dawg House";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nOrder Number 05";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nSeptember 30 2021";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nMild Sausage  x{mildBox} @ {mildPrice.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nHot Sausage   x{hotBox}  @ {hotPrice.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nHotDog           x{dogBox} @ {dogPrice.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nSubtotal                   {totalCost.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nTax                         {tax.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nTotal                       {finalCost.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nTendered                   {payment.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nChange                      {change.ToString("c")}";
            Refresh();
            Thread.Sleep(500);
            receitLabel.Text += $"\nHave a nice day!";



            ;        }

        private void mildReceipt_Click(object sender, EventArgs e)
        {

        }
    }
}
