Console.WriteLine("Assalomu alaykum Geometry Guru loyihasiga xush kelibsiz!!!");
int qaytaIshlataman;
do
{
    Console.WriteLine("Qaysi shaklning yuzasini hisoblaymi?");
    Console.WriteLine("1.Kvadrat\n2.To'g'ri to'rtburchak\n3.Uchburchak\n4.Karra jadval");
    Console.Write("Tanlang: ");
    int tanlanganShakl = int.Parse(Console.ReadLine());
    switch (tanlanganShakl)
    {
        case 1:
            Console.Write("Kvadratning tomonini kiriting\na = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"S = {YuzaHisoblaKvadrat(a)}");
            break;
        case 2:
            Console.Write("To'g'ri to'rtburchakning birinchi tomon uzunligini kiriting\na = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Endi esa ikkinchi tomoni uzunligini kiriting\nb = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"S = {YuzaHisoblaTortburchak(b, c)}");
            break;
        case 3:
            Console.Write("Uchburchakning tomonlarini kiriting\na = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double f = double.Parse(Console.ReadLine());
            bool isTriangle = (d + e > f) && (d + f > e) && (e + f > d);
            if (isTriangle)
            {

                Console.WriteLine($"S = {YuzaHisoblaUchburchak}");
            }
            else
            {
                Console.Write("Siz kiritgan tomonlardan uchburchak yasab bo'lmaydi.");
            }
            break;
        case 4:
            KarraJadvalChiqar();
            break;
        default:
            Console.WriteLine("Hazillashyabsizmi jigar. Bizda bunday shakl mavjud emas...");
            break;

    }
    System.Console.WriteLine("Dasturni qaytadan ishlatvoramizami oka?(1.ha 0.yo'q)");
    Console.Write(">> ");
    qaytaIshlataman = Convert.ToInt16(Console.ReadLine());
} while (qaytaIshlataman == 1);
Console.WriteLine("Salomat bo'ling jigar. Yaxshi boring :)");

static double YuzaHisoblaKvadrat(double a)
{
    return a * a;
}
static double YuzaHisoblaTortburchak(double a, double b)
{
    return a * b;
}
static double YuzaHisoblaUchburchak(double a, double b, double c)
{
    double P, S;
    P = (a + b + c) / 2.0;
    S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
    return S;
}
static void KarraJadvalChiqar()
{
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.WriteLine(i + " * " + j + "=" + (i * j));
        }
        System.Console.WriteLine();
    }
}