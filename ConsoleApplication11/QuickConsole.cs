using System;

namespace ConsoleApplication11 {
	public class QuickConsole
	{
		private static string cnt = string.Empty;
		private static int MaxLength = 4096;

		public int Length
		{
			get
			{
				return MaxLength;
			}

			set
			{
				MaxLength = value;
			}
		}

		public void Write(string msg)
		{
			cnt += msg;
			CheckLength();
		}
		public void WriteLine(string msg)
		{
			cnt += msg + "\n";
			CheckLength();
		}

		private void CheckLength()
		{
			if (cnt.Length >= MaxLength)
			{
				Render();
			}
		}
		public void Render()
		{
			Console.Write(cnt);
			cnt = string.Empty;
		}
	}
}