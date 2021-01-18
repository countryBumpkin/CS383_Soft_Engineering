using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{ get; private set; }

    public enum State {WIN, LOSS};

    private void Awake(){
    	if(Instance != null){
    		Destroy(this.gameObject); // prevent duplication
    	}

 		Instance = this;
    }

    private void Start()
    {

    }

    private void Update()
	{
		if (Input.GetKeyDown("escape"))
		{
             TogglePauseGame();
        }
	}

    public void Exit()
    {
    	Application.Quit();
    }

    public void TogglePauseGame()
    {
    	// pause time toggle
    	if(Time.timeScale != 0f)
    	{ 
    		Time.timeScale = 0f;
    	}else
    	{
    		Time.timeScale = 1f;
    	}

    	// Open the pause menu in UIManager
    	UIManager.Instance.TogglePauseMenu();
    }

    public void GameOver(State gameState = State.LOSS)
    {
    	Time.timeScale = 0f;

    	// Show game over panel
    	if(gameState == State.WIN)
    	{
    		UIManager.Instance.ShowGameOver("You Won!");
    	}else{
    		UIManager.Instance.ShowGameOver("Game Over");
    	}
    }

    public void Restart()
    {
    	// reload the scene I guess
    	Debug.Log("reload the scene");
    	Time.timeScale = 1f;
    	SceneManager.LoadScene("Main_Game");
    }
}
