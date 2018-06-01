using System;
using Xunit;
using TddTestDemo1;

namespace XUnitTestProject1
{
    public class UtilitiesTest
    {
        [Fact]
        public void RendersParagraphForCorrectInput()
        {
			string text = "not a hedgehog";
			string actual = Utilities.RenderParagraph(text);
			string expected = "<p>" + text + "</p>";
			Assert.Equal(expected, actual);
        }

		[Fact]
		public void RendersEmptyParagraphForEmptyString()
		{
			string actual = Utilities.RenderParagraph("");
			Assert.Equal("<p></p>", actual);
		}

		[Fact]
		public void ThrowsExeptionForNull()
		{
			Assert.Throws<Exception>(() =>
			{
				Utilities.RenderParagraph(null);
			});
		}
    }
}
