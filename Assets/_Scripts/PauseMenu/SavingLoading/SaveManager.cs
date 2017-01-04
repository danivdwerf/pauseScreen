[System.Serializable]
public class SaveManager
{
	//Create a property to store your score in 
	private float volume{ get; set;}
	//Make the variable accessible to get and set from other scripts 	
	public float theVolume
	{
		get
		{
			return volume;
		}
		set
		{ 
			volume = value;
		}
	}
}