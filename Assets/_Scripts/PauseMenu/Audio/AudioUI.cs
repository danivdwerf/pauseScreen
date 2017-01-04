using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class AudioUI : MonoBehaviour 
{
	//Reference to the audiosettings panel
	[SerializeField]private GameObject audioPanel;
	//Reference to the volumeSlider
	[SerializeField]private Slider volumeSlider;
	//Reference to the text that will show the volume
	[SerializeField]private Text volumeText;
	//Reference to the back button
	[SerializeField]private Button back;
	//Reference to the scripts you need to use
	private AudioLogic logic;
	private SettingValues values;

	private void Start()
	{
		//Make sure The panel is hidden from the start
		hideAudioSettings ();
		//Set the references to the scripts we use
		setReferences ();
		//set the right volume from the start
		changeVolume ();
		//Set the eventlisteners to the buttons
		setListeners ();

	}

	private void setListeners()
	{
		volumeSlider.onValueChanged.AddListener (delegate(float EventArgs){changeVolume();});
		back.onClick.AddListener (delegate(){hideAudioSettings();});
	}

	public void changeVolume()
	{
		logic.adjustVolume(volumeSlider.value);
	}

	private void Update()
	{
		if (this.isActiveAndEnabled)
		{
			//update the volume text
			volumeText.text = "Volume: " + Mathf.Round (values.theVolume * 100);
			//update the volume value
			volumeSlider.value = values.theVolume;
		}
	}

	private void setReferences()
	{
		logic = GetComponent<AudioLogic> ();
		values = GetComponent<SettingValues> ();
	}

	public void showAudioSettings()
	{
		audioPanel.SetActive (true);
	}

	public void hideAudioSettings()
	{
		audioPanel.SetActive (false);
	}
}
