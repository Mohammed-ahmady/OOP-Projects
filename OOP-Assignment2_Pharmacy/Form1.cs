using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OOP_Assignment2
{

    public class Drug
    {
        public string name;
        public double price;
        public int countaty;
        public int idd;

        public int id { get; set; }
        public double pricee { get; set; }
        public int con { get; set; }
        public string namee { get; set; }
       
       
    }
    

    public partial class Form1 : Form
    {
        Drug drug = new Drug();
        Button buttonCount = new Button();
        Button ButtonPrice = new Button();
        Button ButtonAdd = new Button();

        
        Label lprice = new Label();
        Label lid = new Label();
        Label lname = new Label();
        Label lcount = new Label();
        Label madeBy = new Label();

        TextBox price = new TextBox();
        TextBox id = new TextBox();
        TextBox name = new TextBox();
        TextBox count = new TextBox();
        TextBox showCon = new TextBox();
        TextBox showPri = new TextBox();


       
        Font newFont = new Font("Tahoma", 9, FontStyle.Bold);
        PictureBox pic1 = new PictureBox();
        
        


        public Form1()
        {
            InitializeComponent();
            Drug drug = new Drug();
        }
       


        

        private void Form1_Load(object sender, EventArgs e)
        {
            Drug drug = new Drug();
            this.Text = "Pharmacy Management System";
            this.Font = newFont;
            this.Size = new Size(1355, 680);
            

// add items : 

            // add item buttons : 
            this.Controls.Add(ButtonAdd);
            this.Controls.Add(ButtonPrice);
            this.Controls.Add(buttonCount);


            // add item labels : 
            this.Controls.Add(lprice);
            this.Controls.Add(lname);
            this.Controls.Add(lid);
            this.Controls.Add(lcount);

            // add item textoxes : 
            this.Controls.Add(price);
            this.Controls.Add(id);
            this.Controls.Add(name);
            this.Controls.Add(count);
            this.Controls.Add(showCon);
            this.Controls.Add(showPri);


            // add item additions : 
            this.Controls.Add(madeBy);
            this.Controls.Add(pic1);


// initialize their props: 

            // init images :

            Image image = Image.FromFile("C:\\Users\\Lenovo\\Downloads\\2023-11-20 15_40_49-Window.png");
            pic1.Image = image;
            pic1.Location = new Point(430, 56);
            pic1.Size = new Size(114, 103);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;

            // init buttons : 

            buttonCount.Location = new Point(1019, 226);
            buttonCount.Size = new Size(289,40);
            buttonCount.Text = "Display items less than 10";
            buttonCount.Click += new EventHandler(Count_button_click);

            ButtonPrice.Location = new Point(1019, 499);
            ButtonPrice.Size = new Size(289, 40);
            ButtonPrice.Text = "Display Drugs more than 1000";
            ButtonPrice.Click += new EventHandler(Price_button_click);


            ButtonAdd.Location = new Point(320, 499);
            ButtonAdd.Size = new Size(287, 40);
            ButtonAdd.Text = "Add The Drug";
            ButtonAdd.Click += new EventHandler(Add_button_click);


            // init Textboxes:

            name.Location = new Point(105, 253);
            name.Size = new Size(291, 31);
            name.Multiline = true;

            price.Location = new Point(571, 253);
            price.Size = new Size(291, 31);
            price.Multiline = true;

            id.Location = new Point(105, 382);
            id.Size = new Size(291, 31);
            id.Multiline = true;

            count.Location = new Point(571, 378);
            count.Size = new Size(291, 31);
            count.Multiline = true;

            showCon.Location = new Point(1019, 38);
            showCon.Size = new Size(288, 179);
            showCon.Multiline = true;

            showPri.Location = new Point(1019, 310);
            showPri.Size = new Size(288, 179);
            showPri.Multiline = true;

           
            


            // init labels :
            
            lprice.Location = new Point(527, 259);
            lprice.Size = new Size(39, 16);
            lprice.Text = "Price";


            lid.Location = new Point(65, 393);
            lid.Size = new Size(21, 16);
            lid.Text = "ID";

            lname.Location = new Point(28, 259);
            lname.Size = new Size(77, 16);
            lname.Text = "Drug Name";

            lcount.Location = new Point(516, 385);
            lcount.Size = new Size(45, 16);
            lcount.Text = "Count";

            madeBy.Location = new Point(735, 540);
            madeBy.Size = new Size(50, 21);
            madeBy.Text = "M_M_A";
        }

        private void Count_button_click(object sender, EventArgs e)
        {
            int countt = 0;
            

            if (int.Parse(count.Text) < 10)
            {
                countt += 1;
                showCon.Text = countt.ToString();
            }
            else
            {
                int x = 0;
                showCon.Text = x.ToString();
            }
        }

        private void Price_button_click(object sender, EventArgs e)
        {
            int countt = 0;
            
            if (int.Parse(price.Text) > 1000)
            {
                countt += 1;
                showPri.Text = countt.ToString();
            }
            else
            {
                int x = 0;
                showPri.Text = x.ToString();
            }

        }
        
        private void Add_button_click(object sender, EventArgs e)
        {
            string filePath = "DrugName.txt";
            string[] nameOfDrug = name.Text.Split(' ');
            string[] PriceOfDrug = price.Text.Split(' ');
            string[] IdOfDrug = id.Text.Split(' ');
            string[] countOfDrug = count.Text.Split(' ');

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(count.Text) || string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(price.Text))
            {
                MessageBox.Show("Error, You Must Fill all The Previos Fields !");
            }
            else
            {

                for (int i = 0; i < nameOfDrug.Length; i++)
                {

                    string formattedLine = string.Format("{0,-20}: {1,-10} {2,-20}", "Name Of The Drug", nameOfDrug[i], "");
                    formattedLine += string.Format("{0,-20}: {1,-10} {2,-20}", "Price", PriceOfDrug[i], "");
                    formattedLine += string.Format("{0,-20}: {1,-10} {2,-20}", "Id", IdOfDrug[i], "");
                    formattedLine += string.Format("{0,-20}: {1,-10} {2,-20}", "Countatiy", countOfDrug[i], "");

                    File.AppendAllText(filePath, formattedLine + Environment.NewLine);

                }

                MessageBox.Show("The Drug Added Succssefully ");
                MessageBox.Show("Do You Want Any Thing Else ?","",MessageBoxButtons.OKCancel);
                

            }






        }
    }
}
