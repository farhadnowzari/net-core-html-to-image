namespace CoreHtmlToImage.Console
{
	internal class Program
	{
		private static void Main( string[] args )
		{
			// From HTML string
			var converter = new HtmlConverter();
			var html = "<div><strong>Hello</strong> World!</div>";
			var htmlBytes = converter.FromHtmlString( html );
		}
	}
}