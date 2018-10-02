using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Func<int[], int> deleg;
        List<int> expressionNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_click(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {

        }

        private void btnNumbOp_click(object sender, EventArgs e)
        {
            this.textBox1.Text += (sender as Button).Text;
        }

        int doCalc(string charOperator)
        {
            switch (charOperator) {
                case "*":
                    break;

                case "/":
                    break;

                case "-":
                    break;

                case "+":
                    break;
            }
            return 3;
        }
        private void btEqual_Click(object sender, EventArgs e)
        {
            string[] operators = new string[] { "/", "*", "-", "+" };
            string expression = this.textBox1.Text;
            string[] numbers = expression.Split('/', '+', '*', '-');
            string[] existingOps = operators.Substring();

            this.deleg = (int[] nums) => {
                return 1; 
            };
        }
    }
}
