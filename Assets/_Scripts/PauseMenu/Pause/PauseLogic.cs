using System.Collections;
using UnityEngine;

public class PauseLogic : MonoBehaviour 
{
	//Reference to the ui script
	private PauseUI ui;
	//Boolean to check if we are already paused
	private bool paused;
	public bool isPaused
	{
		get
		{ 
			return paused;
		}
	}

	private void Start()
	{
		//Create reference
		ui = GetComponent<PauseUI> ();
		//Set startvalue to the boolean
		paused = false;
	}

	public void switchPauseState()
	{
		//if already paused, continue
		if (paused)
		{
			paused = false;
			continueGame ();
			return;
		}

		//If not paused, pause
		if (!paused)
		{
			paused = true;
			pauseGame ();
			return;
		}
	}

	private void pauseGame()
	{
		//enable the UI
		ui.enablePausePanel ();
		//Stop the movement
		Time.timeScale = 0;
		//Stop the scripts
		stopScripts ();
	}

	private void continueGame()
	{
		//Hide all the panels
		ui.hideAll ();
		//Enable the movement
		Time.timeScale = 1;
		//Start all the scripts
		startScripts ();
	}

	private void stopScripts()
	{
		//Stop scripts that don't use the time here (example movementInput.enabled = false;)
	}

	private void startScripts()
	{
		//Start scripts that don't use the time here (example movementInput.enabled = true;)
	}
}
