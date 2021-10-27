using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4_Task_2
{
    public partial class Form1 : Form
    {
        private Square square;
        private Rectangle rectangle;
        private Rhomb rhomb;
        private Triangle triangle;
        private Circle circle;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            square = null;
            rectangle = null;
            rhomb = null;
            triangle = null;
            circle = null;
            try
            {
                double a = Convert.ToDouble(textBox1.Text);

                square = new Square(a);
                MessageBox.Show("Квадрат створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити квадрат");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            square = null;
            rectangle = null;
            rhomb = null;
            triangle = null;
            circle = null;
            try
            {
                double a = Convert.ToDouble(textBox2.Text);
                double b = Convert.ToDouble(textBox3.Text);

                rectangle = new Rectangle(a, b);
                MessageBox.Show("Прямокутник створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити прямокутник");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            square = null;
            rectangle = null;
            rhomb = null;
            triangle = null;
            circle = null;
            try
            {
                double a = Convert.ToDouble(textBox4.Text);
                double b = Convert.ToDouble(textBox5.Text);
                double c = Convert.ToDouble(textBox6.Text);

                triangle = new Triangle(a, b, c);
                MessageBox.Show("Трикутник створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити трикутник");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            square = null;
            rectangle = null;
            rhomb = null;
            triangle = null;
            circle = null;
            try
            {
                double a = Convert.ToDouble(textBox7.Text);
                double alpha = Convert.ToDouble(textBox9.Text);

                rhomb = new Rhomb(a, alpha);
                MessageBox.Show("Ромб створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити ромб");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            square = null;
            rectangle = null;
            rhomb = null;
            triangle = null;
            circle = null;
            try
            {
                double r = Convert.ToDouble(textBox10.Text);

                circle = new Circle(r);
                MessageBox.Show("Круг створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити круг");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(square != null)
                MessageBox.Show(square.GetPerimetr().ToString());
            else if(rectangle != null)
                MessageBox.Show(rectangle.GetPerimetr().ToString());
            else if(rhomb != null)
                MessageBox.Show(rhomb.GetPerimetr().ToString());
            else if(triangle != null)
                MessageBox.Show(triangle.GetPerimetr().ToString());
            else if (circle != null)
                MessageBox.Show(circle.GetPerimetr().ToString());
            else
                MessageBox.Show("Спочатку створіть фігуру!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (square != null)
                MessageBox.Show(square.GetArea().ToString());
            else if (rectangle != null)
                MessageBox.Show(rectangle.GetArea().ToString());
            else if (rhomb != null)
                MessageBox.Show(rhomb.GetArea().ToString());
            else if (triangle != null)
                MessageBox.Show(triangle.GetArea().ToString());
            else if (circle != null)
                MessageBox.Show(circle.GetArea().ToString());
            else
                MessageBox.Show("Спочатку створіть фігуру!");
        }

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
