using System;
using Xunit;
using TddTestDemo1;

namespace XUnitTestProject1
{
	public class UtilitiesTest
	{
		[Fact]
		public void RenderParagraph_RendersParagraphForCorrectInput()
		{
			string text = "not a hedgehog";
			string actual = Utilities.RenderParagraph(text);
			string expected = "<p>" + text + "</p>";
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void RenderParagraph_RendersEmptyParagraphForEmptyString()
		{
			string actual = Utilities.RenderParagraph("");
			Assert.Equal("<p></p>", actual);
		}

		[Fact]
		public void RenderParagraph_ThrowsExeptionForNull()
		{
			Assert.Throws<Exception>(() =>
			{
				Utilities.RenderParagraph(null);
			});
		}


		[Fact]
		public void IsTrue_ReturnsTrueWhenParameterTrue()
		{
			bool actual = Utilities.IsTrue(true);
			Assert.True(actual);
		}

		[Fact]
		public void IsTrue_ReturnsFalseWhenParameterFalse()
		{
			Assert.False(Utilities.IsTrue(false));
		}


		// 
		[Fact]
		public void Multiply_46340Returns2147395600()
		{
			int actual = Utilities.Multiply(46340, 46340);
			Assert.Equal(2147395600, actual);
		}
		[Fact]
		public void Multiply_ExceptionOnOverflow()
		{
			Assert.Throws<OverflowException>(() => Utilities.Multiply(2147395600, 2147395600));
		}
		[Fact]
		public void Multiply_0Returns0()
		{
			Assert.Equal(0, Utilities.Multiply(0, 848));
			Assert.Equal(0, Utilities.Multiply(976767, 0));
			//Assert.Equal(0, Utilities.Multiply(0, 0));
		}

		
		[Fact]
		public void IsOdd_ThreeIsOddNumber()
		{
			Assert.True(Utilities.IsOdd(3));
		}
		[Fact]
		public void IsOdd_TwoIsEvenNumber() {
			Assert.False(Utilities.IsOdd(2));
		}

		// Repeat: 't', 5 -> "ttttt"
		// ',', 0 -> ""
		// 't', -5 -> throw Exception
		// '/', ' ',
		// 'е', 'д', 'ц'
		[Fact]
		public void Repeat_RepeatsChar()
		{
			string actual = Utilities.Repeat('t', 5);
			Assert.Equal("ttttt", actual);
		}
		[Fact]
		public void Repeat_EmptyStringForZero()
		{
			string actual = Utilities.Repeat(',', 0);
			Assert.Equal("", actual);
		}
		[Fact]
		public void Repeat_ThrowsForNegativeCount()
		{
			Assert.Throws<Exception>(() => Utilities.Repeat('t', -5));
		}
		[Fact]
		public void Repeat_SpecialCharacters()
		{
			Assert.Equal("///", Utilities.Repeat('/', 3));
			Assert.Equal("    ", Utilities.Repeat(' ', 4));
		}
		[Fact]
		public void Repeat_OtherEncoding()
		{
			Assert.Equal("еее", Utilities.Repeat('е', 3));
		}
	}
}
