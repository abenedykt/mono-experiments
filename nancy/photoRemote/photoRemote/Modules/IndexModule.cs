using Nancy;

namespace photoRemote.Modules
{
	public class IndexModule : NancyModule
	{
		public IndexModule()
		{
			Get["/"] = parameters => View["index"];

			Get ["/settings"] = _ => View ["parameters"];

			Get["/photo"] = _ => View[new PhotoModel()];
		}
	}
}
