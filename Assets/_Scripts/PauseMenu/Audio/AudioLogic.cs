using System.Collections;
using UnityEngine;

public class AudioLogic : MonoBehaviour 
{
	//Reference to the setting values
	private SettingValues values;
	private void Start()
	{
		//Create reference
		values = GetComponent<SettingValues> ();
	}

	//adjust the volume from the settings value
	public void adjustVolume(float value)
	{
		values.theVolume = value;
	}
}
