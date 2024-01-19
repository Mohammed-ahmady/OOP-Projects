using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Button addButton = new Button();
        Button subButton = new Button();
        Button devButton = new Button();
        Button mulButton = new Button();

        TextBox firstTextBox = new TextBox();
        TextBox secondTextBox = new TextBox();
        TextBox resultTextBox = new TextBox();

        Label firstLabel = new Label();
        Label secondLabel = new Label();
        Label resultlabel = new Label();
       



        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calc";
            this.Size = new Size(800, 600);

            this.Controls.Add(addButton);
            this.Controls.Add(subButton);
            this.Controls.Add(devButton);
            this.Controls.Add(mulButton);

            this.Controls.Add(firstTextBox);
            this.Controls.Add(resultTextBox);
            this.Controls.Add(secondTextBox);


            this.Controls.Add(firstLabel);
            this.Controls.Add(secondLabel);
            this.Controls.Add(resultlabel);

            addButton.Location  = new Point(118,444);
            addButton.Size = new Size(99,38);
            addButton.Text = "Add";

            subButton.Location = new Point(260,444);
            subButton.Size = new Size(99, 38);
            subButton.Text = "Sub";

            devButton.Location = new Point(416,444);
            devButton.Size = new Size(99, 38);
            devButton.Text = "Divide";

            mulButton.Location = new Point(556,444);
            mulButton.Size = new Size(99, 38);
            mulButton.Text = "Multiply";

            firstTextBox.Location = new Point(147,77);
            firstTextBox.Size = new Size(178, 31);

            secondTextBox.Location = new Point(147,152);
            secondTextBox.Size = new Size(178, 31);

            resultTextBox.Location = new Point(287,286);
            resultTextBox.Size = new Size(132,43);


            addButton.Click += new EventHandler(add_click);
            subButton.Click += new EventHandler(sub_click);
            mulButton.Click += new EventHandler(mul_click);
            devButton.Click += new EventHandler(dev_click);











        }

        private void dev_click(object sender, EventArgs e)
        {
            int x = int.Parse(firstTextBox.Text);
            int y = int.Parse(secondTextBox.Text);

            int res = x / y;
            resultTextBox.Text = res.ToString();
        }

        private void mul_click(object sender, EventArgs e)
        {
            int x = int.Parse(firstTextBox.Text);
            int y = int.Parse(secondTextBox.Text);

            int res = x * y;
            resultTextBox.Text = res.ToString();
        }

        private void sub_click(object sender, EventArgs e)
        {
            int x = int.Parse(firstTextBox.Text);
            int y = int.Parse(secondTextBox.Text);

            int res = x - y;
            resultTextBox.Text = res.ToString();
        }

        private void add_click(object sender, EventArgs e)
        {
            int x = int.Parse(firstTextBox.Text);
            int y = int.Parse(secondTextBox.Text);

            int res = x + y;
            resultTextBox.Text = res.ToString();
        }
    }
}
