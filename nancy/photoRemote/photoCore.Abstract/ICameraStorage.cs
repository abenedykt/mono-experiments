using System.Collections.Generic;

namespace photoCore.Abstract
{
	public interface ICameraStorage
	{
		IEnumerable<ICameraImage> GetAll();
	}
}