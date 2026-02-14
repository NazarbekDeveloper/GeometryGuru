using GeometryGuru;

Printer printer = new Printer();
Yuza yuza = new Yuza();
KarraJadval karra = new KarraJadval();
printer.PrintLine("Assalomu alaykum Geometry Guru loyihasiga xush kelibsiz!!!");
int qaytaIshlataman;
do
{
    printer.PrintLine("Qaysi shaklning yuzasini hisoblaymi?");
    printer.PrintLine("1.Kvadrat\n2.To'g'ri to'rtburchak\n3.Uchburchak\n4.Karra jadval");
    printer.Print("Tanlang: ");
    int tanlanganShakl = int.Parse(Reader.ConsoleReader());
    switch (tanlanganShakl)
    {
        case 1:
            printer.Print("Kvadratning tomonini kiriting\na = ");
            double a = double.Parse(Reader.ConsoleReader());
            try
            {
                if (a <= 0) throw new ArgumentOutOfRangeException();
                printer.PrintLine($"S = {yuza.YuzaHisoblaKvadrat(a)}");
            }
            catch (ArgumentOutOfRangeException)
            {
                printer.PrintLine("Oka kvadratning tomoni bunaqa son bo'lolmidiku. Nimala qvos..");
            }
            break;
        case 2:
            printer.Print("To'g'ri to'rtburchakning birinchi tomon uzunligini kiriting\na = ");
            double b = double.Parse(Reader.ConsoleReader());
            printer.Print("Endi esa ikkinchi tomoni uzunligini kiriting\nb = ");
            double c = double.Parse(Reader.ConsoleReader());
            try
            {
                if (b <= 0 || c <= 0) throw new ArgumentOutOfRangeException();
                printer.PrintLine($"S = {yuza.YuzaHisoblaTortburchak(b, c)}");
            }
            catch (ArgumentOutOfRangeException)
            {
                printer.PrintLine("Oka to'rtburchakning tomonlari bunaqa son bo'lolmidiku. Nimala qvos..");
            }
            break;
        case 3:
            printer.Print("Uchburchakning tomonlarini kiriting\na = ");
            double d = double.Parse(Reader.ConsoleReader());
            printer.Print("b = ");
            double e = double.Parse(Reader.ConsoleReader());
            printer.Print("c = ");
            double f = double.Parse(Reader.ConsoleReader());
            try
            {
                if (d <= 0 || e <= 0 || f <= 0) throw new ArgumentOutOfRangeException();
                if (IsUchburchak(d, e, f))
                {
                    printer.PrintLine($"S = {yuza.YuzaHisoblaUchburchak(d, e, f)}");
                }
                else
                {
                    printer.PrintLine("Siz kiritgan tomonlardan uchburchak yasab bo'lmaydi.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                printer.PrintLine("Oka uchburchakning tomonlari bunaqa son bo'lolmidiku. Nimala qvos..");
            }
            break;
        case 4:
            karra.KarraJadvalChiqar();
            break;
        default:
            printer.PrintLine("Hazillashyabsizmi jigar. Bizda bunday shakl mavjud emas...");
            break;

    }
    printer.PrintLine("Dasturni qaytadan ishlatvoramizami oka?(1.ha 0.yo'q)");
    printer.Print(">> ");
    qaytaIshlataman = Convert.ToInt16(Reader.ConsoleReader());
} while (qaytaIshlataman == 1);
static bool IsUchburchak(double d, double e, double f)
{
    return (d + e > f) && (d + f > e) && (e + f > d);
}
printer.PrintLine("Salomat bo'ling jigar. Yaxshi boring :)");
