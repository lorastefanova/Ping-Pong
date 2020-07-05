using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Canvas Game;
	public Button startButton;
	public Button exitButton;

	// Use this for initialization
	void Start ()
    {
		Game = Game.GetComponent<Canvas> ();
		startButton = startButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
	}
	
	public void ExitPress ()
    {
        Application.Quit();
    }

    public void PlayPress()
    {
        SceneManager.LoadScene("Game");
    }

	public void StartGame ()
    {
		SceneManager.LoadScene ("Main");
	}

}
