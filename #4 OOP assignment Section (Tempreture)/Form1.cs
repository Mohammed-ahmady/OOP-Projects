using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_assignment_Section__Tempreture_
{
    public partial class Form1 : Form
    {
        Button convert = new Button();
        Label tempLabel = new Label();
        Label convertLabel = new Label();
        Label resultLabel = new Label();
        TextBox tempText = new TextBox();
        RadioButton cels = new RadioButton();
        RadioButton fehrn = new RadioButton();
        ToolTip fehrTocels = new ToolTip();
        ToolTip celsTofehr = new ToolTip();
        ToolTip TextForTiping = new ToolTip();

        Font f1 = new Font("Tahoma", 9,FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(425, 458);
            this.Text = "Temperature Converter";
            this.Font = f1;
            fehrTocels.SetToolTip(cels, "Fehrenheit To Celsuis");
            celsTofehr.SetToolTip(fehrn, "Celsuis To Fehrenheit");
            TextForTiping.SetToolTip(tempText, "Enter The Temperature");
            this.Controls.Add(convert);
            this.Controls.Add(tempLabel);
            this.Controls.Add(tempText);
            this.Controls.Add(convertLabel);
            this.Controls.Add(resultLabel);
            this.Controls.Add(cels);
            this.Controls.Add(fehrn);

            // labels sizes 
            convertLabel.Size = new Size(80, 13);
            tempLabel.Size = new Size(90, 13);
            resultLabel.Size = new Size(80, 13);

            // labels locations
            convertLabel.Location = new Point(20, 177);
            tempLabel.Location = new Point(20, 79);
            resultLabel.Location = new Point(219, 260);

            // labels text
            convertLabel.Text = "Convert To ";
            tempLabel.Text = "Temperature";
            resultLabel.Text = "Result = ?";

            // textbox 
            tempText.Size = new Size(239, 31);
            tempText.Location = new Point(165, 69);
            tempText.Multiline = true;

            // button 
            convert.Text = "Convert";
            convert.Size = new Size(118, 38);
            convert.Location = new Point(190, 332);
            convert.Click += new EventHandler(convert1_btn);

            // radiobuttons
            cels.Size = new Size(85, 17);
            cels.Location = new Point(186, 177);
            cels.Text = "Celsius";
            fehrn.Size = new Size(95, 17);
            fehrn.Location = new Point(312, 177);
            fehrn.Text = "Fehrenheit";




        }

        private void convert1_btn(object sender, EventArgs e)
        {
            if (tempText.Text == string.Empty)
            {
                MessageBox.Show("You Must Enter a Value in The Previous Field", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double input = Convert.ToDouble(tempText.Text);
                double result = 0;
                if (cels.Checked)
                {
                    result = ((input - 32) * 0.555555555555556);
                    resultLabel.Text = $"{result.ToString("F1")} °C";
                    
                    MessageBox.Show($"{result.ToString("F1")} °C", "Result in Celsius", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (fehrn.Checked)
                {
                    result = (input * 1.8) + 32;
                    resultLabel.Text = $"{result.ToString("F1")} °F";
                    MessageBox.Show($"{result.ToString("F1")} °F", "Result in Fehrenheit", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Error, You Must Select at Least one Item", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
