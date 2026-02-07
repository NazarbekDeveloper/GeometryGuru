namespace GeometryGuru
{
    public class Yuza
    {
        public double YuzaHisoblaKvadrat(double a)
        {
            return a * a;
        }
        public double YuzaHisoblaTortburchak(double a, double b)
        {
            return a * b;
        }
        public double YuzaHisoblaUchburchak(double a, double b, double c)
        {
            double P, S;
            P = (a + b + c) / 2.0;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
    }
}