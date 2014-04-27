using System.Collections.Generic;

namespace photoRemote.Abstract
{
	public interface ICameraStorage
	{
		IEnumerable<ICameraImage> GetAll();
	}
}