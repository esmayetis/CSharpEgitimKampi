using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Alt alta 10 tane yıldız oluşturma

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine("*");
			//}
			#endregion

			#region Yan Yana 10 tane yıldız oluşturma

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.Write("*");
			//}
			#endregion

			#region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine("**********");
			//}
			#endregion

			#region Dik Üçgen

			//for (int i = 1; i <= 5; i++)
			//{
			//	for(int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}



			//while ile kendi çözümüm 
			//int a;
			//for (int i = 1; i <= 10; i++)
			//{
			//	a = i;
			//	while (a > 0)
			//	{
			//		Console.Write("*");
			//		a--;
			//	}
			//	Console.WriteLine();
			//}
			#endregion

			#region Tersten Dik Üçgen
			////     ***
			////     **
			////     *

			//for (int i = 5; i >= 1; i--)//üçgeni tersten çizdiğimiz için ilk aslında besıncı satırı basarak çalışıyoruz. sonra dört, üç iki bir diye gidiyor
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			#endregion

			#region Dik ve Ters Dik üçgen beraber

			//for (int i = 1; i <= 5; i++)
			//{
			//    for (int j = 1; j <= i; j++)
			//    {
			//        Console.Write("*");
			//    }
			//    Console.WriteLine();
			//}

			//for (int k = 4; k >= 1; k--)
			//{
			//    for (int m = 1; m <= k; m++)
			//    {
			//        Console.Write("*");
			//    }
			//    Console.WriteLine();
			//}

			#endregion

			#region Baklava Dilimi

			////üst kısım

			//int n = 5;
			//for (int i = 1; i <= n; i++)
			//{
			//	for (int j = n - 1; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}

			//	Console.WriteLine();
			//}


			////alt kısım

			//for (int i = n - 1; i >= 1; i--)
			//{
			//	for (int j = n - 1; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}



			//chatle yapmış olduğum baklava dilimi

			//int satirSayisi = 5; // Baklava diliminin orta kısmına kadar olan satır sayısı

			//// Üst kısım
			//for (int i = 1; i <= satirSayisi; i++)
			//{
			//	// Boşlukları yazdır
			//	for (int j = satirSayisi; j > i; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	// Yıldızları yazdır
			//	for (int k = 1; k <= (2 * i - 1); k++)
			//	{
			//		Console.Write("*");
			//	}

			//	// Yeni satıra geç
			//	Console.WriteLine();
			//}

			//// Alt kısım
			//for (int i = satirSayisi - 1; i >= 1; i--)
			//{
			//	// Boşlukları yazdır
			//	for (int j = satirSayisi; j > i; j--)
			//	{
			//		Console.Write(" ");
			//	}

			//	// Yıldızları yazdır
			//	for (int k = 1; k <= (2 * i - 1); k++)
			//	{
			//		Console.Write("*");
			//	}

			//	// Yeni satıra geç
			//	Console.WriteLine();
			//}
			#endregion

			#region Piramit

			//int n = 5;

			//for (int i = 1; i <= n; i++)//aşağı yönlü ilerleyişi sağlayacak
			//{
			//	for(int j = n-i; j > 0; j--)//bir satırdaki boşlukları ayarlayacak
			//	{
			//		Console.Write(" ");
			//	}

			//	for(int k = 1; k <= 2*i - 1; k++)//bir satırdaki yıldızları ayarlayacak
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			#endregion

			#region Ters Piramit

			//int n = 5;

			//for (int i = 5; i >= 1; i--)
			//{
			//	for (int j = n - i; j >= 1; j--)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int k = 1; k <= 2 * i - 1; k++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			#endregion

			Console.Read();
		}
	}
}


/*  Alıştırma sıralaman şu şekilde olabilir:
 *  1) dik üçgen
 *  2) piramit
 *  3) ters piramit
 *  4) baklava dilimi 
 * 
 */


/*  Baklava Dilimi Çıktısı
 *          *  
 *		   * *
 *		  * * *
 *		   * *
 *			* 
 */

