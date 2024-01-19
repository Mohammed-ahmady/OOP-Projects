using System;
using System.Drawing;
using System.Windows.Forms;

public class PharmacyForm : Form
{
    TextBox idTextBox, priceTextBox, quantityTextBox;
    Button priceButton, quantityButton;
    PictureBox logoPictureBox;

    public PharmacyForm()
    {
        // Create text boxes
        idTextBox = new TextBox { Location = new Point(10, 10) };
        priceTextBox = new TextBox { Location = new Point(10, 40) };
        quantityTextBox = new TextBox { Location = new Point(10, 70) };

        // Create buttons
        priceButton = new Button { Text = "Calculate Price", Location = new Point(10, 100) };
        priceButton.Click += PriceButton_Click;

        quantityButton = new Button { Text = "Calculate Quantity", Location = new Point(10, 130) };
        quantityButton.Click += QuantityButton_Click;

        // Create picture box for logo
        logoPictureBox = new PictureBox { Location = new Point(10, 160), Size = new Size(100, 100) };
        
        // Add controls to the form
        Controls.Add(idTextBox);
        Controls.Add(priceTextBox);
        Controls.Add(quantityTextBox);
        Controls.Add(priceButton);
        Controls.Add(quantityButton);
        Controls.Add(logoPictureBox);
    }

    private void PriceButton_Click(object sender, EventArgs e)
    {
        decimal price = decimal.Parse(priceTextBox.Text);
        if (price > 1000)
        {
            MessageBox.Show("Price is greater than 1000");
        }
    }

    private void QuantityButton_Click(object sender, EventArgs e)
    {
        int quantity = int.Parse(quantityTextBox.Text);
        if (quantity < 10)
        {
            MessageBox.Show("Quantity is less than 10");
        }
    }

}
