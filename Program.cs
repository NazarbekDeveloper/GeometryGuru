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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"S = {a * a}");
            break;
        case 2:
            Console.Write("To'g'ri to'rtburchakning birinchi tomon uzunligini kiriting\na = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Endi esa ikkinchi tomoni uzunligini kiriting\nb = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"S = {b * c}");
            break;
        case 3:
            double P, S;
            Console.Write("Uchburchakning tomonlarini kiriting\na = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int f = int.Parse(Console.ReadLine());
            bool isTriangle = (d + e > f) && (d + f > e) && (e + f > d);
            if (isTriangle)
            {
                P = (d + e + f) / 2.0;
                S = Math.Sqrt(P * (P - d) * (P - e) * (P - f));
                Console.WriteLine($"S = {S}");
            }
            else
            {
                Console.Write("Siz kiritgan tomonlardan uchburchak yasab bo'lmaydi.\n Qaytadan");
            }
            break;
        case 4:
            for (int i = 2; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + "=" + (i * j));
                }
                System.Console.WriteLine();
            }
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