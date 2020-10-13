using System.Drawing;

namespace CoreHtmlToImage
{
	public class ConverterOptions
	{
		public ImageFormat OutputFormat { get; set; } = ImageFormat.Jpg;
		public string OutputFormatString => OutputFormat.ToString().ToLower();
		public Size OutputSize { get; set; } = new Size( 1024, 768 );
		public bool DisableSmartWidth { get; set; } = false;
		public int Quality { get; set; } = 100;

		public string GetCommandArgs()
		{
			var args = $"--quality {Quality} --width {OutputSize.Width} --height {OutputSize.Height} --format {OutputFormatString}";
			if ( DisableSmartWidth )
			{
				args = $"{args} --disable-smart-width";
			}
			return args;
		}
	}
}