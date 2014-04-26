namespace photoRemote
{
	using Nancy;
	using System.IO;

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

			Get["/photo"] = _ => {
				MakePhoto();
				return View[new PhotoModel()];
			};
		}

		public void MakePhoto(){
			var command = "/home/pi/makephoto";

			var proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "bash";
			proc.StartInfo.Arguments = "'" + command +  "'";
			proc.StartInfo.UseShellExecute =false;
			proc.StartInfo.CreateNoWindow = true;

			proc.Start();

		}


	}

	public class PhotoModel{
		public string ImagePath {
			get{ return "image.jpg";}
			set{}
		}
	}
}
