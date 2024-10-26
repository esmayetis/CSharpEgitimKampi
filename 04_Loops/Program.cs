using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region For Döngüsü

			//For(x;y;z)
			//x:başlangıç
			//y:bitiş
			//z:artış-azalış

			//int i;

			//for (i = 1; i <= 5; i++)
			//{
			//    Console.WriteLine("C# Eğitim Kampı");
			//}

			//for (int i = 1; i <= 20; i++)
			//{
			//    Console.WriteLine(i);
			//}

			//for(int i = 3; i <= 50; i += 3)
			//{
			//    Console.WriteLine(i);
			//}


			//Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
			//int finishValue = int.Parse(Console.ReadLine());

			//for (int i = 0; i <= finishValue; i++)
			//{
			//	Console.WriteLine("Yaşasın Cumhuriyet");
			//}


			#endregion

			#region For Döngüsü İle Karar Yapıları

			//1 ile 100 arasındaki beşe tam bölünen sayıları yazdırma
			//for(int i = 1; i <= 100; i++) 
			//{ 
			//	if(i % 5 == 0)
			//	{
			//		Console.WriteLine(i);	
			//	}
			//}




			//1 ile 10 arasındaki sayıların toplamını ekrana yazdırma

			//int total = 0;
			//for (int i = 1; i <= 10; i++)
			//{
			//	total += i;
			//}
			//Console.WriteLine(total);






			//1 ile 20 arasındaki çift sayıların toplamı

			//int totalValue = 0;
			//for (int i = 1; i < 20; i++)
			//{
			//	if (i % 2 == 0)
			//	{
			//		totalValue += i;
			//		Console.WriteLine(i);
			//	}
			//}
			//Console.WriteLine("--------");
			//Console.WriteLine(totalValue);





			//1 ile 50 arasında yediye tam bölünen kaç sayı var

			//int count = 0;
			//for (int i = 1; i <= 50; i++)
			//{
			//	if (i % 7 == 0)
			//	{
			//		count++;
			//	}
			//}
			//Console.WriteLine(count);



			//bakteriler her saat sonunda iki katına çıkıyor, 24 saatin sonunda kaç tane bakteri vardır? ör: 1-2-4-8-16 ...

			//int bacterium = 1;

			//for (int i = 1; i <= 24; i++)
			//{
			//	bacterium *= 2;
			//	Console.WriteLine(i + ".Saat sonunda: " + bacterium);
			//}




			#endregion

			#region While Döngüsü

			//döngüyü takip eden değişkenimiz döngünün dışında tanımlanır ve gerekirse ilk değer ataması da orada yapılır.

			//değişkenin artıp, azalma işlemleri de döngü bloğu içerisinde yapılır. koşul sağlandığı sürece bu şekilde devam eder.
			//


			/*While(şart / koşul)
			 * {
			 * işlemler
			 * arttırma - azaltma
			 * }
			 */

			//int i = 1;

			//while(i <= 10)
			//{
			//	Console.WriteLine("Merhaba Döngüler");
			//	i++;
			//}





			//1 ile 10 arasında 3 e tam bölünen sayıları bulalım

			//int i = 1;
			//while (i <= 10)
			//{
			//	if (i % 3 == 0)
			//		Console.WriteLine(i);
			//	i++;
			//}




			//1 ile 10 arasındaki sayıların toplamını bulalım

			//int i = 1, sum = 0;
			//while (i <= 10)
			//{
			//	sum += i;
			//	i++;
			//}
			//Console.WriteLine(sum);



			#endregion

			#region Örnek Sınav Sorusu

			//kalvyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

			//benim çözümüm
			//int sum = 0, number;
			//int son, orta, ilk;
			//Console.Write("Sayıyi giriniz: ");
			//number = int.Parse(Console.ReadLine());


			//son = number % 10;
			//number = number / 10;

			//orta = number % 10;
			//number = number / 10;

			//ilk = number;

			//sum = son + orta + ilk;
			//Console.Write("Rakamlarin toplami : " + sum);


			//hocamızın çözümü
			//456

			//Console.Write("Sayıyı Giriniz: ");
			//int number = int.Parse(Console.ReadLine());
			//int ones, tens, hundreds;
			//int sum;

			//ones = number % 10;
			//tens = (number % 100) / 10;
			//hundreds = number / 100;//4.56 --> 4

			//Console.WriteLine(ones + "-" + tens + "-" + hundreds);

			//sum = ones + tens + hundreds;

			//Console.WriteLine(sum);




			#endregion

			Console.Read();
		}
	}
}

//breakpoint kodun çalışma prensibini adım adım incelmeyi sunar. istediğimiz satıra sağ tık yapıp koyabiliriz. sorasında starta basıp f11 ile adım adım takip edebiliriz

//for yazıp tab tab yaparsak otomatik oluşturur.

