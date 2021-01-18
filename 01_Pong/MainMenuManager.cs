using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
	private GameObject Main_Panel;
	private GameObject Controls_Panel;

    // Start is called before the first frame update
    void Start()
    {
    	Transform canvas = this.transform;

        // get reference to Main_Panel
    	Main_Panel = canvas.GetChild(0).gameObject;
    	Main_Panel.SetActive(true);

        // get reference to Directions_Panel
    	Controls_Panel = canvas.GetChild(1).gameObject;
    	Controls_Panel.SetActive(false);
    }

    public void StartGame()
    {
    	Debug.Log("Start new game called");
        SceneManager.LoadScene("Main_Game");
    }
 	
 	// Toggle active state of the Main_Panel based on the state of the Controls_Panel
    public void ToggleMain()
    {
    	Main_Panel.SetActive(!Controls_Panel.activeSelf);
    }

    // Toggle whether Controls_Panel is active based on its current state 
    public void ToggleControls()
    {
    	Controls_Panel.SetActive(!Controls_Panel.activeSelf);
    }

    public void ExitGame()
    {
    	Debug.Log("End game now");
    	Application.Quit();
    }

}
