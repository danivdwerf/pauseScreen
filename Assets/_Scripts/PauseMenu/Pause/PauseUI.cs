using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
	//Create reference to the scrips we are going to use
	private PauseLogic logic;
	private OptionsUI optionUI;
	private SaveFile saver;
	private LoadFile loader;
	//Create reference to all the buttons we can use
	[SerializeField]private Button[] buttons;
	//Create reference to all the panels of the Pause Menu
	[SerializeField]private GameObject[] allPanels;

	private void Start()
	{
		//Make sure the pause screen is not visible from the start
		hidePausePanel ();
		//Create all the references to the scripts we are going to use
		setReferences ();
		//Set all the eventListeners
		setButtonListeners ();
	}

	private void setReferences()
	{
		logic = GetComponent<PauseLogic> ();
		optionUI = GetComponent<OptionsUI> ();
		saver = GetComponent<SaveFile> ();
		loader = GetComponent<LoadFile> ();
	}

	private void setButtonListeners()
	{
		buttons[0].onClick.AddListener(delegate(){logic.switchPauseState();});
		buttons[1].onClick.AddListener(delegate(){optionUI.showOptions();hidePausePanel();});
		buttons[2].onClick.AddListener(delegate(){saver.Save();});
		buttons[3].onClick.AddListener(delegate(){loader.Load();});
	
	}

	public void enablePausePanel()
	{
		allPanels[0].SetActive (true);
	}

	private void hidePausePanel()
	{
		allPanels[0].SetActive (false);
	}

	public void hideAll()
	{
		//Hide all the pausePanels
		for (int i = 0; i < allPanels.Length; i++)
		{
			allPanels [i].SetActive (false);
		}
	}
}
