namespace photoCore.Abstract
{
	public interface ICameraRemote
	{
		bool MakePhoto();
		ICameraStorage Storage { get; }
	}
}