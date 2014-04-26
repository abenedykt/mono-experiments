namespace photoRemote
{
	using Nancy;

	public class IndexModule : NancyModule
	{
		public IndexModule()
		{
			Get["/"] = parameters =>
			{
				return View["index"];
			};

			Get ["/settings"] = _ => {
				return View ["parameters"];
			};
		}
	}
}