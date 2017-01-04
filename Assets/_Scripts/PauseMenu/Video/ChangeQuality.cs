using UnityEngine;
using System.Collections;

//change the quality level.
public class ChangeQuality : MonoBehaviour 
{
	public void Change(int level)
	{
		QualitySettings.SetQualityLevel (level);
	}
}