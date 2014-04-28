using System;

namespace photoCore.Abstract
{

	public interface ICameraImage
	{
		DateTime Date { get; }
		string Path { get; }
		string Caption { get; }
	}
}