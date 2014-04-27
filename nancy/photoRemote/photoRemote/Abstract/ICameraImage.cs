using System;

namespace photoRemote.Abstract
{
	public interface ICameraImage
	{
		DateTime Date { get; }
		string Path { get; }
		string Caption { get; }
	}
}