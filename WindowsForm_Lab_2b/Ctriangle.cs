using System;

namespace WindowsForm_Lab_2b
{
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
            if ((arr[i].Side1 + arr[i].Side2) > arr[i].Side3 && (arr[i].Side1 + arr[i].Side3) > arr[i].Side2 && (arr[i].Side3 + arr[i].Side2) > arr[i].Side1)
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
                for (int i = 0; i < (arr.Length < 10 ? arr.Length : 10); i++)
                    middle += arr[i].GetSquare(arr[i].Side1, arr[i].Side2, arr[i].Side3);

            middle /= arr.Length;

            return middle;
        }
    }


}
