using System.Collections;
using UnityEngine;

public class SettingValues : MonoBehaviour
{
	//create a max Volume
	private float maxVolume = 1;
	//set a start value to the volume
	private float volume = 0.8f;
	//make the volume accessable, so we can save the value
	public float theVolume
	{
		get{return volume;}

		set
		{ 
			if (value <= maxVolume)
			{
				volume = value;
			} 
			else
			{
				volume = maxVolume;
			}
		}
	}
}
