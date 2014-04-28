using Nancy;
using photoCore.Abstract;

namespace photoRemote.Modules
{
	public class PhotoModule : NancyModule
	{
		private readonly ICameraRemote _camera;

		public PhotoModule(ICameraRemote camera)
		{
			_camera = camera;

			Get["/photo/last"] = _ => View["last","image.jpg"];

			Get["/photo/all"] = _ => View["all", _camera.Storage.GetAll()];

			Get["/photo/make"] = _ => _camera.MakePhoto();
		}
	}
}