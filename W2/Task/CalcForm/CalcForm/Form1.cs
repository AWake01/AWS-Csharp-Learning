using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    public partial class Shape_Calculator_Form : Form
    {
        public Shape_Calculator_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rectangle_Rb.Checked = true;   //Default radio button

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rectangle_RB_CheckedChanged(object sender, EventArgs e)
        {
                  
        }

        private void rectangle_Rb_CheckedChanged_1(object sender, EventArgs e)
        {
            //Enable text input and set labels
            d1_Tb.Enabled = true;
            d2_Tb.Enabled = true;
            d3_Tb.Enabled = false;
            d1_Lb.Text = "Width";
            d2_Lb.Text = "Height";
            d3_Lb.Text = "-";
        }

        private void circle_RB_CheckedChanged(object sender, EventArgs e)
        {
            //Enable text input and set labels
            d1_Tb.Enabled = true;
            d2_Tb.Enabled = false;
            d3_Tb.Enabled = false;
            d1_Lb.Text = "Radius";
            d2_Lb.Text = "-";
            d3_Lb.Text = "-";
        }

        private void triangle_RB_CheckedChanged(object sender, EventArgs e)
        {
            //Enable text input and set labels
            d1_Tb.Enabled = true;
            d2_Tb.Enabled = true;
            d3_Tb.Enabled = true;
            d1_Lb.Text = "Side 1";
            d2_Lb.Text = "Side 2";
            d3_Lb.Text = "Side 3";
        }

        private void CalcArea_Btn_Click(object sender, EventArgs e)
        {
            //Read textbox values
            double d1 = Convert.ToDouble(d1_Tb.Text);
            double d2 = Convert.ToDouble(d2_Tb.Text);
            double d3 = Convert.ToDouble(d3_Tb.Text);

            string shape = "";
            double area = 0.0;

            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();  //Get collecion of radio buttons


            switch (radioBtn.Name)  //Chck which radio button is selected
            {

                case "rectangle_Rb":
                    Rectangle rec = new Rectangle();
                    rec.width = d1;
                    rec.height = d2;
                    area = rec.Area();
                    shape = "rectangle";
                    break;

                case "circle_Rb":
                    Circle cir = new Circle();
                    cir.radius = d1;
                    area = cir.Area();
                    shape = "circle";
                    break;

                case "triangle_Rb":
                    Triangle tri = new Triangle();
                    tri.s1 = d1;
                    tri.s2 = d2;
                    tri.s3 = d3;
                    area = tri.Area();
                    shape = "triangle";
                    break;

                default:
                    break;
            }

            area = Math.Round(area, 2);
            MessageBox.Show($"The area of the {shape} is: {area.ToString()}"); //Display mesage box with area caluation
        }

        private void perimeter_btn_Click(object sender, EventArgs e)
        {
            //Read textbox values
            double d1 = Convert.ToDouble(d1_Tb.Text);
            double d2 = Convert.ToDouble(d2_Tb.Text);
            double d3 = Convert.ToDouble(d3_Tb.Text);

            string shape = "";
            double per = 0.0;

            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();  //Get collecion of radio buttons


            switch (radioBtn.Name)  //Chck which radio button is selected
            {

                case "square_Rb":
                    d1_Lb.Text = "Width";
                    d2_Lb.Text = "Height";
                    d3_Lb.Text = "-";

                    Rectangle rec = new Rectangle();
                    rec.width = d1;
                    rec.height = d2;
                    per = rec.Perimiter();
                    shape = "rectangle";
                    break;

                case "circle_Rb":
                    Circle cir = new Circle();
                    cir.radius = d1;
                    per = cir.Perimiter();
                    shape = "circle";
                    break;

                case "triangle_Rb":
                    Triangle tri = new Triangle();
                    tri.s1 = d1;
                    tri.s2 = d2;
                    tri.s3 = d3;
                    per = tri.Perimiter();
                    shape = "triangle";
                    break;

                default:
                    break;
            }

            per = Math.Round(per, 2);
            MessageBox.Show($"The perimeter of the {shape} is: {per.ToString()}"); //Display mesage box with area caluation
        }
    }
}
