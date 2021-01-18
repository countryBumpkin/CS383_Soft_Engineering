using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

	public static PlayerManager Instance { get; private set; }

	public int maxLives = 3;
	public bool invincible = false;

	private int lives;

	public int Score = 0;

	private void Awake()
	{
		if(Instance != null)
		{
			Destroy(this.gameObject);
		}else{
			Instance = this;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        if(!invincible)
        {
        	lives = maxLives;
        }else
        {
        	lives = 999;
        }
    }

    public void DecrementLives()
    {
    	lives--;

    	if(lives <= 0)
    	{
    		GameManager.Instance.GameOver();
    	}
    }
}
