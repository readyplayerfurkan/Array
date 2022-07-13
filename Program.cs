//dizi tanımlama

string[] veri = new string[5];

string[] bitkiler = { "Papatya", "Isırgan Otu", "Çimen" };

int[] yaslar;
yaslar = new int[6];

//diziye değer atama ve erişim

veri[0] = "Cinsiyet";

yaslar[5] = 26;

Console.WriteLine(veri[0]);
Console.WriteLine(yaslar[5]);
Console.WriteLine(bitkiler[1]);

//döngülerle dizi kullanımı
//Klavyeden girilen n tane sayının ortalamasını alma

Console.WriteLine("Lütfen sayı miktarını giriniz: ");

int miktar = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[miktar];

for (int i = 0; i < miktar; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;

foreach (int sayi in sayiDizisi)
{
    toplam += sayi;
}

Console.WriteLine("Sayıların ortalaması: " + toplam / miktar);