using System;
using System.Collections;


Console.WriteLine("10.11.2024 Tarihli Ödev");
Console.WriteLine("------------------------");


Console.WriteLine("\n");

/*

Console.WriteLine("Soru 1: Foreach Döngüsü ile Liste Elemanlarını Yazdırma");
Console.WriteLine("--------------------------------------------------------");


int[] tamsayı = { 3, 4, 5, 6 };
int toplam = 0;

foreach (int eleman in tamsayı)
{
    Console.WriteLine(eleman);
    toplam += eleman; 
}

Console.WriteLine("Toplam: " + toplam);


*/





/*

Console.WriteLine("Soru 2: Hazır Metod Kullanımı");
Console.WriteLine("------------------------------");


Console.Write("Bir cümle girin: ");
string cümle = Console.ReadLine();

string[] kelimeler = cümle.Split(' ');

int kelimeSayisi = kelimeler.Length;

Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);


*/








/*


Console.WriteLine("Soru 3: ArrayList ile Alfabetik Sıralama");
Console.WriteLine("-----------------------------------------");



ArrayList list = new ArrayList(); 
list.Add("Hasan");
list.Add("Ahmet");
list.Add("Mehmet");
list.Add("Berra");
list.Add("Berkay");

Console.WriteLine("Sıralanmış Liste");
list.Sort();
foreach (string i in list)
Console.WriteLine(i.ToString());



*/







/*

Console.WriteLine("Soru 4: For Döngüsü ile Fibonacci Serisi");
Console.WriteLine("-----------------------------------------");



Console.Write("Fibonacci serisindeki terim sayısını giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
    return; 
}

int[] fibonacci = new int[n];

if (n >= 1) fibonacci[0] = 0; 
if (n >= 2) fibonacci[1] = 1; 

for (int i = 2; i < n; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; 
}

Console.WriteLine("Fibonacci Serisi: ");
foreach (int sayi in fibonacci)
{
    Console.WriteLine(sayi);
}



*/






/*


Console.WriteLine("Soru 5: While Döngüsü ile Tahmin Oyunu");
Console.WriteLine("---------------------------------------");


Random random = new Random();
int hedefSayi = random.Next(0, 11); 
int tahmin;

Console.WriteLine("0 ile 10 arasında bir sayı tahmin edin. Doğru sayıyı bulana kadar oyun devam edecektir.");

while (true)
{
    Console.Write("Tahmininizi giriniz: ");
    tahmin = int.Parse(Console.ReadLine());

    if (tahmin == hedefSayi)
    {
        Console.WriteLine("Tebrikler, Doğru tahmin ettiniz."); 
        break; 
    }
    else
    {
        Console.WriteLine("Yanlış tahmin. Tekrar deneyiniz.");
    }
}


*/






/*


Console.WriteLine("Soru 6: Do While Döngüsü ile Basit Hesap Makinesi");
Console.WriteLine("--------------------------------------------------");


string seçim;

do
{
    Console.WriteLine("\nBir işlem seçiniz:");
    Console.WriteLine("1. Toplama");
    Console.WriteLine("2. Çıkarma");
    Console.WriteLine("3. Çarpma");
    Console.WriteLine("4. Bölme");
    Console.WriteLine("Çıkmak için 'çıkış' yazınız.");

    seçim = Console.ReadLine();

    if (seçim.ToLower() == "çıkış")
    {
        break;       
    }

    int işlem;
    if (int.TryParse(seçim, out işlem) && işlem >= 1 && işlem <= 4)
    {
        Console.Write("1.sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2.sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        switch (işlem)
        {
            case 1: Console.WriteLine("Toplam Sonucu: " + (sayi1 + sayi2)); break;
            case 2: Console.WriteLine("Çıkarma Sonucu: " + (sayi1 - sayi2)); break;
            case 3: Console.WriteLine("Çarpma Sonucu: " + (sayi1 * sayi2)); break;
            case 4:
                if (sayi2 != 0)
                {
                    Console.WriteLine("Bölme Sonucu: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez.");
                } break;
            default: Console.WriteLine("Geçersiz sayı girdiniz."); break;
        }

    }
    else
    {
        Console.WriteLine("Lütfen 1-4 arasında bir sayı giriniz veya 'çıkış' yazınız.");
    }

}
while (true);



Console.ReadKey();



*/





/*

Console.WriteLine("Soru 7: For ve While Döngüsü ile Sayı Toplama Oyunu");
Console.WriteLine("----------------------------------------------------");

int toplam = 0;
List<int> sayilar = new List<int>();

while (true)
{
    int pozitif_sayılar = Convert.ToInt32(Console.ReadLine());

    if (pozitif_sayılar != 0 )
    {
        toplam += pozitif_sayılar;
        sayilar.Add(pozitif_sayılar);
    }
    else
    {
        break;
    }

}

Console.WriteLine("Girilen pozitif tamsayıların toplam sonucu: " + toplam);
Console.WriteLine("\n");
Console.WriteLine("Kullanıdan girilen pozitif tamsayılar: ");



for (int i = 0; i < sayilar.Count; i++)
{
     Console.WriteLine(sayilar[i]);
}



Console.ReadKey();


*/


