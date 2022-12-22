namespace Switch_Case_deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap makinesi çalışıyor");
            Console.WriteLine("Ne işlem yapmak istiyorsun?Toplama için T,Çıkartma için Çarpma için X,Bölme için B");
            var islem = Console.ReadLine();

            int sayi1 = 0;
            int sayi2 = 0;
            int sonuc = 0;
            string? sayi;

            switch (islem)
            {
                case "T":
                case "t":
                    Console.WriteLine("Birinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi1 = Convert.ToInt32(sayi);

                    Console.WriteLine("İkinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi2 = Convert.ToInt32(sayi);

                    Console.WriteLine("Toplama işlemi yapıyoruz");
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("{0}+{1}={2}", sayi1, sayi2, sonuc);
                    break;

                case "Ç":
                case "ç":
                case "C":
                case "c":

                    Console.WriteLine("Birinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi1 = Convert.ToInt32(sayi);

                    Console.WriteLine("İkinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi2 = Convert.ToInt32(sayi);

                    Console.WriteLine("Çıkartma işlemi yapıyoruz");
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("{0}-{1}={2}", sayi1, sayi2, sonuc);
                    break;

                case "X":
                case "x":

                    Console.WriteLine("Birinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi1 = Convert.ToInt32(sayi);

                    Console.WriteLine("İkinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi2 = Convert.ToInt32(sayi);

                    Console.WriteLine("Çarpma işlemi yapıyoruz");
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("{0}*{1}={2}", sayi1, sayi2, sonuc);
                    break;

                case "B":
                case "b":
                    Console.WriteLine("Birinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi1 = Convert.ToInt32(sayi);

                    Console.WriteLine("İkinci sayıyı gir");
                    sayi = Console.ReadLine();
                    sayi2 = Convert.ToInt32(sayi);

                    Console.WriteLine("Bölme işlemi yapıyoruz");
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("{0}+{1}={2}", sayi1, sayi2, sonuc);
                    break;

                default:
                    Console.WriteLine("İşlem geçersizdir");
                    break;






            }

        }
    }
}