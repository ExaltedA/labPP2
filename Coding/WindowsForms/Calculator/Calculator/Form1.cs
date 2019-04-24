using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator

{
    enum Functions
    {
        Add, Minus, Divide, Multiply
    }
    public partial class Form1 : Form
    {
        private Functions func;
        private bool functionStatus;
        private double result;
        private int a = 0;
        private int b = 0;
        public Form1()

        {
            InitializeComponent();
            functionStatus = false;
            result = 0.0;



        }


        private void button_Clicker(object sender, EventArgs e)
        {

            Button button = (sender as Button);

            if (functionStatus)
            {

                textBox1.Text = button.Text;

                functionStatus = false;
                return;
            }
            if (textBox1.Text == "0")
            {
                if (button.Text != "0")
                {
                    textBox1.Text = button.Text;
                    //a = int.Parse(button.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
                // a = int.Parse(textBox1.Text);
            }






        }
        private void operation_clicker(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);

            Button button = sender as Button;
            textBox2.Text = textBox1.Text + " " + button.Text;

            switch (button.Text)
            {
                case "+":
                    func = Functions.Add;
                    break;
                case "-":
                    func = Functions.Minus;
                    break;
                case "X":
                    func = Functions.Multiply;
                    break;
                case "/":
                    func = Functions.Divide;
                    break;


                default:
                    break;

            }
            functionStatus = true;
            result = double.Parse(textBox1.Text);


        }

        public void equals(object sender, EventArgs e)
        {

            b = int.Parse(textBox1.Text);
            switch (func)
            {
                case Functions.Add:
                    result = result + double.Parse(textBox1.Text);
                    break;
                case Functions.Minus:
                    result = result - double.Parse(textBox1.Text);
                    break;
                case Functions.Multiply:
                    result = result * double.Parse(textBox1.Text);
                    break;
                case Functions.Divide:
                    result = result / double.Parse(textBox1.Text);
                    break;


                default:
                    break;
            }
            textBox1.Text = result.ToString();

            textBox2.Text = string.Empty;

        }
        private void clear(object sender, EventArgs e)
        {
            a = 0; b = 0;

            textBox1.Text = "0";
            result = 0.0;
            functionStatus = false;
            textBox2.Text = string.Empty;

        }



    }
}
