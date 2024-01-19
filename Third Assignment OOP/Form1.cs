using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_Assignment_OOP
{

    public partial class Form1 : Form
    {
        Button wage = new Button();
        Button salary = new Button();

        Label num_Of_Hours_label = new Label();
        Label rate_label = new Label();
        Label tax_label = new Label();
        Label wage_label = new Label();
        Label salary_label = new Label();

        TextBox Rate = new TextBox();
        TextBox Hours = new TextBox();
        TextBox tax = new TextBox();
        TextBox resultWage = new TextBox();
        TextBox resultSalary = new TextBox();

        Panel p1 = new Panel();
        Panel p2 = new Panel();
        Font newFont = new Font("Tahoma", 9, FontStyle.Bold);
        PictureBox pic1 = new PictureBox();
        LinkLabel madeBy = new LinkLabel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Font = newFont;
            this.Text = "Simple Em Salary Calc";
            this.Size = new Size(506, 467);


            this.Controls.Add(p1);
            this.Controls.Add(p2);

            this.Controls.Add(pic1);

            this.Controls.Add(wage);
            this.Controls.Add(salary);
            this.Controls.Add(wage_label);
            this.Controls.Add(salary_label);

            this.Controls.Add(num_Of_Hours_label);
            this.Controls.Add(rate_label);
            this.Controls.Add(tax_label);

            this.Controls.Add(Rate);
            this.Controls.Add(Hours);
            this.Controls.Add(tax);

            this.Controls.Add(resultWage);
            this.Controls.Add(resultSalary);

            this.Controls.Add(madeBy);






            wage.Location = new Point(91, 352);
            wage.Size = new Size(107, 51);
            wage.Text = "Wage";
            wage.Click += new EventHandler(wage_button_click);

            wage_label.Location = new Point(48, 17);
            wage_label.Size = new Size(41, 14);
            wage_label.Text = "Wage";


            resultWage.Location = new Point(158, 14);
            resultWage.Size = new Size(206, 27);
            resultWage.Multiline = true;

            salary.Location = new Point(279, 352);
            salary.Size = new Size(107, 51);
            salary.Text = "Salary";
            salary.Click += new EventHandler(salary_button_click);

            salary_label.Location = new Point(48, 65);
            salary_label.Size = new Size(44, 14);
            salary_label.Text = "Salary";

            resultSalary.Location = new Point(158, 61);
            resultSalary.Size = new Size(206, 27);
            resultSalary.Multiline = true;

            num_Of_Hours_label.Location = new Point(41, 22);
            num_Of_Hours_label.Size = new Size(130, 14);
            num_Of_Hours_label.Text = "Number Of Hours";

            rate_label.Location = new Point(41, 76);
            rate_label.Size = new Size(130, 14);
            rate_label.Text = "Rate Of Hour";


            tax_label.Location = new Point(51, 131);
            tax_label.Size = new Size(130, 14);
            tax_label.Text = "Tax  %";

            Rate.Location = new Point(183, 73);
            Rate.Size = new Size(258, 27);
            Rate.Multiline = true;

            Hours.Location = new Point(183, 18);
            Hours.Size = new Size(258, 27);
            Hours.Multiline = true;

            tax.Location = new Point(183, 128);
            tax.Size = new Size(258, 27);
            tax.Multiline = true;

            p1.Location = new Point(14, 13);
            p1.Size = new Size(463, 177);
            p1.Controls.Add(num_Of_Hours_label);
            p1.Controls.Add(rate_label);
            p1.Controls.Add(tax_label);
            p1.Controls.Add(Rate);
            p1.Controls.Add(Hours);
            p1.Controls.Add(tax);
            p1.BorderStyle = BorderStyle.Fixed3D;


            p2.Location = new Point(40, 215);
            p2.Size = new Size(416, 111);
            p2.Controls.Add(resultWage);
            p2.Controls.Add(wage_label);
            p2.Controls.Add(resultSalary);
            p2.Controls.Add(salary_label);
            p2.BorderStyle = BorderStyle.Fixed3D;


            madeBy.Location = new Point(430, 405);
            madeBy.Size = new Size(60, 15);
            madeBy.Text = "M-M-A";
            madeBy.Click += new EventHandler(madyby_click);


        }

        private void madyby_click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Mohammed Mohsen Ahmady");
        }

        private void wage_button_click(object sender, EventArgs e)
        {

            int regHours = 40;
            int hours = Int32.Parse(Hours.Text);
            int regRate = Int32.Parse(Rate.Text);
            int taxx = Int32.Parse(tax.Text);
            int result = 0;

            if (hours <= regHours)
            {
                result = hours * regRate;
                int tax = ((result * taxx) / 100);
                int res = result - tax;
                resultWage.Text = res.ToString();
            }
            else
            {

                int regResult = regHours * regRate;
                int over = hours - 40;
                int rateforOver = regRate * 2;
                int overResult = rateforOver * over;
                result = regResult + overResult;
                int tax = ((result * taxx) / 100);
                int res = result - tax;
                resultWage.Text = res.ToString();

            }


        }

        private void salary_button_click(object sender, EventArgs e)
        {

            int regHours = 40;
            int hours = Int32.Parse(Hours.Text);
            int regRate = Int32.Parse(Rate.Text);
            int taxx = Int32.Parse(tax.Text);
            int result = 0;

            if (hours <= regHours)
            {
                result = hours * regRate;
                int salaryT = result * 4;
                int tax = ((salaryT * taxx) / 100);
                int res = salaryT - tax;
                resultSalary.Text = res.ToString();
            }
            else
            {

                int regResult = regHours * regRate;
                int over = hours - 40;
                int rateforOver = regRate * 2;
                int overResult = rateforOver * over;
                result = regResult + overResult;
                int salaryT = result * 4;
                int tax = ((salaryT * taxx) / 100);
                int res = salaryT - tax;
                resultSalary.Text = res.ToString();


            }
        }
    }
}

