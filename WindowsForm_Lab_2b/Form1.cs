using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Lab_2b
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Ctriangle number = new Ctriangle();

                EquilateralCtriangle count = new EquilateralCtriangle();

                Ctriangle[] ctriangles = new Ctriangle[Convert.ToInt32(textBox1.Text)];

                EquilateralCtriangle[] equilateralctriangles = new EquilateralCtriangle[Convert.ToInt32(textBox2.Text)];

                Random random = new Random();

                for (int i = 0; i < (ctriangles.Length < 10 ? ctriangles.Length : 10); i++) {
                    do {
                        ctriangles[i] = new Ctriangle();
                        ctriangles[i].Side1 = random.Next(10, 15);
                        ctriangles[i].Side2 = random.Next(10, 15);
                        ctriangles[i].Side3 = random.Next(2, 20);
                    } while (!number.isCtriangle(ctriangles, i));
                }

                for (int i = 0; i < (equilateralctriangles.Length < 10 ? equilateralctriangles.Length : 10); i++)
                {
                    do
                    {
                        equilateralctriangles[i] = new EquilateralCtriangle();
                        equilateralctriangles[i].Side1 = random.Next(6, 15);

                        do {
                            equilateralctriangles[i].Side2 = random.Next(6, 15);
                        } while (!(equilateralctriangles[i].Side2 == equilateralctriangles[i].Side1));

                        do
                        {
                            equilateralctriangles[i].Side3 = random.Next(6, 15);
                        } while (!(equilateralctriangles[i].Side3 == equilateralctriangles[i].Side1));


                    } while (!count.isCorrect(equilateralctriangles, i));
                }



                richTextBox1.Text += "--------------------------------------------------------------------------------------------------\n";
                richTextBox1.Text +=  $"Средняя площадь всех {Convert.ToInt32(textBox1.Text)} треугольников = " + Math.Round(number.findMiddleSquare(ctriangles)) + "\n";
                richTextBox1.Text += "--------------------------------------------------------------------------------------------------";

                richTextBox2.Text += "--------------------------------------------------------------------------------------------------\n";
                richTextBox2.Text += $"Наибольшая площадь среди {Convert.ToInt32(textBox2.Text)} р-них треугольников = " + Math.Round(count.findMaxSquare(equilateralctriangles)) + "\n";
                richTextBox2.Text += "--------------------------------------------------------------------------------------------------";


                for (int i = 0; i < (ctriangles.Length < 10 ? ctriangles.Length : 10); i++) {
                    richTextBox1.Text += "\n";
                    richTextBox1.Text += $"Информация об треугольнике под номером {i + 1}\n";
                    richTextBox1.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox1.Text += $"Длина стороны № 1  = {ctriangles[i].Side1} , Длина стороны № 2  = {ctriangles[i].Side2} , Длина стороны № 3  = {ctriangles[i].Side3}\n";
                    richTextBox1.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox1.Text += $"Периметр = {Math.Round(ctriangles[i].GetPerimetr(ctriangles[i].Side1, ctriangles[i].Side2, ctriangles[i].Side3))}\n";
                    richTextBox1.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox1.Text += $"Угол № 1 = {Math.Round(ctriangles[i].GetAngle1(ctriangles[i].Side1, ctriangles[i].Side2, ctriangles[i].Side3), 4)} ; Угол № 2 = {Math.Round(ctriangles[i].GetAngle2(ctriangles[i].Side1, ctriangles[i].Side2, ctriangles[i].Side3) , 4)} ; Угол № 3 = {Math.Round(ctriangles[i].GetAngle3(ctriangles[i].Side1, ctriangles[i].Side2, ctriangles[i].Side3) , 4)}\n";
                    richTextBox1.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox1.Text += $"Площадь = {Math.Round(ctriangles[i].GetSquare(ctriangles[i].Side1, ctriangles[i].Side2, ctriangles[i].Side3))}\n";
                }

                for (int i = 0; i < (equilateralctriangles.Length < 10 ? equilateralctriangles.Length : 10); i++)
                {
                    richTextBox2.Text += "\n";
                    richTextBox2.Text += $"Информация об р-нем треугольнике под номером {i + 1}\n";
                    richTextBox2.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox2.Text += $"Длина стороны № 1  = {equilateralctriangles[i].Side1} , Длина стороны № 2  = {equilateralctriangles[i].Side2} , Длина стороны № 3  = {equilateralctriangles[i].Side3}\n";
                    richTextBox2.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox2.Text += $"Периметр = {Math.Round(equilateralctriangles[i].GetPerimetr(equilateralctriangles[i].Side1, equilateralctriangles[i].Side2, equilateralctriangles[i].Side3))}\n";
                    richTextBox2.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox2.Text += $"Угол № 1 = {Math.Round(equilateralctriangles[i].GetAngle1(equilateralctriangles[i].Side1, equilateralctriangles[i].Side2, equilateralctriangles[i].Side3), 4)} ; Угол № 2 = {Math.Round(equilateralctriangles[i].GetAngle2(equilateralctriangles[i].Side1, equilateralctriangles[i].Side2, equilateralctriangles[i].Side3), 4)} ; Угол № 3 = {Math.Round(equilateralctriangles[i].GetAngle3(equilateralctriangles[i].Side1, equilateralctriangles[i].Side2, equilateralctriangles[i].Side3), 4)}\n";
                    richTextBox2.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
                    richTextBox2.Text += $"Площадь = {Math.Round(equilateralctriangles[i].GetSquare(equilateralctriangles[i].Side1, equilateralctriangles[i].Side2, equilateralctriangles[i].Side3))}\n";
                }
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }

            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

    }


}
