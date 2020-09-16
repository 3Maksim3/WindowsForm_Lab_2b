using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Lab_2b {
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

                for (int i = 0; i < ctriangles.Length; i++) {
                    do {
                        ctriangles[i] = new Ctriangle();
                        ctriangles[i].Side1 = random.Next(10, 15);
                        ctriangles[i].Side2 = random.Next(10, 15);
                        ctriangles[i].Side3 = random.Next(2, 20);
                    } while (!number.isCtriangle(ctriangles, i));
                }

                for (int i = 0; i < equilateralctriangles.Length; i++)
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


                for (int i = 0; i < ctriangles.Length; i++) {
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

                for (int i = 0; i < ctriangles.Length; i++)
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

    class Ctriangle
    {
        private double lengthside1;
        private double lengthside2;
        private double lengthside3;
        double Angle1, Angle2, Angle3;

        public double Side1 { get => lengthside1; set => lengthside1 = (value > 0 ? value : 1); }
        public double Side2 { get => lengthside2; set => lengthside2 = (value > 0 ? value : 1); }
        public double Side3 { get => lengthside3; set => lengthside3 = (value > 0 ? value : 1); }
        public double Angle11 { get => Angle1; set => Angle1 = value; }
        public double Angle21 { get => Angle2; set => Angle2 = value; }
        public double Angle31 { get => Angle3; set => Angle3 = value; }

        public bool isCtriangle(Ctriangle[] arr, int i)
        {
            if ((arr[i].Side1 + arr[i].Side2) > arr[i].Side3)
                return true;
            else
                return false;
        }

        public double GetAngle1(double Side1, double Side2, double Side3)
        {
            return Angle11 = Math.Cos((Math.Pow(Side1, 2) + Math.Pow(Side3, 2) - Math.Pow(Side2, 2)) / (2 * Side1 * Side3));
        }

        public double GetAngle2(double Side1, double Side2, double Side3)
        {
            return Angle21 = Math.Cos((Math.Pow(Side1, 2) + Math.Pow(Side2, 2) - Math.Pow(Side3, 2)) / (2 * Side1 * Side3));
        }

        public double GetAngle3(double Side1, double Side2, double Side3)
        {
            return Angle31 = Math.Cos((Math.Pow(Side2, 2) + Math.Pow(Side3, 2) - Math.Pow(Side1, 2)) / (2 * Side1 * Side3));
        }

        public double GetPerimetr(double Side1, double Side2, double Side3)
        {
            return Side1 + Side2 + Side3;
        }

        public double GetSquare(double Side1, double Side2, double Side3)
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public string PrintCtriangle(double Side1, double Side2, double Side3)
        {
            return $"Default Ctriangle:\nSide1 = {Side1} ; Side2 = {Side2} ; Side3 = {Side3} \nAngles = {GetAngle1(Side1, Side2, Side3)} ; {GetAngle2(Side1, Side2, Side3)} ; {GetAngle3(Side1, Side2, Side3)} \nPerimetr = {GetPerimetr(Side1, Side2, Side3)} ; Square = {GetSquare(Side1, Side2, Side3)}";
        }

        public double findMiddleSquare(Ctriangle[] arr)
        {
            double middle = 0;

            if (arr.Length > 0)
                for (int i = 0; i < arr.Length; i++)
                    middle += arr[i].GetSquare(arr[i].Side1, arr[i].Side2, arr[i].Side3);

            middle /= arr.Length;

            return middle;
        }
    }

    class EquilateralCtriangle : Ctriangle
    {
        private double lengthside1;
        private double lengthside2;
        private double lengthside3;
        double Angle1, Angle2, Angle3;

        public double Lengthside1 { get => lengthside1; set => lengthside1 = (value > 0 ? value : 1); }
        public double Lengthside2 { get => lengthside2; set => lengthside2 = (value > 0 ? value : 1); }
        public double Lengthside3 { get => lengthside3; set => lengthside3 = (value > 0 ? value : 1); }
        public double Angle12 { get => Angle1; set => Angle1 = value; }
        public double Angle22 { get => Angle2; set => Angle2 = value; }
        public double Angle32 { get => Angle3; set => Angle3 = value; }

        public bool isCorrect(EquilateralCtriangle[] arr, int i)
        {
            if (Lengthside1 == Lengthside2 && Lengthside1 == Lengthside3 && Lengthside2 == Lengthside3)
                return true;
            else
                return false;
        }

        new public double GetPerimetr(double Lengthside1, double Lengthside2, double Lengthside3)
        {
            return base.GetPerimetr(Lengthside1, Lengthside2, Lengthside3);
        }

        new public double GetSquare(double Lengthside1, double Lengthside2, double Lengthside3)
        {
            return base.GetSquare(Lengthside1, Lengthside2, Lengthside3);
        }

        new public string PrintCtriangle(double Lengthside1, double Lengthside2, double Lengthside3)
        {
            return $"Equilateral Ctriangle:\nSide1 = {Lengthside1} ; Side2 = {Lengthside2} ; Side3 = {Lengthside3} \nAngles = {GetAngle1(Lengthside1, Lengthside2, Lengthside3)} ; {GetAngle2(Lengthside1, Lengthside2, Lengthside3)} ; {GetAngle3(Lengthside1, Lengthside2, Lengthside3)} \nPerimetr = {GetPerimetr(Lengthside1, Lengthside2, Lengthside3)} ; Square = {GetSquare(Lengthside1, Lengthside2, Lengthside3)}";
        }

        public double findMaxSquare(EquilateralCtriangle[] arr)
        {
            double max = 0;

            if (arr.Length > 0)
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].GetSquare(arr[i].Side1, arr[i].Side2, arr[i].Side3) > max)
                        max = arr[i].GetSquare(arr[i].Side1, arr[i].Side2, arr[i].Side3);
                }
            return max;
        }
    }


}
