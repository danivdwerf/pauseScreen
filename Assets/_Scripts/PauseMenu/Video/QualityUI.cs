using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Show which quality level the game is currently on.
public class QualityUI : MonoBehaviour 
{
	//reference to the text that will show the quality name.
	[SerializeField]private Text quality;
	[SerializeField]private Button back;
	[SerializeField]private GameObject videoPanel;
	//an array where we will store the quality names in.
	private string[] qualityNames{get;set;}
	//a string to tell the user its about the quality.
	private string qualityText{get;set;}

	private void Start()
	{
		hideQualityPanel ();
		//store the possible names in the array.
		qualityNames = QualitySettings.names;
		//set the quality text to Quality:
		qualityText = "Quality: ";
		//Make sure the UI tells from the beginning what the name.
		CurrentLevel ();

		back.onClick.AddListener (delegate(){hideQualityPanel();});
	}

	public void CurrentLevel()
	{
		//change the visual text to Quality: *QUALITYNAME*.  
		quality.text = qualityText + qualityNames[QualitySettings.GetQualityLevel()];
	}

	public void showQualityPanel()
	{
		videoPanel.SetActive (true);
	}

	public void hideQualityPanel()
	{
		videoPanel.SetActive (false);
	}
}