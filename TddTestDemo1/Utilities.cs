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
	}
}
