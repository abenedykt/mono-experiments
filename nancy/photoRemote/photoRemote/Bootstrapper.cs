using photoCore.Camera;

namespace photoRemote
{
	using Nancy;

	public class Bootstrapper : DefaultNancyBootstrapper
	{
		// The bootstrapper enables you to reconfigure the composition of the framework,
		// by overriding the various methods and properties.
		// For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper	

		public Bootstrapper()
		{
			LoadAssemblies();

		}

		public static void LoadAssemblies()
		{
			CameraRemote remote = null;
			CameraStorage storage = null;
		}
	}
}