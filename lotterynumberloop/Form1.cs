using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotterynumberloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnLotto_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //creates a random class
            lstLottery.Items.Clear(); // clear current items in the list

            int[] lottery_numbers;
            lottery_numbers = new int[6]; //able to generate 6 numbers if the number between square brackets is changed example to 7 seven numbers will be generate

           

            for (int i = 0; i != (lottery_numbers.Length); i++)
            {
                lottery_numbers[i] = rnd.Next(1,49);
                lstLottery.Items.Add(lottery_numbers[i]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLottery.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
