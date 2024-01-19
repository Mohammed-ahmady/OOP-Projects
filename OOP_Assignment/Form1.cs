using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        Button wage = new Button();
        Button salary = new Button();
        Label num_Of_Hours = new Label();
        Label lRate = new Label();
        TextBox Rate = new TextBox();
        TextBox Hours = new TextBox();
        TextBox resultWage = new TextBox();
        TextBox resultSalary = new TextBox();
        Panel p1 = new Panel();
        Panel p2 = new Panel();
        Panel p3 = new Panel();
        Font newFont = new Font("Myanmar Text", 9, FontStyle.Bold);
        PictureBox pic1 = new PictureBox();
        //Icon newIcon = new Icon("C:\\Users\\Lenovo\\Downloads\\OIP.ico");
        Label madeBy = new Label();

        


        public Form1()
        {
            InitializeComponent();


        }
        

        private void wage_button_click(object sender, EventArgs e)
        {
            int regHours = 40;
            int hours = Int32.Parse(Hours.Text);
            int regRate = Int32.Parse(Rate.Text);
            int result = 0;

            if (hours <= regHours)
            {
                result = hours * regRate;
                resultWage.Text = result.ToString();
            }
            else
            {

                int regResult = regHours * regRate;
                int over = hours - 40;
                int rateforOver =regRate * 2;
                int overResult = rateforOver * over;
                result = regResult + overResult;
                resultWage.Text = result.ToString();

            }
        }

        private void salary_button_click(object sender, EventArgs e)
        {
            int regHours = 40;
            int hours = Int32.Parse(Hours.Text);
            int regRate = Int32.Parse(Rate.Text);
            int result = 0;

            if (hours <= regHours)
            {
                result = hours * regRate;
                int salaryT = result * 4;

                resultSalary.Text = salaryT.ToString();
            }
            else
            {

                int regResult = regHours * regRate;
                int over = hours - 40;
                int rateforOver = regRate * 2;
                int overResult = rateforOver * over;
                result = regResult + overResult;
                int salaryT = result * 4;
                resultSalary.Text = salaryT.ToString();


            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "Salary Calclator";
            this.Font = newFont;
            this.Size = new Size(800, 600);
            
            //this.Icon = newIcon;

            this.Controls.Add(p1);
            this.Controls.Add(p2);
            this.Controls.Add(p3);
            
            this.Controls.Add(pic1);
            
            this.Controls.Add(wage);
            this.Controls.Add(salary);
            
            this.Controls.Add(num_Of_Hours);
            this.Controls.Add(lRate);
            
            this.Controls.Add(Rate);
            this.Controls.Add(Hours);
            
            this.Controls.Add(resultWage);
            this.Controls.Add(resultSalary);

            this.Controls.Add(madeBy);

            Image image = Image.FromFile("C:\\Users\\Lenovo\\Downloads\\2023-11-20 15_40_49-Window.png");
            pic1.Image = image;
            pic1.Location = new Point(597, 65);
            pic1.Size = new Size(108, 108);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;

            wage.Location = new Point(80, 24);
            wage.Size = new Size(111, 52);
            wage.Text = "Wage";
            wage.Click += new EventHandler(wage_button_click);

            resultWage.Location = new Point(39, 114);
            resultWage.Size = new Size(206, 29);
            resultWage.Multiline = true;

            salary.Location = new Point(80, 24);
            salary.Size = new Size(111, 52);
            salary.Text = "Salary";
            salary.Click += new EventHandler(salary_button_click);

            resultSalary.Location = new Point(39, 114);
            resultSalary.Size = new Size(206, 29);
            resultSalary.Multiline = true;

            num_Of_Hours.Location = new Point(38, 28);
            num_Of_Hours.Size = new Size(120, 21);
            num_Of_Hours.Text = "Number Of Hours";

            lRate.Location = new Point(48, 156);
            lRate.Size = new Size(100, 21);          
            lRate.Text = "Rate Of Hour";
             
            Rate.Location = new Point(165, 153);
            Rate.Size = new Size(206, 29);
            Rate.Multiline = true;

            Hours.Location = new Point(165, 25);
            Hours.Size = new Size(206, 29);
            Hours.Multiline = true;
            

            p1.Location = new Point(436, 320);
            p1.Size = new Size(265, 176);
            p1.Controls.Add(salary);
            p1.Controls.Add(resultSalary);
            p1.BorderStyle = BorderStyle.FixedSingle;
            



            p2.Location = new Point(73, 320);
            p2.Size = new Size(265, 176);
            p2.Controls.Add(wage);
            p2.Controls.Add(resultWage);
            p2.BorderStyle = BorderStyle.FixedSingle;


            p3.Location = new Point(38, 12);
            p3.Size = new Size(518, 234);
            p3.Controls.Add(num_Of_Hours);
            p3.Controls.Add(Rate);
            p3.Controls.Add(Hours);
            p3.Controls.Add(lRate);
            p3.BorderStyle = BorderStyle.FixedSingle;

            madeBy.Location = new Point(735, 540);
            madeBy.Size = new Size(50, 21);
            madeBy.Text = "M_M_A";

        }
    }
}
