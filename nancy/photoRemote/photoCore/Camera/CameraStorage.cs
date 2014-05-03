using System;
using System.Collections.Generic;
using photoCore.Abstract;

namespace photoCore.Camera
{
	public class CameraStorage : ICameraStorage
	{
		public IEnumerable<ICameraImage> GetAll()
		{
			yield return new CameraImage
			{
				Path = "image1.jpg",
				Date = DateTime.Now,
				Caption = "image1"
			};
			yield return new CameraImage
			{
				Path = "image2.jpg",
				Date = DateTime.Now,
				Caption = "image1"
			};
			yield return new CameraImage
			{
				Path = "image3.jpg",
				Date = DateTime.Now,
				Caption = "image1"
			};
			yield return new CameraImage
			{
				Path = "image4.jpg",
				Date = DateTime.Now,
				Caption = "image1"
			};
		}

		public class CameraImage : ICameraImage
		{
			public DateTime Date { get; internal set; }
			public string Path { get; internal set; }
			public string Caption { get; internal set; }
		}
	}
}