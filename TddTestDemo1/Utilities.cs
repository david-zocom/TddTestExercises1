using System;
using System.Collections.Generic;
using System.Text;

namespace TddTestDemo1
{
	public class Utilities
	{


		/*1 Skriv testfall för funktionen RenderParagraph, som ska ta en sträng som parameter och returnera en sträng som motsvarar en HTML-paragraf. Exempel:
		RenderParagraph("hello") → "<p>hello</p>"

		2 Skriv testfall för funktionen IsTrue(bool) som ska returnera true om parametern är true och false annars.

		3 Skriv testfall för funktionen int Multiply(int, int) som ska ta två heltal som parametrar och returnerar deras produkt. Exempel: Multiply(2, 5) → 10

		4 Skriv testfall för funktionen IsOdd(int x) som ska returnera true om parametern x är ett udda tal.

		*/
		public static string RenderParagraph(string text)
		{
			if (text == null)
				throw new Exception("null is not allowed");
			return $"<p>{text}</p>";
		}

		public static bool IsTrue(bool v)
		{
			return v;
		}

		public static int Multiply(int v1, int v2)
		{
			checked
			{
				return v1 * v2;
			}
		}

		public static bool IsOdd(int v)
		{
			return v % 2 == 1;
		}

		public static string Repeat(char character, int count)
		{
			if (count < 0) throw new Exception("count must be positive");
			string result = "";
			for (int i = 0; i < count; i++)
				result += character;
			return result;
		}

		/*5 Skriv testfall för funktionen string Repeat(char, int). Den ska ta ett tecken och ett heltal som parameter, och returnera en string med lika många kopior av tecknet som talet. Tips: fundera på vilka olika sorters tillåtna respektive otillåtna värden respektive parameter har. Specen är inte fullständig utan du måste göra designbeslut.*/
	}
}
