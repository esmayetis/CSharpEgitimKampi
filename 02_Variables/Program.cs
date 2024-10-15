using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Double Değişkenler
			////double number;

			////number = 4.85; //kod tarafında nokta olarak girilir, konsolda virgül olarak gözükür

			////Console.WriteLine(number);

			//Console.WriteLine("**** Fiyat Listesi ****");
			//Console.WriteLine();

			//double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

			//applePrice = 14.85;
			//orangePrice = 20.95;
			//strawberryPrice = 45;
			//potatoPrice = 9.74;
			//tomatoPrice = 6.88;

			//Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
			//Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
			//Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
			//Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
			//Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

			//Console.WriteLine();
			//Console.WriteLine();

			//double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

			//appleGram = 1.245;
			//orangeGram = 2.650;
			//strawberryGram = 0.750;
			//potatoGram = 4.859;
			//tomatoGram = 3.745;


			//double appleTotalPrice = appleGram * applePrice;
			//double orangeTotalPrice = orangeGram * orangePrice;
			//double  strawberryTotalPrice = strawberryGram * strawberryPrice;
			//double potatoTotalPrice = potatoGram * potatoPrice;
			//double tomatoTotalPrice = tomatoGram * tomatoPrice;



			//Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " - Gramaj: " +  appleGram + " Toplam Tutar: " + appleTotalPrice);

			//Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " - Gramaj: " +  orangeGram + " Toplam Tutar: " + orangeTotalPrice);

			//Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " - Gramaj: " +  strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);

			//Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " - Gramaj: " +  potatoGram + " Toplam Tutar: " + potatoTotalPrice);

			//Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);


			//Console.WriteLine();

			//double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

			//Console.WriteLine("Alışveriş Toplam Tutarı : " + shoppingTotalPrice);




			#endregion

			#region Char Değişkenler


			//char symbol;
			//symbol = 'a';

			//Console.WriteLine(symbol);	





			////hocamızın derste belirtmiş olduğu şifreleme yönteminin kodlaması
			//char[] a = { 'a', 'b', 'c', 'd', 'e', 'f', 'g','ğ', 'h', 'i','j', 'k','l','m','n','p','r','s','t','ü','v','y','z' };
			//char[] b = { 'e', 's', 'm', 'a' }; //şifrelenmesini istedğimiz karakter dizisi
			//int y = 0;
			//int i = 0;
			//while(i< a.Length && y <b.Length)
			//{
			//	if (a[i] == b[y])
			//	{
			//		b[y] = a[i+1];
			//		i = 0;
			//		y++;
			//		continue;
			//	}
			//	i++;
			//}
			//for (int x = 0; x < b.Length; x++)
			//{
			//	Console.Write(b[x]);

			//}


			#endregion

			#region Klavyeden Veri Girişleri String Değişkenler

			//Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
			//Console.WriteLine();

			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerGender, passengerIdentityNumber;

			//Console.Write("Yolcu Adı: ");
			//passengerName = Console.ReadLine();

			//Console.Write("Yolcu Soyadı: ");
			//passengerSurname = Console.ReadLine();

			//Console.Write("İlçe Bilgisi: ");
			//passengerDistrict = Console.ReadLine();

			//Console.Write("Şehir Bilgisi: ");
			//passengerCity = Console.ReadLine();

			//Console.Write("Yolcu Yaş: ");
			//passengerAge = Console.ReadLine();

			//Console.Write("Yolcu Cinsiyet: ");
			//passengerGender = Console.ReadLine();

			//Console.Write("Yolcu TC Kimlik Numarası: ");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();

			//Console.WriteLine("---------------------------");
			//Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " " + passengerGender);


			#endregion

			#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

			//int shoesPrice, computerPrice, chairPrice, tvPrice;
			//shoesPrice = 1000;
			//computerPrice = 2000;
			//chairPrice = 5000;
			//tvPrice = 12000;


			//int shoesCount, computerCount, chairCount, tvCount;

			//Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
			//shoesCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
			//computerCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
			//chairCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
			//tvCount = int.Parse(Console.ReadLine());


			//int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvCount * tvPrice;


			//Console.WriteLine();
			//Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);





			#endregion

			#region Klavyeden Ondalıklı Sayı İşlemleri

			//double exam1, exam2, exam3, result;

			//Console.Write("Lütfen 1.Sınav notunu giriniz: ");
			//exam1=double.Parse(Console.ReadLine());	


			//Console.Write("Lütfen 2.Sınav notunu giriniz: ");
			//exam2=double.Parse(Console.ReadLine());	


			//Console.Write("Lütfen 3.Sınav notunu giriniz: ");
			//exam3=double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;

			//Console.WriteLine();
			//Console.WriteLine("Sınav Ortalamanız: " + result);


			#endregion

			#region Klavyeden Karakter Girişleri

			//char gender;

			//Console.Write("Lütfen cinsiyet seçiniz: ");
			//gender = char.Parse(Console.ReadLine());

			//Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

			#endregion

			Console.Read();
		}
	}
}



//double -> ondalıklı sayıları tutar
//char -> karaker olan verileri tutar



// ctrl + f ile sağ üstte açılan panelden find yerine değiştirmek istediğimiz veriyi, replace yerine de o veri yerine ne yazıcağımızı koyup ab ok işaretli butona basarsak kod içerisinde eski verinin yazıldığı yerleri bulup yeni veri ile değiştirir. ->Ders2 27:20 saniye




//C# dili klavyeden girilen her şeyi ilk okumasında string olarak kabul eder. bizler tür dönüşümü ile istediğimiz veri tipine dönüştürebiliriz. 


//int16, int 32, int64 gibi türleri intin bellekte kapladığı büyüklüğü temsil eder


//int.Parse = string olarak kullanıcının girdiği bilgiyi inte çeviriyoruz

