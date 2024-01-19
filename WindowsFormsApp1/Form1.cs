using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button dot = new Button();
        Button add = new Button();      Button sub = new Button();
        Button div = new Button();      Button mul = new Button();
        Button div2 = new Button();     Button c = new Button();
        Button num0 = new Button();     Button num1 = new Button();
        Button num2 = new Button();     Button equal = new Button();
        Button num3 = new Button();     Button num4 = new Button();
        Button num5 = new Button();     Button num6 = new Button();
        Button num7 = new Button();     Button num8 = new Button();
        Button num9 = new Button();     TextBox res = new TextBox();
        Font newFont = new Font("Segoe Print", 9, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Not a Simple Calculator '_'";
            this.Size = new Size(298, 380);
            this.BackColor = Color.DimGray;
            this.Controls.Add(add);
            this.Controls.Add(sub);
            this.Controls.Add(mul);
            this.Controls.Add(div);
            this.Controls.Add(equal);
            this.Controls.Add(div2);
            this.Controls.Add(c);
            this.Controls.Add(num0);
            this.Controls.Add(num1);
            this.Controls.Add(num2);
            this.Controls.Add(num3);
            this.Controls.Add(num4);
            this.Controls.Add(num5);
            this.Controls.Add(num6);
            this.Controls.Add(num7);
            this.Controls.Add(num8);
            this.Controls.Add(num9);
            this.Controls.Add(res);
            this.Controls.Add(dot);

            add.Location = new Point(206, 197);
            add.Size = new Size(60, 36);
            add.Text = "+";
            add.BackColor = Color.OrangeRed;
            add.Click += new EventHandler(add_btnclic);

            equal.Location = new Point(206, 235);
            equal.Size = new Size(60, 90);
            equal.Text = "=";
            equal.BackColor = Color.DarkRed;
            equal.Click += new EventHandler(equal_btnclic);

            sub.Location = new Point(206, 155);
            sub.Size = new Size(60, 36);
            sub.Text = "-";
            sub.BackColor = Color.OrangeRed;
            sub.Click += new EventHandler(sub_btnclic);

            div.Location = new Point(140, 113);
            div.Size = new Size(60, 36);
            div.Text = "/";
            div.BackColor = Color.OrangeRed;
            div.Click += new EventHandler(div_btnclic);

            div2.Location = new Point(74, 113);
            div2.Size = new Size(60, 36);
            div2.Text = "%";
            div2.BackColor = Color.OrangeRed;
            div2.Click += new EventHandler(div2_btnclic);

            c.Location = new Point(12, 113);
            c.Size = new Size(60, 36);
            c.Text = "c";
            c.BackColor = Color.OrangeRed;
            c.Click += new EventHandler(c_btnclic);

            mul.Location = new Point(206, 113);
            mul.Size = new Size(60, 36);
            mul.Text = "x";
            mul.BackColor = Color.OrangeRed;
            mul.Click += new EventHandler(mul_btnclic);

            res.Location = new Point(12, 12);
            res.Size = new Size(258, 77);
            res.Multiline = true;

            num0.Location = new Point(12, 289);
            num0.Size = new Size(122, 36);
            num0.Text = "0";
            num0.BackColor = Color.Firebrick;
            num0.Click += new EventHandler(num0_btnclic);

            num1.Location = new Point(13, 247);
            num1.Size = new Size(60, 36);
            num1.Text = "1";
            num1.BackColor = Color.Firebrick;
            num1.Click += new EventHandler(num1_btnclic);

            num2.Location = new Point(74, 247);
            num2.Size = new Size(60, 36);
            num2.Text = "2";
            num2.BackColor = Color.Firebrick;
            num2.Click += new EventHandler(num2_btnclic);

            num3.Location = new Point(140, 247);
            num3.Size = new Size(60, 36);
            num3.Text = "3";
            num3.BackColor = Color.Firebrick;
            num3.Click += new EventHandler(num3_btnclic);

            num4.Location = new Point(12, 205);
            num4.Size = new Size(60, 36);
            num4.Text = "4";
            num4.BackColor = Color.Firebrick;
            num4.Click += new EventHandler(num4_btnclic);

            num5.Location = new Point(74, 205);
            num5.Size = new Size(60, 36);
            num5.Text = "5";
            num5.BackColor = Color.Firebrick;
            num5.Click += new EventHandler(num5_btnclic);

            num6.Location = new Point(140, 205);
            num6.Size = new Size(60, 36);
            num6.Text = "6";
            num6.BackColor = Color.Firebrick;
            num6.Click += new EventHandler(num6_btnclic);

            num7.Location = new Point(12, 163);
            num7.Size = new Size(60, 36);
            num7.BackColor = Color.Firebrick;
            num7.Text = "7";
            num7.Click += new EventHandler(num7_btnclic);

            num8.Location = new Point(74, 163);
            num8.Size = new Size(60, 36);
            num8.Text = "8";
            num8.BackColor = Color.Firebrick;
            num8.Click += new EventHandler(num8_btnclic);

            num9.Location = new Point(140, 163);
            num9.Size = new Size(60, 36);
            num9.Text = "9";
            num9.BackColor = Color.Firebrick;
            num9.Click += new EventHandler(num9_btnclic);

            dot.Location = new Point(140, 289);
            dot.Size = new Size(60, 36);
            dot.BackColor = Color.Firebrick;
            dot.Text = ".";
            dot.Click += new EventHandler(dot_btnclic);
        }

        private void dot_btnclic(object sender, EventArgs e)
        {
            res.Text += ".";
        }
        private void c_btnclic(object sender, EventArgs e)
        {
            res.Text = "";       
        }
        private void equal_btnclic(object sender, EventArgs e)
        {
            string input = res.Text;
            char[] operators = { '+', '-', '*', '/', '%' };

            foreach (char op in operators)
            {
                string[] operands = input.Split(op);

                if (operands.Length == 2)
                {
                    double operand1 = double.Parse(operands[0]);
                    double operand2 = double.Parse(operands[1]);

                    if (op == '*') {
                        res.Text = (operand1 * operand2).ToString();
                        break;
                    }
                    else if (op == '+')
                    {
                        res.Text = (operand1 + operand2).ToString();
                        break;
                    }
                    else if (op == '-') {
                        res.Text = (operand1 - operand2).ToString();
                        break;
                    }
                    else if (op == '/')
                    {
                        if (operand2 != 0)
                        {
                            res.Text = (operand1 / operand2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                        }
                    }
                    else if(op == '%')
                    {
                        res.Text = (operand1 % operand2).ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                    }
                return;
                }
            }
        }

        private void div_btnclic(object sender, EventArgs e)
        {
            res.Text += "/";
        }
        private void div2_btnclic(object sender, EventArgs e)
        {
            res.Text += "%";
        }
        private void mul_btnclic(object sender, EventArgs e)
        {
            res.Text += "*";
        }
        private void add_btnclic(object sender, EventArgs e)
        {
            res.Text+= "+";
        }
        private void sub_btnclic(object sender, EventArgs e)
        {
            res.Text += "-";
        }
        private void num0_btnclic(object sender, EventArgs e)
        {
            res.Text += 0;
        }
        private void num1_btnclic(object sender, EventArgs e)
        {
            res.Text += 1;
        }
        private void num2_btnclic(object sender, EventArgs e)
        {
            res.Text += 2;
        }
        private void num3_btnclic(object sender, EventArgs e)
        {
            res.Text += 3;
        }
        private void num4_btnclic(object sender, EventArgs e)
        {
            res.Text += 4;
        }
        private void num5_btnclic(object sender, EventArgs e)
        {
            res.Text += 5;
        }
        private void num6_btnclic(object sender, EventArgs e)
        {
            res.Text += 6;
        }
        private void num7_btnclic(object sender, EventArgs e)
        {
            res.Text += 7;
        }
        private void num8_btnclic(object sender, EventArgs e)
        {
            res.Text += 8;
        }
        private void num9_btnclic(object sender, EventArgs e)
        {
            res.Text += 9;
        }

        
    }
}