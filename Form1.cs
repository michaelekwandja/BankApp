using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (int.TryParse(lb_UserBalance.Text, out int userBalance))
            {
                UserBalance = userBalance;
            }
            else
            {
                UserBalance = 0;
            }

            if (int.TryParse(tb_Balance.Text, out int balance))
            {
                Balance = balance;
            }
            else
            {
                Balance = 0;
            }
        }

        private int UserBalance;
        private int Balance;

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_Balance.Text, out int balance))
            {
                Balance = balance;
                UserBalance += Balance;
                lb_UserBalance.Text = UserBalance.ToString(); // Update the label
            }
           

            if (UserBalance < 0)
            {
                lb_UserBalance.ForeColor = Color.Red;
            }
            else
            if (UserBalance > 0)
            {
                lb_UserBalance.ForeColor = Color.Green;
            }
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_Balance.Text, out int balance))
            {
                Balance = balance;
                UserBalance -= Balance;
                lb_UserBalance.Text = UserBalance.ToString(); // Update the label
            }

            if (UserBalance < 0)
            {
                lb_UserBalance.ForeColor = Color.Red;
            }
            else
            if (UserBalance > 0)
            {
                lb_UserBalance.ForeColor = Color.Green;
            }
        }

        
    }
}
