namespace photoRemote
{
	using System;
	using Nancy.Hosting.Self;

	class Program
	{
		static void Main(string[] args)
		{
			var uri =
				new Uri("http://localhost:8888");

			using (var host = new NancyHost(uri))
			{
				host.Start();

				if (args.Any(s => s.Equals("-d", StringComparison.CurrentCultureIgnoreCase)))
	            {
	                Thread.Sleep(Timeout.Infinite);
	            }
	            else
	            {
					Console.WriteLine("Your application is running on " + uri);
					Console.WriteLine("Press any [Enter] to close the host.");
					Console.ReadLine();
					host.Stop();
	            }

			}
		}
	}
}
