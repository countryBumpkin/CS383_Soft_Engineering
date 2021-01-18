using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public static UIManager Instance { get; private set; }

    public GameObject Court;

	private GameObject Pause_Panel;
	private GameObject HUD;
    private GameObject GameOver_Panel;
    private GameObject Controls_Panel;

	private void Awake()
	{
		if(Instance != null)
		{
			Destroy(this.gameObject);
		}

		Instance = this;
	}

    // Start is called before the first frame update
    void Start()
    {
    	Transform canvas = this.transform.GetChild(0);

        Pause_Panel = canvas.GetChild(0).gameObject;
        Pause_Panel.SetActive(false);

        HUD = canvas.GetChild(1).gameObject;
        HUD.SetActive(true);

        GameOver_Panel = canvas.GetChild(2).gameObject;
        GameOver_Panel.SetActive(false);

        Controls_Panel = canvas.GetChild(3).gameObject;
        Controls_Panel.SetActive(false);


    }

    public void TogglePauseMenu()
    {
    	HUD.SetActive(!HUD.activeSelf);
    	Pause_Panel.SetActive(!Pause_Panel.activeSelf);
    }

    public void ToggleControls()
    {
        Controls_Panel.SetActive(!Controls_Panel.activeSelf);
    }

    public void ShowGameOver(string msg)
    {
        HUD.SetActive(false);
        GameOver_Panel.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = msg; // Title of end game, either win or loss message
        GameOver_Panel.transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = PlayerManager.Instance.Score.ToString(); 
        GameOver_Panel.SetActive(true);

        // hide court
        Court.SetActive(false);
    }

    public void UpdateScore()
    {
        HUD.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = PlayerManager.Instance.Score.ToString();
    }
}
