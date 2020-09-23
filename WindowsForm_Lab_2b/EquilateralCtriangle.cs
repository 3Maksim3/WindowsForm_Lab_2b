namespace WindowsForm_Lab_2b
{
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
                for (int i = 0; i < (arr.Length < 10 ? arr.Length : 10); i++)
                {
                    if (arr[i].GetSquare(arr[i].Side1, arr[i].Side2, arr[i].Side3) > max)
                        max = arr[i].GetSquare(arr[i].Side1, arr[i].Side2, arr[i].Side3);
                }
            return max;
        }
    }


}
