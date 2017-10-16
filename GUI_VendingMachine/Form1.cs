using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_VendingMachine 
{
    public partial class Form1 : Form
    {
        const double tax = 1.05;
        const int cokePrice = 8;
        const int pepsiPrice = 10;
        const int dietPepsiPrice = 12;
        const int mountainDewPrice = 14;
        const int gatoradePrice = 16;
        const int crushPrice = 18;
        const int redBullPrice = 20;
        const int sunRypePrice = 5;
        const int fantaPrice = 4;
        const int rockStarPrice = 6;
        const int monsterPrice = 9;
        const int sevenUpPrice = 7;

        int convCode;
        double convMoney;
        double change;
        int itemPrice;
        double total;
        string itemName;

        //Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0, btnCancel, btnOK;
        //TextBox tbDisplayNumberCode;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("1");
            btn_OK.Enabled = true;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("2");
            btn_OK.Enabled = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("3");
            btn_OK.Enabled = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("4");
            btn_OK.Enabled = true;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("5");
            btn_OK.Enabled = true;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("6");
            btn_OK.Enabled = true;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("7");
            btn_OK.Enabled = true;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("8");
            btn_OK.Enabled = true;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("9");
            btn_OK.Enabled = true;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.AppendText("0");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            convCode = Convert.ToInt32(this.tb_displayNumberCode.Text);
            if (!isValidCode(convCode))
            {
                MessageBox.Show("Please enter a valid code number.");
                this.tb_displayNumberCode.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your payment and press the 'PAY' button.");
                btn_pay.Enabled = true;
                tb_moneyInsert.Enabled = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_displayNumberCode.Clear();
            tb_moneyInsert.Clear();
            btn_OK.Enabled = false;
            tb_moneyInsert.Enabled = false;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            convMoney = Convert.ToDouble(tb_moneyInsert.Text);

            if(convMoney < getItemPrice(convCode))
            {
                MessageBox.Show("Oooops! Your money is not enough!");
                tb_moneyInsert.Clear();
            }
            else
            {
                itemPrice = getItemPrice(convCode);
                total = calculateTotal(itemPrice);
                change = calculateChange(convMoney, total);
                MessageBox.Show("************************************\n" +
                                "              Purchase Summary " +
                                "\n************************************" +
                                "\nItem: " + chosenItem(convCode) +
                                "\nMoney: $" + convMoney +
                                "\nTax: 5% " +
                                "\n------------------------------------" +
                                "\nTotal: $" + total +
                                "\nChange: $" + change +
                                "\n\n\n************************************" +
                                "\n************************************");

                DialogResult dialogResult = MessageBox.Show("Do you want to exit the application?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb_displayNumberCode.Clear();
                    tb_moneyInsert.Clear();
                    btn_pay.Enabled = false;
                    btn_OK.Enabled = false;
                    tb_moneyInsert.Enabled = false;
                }
            }
            
        }

        public string chosenItem(int itemCode)
        {
            switch (convCode)
            {
                case 1:
                    itemName = "Coke";
                    break;
                case 2:
                    itemName = "Pepsi";
                    break;
                case 3:
                    itemName = "Diet Pepsi";
                    break;
                case 4:
                    itemName = "Mountain Dew";
                    break;
                case 5:
                    itemName = "Gatorade";
                    break;
                case 6:
                    itemName = "Crush";
                    break;
                case 7:
                    itemName = "Red Bull";
                    break;
                case 8:
                    itemName = "Sunrype Juice";
                    break;
                case 9:
                    itemName = "Fanta";
                    break;
                case 10:
                    itemName = "Rockstar";
                    break;
                case 11:
                    itemName = "Monster";
                    break;
                case 12:
                    itemName = "7 Up";
                    break;
                default:
                    MessageBox.Show("An error occured. Please try again.");
                    break;
            }


            return itemName;
        }

        private int getItemPrice(int itemCode)
        {
            switch(itemCode)
            {
                case 1:
                    itemPrice = cokePrice;
                    break;
                case 2:
                    itemPrice = pepsiPrice;
                    break;
                case 3:
                    itemPrice = dietPepsiPrice;
                    break;
                case 4:
                    itemPrice = mountainDewPrice;
                    break;
                case 5:
                    itemPrice = gatoradePrice;
                    break;
                case 6:
                    itemPrice = crushPrice;
                    break;
                case 7:
                    itemPrice = redBullPrice;
                    break;
                case 8:
                    itemPrice = sunRypePrice;
                    break;
                case 9:
                    itemPrice = fantaPrice;
                    break;
                case 10:
                    itemPrice = rockStarPrice;
                    break;
                case 11:
                    itemPrice = monsterPrice;
                    break;
                case 12:
                    itemPrice = sevenUpPrice;
                    break;
                default:
                    MessageBox.Show("An error occured. Please try again.");
                    break;

            }
            
            return itemPrice;
        }

        public double calculateTotal(int itemPrice)
        {
            total = itemPrice * tax;
            return total;
        }
        
        public double calculateChange(double money, double total)
        {
            if (money <= change)
            {
                MessageBox.Show("Your money is not enough. Please insert more!");
            }
            else
            {
                change = money - total;
            }

            return change;
        }

        public bool isValidCode(int entryCode)
        {
            if (entryCode > 12 || entryCode <=0)
            {
                MessageBox.Show("Invalid Code entry.");
            }
            else
            {
                return true;
            }

            return false;
        }

        public bool isMoneyEnough(double money, int itemPrice)
        {
            if(money < Convert.ToDouble(itemPrice))
            {
                MessageBox.Show("Oooops! Your money is not enough!");
            }
            else
            {
                return true;   

            }

            return false;
        }
        
    }
}
