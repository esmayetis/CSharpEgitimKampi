using System;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region If Else

			//Console.Write("Lütfen şifreyi giriniz: ");
			//string password;
			//password = Console.ReadLine();	

			//if(password == "abcd")
			//{
			//	Console.WriteLine("Şifre Doğru");
			//}
			//else
			//{
			//	Console.WriteLine("Şifre Yanlış");
			//}






			//string capital, country;
			//Console.Write("Başkenti giriniz: ");
			//capital = Console.ReadLine();

			//Console.Write("Ülkeyi giriniz: ");
			//country = Console.ReadLine();

			//if (capital == "ankara" & country == "türkiye")
			//{
			//	Console.Write("veriler doğrulandı");
			//}

			//else
			//{
			//	Console.Write("hatali bilgi");
			//}





			//int number;
			//Console.Write("Sayıyı giriniz: ");
			//number  = int.Parse(Console.ReadLine());

			//if(number == 5)
			//{
			//	Console.WriteLine("Sayi doğru");
			//}
			//else
			//{
			//	Console.WriteLine("Sayi yanlis");

			//}



			//int exam1, exam2, exam3, average;
			//string result = "Hata";
			//Console.Write("Sınav 1: ");
			//exam1 = int.Parse(Console.ReadLine());
			//Console.Write("Sınav 2: ");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.Write("Sınav 3: ");
			//exam3 = int.Parse(Console.ReadLine());


			//average = (exam1 + exam2 + exam3) / 3;
			//Console.WriteLine("Sınavın ortalaması: " + average);

			//if (average > 0 & average <= 50)
			//{
			//	result = "Sonuç vasat";
			//}


			//if (average > 50 & average <= 70)
			//{
			//	result = "Sonuç orta";
			//}

			//if (average > 70 & average <= 84)
			//{
			//	result = "Sonuç iyi";
			//}

			//if (average > 84)
			//{
			//	result = "Sonuç çok iyi";
			//}

			//Console.WriteLine(result);


			//string city;
			//Console.Write("Lütfen şehir girişi yapınız: ");
			//city = Console.ReadLine();

			//if(city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
			//{
			//	Console.WriteLine("şehir mevcut");
			//}
			//else
			//{
			//	Console.WriteLine("şehir mevcut değil");
			//}

			//Console.Write("Lütfen kullanıcı adını giriniz: ");
			//string username = Console.ReadLine();
			//if(username != "admin")
			//{
			//	Console.Write("bu kullanıcı adı kabul edilmez");
			//}
			//else
			//{
			//	Console.Write("Hoş Geldiniz");
			//}


			#endregion

			#region Mod İşlemleri
			//mod işlemi = kalanı yazdırır
			//int number;

			//number = 26;
			//int result = number % 5;
			//Console.WriteLine(result);





			//int number, modvalue, result;
			//Console.Write("Lütfen 1.sayıyı giriniz: ");
			//number =int.Parse(Console.ReadLine());
			//Console.Write("Lütfen 2. sayıyı giriniz: ");
			//modvalue= int.Parse(Console.ReadLine());

			//result = number % modvalue;
			//Console.Write("1.sayının 2. sayıya bölümünden kalan: " + result);



			//Console.Write("Lütfen sayıyı giriniz: ");
			//int number = int.Parse(Console.ReadLine());

			//if(number % 2 == 0) 
			//{
			//	Console.WriteLine("Sayı Çifttir");
			//}
			//else
			//{
			//	Console.WriteLine("Sayi Tektir");
			//}
			#endregion

			#region Char Değişkenler İle Karar Yapıları

			//char team;
			//Console.Write("Takım harfini giriniz: ");
			//team = char.Parse(Console.ReadLine());	

			//if(team == 'g' | team == 'G')
			//{
			//	Console.WriteLine("Team Galatasaray");
			//}
			//else if(team == 'f' | team == 'F')
			//{
			//	Console.WriteLine("Team Fenerbahçe");
			//}
			//else if(team == 'b' | team == 'B')
			//{
			//	Console.WriteLine("Team Besiktas");
			//}

			//else
			//{
			//	Console.WriteLine("Gecersiz harf girisi");
			//}

			#endregion

			#region Örnek Proje Uygulaması

			//Console.WriteLine("********* C# Eğitim Kampı Restoran ***********");
			//Console.WriteLine();
			//Console.WriteLine("----------------------------------");
			//Console.WriteLine("1-Ana Yemekler");
			//Console.WriteLine("2-Çorbalar");
			//Console.WriteLine("3-Pizzalar");
			//Console.WriteLine("4-İçecekler");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("-----------------------------------");
			//Console.WriteLine();

			//string menuItem;
			//Console.Write("Detayını görmek istediğiniz menü seçimi: ");
			//menuItem = Console.ReadLine();

			//if (menuItem == "1")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("----------------Ana Yemekler------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Köri Soslu Tavuk");
			//	Console.WriteLine("2-Kızartma Tabağı");
			//	Console.WriteLine("3-Fasulye Pilav");
			//	Console.WriteLine("4-Fırında Somon");
			//	Console.WriteLine("5-Patlıcan Musakka");
			//	Console.WriteLine("----------------Ana Yemekler------------");

			//	Console.WriteLine();
			//}

			//if (menuItem == "2")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------------Çorbalar------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Mercimek Çorbası");
			//	Console.WriteLine("2-Domates Çorbası");
			//	Console.WriteLine("---------------Çorbalar------------");

			//	Console.WriteLine();
			//}

			//if (menuItem == "3")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------------Pizzalar------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Akdeniz Pizza");
			//	Console.WriteLine("2-Margaritha");
			//	Console.WriteLine("3-Tavuklu Pizza");
			//	Console.WriteLine("---------------Pizzalar------------");

			//	Console.WriteLine();
			//}

			//if (menuItem == "4")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------------İçecekler------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Su");
			//	Console.WriteLine("2-Ayran");
			//	Console.WriteLine("3-Çay");
			//	Console.WriteLine("---------------İçecekler------------");

			//	Console.WriteLine();
			//}

			//if (menuItem == "5")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("---------------Tatlılar------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Trileçe");
			//	Console.WriteLine("2-Kazandibi");
			//	Console.WriteLine("3-Sütlaç");
			//	Console.WriteLine("4-Revani");
			//	Console.WriteLine("---------------Tatlılar------------");

			//	Console.WriteLine();
			//}

			#endregion

			#region Switch Case
			//switch anahtarımız case ise bu anahtarın durumlarıdır

			//Console.Write("Lütfen ay girişi yapınız: ");
			//int monthNumber = int.Parse(Console.ReadLine());

			//switch (monthNumber)
			//{
			//	case 1: Console.WriteLine("Ocak"); break;
			//	case 2: Console.WriteLine("Şubat"); break;
			//	case 3: Console.WriteLine("Mart"); break;
			//	case 4: Console.WriteLine("Nisan"); break;
			//	case 5: Console.WriteLine("Mayıs"); break;
			//	case 6: Console.WriteLine("Haziran"); break;
			//	case 7: Console.WriteLine("Temmuz"); break;
			//	case 8: Console.WriteLine("Ağustos"); break;
			//	case 9: Console.WriteLine("Eylül"); break;
			//	case 10: Console.WriteLine("Ekim"); break;
			//	case 11: Console.WriteLine("Kasım"); break;
			//	case 12: Console.WriteLine("Aralık"); break;
			//	default: Console.WriteLine("Hatalı veri girişi");break;
			//}
			#endregion

			#region Switch Case Hesap Makinesi

			int number1, number2, result;
			char symbol;

			Console.Write("1.Sayıyı Giriniz: ");
			number1 = int.Parse(Console.ReadLine());

			Console.Write("2.Sayıyı Giriniz: ");
			number2 = int.Parse(Console.ReadLine());

			Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
			symbol = char.Parse(Console.ReadLine());


			switch (symbol)
			{
				case '+':
					result = number1 + number2;
					Console.WriteLine("Toplam: " + result);
					break;

				case '-':
					result = number1 - number2;
					Console.WriteLine("Fark: " + result);
					break;

				case '*':
					result = number1 * number2;
					Console.WriteLine("Çarpım: " + result);
					break;

				case '/':
					result = number1 / number2;
					Console.WriteLine("Bölüm: " + result);
					break;

				case '%':
					result = number1 % number2;
					Console.WriteLine("Modu: " + result);
					break;

				default:
					Console.WriteLine("Hatalı sembol girişi");
					break;
			}

			#endregion


			Console.Read();

		}
	}
}


//normalde && operatörünü kullanıyorduk ve için c# da & tek bir tane de yeterli. veya içinde aynı şey geçerli.


//ctrl k d yapınca kodları düzenliyor


//switch case de durumlarımız int,char olabilir. aya göre ismini yazdırmada int değerler oldu casemiz, hesap makinesinde caselerimiz işlemler(char) oldu.