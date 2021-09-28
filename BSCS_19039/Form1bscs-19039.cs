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
        Double result_value=0;
        string operation_performed = "";
        bool op_perfom = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Result.Text += B_1.Text;
        }
       
        private void B_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || (op_perfom))
                Result.Clear();

            op_perfom = false;

            Button b = (Button)sender;
            Result.Text += b.Text;
 
        }

        private void Op_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation_performed = b.Text;
            result_value = Double.Parse(Result.Text);
            op_perfom = true;
        }

        private void clear(object sender, EventArgs e)
        {
            Result.Text = "0";
            result_value = 0;
        }

        private void total_clear(object sender, EventArgs e)
        {
            Result.Text = "0";
        }
       
        private void UnararOPr(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation_performed = b.Text;
            result_value = Double.Parse(Result.Text);
            op_perfom = true;

            switch(operation_performed)
            {
                case "±":
                    {
                        Result.Text = (-Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "1/x":
                    {
                        Result.Text = (1/Double.Parse(Result.Text)).ToString();
                        break;
                    }
                    case "²√x ":
                    {
                        Result.Text = Math.Sqrt((Double.Parse(Result.Text))).ToString();
                        break;
                    }
                    case " x²  ":
                    {
                        Result.Text = (Double.Parse(Result.Text) * Double.Parse(Result.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }


        private void equal_res(object sender, EventArgs e)
        {
            switch(operation_performed)
            {
                case "+":
                    {
                        Result.Text = (result_value + Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "−":
                    {
                        Result.Text = (result_value - Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "×":
                    {
                        Result.Text = (result_value * Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "÷":
                    {
                        Result.Text = (result_value / Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "%":
                    {
                        Result.Text = (result_value % Double.Parse(Result.Text)).ToString();
                        break;
                    }
                default :
                    {
                        break;
                    }
                    

            }
        }
    }
}
