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

namespace CashRegister
{
    public partial class Form1 : Form
    {
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
                receitLabel.Text = $"";
                mildBox = Convert.ToInt32(mildSausagebox.Text);
                hotBox = Convert.ToInt32(hotSausagebox.Text);
                dogBox = Convert.ToInt32(hotdogBox.Text);

                mildPrice = mildBox * mild;
                hotPrice = hotBox * hot;
                dogPrice = dogBox * dog;
                
                totalCost = mildPrice + hotPrice + dogPrice;
                finalTax = totalCost * tax;
                finalCost = totalCost + tax;

                costLabel.Text = $"Cost: {totalCost.ToString("C")}";
                taxLabel.Text = $"Tax: {finalTax.ToString("C")}";
                totalPriceLabel.Text = $"Total price: {finalCost.ToString("c")}";
            }
            catch
            {
                receitLabel.Text = $"Please put only whole numbers in the boxes";
            }
            
        }

        private void mildSausageLabel_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                receitLabel.Text = $"";
                totalPriceLabel.Text = $"Total price: {finalCost.ToString("c")}";
                payment = Convert.ToInt32(paymentBox.Text);
                change = payment - finalCost;
                changeLabel.Text = $"Change: {change.ToString("c")}";
            }
            catch
            {
                receitLabel.Text = $"We only accept full bills here";
            }
        }

        private void changeLabel_Click(object sender, EventArgs e)
        {

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            payment = Convert.ToInt32(paymentBox.Text);
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
