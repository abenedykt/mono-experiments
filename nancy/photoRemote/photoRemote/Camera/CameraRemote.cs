using photoRemote.Abstract;

namespace photoRemote.Camera
{
	public class CameraRemote : ICameraRemote
	{
		public bool MakePhoto()
		{
			const string command = "/home/pi/makephoto";

			var proc = new System.Diagnostics.Process
			{
				StartInfo = { FileName = "bash", Arguments = "'" + command + "'", UseShellExecute = false, CreateNoWindow = true }
			};

			proc.Start();

			return true;

		}

		public ICameraStorage Storage
		{
			get { return new CameraStorage(); }
		}
	}
}