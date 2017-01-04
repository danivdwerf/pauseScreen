using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OptionsUI : MonoBehaviour 
{
	//Make reference to the panel you with the options
	[SerializeField]private GameObject OptionsPanel;
	//An array of buttons available in the options menu
	[SerializeField]private Button[] optionButtons;
	//References to the scripts we are going to use from the options
	private AudioUI audioUI;
	private QualityUI qualityUI;
	private PauseUI pauseUI;

	private void Start()
	{
		//make shure the options are not shown from the beginning
		hideOptions ();
		//Set all the references
		setReferences ();
		//Set the eventlisteners of the buttons
		setButtonListeners ();
	}

	private void setReferences()
	{
		audioUI = GetComponent<AudioUI> ();
		qualityUI = GetComponent<QualityUI> ();
		pauseUI = GetComponent<PauseUI> ();
	}

	private void setButtonListeners()
	{
		//Show the right panels when you click the button
		optionButtons [0].onClick.AddListener (delegate {audioUI.showAudioSettings();});
		optionButtons [1].onClick.AddListener (delegate {qualityUI.showQualityPanel();});	
		optionButtons [2].onClick.AddListener (delegate {hideOptions();pauseUI.enablePausePanel();});	
	}

	public void showOptions()
	{
		OptionsPanel.SetActive (true);
	}

	public void hideOptions()
	{
		OptionsPanel.SetActive (false);
	}
}
