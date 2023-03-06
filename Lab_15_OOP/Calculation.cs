using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_15_OOP
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
            harvestSumTextBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            task1 tascOne = new task1();
            tascOne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            harvestSumTextBox.Hide();
            harvestSumLabel.Text = "";
            yieldLabel1.Text = "Врожайність першого сорту";
            yieldLabel2.Text = "Врожайність другого сорту";
            yieldLabel3.Text = "Врожайність третього сорту";
            valueLabel.Text = "ц / Га";

            yield1.Text = "";
            yield2.Text = "";
            yield3.Text = "";

            field1.Text = "";
            field2.Text = "";
            field3.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yieldOne = 0.0;
            double yieldTwo = 0.0;
            double yieldThree = 0.0;

            double fieldOne = 0.0;
            double fieldTwo = 0.0;
            double fieldThree = 0.0;

            try
            {
                yieldOne = double.Parse(yield1.Text);
                yieldTwo = double.Parse(yield2.Text);
                yieldThree = double.Parse(yield3.Text);

                fieldOne = double.Parse(field1.Text);
                fieldTwo = double.Parse(field2.Text);
                fieldThree = double.Parse(field3.Text);
            }
            catch 
            {
                yield1.Text = "";
                yield2.Text = "";
                yield3.Text = "";

                field1.Text = "";
                field2.Text = "";
                field3.Text = "";
            }
            yield1.Text = "";
            yield2.Text = "";
            yield3.Text = "";

            field1.Text = "";
            field2.Text = "";
            field3.Text = "";

            double harvestOne = 0.0;
            double harvestTwo = 0.0;
            double harvestThree = 0.0;
            double harvestSum = 0.0;

            if( yieldOne < 0 || yieldTwo < 0 || yieldThree < 0)
            {
                MessageBox.Show("Врожайність не може бути меншою 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(fieldOne <= 0 || fieldTwo <= 0 || fieldThree <= 0)
            {
                MessageBox.Show("Площа поля не може бути від'ємною", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                harvestSumTextBox.Show();

                yieldLabel1.Text = "Зібрано першого сорту";
                yieldLabel2.Text = "Зібрано другого сорту";
                yieldLabel3.Text = "Зібрано третього сорту";

                valueLabel.Text = "Ц";

                harvestSumLabel.Text = "Врожай разом";

                harvestOne = yieldOne * fieldOne;
                harvestTwo = yieldTwo * fieldTwo;
                harvestThree = yieldThree * fieldThree;
                harvestSum = harvestOne + harvestTwo + harvestThree;

                yield1.Text = Math.Round(harvestOne, 2).ToString();
                yield2.Text = Math.Round(harvestTwo, 2).ToString();
                yield3.Text = Math.Round(harvestThree,2).ToString();

                harvestSumTextBox.Text = Math.Round(harvestSum, 2).ToString();

            }
        }
    }
}
