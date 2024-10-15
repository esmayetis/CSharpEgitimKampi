using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region YazdırmaKomutları
			//Console.Write("Merhaba Dünya");
			//Console.WriteLine("selam");//alt satıra geçip orda bekletir imleci


			//Console.Read();//konsolun göründükten sonra entera basılana kadar açık kalmasını sağlayan komut satırı


			//Console.WriteLine("***** Yemek Kategorileri *****\n");
			////Console.WriteLine("");
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine("\n***** Yemek Kategorileri *****\n");

			#endregion

			#region StringDeğişkenler
			////Değişken_türü değişken_adi;

			////string name;
			////name = "Esma";
			////Console.WriteLine(name);

			//string customerName;
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city;

			//customerName = "Ali";
			//customerSurname = "Kaya";
			//customerPhone = "+90 500 400 30 20";
			//customerEmail = "deneme@gmail.com";
			//district = "Kadıköy";
			//city = "İstanbul";

			//Console.WriteLine("**** Rezervasyon Kartı ****\n");
			//Console.WriteLine("-----------------------------------------");
			//Console.WriteLine("Müşteri: " +  customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " +  district + "/" + city);
			//Console.WriteLine("-----------------------------------------");

			//Console.WriteLine();

			//customerName = "Ayşegül";
			//customerSurname = "Kaya";
			//customerPhone = "+90 500 400 80 70";
			//customerEmail = "test@gmail.com";
			//district = "Sapanca";
			//city = "Sakarya";


			//Console.WriteLine("-----------------------------------------");
			//Console.WriteLine("Müşteri: " +  customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " +  district + "/" + city);
			//Console.WriteLine("-----------------------------------------");



			#endregion

			#region İnt Değişkenler
			//int number = 24;
			//Console.WriteLine(number);	

			int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;

			Console.WriteLine("**** Restoran Menü Fiyatı ****");
			Console.WriteLine();
			Console.WriteLine("--Hamburger: " + hamburgerPrice + " TL");
			Console.WriteLine("--Pizza: " + pizzaPrice + " TL");
			Console.WriteLine("--Kola: " + cokePrice + " TL");
			Console.WriteLine("--Limonata: " + lemonadePrice + " TL");
			Console.WriteLine("--Kızartma: " + friesPrice + " TL");
			Console.WriteLine("--Su: " + waterPrice + " TL");
			Console.WriteLine("\n**** Restoran Menü Fiyatı ****");


			int hamburgerCount = 3;
			int cokeCount = 3;
			int waterCount = 3;
			int friesCount = 1;
			int pizzaCount = 0;
			int lemonadeCount = 0;

			int totalHamburgerPrice = 0;
			int totalCokePrice = 0;
			int totalWaterPrice = 0;
			int totalFriesPrice = 0;
			int totalPizzaPrice = 0;
			int totalLemonadePrice = 0;

			totalHamburgerPrice = hamburgerCount * hamburgerPrice;
			totalCokePrice = cokeCount * cokePrice;	
			totalWaterPrice = waterCount * waterPrice;
			totalFriesPrice = friesCount * friesPrice;	
			totalPizzaPrice = pizzaCount * pizzaPrice;
			totalLemonadePrice  = lemonadeCount * lemonadePrice;


			Console.WriteLine("-----------------------------------");
			Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
			Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
			Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
			Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
			Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
			Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");


			Console.WriteLine();

			int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + 
				totalPizzaPrice + totalFriesPrice;

			Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
			#endregion




			Console.Read();
		
		}
	}
}

//yorum satırları
//yazdırma komutları

//en tepedeki using ifadeleri dahil edilen kütüphaneleri gösterir


//internal bir erişim belirleyicisidir. public, private gibi

//mor renkli küp metod olduğunu belirtir.

//#region - #endregion aralığı kodun bir bölümünü oluşturur. yanda açılır kapanır ok işareti ekler


//Değişkenler: geçici olarak program için gerekli olan verileri ram de tutan değerlerdir.
//string: alfabetik türde verilerimizi tutan değişken

//camelcase = customerName örneği mesela her adlandırmda ilki küçük sonraki her kelimenin ilk karakteri büyük olursa camelcase e uyar. customer_name örneği camelcase e uymaz



//int : sayısal tipte verileri tutan değişkenimiz
