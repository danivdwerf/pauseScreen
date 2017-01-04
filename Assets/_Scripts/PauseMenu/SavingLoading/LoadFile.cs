using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class LoadFile : MonoBehaviour 
{
	//Create reference to the scripts you are going to load data to
	private SettingValues settings;

	private void Start()
	{
		//Make the reference to the scripts
		settings = GameObject.FindObjectOfType<SettingValues>();
	}
	public void Load()
	{
		//Check if the file that you are trying to load exists
		if (File.Exists (Application.persistentDataPath + "/saveFile.dat"))
		{
			//Create a new instance of the BinaryFormatter to deserialize the stream
			BinaryFormatter binary = new BinaryFormatter ();
			//Open the filestream to the file we saved
			FileStream fStream = File.Open (Application.persistentDataPath + "/saveFile.dat", FileMode.Open);
			//Deserialize the class with properties we saved
			SaveManager saver = (SaveManager)binary.Deserialize (fStream);
			//Close the stream 
			fStream.Close ();

			//Set the values of back to scripts
			settings.theVolume = saver.theVolume;
		} 
	}
}